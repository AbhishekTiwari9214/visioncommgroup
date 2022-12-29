using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class defaultrender : MonoBehaviour
{
public GameObject activegame;
public void Activate()
{
    if(activegame.activeSelf!=true){
 activegame.SetActive(true);
    }
    else{
        activegame.SetActive(false);
    }
   
}


}
