package org.aguzman.webapp.jsf3.services;

import jakarta.ejb.Local;
import org.aguzman.webapp.jsf3.entities.Usuario;

import java.util.Optional;


@Local
public interface UsuarioService {
    Optional<Usuario> login(String username, String password);
}
