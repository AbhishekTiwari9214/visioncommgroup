using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class InventoryManager : MonoBehaviour
{
   public static InventoryManager Instance;
public List<Item> Items =new List<Item>();
public Transform ItemContent;
public GameObject InventoryItem;
public TMP_Text Total;

// public TMP_Text Price;


// Debug.Log(sumtotal);
// public Toggle EnableRemove;
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
    Items.Remove(item);
  }
  

  
public void ListItems()
   {
   
//clean existed items
     foreach (Transform item in ItemContent)
	{
    
           Destroy (item.gameObject);
	}
  // foreach(var item in Items){
  //   sumtotal+=item.price;
  // }
  var sumtotal=0.0;
     foreach(var item in Items)
	{
  
    //  sumtotal+= item.price;
	GameObject obj=Instantiate(InventoryItem, ItemContent);
  //  Debug.Log(sumtotal);
 var itemName = obj.transform.Find("ItemName").GetComponentInChildren<TMP_Text>();
	var itemIcon = obj.transform.Find("ItemIcon").GetComponent<Image>();
   var itemPrice = obj.transform.Find("price").GetComponentInChildren<TMP_Text>();
// var removeButton=obj.transform.Find("RemoveButton").gameObject;
itemName.text=item.itemName;
itemIcon.sprite=item.icon; 
 sumtotal+= item.price;
// Debug.Log(sumtotal);

itemPrice.text= $"{item.price}";
Total.text=$"{sumtotal}";
// if(EnableRemove.isOn)
// removeButton.gameObject.SetActive(true);
// }
// 	}
void Update(){

SetInventoryItems();

}
// 	}
// public void EnableItemsRemove()
// {
//  if (EnableRemove.isOn)
// 	{
// 		foreach(Transform item in ItemContent)
// 	{
// 		item.Find("RemoveButton").gameObject.setActive(true);
// 	}
// 	}
// else
// 	{
	// 	foreach(Transform item in ItemContent)
	// {
	// 	item.Find("RemoveButton").gameObject.setActive(true);
	// }
// 	}
	}
   }




 void SetInventoryItems()
{


InventoryItems=ItemContent.GetComponentsInChildren<InventoryItemController>();
for(int i=0;i<Items.Count;i++)
{
InventoryItems[i].AddItem(Items[i]);
}

}

   }