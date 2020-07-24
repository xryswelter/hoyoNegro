using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinScript : MonoBehaviour
{
    public GameObject player;

    public bool playerIsInTriggerArea;

    public bool isPickedUp;

    public float floatOffset;

    public float forwardOffset;

    private void Update()
    {
        if (isPickedUp && player != null)
        {
            transform.position = player.transform.position + new Vector3(0, floatOffset) + (player.transform.forward * forwardOffset);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            playerIsInTriggerArea = true;
            player = other.gameObject;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            playerIsInTriggerArea = false;
            player = null;
        }
    }



}

