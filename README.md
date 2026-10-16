## Instrucciones de ejecución

1. Abrir el proyecto Escape Room 3D desde Unity Hub utilizando Unity 6 (6000.5.5f1).
2. En el panel Project de Unity, buscar y abrir la escena SampleScene.
3. Presionar Play para iniciar la ejecución.
4. Hacer clic en la ventana Game para controlar al jugador.
5. Utilizar las teclas WASD para desplazarse.
6. Acercarse a la puerta y presionar E para comprobar su interacción.
7. Para probar el puzzle, verificar que exista un objeto con el componente PuzzleManager en la escena.
8. Presionar las teclas 1, 2 y 3 en ese orden para completar el puzzle.
9. Presionar R para reiniciar el puzzle.
10. Verificar los mensajes de funcionamiento en la ventana Console de Unity.

## Comprobación de validación

Para comprobar la corrección del Caso 19, seleccionar el objeto con PuzzleManager y configurar Correct Code con tamaño 0 antes de iniciar Play. Al intentar introducir un número, Unity debe mostrar la advertencia "Puzzle sin codigo configurado" sin generar un error de acceso al arreglo.