using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class coinScript : MonoBehaviour
{
    public GameObject player;
    //headMovement cameraControl;

    public bool playerIsInTriggerArea;

    public bool isPickedUp;

    //public float floatOffset;

    //public float forwardOffset;
    ObjectInformation animalName;
    public string animalType;

    private void Start()
    {
        animalName = GameObject.FindGameObjectWithTag("GameController").GetComponent<ObjectInformation>();
        //cameraControl = Camera.main.GetComponent<headMovement>();
    }

    private void Update()
    {

        //
        if (isPickedUp == false && playerIsInTriggerArea )
        {
            if (Input.GetMouseButtonDown(1))
            {
                player.GetComponent<playerMovement>().makeSound();
                Debug.Log(gameObject.name);
                switch (animalType)
                {
                    case "bear":
                        {
                            animalName.bearCount += 1;
                            animalName.bearText.text = animalName.bearCount + "/4";
                            Debug.Log("Bear " + animalName.bearCount);
                            if(animalName.bearCount >= 4)
                            {
                                animalName.bearText.transform.parent.GetComponent<Button>().interactable = true; 
                            }
                            gameObject.SetActive(false);
                        }
                        break;
                    case "elephant":
                        {
                            animalName.elephantCount += 1;
                            animalName.elephantText.text = animalName.elephantCount + "/6";
                            Debug.Log("Elephant " + animalName.bearCount);
                            if (animalName.elephantCount >= 6)
                            {
                                animalName.elephantText.transform.parent.GetComponent<Button>().interactable = true;
                            }
                            gameObject.SetActive(false);
                        }
                        break;
                    case "naia":
                        {
                            animalName.naiaCount += 1;
                            animalName.naiaText.text = animalName.naiaCount + "/2";
                            Debug.Log("Naia " + animalName.naiaCount);
                            if (animalName.naiaCount >= 2)
                            {
                                animalName.naiaText.transform.parent.GetComponent<Button>().interactable = true; 
                            }
                            gameObject.SetActive(false);
                        }
                        break;
                    case "tiger":
                        {
                            animalName.sabertoothCount += 1;
                            animalName.sabertoothText.text = animalName.sabertoothCount + "/2";
                            Debug.Log(animalName.sabertoothCount);
                            if (animalName.sabertoothCount >= 2)
                            {
                                animalName.sabertoothText.transform.parent.GetComponent<Button>().interactable = true; 
                            }
                            gameObject.SetActive(false);
                        }
                        break;
                    case "sloth":
                        {
                            animalName.slothCount += 1;
                            animalName.slothText.text = animalName.slothCount + "/3";
                            Debug.Log(animalName.slothCount);
                            if (animalName.slothCount >= 3)
                            {
                                animalName.slothText.transform.parent.GetComponent<Button>().interactable = true; 
                            }
                            gameObject.SetActive(false);
                        }
                        break;
                    case "wolf":
                        {
                            animalName.wolfCount += 1;
                            animalName.wolfText.text = animalName.wolfCount + "/1";
                            Debug.Log(animalName.wolfCount);
                            if (animalName.wolfCount >= 1)
                            {
                                animalName.wolfText.transform.parent.GetComponent<Button>().interactable = true; 
                            }
                            gameObject.SetActive(false);
                        }
                        break;
                       
                    default:
                        break;
                }
            }

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





