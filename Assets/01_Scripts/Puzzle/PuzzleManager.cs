using UnityEngine;
using UnityEngine.InputSystem;

public class PuzzleManager : MonoBehaviour
{
    public int[] correctCode = new int[3] { 1, 2, 3 };
    public int step = 0;
    public bool solved = false;

    private void Update()
    {
        if (Keyboard.current == null) return;

        if (Keyboard.current.digit1Key.wasPressedThisFrame) PressButton(1);
        if (Keyboard.current.digit2Key.wasPressedThisFrame) PressButton(2);
        if (Keyboard.current.digit3Key.wasPressedThisFrame) PressButton(3);
    }

    public void PressButton(int number)
    {
        if (solved) return;

        if (number == correctCode[step])
        {
            step++;
            Debug.Log("Correct step: " + step);

            if (step >= correctCode.Length)
            {
                solved = true;
                Debug.Log("Puzzle solved");
            }
        }
        else
        {
            step = 0;
            Debug.Log("Wrong button, puzzle reset");
        }
    }
}