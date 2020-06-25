using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    [SerializeField] private playerInputActions _controls;
    private Vector2 _moveaxis;

    private void OnEnable(){
        //Enable Controls for horizonal("plain") movement 
        _controls.PlayerControls.Movement.performed += HandleMovement;
        _controls.PlayerControls.Movement.Enable();
        //Enable Controls for vertical movement
        _controls.PlayerControls.Float.performed += HandleFloat;
        _controls.PlayerControls.Float.Enable();

    } 
    
    private void OnDisable(){
        //Disable Controls for horizonal("plain") movement 
        _controls.PlayerControls.Movement.performed -= HandleMovement;
        _controls.PlayerControls.Movement.Disable();
        //Disable Controls for vertical movement
        _controls.PlayerControls.Float.Disable();
        _controls.PlayerControls.Float.Disable();

    }

    private void Update(){
        //Change the player location "aka movement"
        transform.position += new Vector3(
            _moveaxis.x * time.deltaTime* _speed,
            _floataxis*time.deltaTime*_speed,
            _moveaxis.y*time.deltaTime*_speed
        );
        //Used Vector 3 to add in the float function
    }

    //Movement call function
    private void HandleMovement(InputAction.CallbackContent context){
        _moveaxis = context.ReadValue<Vector2>();
        Debug.log($"Move Axis {_moveaxis}");
    }
    //Float call function
    private void HandleFloat(InputAction.CallbackContent context){
        _floataxis = context.ReadValue<Axis>();
        Debug.log($"Float Axis {_floataxis}");
    }
}
