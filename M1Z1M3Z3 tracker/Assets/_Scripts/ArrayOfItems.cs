using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(menuName = "Array")]
public class ArrayOfItems : ScriptableObject
{
   public Iteminfo[] ItemStatusArray;
   public ItemCount pendent;
   public ItemCount redcrystals;
   public ItemCount crystals;
   public ItemCount requiredz3;
   private int currentNumber;

   public void ClearItems()
   {
      foreach (var item in ItemStatusArray)
      {
         item.Item = false;
      }

      crystals.itemcount = 0;
      redcrystals.itemcount = 0;
      pendent.itemcount = 0;
   }

   public bool IsItemAvailable(string itemname)
   {
      foreach (var item in ItemStatusArray)
      {
         if (item.name == itemname)
         {
            return item.Item;
         }
      }

      return false;
   }
   public bool IsItemsAvailable(string[] itemnames)
   {
      currentNumber = 0;
      int numberofItems = itemnames.Length;
      foreach (var itemstring in itemnames)
      {
          foreach (var item in ItemStatusArray)
          {
             if (item.name == itemstring)
             {
                currentNumber =+ 1;
             }
             if (currentNumber == numberofItems)
             {
                return item.Item;
             }
          }
          
      }
      return false;
   }
   public bool IsAnyAvailable(string[] itemnames)
   {
      int numberofItems = itemnames.Length;
      foreach (var itemstring in itemnames)
      {
         foreach (var item in ItemStatusArray)
         {
            if (item.name == itemstring)
            {
               if (item.Item)
               {
                  return true;
               }
            }
         }
      }
      return false;
   }
}
