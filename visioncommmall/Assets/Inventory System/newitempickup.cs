using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class newitempickup : MonoBehaviour
{
public Item Item;
void Pickup()
{
InventoryManager.Instance.Add(Item);
Destroy(gameObject);
}


private void OnMouseDown()
{
Pickup();
}
}
