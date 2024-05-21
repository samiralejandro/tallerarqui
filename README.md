# Taller de Arquitectura de Software - Ecommerce de los Chakales

Este proyecto es un ejemplo de una aplicación web desarrollada con JavaServer Faces (JSF) 3.0, que simula un sistema de comercio electrónico básico. El proyecto se denomina "Ecommerce de los Chakales" y está diseñado para demostrar el uso de diversas tecnologías y patrones de diseño en el desarrollo de aplicaciones web empresariales.

## Características

- **Gestión de Productos**: Permite crear, editar y eliminar productos del catálogo.
- **Listado de Productos**: Muestra un listado de todos los productos disponibles en el sistema.
- **Gestión de Categorías**: Los productos pueden clasificarse en diferentes categorías.

## Tecnologías Utilizadas

- **JavaServer Faces (JSF) 3.0**: Marco de trabajo para construir interfaces de usuario en aplicaciones web.
- **Jakarta EE 9**: Plataforma para el desarrollo de aplicaciones empresariales en Java.
- **Maven**: Herramienta de gestión y comprensión de proyectos de software.

## Estructura del Proyecto

El proyecto sigue una estructura modular que separa las responsabilidades de las diferentes partes de la aplicación:

- **Modelo**: Define las entidades del dominio de la aplicación, como `Producto` y `Categoria`.
- **Vista**: Archivos XHTML que definen la interfaz de usuario de la aplicación.
- **Controlador**: Clases Java que manejan la lógica de negocio y la interacción entre la vista y el modelo.

## Cómo Empezar

Para ejecutar el proyecto, necesitarás tener instalado JDK 11 y Maven. Sigue estos pasos para ejecutar la aplicación:

1. Clona el repositorio del proyecto:
git clone https://github.com/samiralejandro/tallerarqui.git


2. Navega al directorio del proyecto:
cd webapp-jsf3


3. Ejecuta la aplicación con Maven:
mvn clean package wildfly:run


La aplicación debería estar ahora ejecutándose y accesible a través de `http://localhost:8080/webapp-jsf3`.

## Contribuir

Si deseas contribuir al proyecto, por favor, sigue las siguientes recomendaciones:

- **Reporta Bugs**: Si encuentras algún error, por favor, crea un issue en el repositorio.
- **Sugiere Mejoras**: Si tienes alguna idea para mejorar la aplicación, no dudes en compartirla.
- **Envía Pull Requests**: Si deseas aportar directamente al código, siente libre de hacer un fork y enviar un pull request con tus cambios.

## Licencia

Este proyecto está licenciado bajo la Licencia MIT - vea el archivo [LICENSE.md](LICENSE.md) para más detalles.

## Agradecimientos

- A todos los contribuyentes que han ayudado a mejorar este proyecto.
- A la comunidad de Jakarta EE y JSF por proporcionar las tecnologías utilizadas en este proyecto.
