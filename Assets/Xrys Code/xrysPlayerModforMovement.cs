using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;


public class PlayerCharacter : MonoBehaviour
{
    //Player Body
    private PlayerInputActions _controls;
    private Vector2 _moveaxis;
    private float _floataxis;
    public float _speed;
    private Rigidbody body;


    private void Start()
    {
        body = GetComponent<Rigidbody>();
    }
    private void FixedUpdate()
    {
        // Creating Vector3 variable for new movement by input
        Vector3 movement = new Vector3(_moveaxis.x, _floataxis, _moveaxis.y);
        body.AddForce(movement * _speed);

    }

    //Movement call function
    public void HandleMovement(InputAction.CallbackContext context)
    {
        _moveaxis = context.ReadValue<Vector2>();
        // Debug.log($"Move Axis {_moveaxis}");
    }
    //Float call function
    public void Buoyancy(InputAction.CallbackContext context)
    {
        _floataxis = context.ReadValue<float>();
        // Debug.log($"Float Axis {_floataxis}");
    }
}
