package org.aguzman.webapp.jsf3.repositories;


import jakarta.inject.Inject;
import jakarta.persistence.EntityManager;
import org.aguzman.webapp.jsf3.configs.Repository;
import org.aguzman.webapp.jsf3.entities.Usuario;

import java.util.List;

@RepositoryJpa
@Repository
public class UsuarioRepositoryJpaImpl implements UsuarioRepository{
    @Inject
    private EntityManager em;

    @Override
    public List<Usuario> listar() {
        return em.createQuery("from Usuario", Usuario.class).getResultList();
    }

    @Override
    public Usuario porId(Long id) {
        return em.find(Usuario.class, id);
    }

    @Override
    public void guardar(Usuario usuario) {
        if (usuario.getId() != null && usuario.getId() > 0) {
            em.merge(usuario);
        } else {
            em.persist(usuario);
        }
    }

    @Override
    public void eliminar(Long id) {
        em.remove(porId(id));
    }

    @Override
    public Usuario porUsername(String username) throws Exception {
        return em.createQuery("select u from Usuario u where u.username = :username", Usuario.class)
                .setParameter("username", username)
                .getSingleResult();
    }
}
