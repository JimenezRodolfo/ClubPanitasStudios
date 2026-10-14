using UnityEngine;
using UnityEngine.InputSystem;

public class OldDoorController : MonoBehaviour
{
    public bool isOpen = false;

    private void Update()
    {
        if (Keyboard.current == null) return;

        if (Keyboard.current.gKey.wasPressedThisFrame)
        {
            isOpen = !isOpen;
            Debug.Log("Old door toggled");
        }
    }
}