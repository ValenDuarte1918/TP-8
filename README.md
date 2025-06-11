# Gestión de Sucursales

Este repositorio contiene una solución para la gestión de sucursales, desarrollada en .NET Framework y basada en una arquitectura de programación en 3 capas. 
Fue desarollado por:
- Valentin Duarte
- Ignacio Arnaude
- Franco David Monzon Lopez
- Camila Moyano
- Miguel Armando Velazquez Barreto
- Nicolas Gabriel Blanco

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

![img-1](https://github.com/user-attachments/assets/a89c2b8c-9544-4680-9103-960b678cbff2)
![img-2](https://github.com/user-attachments/assets/3f8a0792-b466-4e55-9436-274665bad0a0)
![img-3](https://github.com/user-attachments/assets/1c283b63-b4b9-4c3e-8917-1685eea81a49)
