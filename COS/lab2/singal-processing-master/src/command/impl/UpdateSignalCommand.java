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
public class UpdateSignalCommand implements Command {
    @Override
    public String execute(HttpServletRequest request) throws CommandException {
        String page = null;
        HttpSession session = request.getSession();
        ArrayList<Signal> signalList = (ArrayList<Signal>) request.getSession().getAttribute("signal_list");
        String signalId = request.getParameter("signal_id");
        String amplitude = request.getParameter("amplitude");
        String phase = request.getParameter("phase");
        String frequency = request.getParameter("frequency");
        Signal signal = new Signal();
        signal.setSignalId(Long.parseLong(signalId));
        signal.setAmplitude(amplitude);
        signal.setPhase(phase);
        signal.setFrequency(frequency);
        Signal oldSignal = null;
        for(int i = 0; i < signalList.size(); i++){
            oldSignal = signalList.get(i);
            if(oldSignal.getSignalId() == signal.getSignalId()){
                signalList.set(i, signal);
            }
        }
        session.setAttribute("signal_list", signalList);
        session.removeAttribute("signal");
        page = JspPageName.ALL_SIGNALS;
        return page;
    }
}
