package command.impl;

import command.Command;
import constant.JspPageName;
import entity.Signal;
import exception.CommandException;

import javax.servlet.http.HttpServletRequest;
import java.util.ArrayList;
import java.util.Iterator;

/**
 * Created by Антон on 24.10.2016.
 */
public class FindSignalForUpdateCommand implements Command {
    @Override
    public String execute(HttpServletRequest request) throws CommandException {
        String page = null;
        long signalId = Long.parseLong(request.getParameter("signal_id"));
        ArrayList<Signal> signalList = (ArrayList<Signal>) request.getSession().getAttribute("signal_list");
        Iterator<Signal> iterator = signalList.iterator();
        Signal signal = null;
        while (iterator.hasNext()){
            signal = iterator.next();
            if(signal.getSignalId() == signalId){
                break;
            }
        }
        request.getSession().setAttribute("signal", signal);
        page = JspPageName.EDIT_SIGNAL;
        return page;
    }
}
