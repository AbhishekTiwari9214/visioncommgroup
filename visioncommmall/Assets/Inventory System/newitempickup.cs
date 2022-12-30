using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class newitempickup : MonoBehaviour
{
    float clicked = 0;
    float clicktime = 0;
    float clickdelay = 0.5f;
public Item item;
void Pickup()
{
InventoryManager.Instance.Add(item);
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
//             Vector2 mousePos = new Vector2(Screen.width - Input.mousePosition.x, Screen.height - Input.mousePosition.y);
//             if (this.GetComponent<RectTransform>().rect.Contains(mousePos)) {
//                 Pickup();
//             }
 
//     }
//     }

private void OnMouseDown()
{
Pickup();
}
}
