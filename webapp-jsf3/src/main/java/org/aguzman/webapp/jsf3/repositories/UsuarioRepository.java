package org.aguzman.webapp.jsf3.repositories;


import org.aguzman.webapp.jsf3.entities.Usuario;

public interface UsuarioRepository extends CrudRepository<Usuario> {
    Usuario porUsername(String username) throws Exception;
}
