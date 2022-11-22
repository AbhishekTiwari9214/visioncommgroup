using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyPickUpScript : MonoBehaviour
{
    public GameObject keyOB;
    public GameObject invOB;
    public GameObject pickUpText;

    public bool inReach;


    void Start()
    {
        inReach = false;
        pickUpText.SetActive(false);
        invOB.SetActive(false);
    }


    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Reach")
        {
            inReach = true;
            pickUpText.SetActive(true);

        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Reach")
        {
            inReach = false;
            pickUpText.SetActive(false);

        }
    }


    void Update()
    {
        if (inReach && Input.GetButtonDown("Get"))
        {
            keyOB.SetActive(false);
            invOB.SetActive(true);
            pickUpText.SetActive(false);
        }


    }
}
