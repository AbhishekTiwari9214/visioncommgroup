using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disable : MonoBehaviour
{

    public GameObject Cart;
    // Start is called before the first frame update
    void Start()
    {
	Cart.SetActive(false);        
    }

    // Update is called once per frame
    void Update()
    {
   
    }
}
