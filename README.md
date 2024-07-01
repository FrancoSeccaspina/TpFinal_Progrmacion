# Trabajo Práctico (veterinaria)
### integrantes
* Aguirre Lucas
* Lanza Tomás
* Jimenez Gustavo
* Seccaspina Franco
# Configuración del Proyecto

## 1. Entrar al repositorio de GitHub
- Abre tu navegador web y dirígete al siguiente enlace: [TpFinal_Progrmacion](https://github.com/FrancoSeccaspina/TpFinal_Progrmacion).

## 2. Descargar el repositorio
### Opción 1: Descargar como ZIP
1. En la parte superior derecha del repositorio, haz clic en el botón verde que dice `<> Code`.
2. Selecciona `Download ZIP`.
3. Descomprime el archivo ZIP en tu computadora.

### Opción 2: Clonar el repositorio usando Git Bash
1. Abre Git Bash en tu computadora.
2. Navega al directorio donde deseas clonar el repositorio.
3. Ejecuta el siguiente comando:
    ```bash
    git clone https://github.com/FrancoSeccaspina/TpFinal_Progrmacion.git
    ```
4. Una vez completado, navega al directorio clonado:
    ```bash
    cd TpFinal_Progrmacion
    ```

## 3. Configurar la base de datos
- Asegúrate de tener SQL Server 2019 y SQL Server Management Studio 20 instalados en tu computadora.
- Busca el script SQL en el repositorio que genera la base de datos.
- Abre SQL Server Management Studio y conéctate a tu instancia de SQL Server.
- Ejecuta el script para crear la base de datos y las tablas necesarias.

## 4. Configuración del entorno de desarrollo
- Asegúrate de tener Visual Studio 2022 instalado.
- Abre el proyecto en Visual Studio.
- Verifica que el proyecto esté configurado para usar .NET Framework 4.7.2 o superior.
- Configura las cadenas de conexión a la base de datos en los archivos de configuración del proyecto si es necesario.


## Utilización el Programa:
Para ingresar al programa, se puede ingresar con el usuario supremo.
Usuario: admin
Contraseña: 123

**ATENCIÓN: EL TRABAJO PUEDE ESTAR SUJETO A MODIFICACIONES**

## Premisa:
Desarrollar un programa para una veterinaria.

## Ingreso:
Al sistema se debe poder ingresar con usuario y contraseña, los mismos deben estar guardados en la base de datos.

## ABMs Requeridos:

### Clientes:
Los clientes deben tener como mínimo DNI y nombre.

### Especies:
Las especies de los animales deben ser cargadas por el usuario, incluyendo nombre de la especie, edad de madurez y peso promedio.

### Animales:
Los animales deben estar asociados a un cliente y a una especie. Adicionalmente deben tener nombre, peso y edad.

### Usuarios:
Se debe poder dar de alta un usuario, cuya clave se preguntará la primera vez que intente ingresar.

## Reportes Solicitados:
Mostrar los siguientes datos en formato de grilla (deben estar en pantallas separadas):

1. Mostrar el peso máximo, mínimo y promedio agrupado por especie de todos los animales. Este reporte debe contener un filtro para seleccionar el rango de edad (pueden hacerlo por medio de dos textbox e incluir su valor en el texto de la query).
   
2. Mostrar la cantidad de animales con los que cuenta cada dueño, ordenado de menor a mayor.

## Requisitos Técnicos:
- Los datos deben persistir en una base de datos SQL Server.
- La aplicación puede estar hecha en Visual Basic o C# (pueden utilizar ambos a la vez).
- El programa debe estar separado en al menos dos proyectos.
- Debe estar hecho en Windows Forms con .NET Framework.

## Condiciones de Entrega:
- La entrega deberá hacerse por grupos de no más de cuatro personas.
- Deberá ser entregado por un solo miembro del grupo en un comprimido con el nombre de todos los integrantes.
- Dentro del comprimido, deben incluirse el código fuente del programa y el esquema correspondiente a la base de datos. Además, deberá existir un readme.txt con las instrucciones de instalación.

## Respecto a la Autenticidad del Trabajo:
- Si se entregan dos trabajos iguales, se calificará con la nota 1 (Uno) al grupo que se haya copiado, siempre y cuando se pueda demostrar cuál es el trabajo original. En caso contrario, se calificará con la nota 1 (Uno) a ambos.
- En caso de entregar un trabajo extraído de internet, se calificará al grupo en cuestión con la nota 1 (Uno).

