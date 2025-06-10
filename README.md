# Gestión de Sucursales

Este repositorio contiene una solución para la gestión de sucursales, desarrollada en .NET Framework y basada en una arquitectura de programación en 3 capas.

## Características

- Gestión integral de información de sucursales.
- Arquitectura en 3 capas: visual, lógica de negocio y acceso a datos.

## Arquitectura en 3 Capas

- **Capa Visual:** Interfaz de usuario para la interacción con el sistema.
- **Capa Lógica de Negocio:** Procesa la información y aplica las reglas de negocio.
- **Capa Acceso a Datos:** Gestiona la comunicación con la base de datos.

## Scripts de Base de Datos

Para inicializar la base de datos necesaria para la aplicación, sigue estos pasos:

1. **Ubicación del script:**  
   El script de creación de la base de datos se encuentra en la carpeta `Datos` del proyecto.

2. **Ejecución del script:**  
   - Abre SQL Server Management Studio (SSMS).
   - Conéctate a tu instancia de SQL Server.
   - Abre el archivo de script (`.sql`) desde la carpeta `Datos`.
   - Haz clic en __Ejecutar__ para crear la base de datos y sus objetos.

3. **Configuración de la cadena de conexión:**  
   - Actualiza la cadena de conexión en el archivo de configuración del proyecto (`AccesoDatos`) para apuntar a la base de datos creada.

