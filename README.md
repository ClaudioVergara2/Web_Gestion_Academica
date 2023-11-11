# Web de Gestión Académica
Este repositorio contiene una web de gestión académica conectada con una api. (https://github.com/ClaudioVergara2/API_GestionAcademica)

## Pantalla Inicio de Sesión
- Se validan los campos de nombre de usuario y contraseña.
- Si el usuario no se encuentra, se muestra el mensaje "Usuario no se encuentra en el sistema".
- Si el usuario se encuentra pero la contraseña es incorrecta, se muestra "Contraseña incorrecta".
- Al iniciar sesión con éxito, se muestra el nombre de la persona en la parte superior.

## Menú Principal
- Se muestra una lista de cursos del semestre actual (semestre activo) por defecto.
- Acceso a diferentes pantallas según el perfil del usuario:
  - Ingreso de Notas (Operador, Profesor).
  - Ingreso de Curso (Operador).
  - Ingreso de Persona (Operador).
  - Ingreso de Perfil (Operador).
  - Ingreso de Usuario (Operador).
  - Ingreso de Alumnos por Curso (Operador).
  - Ingreso de Asignatura (Operador).
  - Ingreso de Semestre (Operador).
  -Ingreso de Tipo Asignatura (Operador).

## Pantalla Tipo Asignatura
- Permite configurar tipos de asignaturas.
- Se pueden agregar nuevos tipos, pero no eliminar o editar existentes.
- Los campos no pueden estar vacíos.
- Visualización de tipos ingresados.
- Los registros nuevos tienen un ID autoincremental.
- Campos: ID, NOM_TIPO_ASIGNATURA, CANTIDAD_NOTAS.

## Pantalla Semestre
- Permite ingresar un nuevo semestre relacionado con un año.
- Los datos no pueden estar vacíos.
- Visualización de todos los semestres con su estado (ACTIVO/INACTIVO).
- Edición del estado del semestre (ACTIVO/INACTIVO).

 ## Pantalla Ingreso Asignatura
- Permite ingresar una asignatura.
- Campos: Código, Nombre, Semestre.
- Validación de campos no vacíos.
- Validación de código único.
- Selección de semestre y asignatura desde un dropdownlist.

## Pantalla Ingreso Curso
- Permite ingresar un nuevo curso.
- Campos: Profesor, Asignatura, Sección.
- Validación de sección única por curso y profesor.
- Visualización de datos, no permite eliminar o editar registros.

## Pantalla Perfil
- Permite registrar nuevos perfiles.
- Visualización de perfiles, no permite eliminar o editar.

## Pantalla Persona
- Registro de personas (Operador, Profesor, Estudiante).
- Campos: Nombre, Apellido, Fecha de nacimiento, Perfil.
- Validación de campos no vacíos.
- Visualización y edición de registros (nombre, apellido, fecha de nacimiento).
- Pantalla Ingreso Alumnos

## Formulario para ingresar alumnos.
- Campos: Nombres, Apellidos, Código (autoincremental).
- Validación de campos no vacíos.
- Modificación de datos y habilitación/deshabilitación.

## Pantalla Usuario
- Registro de usuarios para perfiles Operador y Profesor.
- Campos: Nombre de usuario, Contraseña.
- Validación de campos no vacíos.
- Visualización de registros.

## Pantalla Alumnos
- Ingreso de alumnos con perfil Estudiante.
- Selección de curso desde un dropdownlist.
- Validación de campos no vacíos.
- Visualización y eliminación de registros (si no tienen notas asociadas).

## Pantalla Notas
- Ingreso de notas para alumnos.
- Selección de curso y sección activos desde dropdownlist.
- Listado de alumnos con cantidad de notas según el tipo de asignatura.
- Edición de notas existentes.
- Botón "Guardar Todo" para guardar las notas.
