# Microservicios con Docker y ASP.Net Core

## Descripción
[Proporciona una breve descripción de tu proyecto aquí. Explica el propósito del proyecto y las funcionalidades principales.]

## Tecnologías Utilizadas
- **ASP.NET Core**: Para construir la API web.
- **Entity Framework Core**: Para interactuar con la base de datos.
- **SQL Server**: Como sistema de gestión de base de datos.
- **Docker**: Para la creación de contenedores y la gestión del entorno de desarrollo.
- **Docker Compose**: Para orquestar los microservicios.
- **Postman**: Para probar las API.

## Patrón de Arquitectura
El proyecto sigue una arquitectura de microservicios, donde cada servicio (por ejemplo, `ProductService`, `OrderService`) es independiente y se comunica con otros a través de APIs. Se utiliza Docker para la contenedorización de cada servicio, lo que facilita su despliegue y escalabilidad.

## Archivos del Proyecto
- `Dockerfile`: Define cómo construir la imagen de Docker para cada servicio.
- `docker-compose.yml`: Orquesta múltiples contenedores Docker, incluyendo los microservicios y la base de datos.
- `Program.cs`: Punto de entrada del proyecto ASP.NET Core y Configuración del pipeline de la aplicación y servicios

## Instrucciones de Ejecución
1. **Clonar el repositorio**:
   ```bash
   git clone https://github.com/tu_usuario/tu_repositorio.git
   cd tu_repositorio
2. **Construir y ejecutar los contenedores con Docker Compose**:
  ```bash
  docker-compose up --build
```
3. **Aplicar migraciones de la base de datos**:
Si es necesario, puedes aplicar las migraciones manualmente dentro del contenedor:
```bash
docker exec -it <nombre_del_contenedor> dotnet ef database update
```
4. **Probar la API**:
Puedes utilizar Postman para hacer peticiones a la API en http://localhost:8001/api/Products para el ProductService.

## Licencia

Este proyecto está licenciado bajo la [MIT License](LICENSE).

## Agradecimientos

Un agradecimiento especial a los miembros del canal InfoToolsSV por su apoyo continuo y por hacer posible este proyecto. ¡Gracias por ser parte de esta comunidad y por contribuir a su crecimiento!

