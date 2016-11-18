package command;

import command.impl.*;
import exception.CommandException;

import java.util.HashMap;

/**
 * Created by Антон on 15.07.2016.
 */
public class CommandManager {

    private static HashMap<CommandName, Command> availableCommands = new HashMap<>();
    static {
        availableCommands.put(CommandName.GO_HOME, new GoHomeCommand());
        availableCommands.put(CommandName.FIND_ALL_SIGNALS, new FindAllSignalsCommand());
        availableCommands.put(CommandName.CREATE_SIGNAL, new CreateSignalCommand());
        availableCommands.put(CommandName.FIND_SIGNAL_FOR_CREATE, new FindSignalForCreateCommand());
        availableCommands.put(CommandName.FIND_SIGNAL_FOR_UPDATE, new FindSignalForUpdateCommand());
        availableCommands.put(CommandName.CREATE_SIGNAL, new CreateSignalCommand());
        availableCommands.put(CommandName.UPDATE_SIGNAL, new UpdateSignalCommand());
        availableCommands.put(CommandName.DELETE_SIGNAL, new DeleteSignalCommand());
        availableCommands.put(CommandName.DRAW_GRAPH, new DrawGraphCommand());
        availableCommands.put(CommandName.FOURIE_TRANSFORM, new FourieTransformCommand());
    }

    public static Command getCommand(String commandName) throws CommandException {
        if(commandName != null) {
            if (!commandName.isEmpty()) {
                try {
                    CommandName name = CommandName.valueOf(commandName.toUpperCase());
                    return availableCommands.get(name);
                }catch (IllegalArgumentException e) {
                    throw new CommandException("Invalid command", e);
                }
            } else throw new CommandException("Invalid command");
        }else return availableCommands.get(CommandName.GO_HOME);
    }
}
