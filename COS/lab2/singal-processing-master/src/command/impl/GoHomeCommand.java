package command.impl;

import command.Command;
import constant.JspPageName;

import javax.servlet.http.HttpServletRequest;

/**
 * Created by Антон on 22.09.2016.
 */
public class GoHomeCommand implements Command {
    @Override
    public String execute(HttpServletRequest request) {
        request.getSession(true);
        return JspPageName.INDEX;
    }
}
