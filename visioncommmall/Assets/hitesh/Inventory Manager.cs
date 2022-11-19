Using System.Collection;
Using System.Collection.Generic;
Using UnityEngine;
public class InventoryManager :MonoBehaviour
{
public static InventoryManager Instance;
public List<Item> Items =new List<Items>();
public Transform ItemContent;
public GameObject InventoryItem;
public Toggle EnableRemove;
public InventoryItemController[] InventoryItems;
private void Awake()
  {
    Instance=this;
  }
public void Add(Item item)
  {
    Item.Add(item);
  }
public void Remove(Item item)
  {
    Item.Remove(item);
  }
public void ListItems()
   {
//clean existed items
     foreach (Transform item in ItemContent)
	{
           Destroy (item.gameObject);
	}
     foreach(var item in Items)
	{
	GameObject obj=Instantiate(Inventory Item,ItemContent);
 	var itemName = obj.transform.Find("Item/ItemName").GetComponent<Text>();
	var itemIcon = obj.transform.Find("Item/ItemIcon").GetComponent<Image>();
var removeButton=obj.trandform.Find("RemoveButton").gameObject;
itemName.text=item.itemName;
itemIcon.sprite=item.icon;
if(EnableRemove.isOn)
removeButton.gameObject.SetActive(true);
}
	}
SetInventoryItems();
	}
public void EnableItemsRemove()
{
 if (EnableRemove.isOn)
	{
		foreach(Transform item in ItemContent)
	{
		item.Find("RemoveButton").gameObject.setActive(true);
	}
	}
else
	{
		foreach(Transform item in ItemContent)
	{
		item.Find("RemoveButton").gameObject.setActive(true);
	}
	}
	}
public void SetInventoryItems()
{
InventoryItems=ItemContent.GetcomponentsInChildren<InventoryItemController>();
for(int i=0;i<Items.Count;i++)
{
InventoryItem[i].AddItem(Items[i]);
}
}
}