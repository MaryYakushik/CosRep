package listener;

import entity.Signal;

import javax.servlet.http.HttpSessionEvent;
import javax.servlet.http.HttpSessionListener;
import java.util.ArrayList;

/**
 * Created by Антон on 24.10.2016.
 */
public class SessionListener implements HttpSessionListener {
    @Override
    public void sessionCreated(HttpSessionEvent httpSessionEvent) {
        int signalNumber = 0;
        ArrayList<Signal> signalList = new ArrayList<>();
        httpSessionEvent.getSession().setAttribute("signal_number", signalNumber);
        httpSessionEvent.getSession().setAttribute("signal_list", signalList);
    }

    @Override
    public void sessionDestroyed(HttpSessionEvent httpSessionEvent) {

    }
}
