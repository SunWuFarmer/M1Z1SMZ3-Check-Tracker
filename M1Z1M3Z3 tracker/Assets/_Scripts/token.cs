using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class token : MonoBehaviour
{
    [SerializeField] private Sprite item1;
     [SerializeField] private Sprite item2;
     [SerializeField] private Sprite item3;
     [SerializeField] private Sprite item4;
     [SerializeField] private Sprite item5;
     [SerializeField] private Sprite item6;
     [SerializeField] private Sprite item7;
     [SerializeField] private Sprite item8;
     [SerializeField] private ItemCount pendent;
     [SerializeField] private ItemCount redcystals;
     [SerializeField] private ItemCount cystals;
     [SerializeField] private Iteminfo greenpendent;
     [SerializeField] private ItemLogic itemTrigger;
     private Image displayeditem;
     private bool light;
     private float itemshown = 1;
     private bool _pressed;
     private bool _pressed3;
     private bool _pressed2;
     private bool _pressed4;

     public void Start()
     {
       displayeditem = GetComponent<Image>();
     }
   
     public void OnrightClick()
     {
       itemTrigger.TriggerEvent();
       displayeditem = GetComponent<Image>();
       itemshown+=1;
       if (itemshown > 4)
       {
         itemshown = 1;
       }
   
       DisplayImage();
       itemTrigger.TriggerEvent();
     }
     public void OnLeftClick()
     {
       if (!light)
       {
         if (_pressed)
         {
           _pressed = false;
           cystals.itemcount--;
         }
        
         if (_pressed2)
         {
           _pressed2 = false;
           redcystals.itemcount--;
           cystals.itemcount--;
         }
        
         if (_pressed3)
         {
           _pressed3 = false;
           greenpendent.Item = false;
         }
        
         if (_pressed4)
         {
           _pressed4 = false;
           pendent.itemcount--;
         }

         if (itemshown == 1)
         {
           displayeditem.sprite = item5;
           light = true;
           cystals.itemcount++;
           _pressed = true;
         }

         if (itemshown == 2)
         {
           if ((item2 != null))
           {
             displayeditem.sprite = item6;
             light = true;
             redcystals.itemcount++;
             cystals.itemcount++;
             _pressed2 = true;
           }
         }

         if (itemshown == 3)
         {
           if (item3 != null)
           {
             displayeditem.sprite = item7;
             light = true;
             greenpendent.Item = true;
             _pressed3 = true;
           }
         }

         if (itemshown == 4)
         {
           if (item4 != null)
           {
             displayeditem.sprite = item8;
             light = true;
             pendent.itemcount++;
             _pressed4 = true;
           }
         }
       } 
      
       else
       {
         DisplayImage();
       }
       itemTrigger.TriggerEvent();
     }
     private void DisplayImage()
     {
      
       

       light = false;
          if (itemshown== 1)
          {
            displayeditem.sprite = item1;
            
          }

          if (itemshown== 2)
          {
            if ((item2 != null))
            {
               displayeditem.sprite = item2;
             
            }
          }
          if (itemshown ==3)
          {
            if (item3 != null)
            {
              displayeditem.sprite = item3;
            
            }
          }
          if (itemshown == 4)
          {
            if (item4!= null)
            {
              displayeditem.sprite = item4;
            }
          }
     }
}
