# Escape Room 3D

Proyecto académico desarrollado en Unity para el laboratorio de control de versiones con Git, GitHub y Visual Studio Code.

## Integrantes del equipo

- Santiago Soria
- Rodolfo Jimenez
- Jairo Marquez
- Fabrizio Mendoza

## Información del proyecto

- **Motor:** Unity 6 (6000.5.5f1)
- **Lenguaje:** C#
- **Repositorio:** ClubPanitasStudios
- **Escena principal de trabajo:** SampleScene
- **Ramas principales:** main y Dev

## Descripción

Escape Room 3D es un proyecto colaborativo en el que se implementan funcionalidades de movimiento, interacción con objetos, validación de códigos y control de puertas.

El laboratorio tiene como objetivo aplicar estrategias de control de versiones mediante 20 casos prácticos, incluyendo conflictos de integración, recuperación de commits, Revert, Cherry-pick y Pull Requests.

## Funcionalidades comprobadas

- Movimiento del jugador mediante WASD.
- Detección de interacción con la tecla E.
- Apertura y cierre de la puerta mediante E.
- Validación del puzzle con el código 1, 2, 3.
- Reinicio del puzzle mediante R.
- Validación para evitar errores cuando el código del puzzle está vacío.

## Control de versiones

Se utiliza la rama Dev para integrar y comprobar cambios durante el desarrollo. Las ramas Feature permiten trabajar en funcionalidades y ejercicios específicos sin modificar directamente la versión principal.

La integración final hacia main se realiza mediante Pull Request, previa revisión y validación.

## Registro del laboratorio

- Caso 12: Corrección de un commit incorrecto.
- Caso 16: Resolución de conflicto y error producido por Accept Both.
- Caso 17: Recuperación de un cambio defectuoso mediante Revert.
- Caso 18: Recuperación de un commit mediante Reflog.
- Caso 19: Aplicación de una corrección mediante Cherry-pick.
- Caso 20: Revisión e integración final mediante Pull Request.