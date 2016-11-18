package command.impl;

import command.Command;
import constant.JspPageName;
import exception.CommandException;

import javax.servlet.http.HttpServletRequest;


public class FindAllSignalsCommand implements Command {
    @Override
    public String execute(HttpServletRequest request) throws CommandException {
        String page = JspPageName.ALL_SIGNALS;
        return page;
    }
}
