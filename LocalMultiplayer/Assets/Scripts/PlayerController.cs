using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public float speed = 1f;
    
    private Vector2 _move = Vector2.zero;

    private void Update()
    {
        transform.position += (Vector3)_move * (speed * Time.deltaTime);
    }

    public void Move(InputAction.CallbackContext context)
    {
        _move = context.ReadValue<Vector2>();
        Debug.Log($"Move: {_move}");
    }
}
