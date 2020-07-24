using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ObjectInformation : MonoBehaviour
{
    public TMP_Text scientificName;
    public TMP_Text commonName;
    public TMP_Text information;
    public TMP_Text age;
    public TMP_Text size;
    public TMP_Text weight;
    public TMP_Text funFact;
    private string[] informationVariables;

    //String Array of Animal Information
    string[] saberToothInformation = { "Saber Tooth", "Feline", "It is a SBTT", "20000", "20x20x50", "45", "It is a cat" };
    
    // Start is called before the first frame update
    void Start()
    {
        informationVariables = new string[7];
        callInformation();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Set variable names
    public void callInformation()
    {
        informationVariables[0] = commonName.text;
        informationVariables[1] = scientificName.text;
        informationVariables[2] = information.text;
        informationVariables[3] = age.text;
        informationVariables[4] = size.text;
        informationVariables[5] = weight.text;
        informationVariables[6] = funFact.text;
    }

    public void displayInformation(string name)
    {
        switch (name)
        {
            case "Saber Tooth":
                for(int i = 0; i<informationVariables.Length; i++)
                {
                    informationVariables[i] = saberToothInformation[i];
                }
                break;
            default:
                break;
        }
    }
}
