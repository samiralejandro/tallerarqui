package org.aguzman.webapp.jsf3.controllers;

import jakarta.enterprise.context.RequestScoped;
import jakarta.inject.Inject;
import jakarta.inject.Named;
import jakarta.faces.context.FacesContext;
import jakarta.servlet.http.HttpServletRequest;
import jakarta.servlet.http.HttpSession;
import org.aguzman.webapp.jsf3.services.LoginService;

import java.io.IOException;
import java.io.Serializable;
import java.util.Optional;

@Named
@RequestScoped
public class LogoutController implements Serializable {

    @Inject
    private LoginService auth;

    public void logout() {
        FacesContext context = FacesContext.getCurrentInstance();
        HttpServletRequest req = (HttpServletRequest) context.getExternalContext().getRequest();
        Optional<String> username = auth.getUsername(req);
        if (username.isPresent()) {
            HttpSession session = req.getSession(false);
            if (session != null) {
                session.invalidate();
            }
            try {
                context.getExternalContext().redirect(req.getContextPath() + "/login.xhtml");
            } catch (IOException e) {
                // Handle possible IOException here
            }
        }
    }
}
