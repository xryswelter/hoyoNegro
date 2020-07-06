// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;
// using UnityEngine.InputSystem;

// public class PlayerController : MonoBehaviour
// {
//     public Camera camera;

//     public float moveSpeed;
//     public float turnSpeed;

//     public float lerpSpeed = 3f;

//     private Quaternion newCameraRotation;
//     private Quaternion newForwardRotation;

//     private Rigidbody body;

//     private float forward;
//     private float horizontal;
//     private float look;
//     private float turn;

//     private void Awake()
//     {
//         Cursor.lockState = CursorLockMode.Locked;

//         body = GetComponent<Rigidbody>();

//         newForwardRotation = transform.rotation;
//         newCameraRotation = camera.transform.localRotation;
      
//     }

//     float yRotation;
//     float xRotation;

//     private void FixedUpdate()
//     {

//         body.velocity = Vector3.zero;

//         //Turn the player based on the Turn Axis
//         yRotation = transform.rotation.eulerAngles.y;
//         yRotation += turnSpeed * turn;
//         newForwardRotation = Quaternion.Euler(transform.rotation.eulerAngles.x, yRotation, transform.rotation.eulerAngles.z);

//         //Pitch the camera based on the Look Axis
//         xRotation = camera.transform.localRotation.eulerAngles.x;
//         xRotation -= turnSpeed * look;
//         newCameraRotation = Quaternion.Euler(xRotation, camera.transform.localRotation.eulerAngles.y, camera.transform.localRotation.eulerAngles.z);

//         //Move the rigidbody based on forward input
//         body.AddForce(transform.forward *  1000 * moveSpeed * forward);

//         //Move the rigidbody based on horizontal input
//         body.AddForce(transform.right * 1000 * moveSpeed * horizontal);

//         //Lerp the rotations
//         transform.rotation = Quaternion.Lerp(transform.rotation, newForwardRotation, lerpSpeed);
//         camera.transform.localRotation = Quaternion.Lerp(camera.transform.localRotation, newCameraRotation, lerpSpeed);

//     }

//     public void Move(InputAction.CallbackContext context)
//     {
//         horizontal = context.ReadValue<Vector2>().x;
//         forward = context.ReadValue<Vector2>().y;

//     }

//     public void Look(InputAction.CallbackContext context)
//     {
//         turn = context.ReadValue<Vector2>().x;
//         look = context.ReadValue<Vector2>().y;
//     }

// }
