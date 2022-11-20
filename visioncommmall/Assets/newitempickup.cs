using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class newitempickup : MonoBehaviour
{
    float clicked = 0;
    float clicktime = 0;
    float clickdelay = 0.5f;
public Item Item;
void Pickup()
{
InventoryManager.Instance.Add(Item);
Destroy(gameObject);
}



//     bool DoubleClick()
//     {
//         if (Input.GetMouseButtonDown(0))
//         {
//             clicked++;
//             if (clicked == 1) clicktime = Time.time;
//         }
//         if (clicked > 1 && Time.time - clicktime < clickdelay)
//         {
//             clicked = 0;
//             clicktime = 0;
//             return true;
//         }
//         else if (clicked > 2 || Time.time - clicktime > 1) clicked = 0;
//         return false;
//     }

//  private void Update()
//     {
       
//         if (DoubleClick())
//         {
//             Pickup();
 
//         }
//     }


private void OnMouseDown()
{
Pickup();
}
}
