package controller;

import command.Command;
import command.CommandManager;
import constant.JspPageName;
import constant.RequestParameter;
import exception.CommandException;

import javax.servlet.ServletException;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;
import java.io.IOException;

/**
 * Created by Антон on 19.09.2016.
 */
public class Controller extends HttpServlet {
    @Override
    protected void doGet(HttpServletRequest req, HttpServletResponse resp) throws ServletException, IOException {
        String page = null;
        String commandName = req.getParameter(RequestParameter.COMMAND);
        try {
            Command command = CommandManager.getCommand(commandName);
            if(command !=null) {
                page = command.execute(req);
            }else {
                page = JspPageName.INDEX;
            }
        } catch (CommandException e) {
            page = JspPageName.INDEX;
        }
        req.getRequestDispatcher(page).forward(req, resp);

    }

    @Override
    protected void doPost(HttpServletRequest req, HttpServletResponse resp) throws ServletException, IOException {

        String page = null;
        String commandName = req.getParameter(RequestParameter.COMMAND);
        try {
            Command command = CommandManager.getCommand(commandName);
            if(command !=null) {
                page = command.execute(req);
            }else {
                page = JspPageName.INDEX;
            }
        } catch (CommandException e) {
            throw new ServletException(e);
        }
        req.getRequestDispatcher(page).forward(req, resp);
    }
}
