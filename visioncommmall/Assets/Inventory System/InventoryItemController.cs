using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryItemController : MonoBehaviour
{
  
Item item;
	public Button deleteitem;
public void RemoveItem()
{
InventoryManager.Instance.Remove(item);
Destroy(gameObject);
} 
public void AddItem(Item newItem)
{
item = newItem;
}
/* public  void useitem()
 {
	value=
total.Instance.PriceItem(Instance.item.price);
 }*/
}
 
