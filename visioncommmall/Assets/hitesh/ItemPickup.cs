Using System.Collection;
Using System.Collection.Generic;
Using UnityEngine;
public class ItemPickup:MonoBehaviour
{
public item Item;
void Pickup()
{
InventoryManager.Instance.Add(item);
Destroy(gameObject);
}
private void OnMouseDown()
{
pickup();
}
}