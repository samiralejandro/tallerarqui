package org.aguzman.webapp.jsf3.services;

import jakarta.ejb.Local;
import org.aguzman.webapp.jsf3.entities.Categoria;
import org.aguzman.webapp.jsf3.entities.Producto;

import java.util.List;
import java.util.Optional;

@Local
public interface ProductoService {
    List<Producto> listar();
    Optional<Producto> porId(Long id);
    void guardar(Producto producto);
    void eliminar(Long id);
    List<Categoria> listarCategorias();
    Optional<Categoria> porIdCategoria(Long id);
}
