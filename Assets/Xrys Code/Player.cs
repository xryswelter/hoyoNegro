using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;


public class Player : MonoBehaviour
{
    //Player Body
    private PlayerInputActions _controls;
    private Vector2 _moveaxis;
    private float _floataxis;
    public float _speed;
    
    //Head Controls
    public Transform playerBody;
    public Transform head;
    private float _turnHead;
    private float _nod;
    public float _mouseSensitivity;

    //Awake and Lock Mouse
    private void Awake(){
        // Cursor.lockState = CursorLockMode.Locked;
    }

    private void Update()
    {
        //Change the player location "aka movement"
        transform.position += new Vector3(
            _moveaxis.x * Time.deltaTime * _speed,
            _floataxis * Time.deltaTime * _speed,
            _moveaxis.y * Time.deltaTime * _speed
        );

        //Head Rotation and movement
        playerBody.transform.Rotate(0, _turnHead,0f);
        head.transform.localRotation = Quaternion.Euler(_nod,0f,0f);
    }

    //Movement call function
    public void HandleMovement(InputAction.CallbackContext context)
    {
        _moveaxis = context.ReadValue<Vector2>();
        // Debug.log($"Move Axis {_moveaxis}");
    }
    //Float call function
    public void HandleFloat(InputAction.CallbackContext context)
    {
        _floataxis = context.ReadValue<float>();
        // Debug.log($"Float Axis {_floataxis}");
    }

    public void HandleLooking(InputAction.CallbackContext context)
    {
        //Turning Body to look left and Right
        Vector2 contextV2 = context.ReadValue<Vector2>();
        _turnHead += contextV2.x * _mouseSensitivity * Time.deltaTime;
        // _turnHead = Mathf.Clamp(_turnHead,-90f,90f);

        //Turning Camera to look up and down
        _nod -=contextV2.y * _mouseSensitivity *Time.deltaTime;
        _nod = Mathf.Clamp(_nod,-90f,90f);

    }
}
