package command.impl;

import command.Command;
import constant.JspPageName;
import entity.Signal;
import exception.CommandException;

import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpSession;
import java.util.ArrayList;

/**
 * Created by Антон on 24.10.2016.
 */
public class CreateSignalCommand implements Command {
    @Override
    public String execute(HttpServletRequest request) throws CommandException {

        String page = null;
        HttpSession session = request.getSession(true);
        int signalNumber = (int) request.getSession().getAttribute("signal_number");
        ArrayList<Signal> signalList = (ArrayList<Signal>) request.getSession().getAttribute("signal_list");
        String amplitude = request.getParameter("amplitude");
        String phase = request.getParameter("phase");
        String frequency = request.getParameter("frequency");
        Signal signal = new Signal();
        signal.setSignalId(signalNumber);
        signal.setAmplitude(amplitude);
        signal.setPhase((phase));
        signal.setFrequency(frequency);
        signalList.add(signal);
        session.setAttribute("signal_list", signalList);
        signalNumber++;
        session.setAttribute("signal_number", signalNumber);
        page = JspPageName.ALL_SIGNALS;
        return page;
    }
}
