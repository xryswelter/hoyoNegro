using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Code inspired + copied from Brackeys First Person Movement

public class playerMovement : MonoBehaviour
{
    public CharacterController controller;   
    public float movementSpeed = 12f;
    public AudioSource clickSound;
    

    private void Start()
    {
        controller = GetComponent<CharacterController>();
        clickSound = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        //Find variables for the 3-axis
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Float");
        float z = Input.GetAxis("Vertical");

        //Create Vector3 variable
        Vector3 move = transform.right * x + transform.up * y + transform.forward * z;
        //Debug.Log("x: " + x);
        //Debug.Log("z: " + z);
        //Debug.Log(move);

        controller.Move(move*movementSpeed*Time.deltaTime);
    }

    public void makeSound()
    {
        clickSound.Play();
    }
}
