using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class InventoryManager : MonoBehaviour
{
   public static InventoryManager Instance;
public List<Item> Items =new List<Item>();
//public List<string> myList = new List<string>();
public Transform ItemContent;
public GameObject InventoryItem;
public TMP_Text Total;
public Toggle EnableRemove;

// public TMP_Text Price;

 float sumtotal=0;

public InventoryItemController[] InventoryItems;

private void Awake()
  {
    Instance=this;
  }

public void Add(Item item)
  {
    Items.Add(item);
  }

public void Remove(Item item)
  { 
  //sumtotal-= item.price;
 // Total.text=$"{sumtotal}";
    Items.Remove(item);
  } 
public void ListItems()
   {
   
//clean existed items
     foreach (Transform item in ItemContent)
	{
    
           Destroy (item.gameObject);
	}
  
 sumtotal=0;
     foreach(var item in Items)
	{
	GameObject obj=Instantiate(InventoryItem, ItemContent);
 var itemName = obj.transform.Find("ItemName").GetComponentInChildren<TMP_Text>();
	var itemIcon = obj.transform.Find("ItemIcon").GetComponent<Image>();
   var itemPrice = obj.transform.Find("price").GetComponentInChildren<TMP_Text>();
var removeButton = obj.transform.Find("deleteitem").GetComponent<Button>();
itemName.text=item.itemName;
itemIcon.sprite=item.icon; 
 sumtotal+= item.price;
itemPrice.text= $"{item.price}";
Total.text=$"{sumtotal}";
  
if (EnableRemove.isOn)
{
 removeButton.gameObject.SetActive(true);
}
	}
SetInventoryItems();
if(Items.Count==0){
  sumtotal=0;
  Total.text=$"{sumtotal}";
}
   }

public void EnableItemsRemove()
 {
 if (EnableRemove.isOn)
	{
		foreach(Transform item in ItemContent)
 	  {
 		item.Find("deleteitem").gameObject.SetActive(true);
 	  }
  }
 else
	{
	 	foreach(Transform item in ItemContent)
	 {
	 	item.Find("deleteitem").gameObject.SetActive(false);
   }
	}
  }




  public void SetInventoryItems()
{
InventoryItems = ItemContent.GetComponentsInChildren<InventoryItemController>();
for(int i=0;i < Items.Count;i++)
{
InventoryItems[i].AddItem(Items[i]);
}

}

   }