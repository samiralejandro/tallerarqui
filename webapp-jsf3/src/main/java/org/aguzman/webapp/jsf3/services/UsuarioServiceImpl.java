package org.aguzman.webapp.jsf3.services;

import jakarta.ejb.Stateless;
import jakarta.inject.Inject;
import org.aguzman.webapp.jsf3.configs.Service;
import org.aguzman.webapp.jsf3.entities.Usuario;
import org.aguzman.webapp.jsf3.repositories.RepositoryJpa;
import org.aguzman.webapp.jsf3.repositories.UsuarioRepository;


import java.util.Optional;

@Service
@Stateless
public class UsuarioServiceImpl implements UsuarioService{
    private UsuarioRepository usuarioRepository;

    @Inject
    public UsuarioServiceImpl(@RepositoryJpa UsuarioRepository usuarioRepository) {
        this.usuarioRepository = usuarioRepository;
    }

    @Override
    public Optional<Usuario> login(String username, String password) {
        try {
            return Optional.ofNullable(usuarioRepository.porUsername(username)).filter(u -> u.getPassword().equals(password));
        } catch (Exception throwables) {
            throw new ServiceJdbcException(throwables.getMessage(), throwables.getCause());
        }
    }
}
