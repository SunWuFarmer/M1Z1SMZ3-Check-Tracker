using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Item : MonoBehaviour
{
  [SerializeField] private Sprite item0;
  [SerializeField] private Sprite item1;
  [SerializeField] private Sprite item2;
  [SerializeField] private Sprite item3;
  [SerializeField] private Sprite item4;

  [SerializeField] private ItemLogic ItemTrigger1;
  [SerializeField] private ItemStatus _itemStatus;
  [SerializeField] private ItemLogic ItemTrigger2;
  [SerializeField] private ItemStatus _itemStatus2;
  private bool triggered;
  private bool triggered2;

  private Image displayeditem;
  private float itemshown = 0;

  public void Start()
  {
    displayeditem = GetComponent<Image>();
  }

  public void OnrightClick()
  {displayeditem = GetComponent<Image>();
    itemshown-=1;
    if (itemshown < -0.5f)
    {
      itemshown = 0;
    }

    DisplayImage();
  }
  public void OnLeftClick()
  {displayeditem = GetComponent<Image>();
    itemshown+=1;
    if (itemshown > 4)
    {
      itemshown = 3;
    }

    DisplayImage();
  }
  private void DisplayImage()
     {
       if (itemshown == 0)
       {
         displayeditem.sprite = item0;
       }

       if (itemshown == 1)
       {
         if (item1 != null)
         {
          
            displayeditem.sprite = item1;
            if (ItemTrigger1 != null )
            {
              if (!_itemStatus.Item)
              {
                _itemStatus.Item = true;
              }
              else
              {
                _itemStatus2.Item = false;
              }
              ItemTrigger1.TriggerEvent();
            }
         }
       }

       if (itemshown == 2)
       {
         if ((item2 != null))
         {
            displayeditem.sprite = item2;
            if (ItemTrigger2 != null)
            { 
              
              if (!_itemStatus2.Item)
              {
                
                  _itemStatus2.Item = true;
              }
              else
              {
                _itemStatus2.Item = false;
              }
            }
            ItemTrigger2.TriggerEvent(); 
         }
         else
         {
           itemshown--;
         }
       }
       if (itemshown == 3)
       {
         if (item3 != null)
         {
           displayeditem.sprite = item3;
         }
         else
         {
           itemshown--;
         }
       }
       if (itemshown == 4)
       {
         if (item4!= null)
         {
           displayeditem.sprite = item4;
         }
         else
         {
           itemshown--;
         }
       }
     }
}
