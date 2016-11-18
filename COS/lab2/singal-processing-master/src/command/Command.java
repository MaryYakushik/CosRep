package command;

import exception.CommandException;

import javax.servlet.http.HttpServletRequest;

/**
 * Created by Антон on 19.09.2016.
 */
public interface Command {
    String execute(HttpServletRequest request) throws CommandException;
}
