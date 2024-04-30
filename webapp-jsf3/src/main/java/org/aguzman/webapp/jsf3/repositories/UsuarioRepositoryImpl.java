package org.aguzman.webapp.jsf3.repositories;


import jakarta.inject.Inject;
import org.aguzman.webapp.jsf3.configs.MysqlConn;
import org.aguzman.webapp.jsf3.configs.Repository;
import org.aguzman.webapp.jsf3.entities.Usuario;

import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;

import java.util.List;

@Repository
@RepositoryJdbc
public class UsuarioRepositoryImpl implements UsuarioRepository {

    @Inject
    @MysqlConn
    private Connection conn;

    @Override
    public List<Usuario> listar() {
        return null;
    }

    @Override
    public Usuario porId(Long id) {
        return null;
    }

    @Override
    public void guardar(Usuario usuario) {

    }

    @Override
    public void eliminar(Long id) {

    }

    @Override
    public Usuario porUsername(String username) throws SQLException {
        Usuario usuario = null;
        try (PreparedStatement stmt = conn.prepareStatement("select * from usuarios where username=?")) {
            stmt.setString(1, username);
            try (ResultSet rs = stmt.executeQuery()) {
                if (rs.next()) {
                    usuario = new Usuario();
                    usuario.setId(rs.getLong("id"));
                    usuario.setUsername(rs.getString("username"));
                    usuario.setPassword(rs.getString("password"));
                    usuario.setEmail(rs.getString("email"));
                }
            }
        }
        return usuario;
    }
}
