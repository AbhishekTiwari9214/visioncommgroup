Using System.Collection;
Using System.Collection.Generic;
Using UnityEngine;
public class InventoryItemController :MonoBehaviour
{
Item item;
	public Button RemoveButton;
	public void RemoveItem()
{
InventoryManager.Instance.Remove(item);
Destory(gameObject);
} 
public void AddItem(Item newItem)
{
item = newItem;
}
}