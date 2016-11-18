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
 * Created by Антон on 18.08.2016.
 */
public class JsonController extends HttpServlet {


    @Override
    protected void doGet(HttpServletRequest req, HttpServletResponse resp) throws ServletException, IOException {
        String commandName = req.getParameter(RequestParameter.COMMAND);
        String json = null;
        try {
            Command command = CommandManager.getCommand(commandName);
            json = command.execute(req);
        } catch (CommandException e) {
            resp.sendRedirect(JspPageName.INDEX);
        }
        resp.setContentType("application/json");
        resp.setCharacterEncoding("UTF-8");
        resp.getWriter().write(json);
    }

    @Override
    protected void doPost(HttpServletRequest req, HttpServletResponse resp) throws ServletException, IOException {
        String commandName = req.getParameter(RequestParameter.COMMAND);
        String json = null;
        try {
            Command command = CommandManager.getCommand(commandName);
            json = command.execute(req);
        } catch (CommandException e) {
            resp.sendRedirect(JspPageName.INDEX);
        }
        resp.setContentType("application/json");
        resp.setCharacterEncoding("UTF-8");
        resp.getWriter().write(json);
    }
}
