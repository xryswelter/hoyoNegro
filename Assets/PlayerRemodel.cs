using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

//Referenced Unity's KeyDoor Puzzle for Coding
public class PlayerRemodel : MonoBehaviour
{
    //Player Body
    private PlayerInputActions _controls;

    private float _horizontalMovement;
    private float _verticalMovement;
    private float _floatMovement;
    public float _movementSpeed;

    //Head Controls
    public Rigidbody playerBody;
    public Transform head;
    private Quaternion headRotation;
    private Quaternion bodyRotation;
    private float _turnHead;
    private float _turnBody;
    public float _mouseSensitivity;
    private float linearCalcSpeed = 3f;

    //Awake and Lock Mouse
    private void Awake()
    {
        Cursor.lockState = CursorLockMode.Locked;

        //Not sure why we need this, but they have it in here
        headRotation = head.transform.localRotation;
        bodyRotation = transform.rotation;
    }

    private void Update()
    {
        playerBody.velocity =Vector3.zero;
        //Looking Update
        float yAxisLook;
        yAxisLook = transform.rotation.eulerAngles.y;
        yAxisLook += _mouseSensitivity * _turnHead;
        headRotation = Quaternion.Euler(transform.rotation.eulerAngles.x, yAxisLook, transform.rotation.eulerAngles.z);


        //Turning Update
        float xAxisLook;
        xAxisLook = transform.rotation.eulerAngles.x;
        xAxisLook += _mouseSensitivity * _turnBody;
        bodyRotation = Quaternion.Euler(xAxisLook, head.transform.localRotation.eulerAngles.y, GetComponent<Camera>().transform.localRotation.eulerAngles.z);

        //Movement Update
        GetComponent<Rigidbody>().AddForce(transform.forward * _movementSpeed * _verticalMovement);
        GetComponent<Rigidbody>().AddForce(transform.right * _movementSpeed * _horizontalMovement);

        //Lerping
        transform.rotation = Quaternion.Lerp(transform.rotation, bodyRotation, linearCalcSpeed);
        head.transform.localRotation = Quaternion.Lerp(head.transform.localRotation, headRotation, linearCalcSpeed);

    }

    //Movement call function
    public void HandleMovement(InputAction.CallbackContext context)
    {
        Vector2 contextV2 = context.ReadValue<Vector2>();
        _horizontalMovement = contextV2.x;
        _verticalMovement = contextV2.y;

        // Debug.log($"Move Axis {_moveaxis}");
    }
    //Float call function
    public void HandleFloat(InputAction.CallbackContext context)
    {
        _floatMovement = context.ReadValue<float>();
        playerBody.AddForce(Vector2.up * _movementSpeed);
        // Debug.log($"Float Axis {_floataxis}");
    }

    public void HandleLooking(InputAction.CallbackContext context)
    {
        //Get Value for deltaMouse
        Vector2 contextV2 = context.ReadValue<Vector2>();
        //Set X + Y movement of mouse into variables
        _turnBody = contextV2.x;
        _turnHead = contextV2.y;

    }
}
