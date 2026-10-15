using UnityEngine;
using UnityEngine.InputSystem;

public class DoorController : MonoBehaviour
{
    public bool isOpen = false;
    public float openAngle = 90f;

    private void Update()
    {
        if (Keyboard.current == null) return;

        if (Keyboard.current.eKey.wasPressedThisFrame)
        {
            isOpen = !isOpen;

            if (isOpen)
            {
                transform.rotation = Quaternion.Euler(0f, openAngle, 0f);
            }
            else
            {
                transform.rotation = Quaternion.Euler(0f, 0f, 0f);
            }
        }
    }
}
