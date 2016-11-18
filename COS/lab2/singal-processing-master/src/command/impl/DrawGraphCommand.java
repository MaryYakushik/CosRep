package command.impl;

import com.google.gson.Gson;
import command.Command;
import entity.GraphData;
import entity.Signal;
import exception.CommandException;
import org.apache.commons.math3.complex.Complex;
import org.apache.commons.math3.transform.FastFourierTransformer;
import org.apache.commons.math3.transform.TransformType;

import javax.script.ScriptEngine;
import javax.script.ScriptEngineManager;
import javax.script.ScriptException;
import javax.servlet.http.HttpServletRequest;
import java.util.ArrayList;

import static org.apache.commons.math3.transform.DftNormalization.STANDARD;
import static org.apache.commons.math3.transform.DftNormalization.UNITARY;


public class DrawGraphCommand implements Command {
    @Override
    public String execute(HttpServletRequest request) throws CommandException {
        final int graphWidth = 65536;
        final int graphWidthForFft = 32768;
        ArrayList<Signal> signalList = (ArrayList<Signal>) request.getSession().getAttribute("signal_list");

        GraphData[] harmonicSignals = new GraphData[signalList.size()];
        GraphData[] polyharmonicSignals = new GraphData[1];

        GraphData[] abs = new GraphData[1];
        GraphData[] arg = new GraphData[1];
        GraphData[] akf = new GraphData[1];
        GraphData[] inverseFFT = new GraphData[1];

        GraphData polyharmonicSignal = new GraphData();
        GraphData[][] signals = new GraphData[6][signalList.size()];
        ScriptEngineManager mgr = new ScriptEngineManager();
        ScriptEngine engine = mgr.getEngineByName("JavaScript");

        double[] x = new double[graphWidth];
        double[] xForFft = new double[graphWidth / 2];
        double xPrevious = 0;

        for (int i = 0; i < graphWidthForFft; i++) {
            xForFft[i] = 1d * i / 10;
        }

        xPrevious = 0;

        for (int i = 0; i < 65536; i++) {
            x[i] = xPrevious;
            xPrevious += 0.001;
        }

        int index = 0;
        double doubleFrequency;
        double doubleAmplitude;
        double doublePhase;

        for (Signal signal : signalList) {

            double[] tempY = new double[graphWidth];
            int xLength = x.length;
            for (int i = 0; i < xLength; i++) {
                String fooFrequency = signal.getFrequency().replaceAll("t", String.valueOf(x[i]));
                String fooAmplitude = signal.getAmplitude().replaceAll("t", String.valueOf(x[i]));
                String fooPhase = signal.getPhase().replaceAll("t", String.valueOf(x[i]));
                try {
                    doubleFrequency = Double.parseDouble(engine.eval(fooFrequency).toString());
                    doubleAmplitude = Double.parseDouble(engine.eval(fooAmplitude).toString());
                    doublePhase = Double.parseDouble(engine.eval(fooPhase).toString());
                    tempY[i] = doubleAmplitude * Math.sin(2 * Math.PI * doubleFrequency * x[i] + doublePhase);
                } catch (ScriptException e) {
                    e.printStackTrace();
                }

            }
            GraphData graphData = new GraphData();
            graphData.setX(x);
            graphData.setY(tempY);
            harmonicSignals[index] = graphData;
            index++;
        }
        double[] tempYArray = new double[graphWidth];
        for (int i = 0; i < graphWidth; i++) {
            polyharmonicSignal.setX(x);
            double tempSum = 0;
            for (int j = 0; j < harmonicSignals.length; j++) {
                tempSum += harmonicSignals[j].getY()[i];
            }
            tempYArray[i] = tempSum;

        }
        polyharmonicSignal.setY(tempYArray);
        polyharmonicSignals[0] = polyharmonicSignal;

        FastFourierTransformer fft = new FastFourierTransformer(UNITARY);
        Complex[] cmx = fft.transform(polyharmonicSignal.getY(), TransformType.FORWARD);
        double[] abses = new double[polyharmonicSignal.getY().length / 2];
        double[] args = new double[polyharmonicSignal.getY().length / 2];
        int absesLength = abses.length;
        for (int i = 0; i < absesLength; i++) {
            abses[i] = cmx[i].abs();
            args[i] = cmx[i].getArgument();
        }

        abs[0] = new GraphData();
        abs[0].setY(abses);
        abs[0].setX(xForFft);

        arg[0] = new GraphData();
        arg[0].setY(args);
        arg[0].setX(xForFft);

        akf[0] = new GraphData();
        akf[0].setX(xForFft);
        akf[0].setY(akf(polyharmonicSignal.getY()));

        inverseFFT[0] = new GraphData();
        inverseFFT[0].setX(x);
        inverseFFT[0].setY(inverseFFT(cmx));


        signals[0] = harmonicSignals;
        signals[1] = polyharmonicSignals;
        signals[2] = abs;
        signals[3] = arg;
        signals[4] = akf;
        signals[5] = inverseFFT;
        return new Gson().toJson(signals);

    }

    private double[] akf(double[] inputData) {
        FastFourierTransformer fft = new FastFourierTransformer(UNITARY);
        Complex[] complices = fft.transform(inputData, TransformType.FORWARD);

        double[] result = new double[inputData.length];
        double[] result1 = new double[inputData.length / 2];

        int length = inputData.length / 2;

        for(int i = 0; i < length; i++){
            result[i] = Math.pow(complices[i].abs(), 2);
        }

        Complex[] data = fft.transform(result, TransformType.INVERSE);
        for(int i = 0; i < length; i++){
            result1[i] = data[i].getReal();
        }
        return result1;
    }


    private double[] inverseFFT(Complex[] inputData){
        FastFourierTransformer fft = new FastFourierTransformer(UNITARY);
        Complex[] complices = fft.transform(inputData, TransformType.INVERSE);

        double[] result = new double[inputData.length];

        int length = inputData.length;

        for(int i = 0; i < length; i++){
            result[i] = complices[i].getReal();
        }
        return result;
    }
}
