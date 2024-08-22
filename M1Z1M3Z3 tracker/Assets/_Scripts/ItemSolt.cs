using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

public class ItemSolt : MonoBehaviour
{
  [SerializeField] private Sprite item0;
  [SerializeField] private Sprite item1;
  [SerializeField] private Sprite item2;
  [SerializeField] private Sprite item3;
  [SerializeField] private Sprite item4;
  [FormerlySerializedAs("ItemTrigger")] [SerializeField] private ItemLogic itemTrigger;
  [FormerlySerializedAs("_itemStatus")] [SerializeField] private Iteminfo iteminfo;
  [FormerlySerializedAs("_itemStatus2")] [SerializeField] private Iteminfo itemStatus2;
  private bool _triggered;
  private bool _triggered2;

  private Image _displayeditem;
  private float _itemshown = 0;

  public void Start()
  {
    _displayeditem = GetComponent<Image>();
  }

  public void OnrightClick()
  {_displayeditem = GetComponent<Image>();
    _itemshown-=1;
    if (_itemshown < -0.5f)
    {
      _itemshown = 0;
    }

    DisplayImage();
  }
  public void OnLeftClick()
  {_displayeditem = GetComponent<Image>();
    _itemshown+=1;
    if (_itemshown > 4)
    {
      _itemshown = 3;
    }

    DisplayImage();
  }
  private void DisplayImage()
     {
       if (_itemshown == 0)
       {
         _displayeditem.sprite = item0;
         if (iteminfo.Item)
         {
           iteminfo.Item = false;
         }

         if (itemTrigger != null)
         {
            itemTrigger.TriggerEvent();
         }
        
       }

       if (_itemshown == 1)
       {
         if (item1 != null)
         {
          
            _displayeditem.sprite = item1;
            if (itemTrigger != null )
            {
              if (!iteminfo.Item)
              {
               
                if (itemStatus2 != null)
                {
                  itemStatus2.Item = false;
                } iteminfo.Item = true;
              }
              itemTrigger.TriggerEvent();
            }
         }
       }

       if (_itemshown == 2)
       {
         if ((item2 != null))
         {
            _displayeditem.sprite = item2;
            if (itemTrigger != null)
            { 
              if (!itemStatus2.Item)
              {
                  itemStatus2.Item = true;
              }
             
            }
            itemTrigger.TriggerEvent(); 
         }
         else
         {
           _itemshown--;
         }
       }
       if (_itemshown == 3)
       {
         if (item3 != null)
         {
           _displayeditem.sprite = item3;
         }
         else
         {
           _itemshown--;
         }
       }
       if (_itemshown == 4)
       {
         if (item4!= null)
         {
           _displayeditem.sprite = item4;
         }
         else
         {
           _itemshown--;
         }
       }
     }
}
