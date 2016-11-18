package command.impl;

import command.Command;
import constant.JspPageName;
import exception.CommandException;

import javax.servlet.http.HttpServletRequest;

/**
 * Created by Антон on 24.10.2016.
 */
public class FindSignalForCreateCommand implements Command {
    @Override
    public String execute(HttpServletRequest request) throws CommandException {
        return JspPageName.EDIT_SIGNAL;
    }
}
