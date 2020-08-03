//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//using UnityEngine.InputSystem;

//public class xrysPlayerController : MonoBehaviour
//{
//    // Looking variables
//    public new Camera camera;
//    public float turnSpeed;
//    public float lerpSpeed = 3f;
//    private Quaternion newCameraRotation;
//    private Quaternion newForwardRotation;
//    private Rigidbody body;
//    private float look;
//    private float turn;
//    //Movement variables
//    private Vector2 _moveaxis;
//    private float _floataxis;
//    public float _speed;

//    private void Awake()
//    {
//        Cursor.lockState = CursorLockMode.Locked;

//        body = GetComponent<Rigidbody>();

//        newForwardRotation = transform.rotation;
//        newCameraRotation = camera.transform.localRotation;

//    }

//    float yRotation;
//    float xRotation;

//    private void FixedUpdate()
//    {

//        body.velocity = Vector3.zero;

//        //Turn the player based on the Turn Axis
//        yRotation = transform.rotation.eulerAngles.y;
//        yRotation += turnSpeed * turn;
//        newForwardRotation = Quaternion.Euler(transform.rotation.eulerAngles.x, yRotation, transform.rotation.eulerAngles.z);

//        //Pitch the camera based on the Look Axis
//        xRotation = camera.transform.localRotation.eulerAngles.x;
//        xRotation -= turnSpeed * look;
//        newCameraRotation = Quaternion.Euler(xRotation, camera.transform.localRotation.eulerAngles.y, camera.transform.localRotation.eulerAngles.z);

//        //Lerp the rotations
//        transform.rotation = Quaternion.Lerp(transform.rotation, newForwardRotation, lerpSpeed);
//        camera.transform.localRotation = Quaternion.Lerp(camera.transform.localRotation, newCameraRotation, lerpSpeed);


//        // Creating Vector3 variable for new movement by input
//        body.AddForce(transform.forward * _speed * _moveaxis.y);
//        body.AddForce(transform.right * _speed * _moveaxis.x);
//        body.AddForce(transform.up * _speed * _floataxis);

//    }

//    //Movement call function
//    public void HandleMovement(InputAction.CallbackContext context)
//    {
//        _moveaxis = context.ReadValue<Vector2>();
//        // Debug.log($"Move Axis {_moveaxis}");
//    }
//    public void Buoyancy(InputAction.CallbackContext context)
//    {
//        _floataxis = context.ReadValue<float>();
//        // Debug.log($"Float Axis {_floataxis}");
//    }

//    public void Look(InputAction.CallbackContext context)
//    {
//        turn = context.ReadValue<Vector2>().x;
//        look = context.ReadValue<Vector2>().y;
//    }

//}
