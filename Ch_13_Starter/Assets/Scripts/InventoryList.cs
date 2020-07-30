using System.Collections;
 using System.Collections.Generic;
 using UnityEngine;
 
 public class InventoryList<T> where T: class
 {
     private T _item;
     public T item 
     {
         get { return _item; }
         set { _item = value; }
     }

     public InventoryList()
     {
         Debug.Log("Generic list initalized...");
     }

     public void SetItem(T newItem)
     {
         // 3
         _item = newItem;
         Debug.Log("New item added...");
     }
 }
