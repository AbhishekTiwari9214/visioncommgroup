using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ordergatescript : MonoBehaviour
{
    public GameObject player;
   public int x,y,z;
   private void OnMouseDown()
{
Debug.Log("collision detecteded");
player.transform.position = new Vector3(x,y,z );


}



    // Update is called once per frame
    void Update()
    {
       } 
}
