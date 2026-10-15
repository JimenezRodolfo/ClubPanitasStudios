using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public float speed = 5f;

    private void Update()
    {
        Move();
    }

    private void Move()
    {   // movimiento actualizado
        if (Keyboard.current == null) return;

        float h = 0f;
        float v = 0f;

        if (Keyboard.current.aKey.isPressed) h = -1f;
        if (Keyboard.current.dKey.isPressed) h = 1f;
        if (Keyboard.current.sKey.isPressed) v = -1f;
        if (Keyboard.current.wKey.isPressed) v = 1f;

        Vector3 movement = new Vector3(h, 0f, v);
        transform.Translate(movement * speed * Time.deltaTime);
        Debug.Log("Movement system active");
    }
}