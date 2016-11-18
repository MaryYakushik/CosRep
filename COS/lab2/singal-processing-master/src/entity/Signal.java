package entity;

/**
 * Created by Антон on 24.10.2016.
 */
public class Signal {
    private long signalId;
    private String amplitude;
    private String phase;
    private String frequency;

    public Signal(){}

    public long getSignalId() {
        return signalId;
    }

    public void setSignalId(long signalId) {
        this.signalId = signalId;
    }

    public String getAmplitude() {
        return amplitude;
    }

    public void setAmplitude(String amplitude) {
        this.amplitude = amplitude;
    }

    public String getPhase() {
        return phase;
    }

    public void setPhase(String phase) {
        this.phase = phase;
    }

    public String getFrequency() {
        return frequency;
    }

    public void setFrequency(String frequency) {
        this.frequency = frequency;
    }

}
