package command.impl;

import command.Command;
import exception.CommandException;

import javax.servlet.http.HttpServletRequest;

/**
 * Created by Anton Shulha on 17.11.2016.
 */
public class FourieTransformCommand implements Command {
    @Override
    public String execute(HttpServletRequest request) throws CommandException {
        return null;
    }
}
