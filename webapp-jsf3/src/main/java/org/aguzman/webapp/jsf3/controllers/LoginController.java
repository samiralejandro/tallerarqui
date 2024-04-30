package org.aguzman.webapp.jsf3.controllers;
import jakarta.enterprise.context.SessionScoped;
import jakarta.faces.application.FacesMessage;
import jakarta.faces.context.FacesContext;
import jakarta.inject.Inject;
import jakarta.inject.Named;
import org.aguzman.webapp.jsf3.entities.Usuario;
import org.aguzman.webapp.jsf3.services.UsuarioService;

import java.io.Serializable;
import java.util.Optional;

@Named
@SessionScoped
public class LoginController implements Serializable {
    private String username;
    private String password;
    // Constructor, inyecciones y otros métodos...

    public String getUsername() {
        return username;
    }

    public void setUsername(String username) {
        this.username = username;
    }

    public String getPassword() {
        return password;
    }

    public void setPassword(String password) {
        this.password = password;
    }

    @Inject
    private UsuarioService usuarioService;

    public String doLogin() {
        Optional<Usuario> usuarioOptional = usuarioService.login(username, password);
        if (usuarioOptional.isPresent()) {
            return "/protected/index.xhtml?faces-redirect=true";
        } else {
            FacesContext.getCurrentInstance().addMessage(null, new FacesMessage(FacesMessage.SEVERITY_ERROR, "Error", "Credenciales incorrectas."));
            return "/login.xhtml?faces-redirect=false";
        }
    }

    public String logout() {
        FacesContext.getCurrentInstance().getExternalContext().invalidateSession();
        return "/login.xhtml?faces-redirect=true";
    }
}

