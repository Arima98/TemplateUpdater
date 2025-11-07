Actualizador de Plantillas (Template Updater)

Esta es una herramienta de escritorio de .NET Windows Forms diseñada para modificar masivamente plantillas de proyectos contenidas en archivos .zip. La aplicación permite al usuario cargar un archivo .zip, definir reglas de reemplazo dinámicas y generar un nuevo archivo .zip con todos los cambios aplicados tanto a los nombres de carpetas/archivos como a su contenido interno.

Características Principales
Reglas de Reemplazo Dinámicas: Permite al usuario definir múltiples reglas de "buscar y reemplazar" en una cuadrícula.

Vista Previa en Tiempo Real: Muestra una estructura de árbol que se actualiza instantáneamente con cada regla, permitiendo al usuario ver la estructura de carpetas resultante antes de procesar.

Procesamiento Completo: Las reglas se aplican de forma integral a:

El contenido textual dentro de todos los archivos.

Los nombres de los archivos.

Los nombres de las carpetas.

Aplicación Autónoma: El ejecutable publicado no requiere que los usuarios tengan instalado .NET en sus máquinas para funcionar.

Para Usuarios: Descarga e Instalación
No es necesario compilar el código para usar esta herramienta.

1. Descarga y Ejecución
Descargar: Navegue a la sección de Releases de este repositorio.

Obtener el archivo: Descargue el archivo .zip de la última versión (ej. TemplateUpdater-v1.0.zip).

Descomprimir:

Haga clic derecho en el archivo .zip descargado y seleccione "Propiedades".

En la pestaña "General", marque la casilla "Desbloquear" (si está disponible) y haga clic en "Aceptar".

Haga clic derecho nuevamente en el .zip y seleccione "Extraer todo...".

Ejecutar: Abra la carpeta recién descomprimida y ejecute el archivo TemplateUpdater.exe.

2. Instrucciones de Uso
Cargar el ZIP:

Haga clic en 1. Cargar ZIP de Plantilla....

Seleccione su archivo .zip. La sección "Vista Previa" (derecha) mostrará la estructura de carpetas actual.

Añadir Reglas de Reemplazo:

En la cuadrícula izquierda ("Reglas de Reemplazo"), haga clic en una celda de la columna Texto Original y escriba el texto que desea cambiar (ej. Departament1).

En la celda Texto Nuevo adyacente, escriba el valor por el cual será reemplazado (ej. Finanzas).

Repita este proceso en las filas inferiores para añadir todas las reglas que necesite.

Verificar la Vista Previa:

Observe el árbol de la derecha ("Vista Previa"). Este se actualizará automáticamente con cada regla que añada, mostrándole cómo se verá la nueva estructura.

Seleccionar Ruta de Salida:

Haga clic en 2. Seleccionar Ruta de Salida....

Elija la ubicación y el nombre para el nuevo archivo .zip que se generará.

Procesar y Comprimir:

Una vez que esté satisfecho con las reglas y la vista previa, haga clic en 3. Actualizar y Comprimir.

La herramienta aplicará todos los cambios y creará el nuevo archivo .zip en la ubicación que seleccionó.

Para Desarrolladores (Compilación)
Si desea modificar o compilar el código fuente:

Clone este repositorio:

Bash

git clone https://github.com/Arima98/TemplateUpdater.git
Abra el archivo TemplateUpdater.sln con Visual Studio 2022.

Asegúrese de tener instalado el SDK de .NET correspondiente (ej. .NET 8.0) y la carga de trabajo de "Desarrollo de escritorio de .NET".

Presione F5 para compilar y ejecutar en modo de depuración.
