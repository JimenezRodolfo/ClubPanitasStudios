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

## Instrucciones de ejecución

1. Abrir el proyecto en Unity Hub con Unity 6 (6000.5.5f1).
2. Abrir la escena SampleScene.
3. Presionar Play.
4. Utilizar WASD para mover al jugador.
5. Presionar E para interactuar con la puerta.
6. Presionar 1, 2 y 3 para resolver el puzzle.
7. Presionar R para reiniciar el puzzle.
8. Revisar los mensajes en la Console de Unity.

## Prueba de validación del puzzle

Seleccionar un objeto con PuzzleManager y establecer Correct Code con tamaño 0 antes de iniciar Play.

Al presionar una tecla numérica, Unity debe mostrar la advertencia "Puzzle sin codigo configurado" sin generar errores de acceso al arreglo.