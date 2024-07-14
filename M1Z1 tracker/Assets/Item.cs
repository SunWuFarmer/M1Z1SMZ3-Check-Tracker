using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Item : MonoBehaviour
{
  [SerializeField] private Sprite item1;
  [SerializeField] private Sprite item2;
  [SerializeField] private Sprite item3;
  [SerializeField] private Sprite item4;
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
         displayeditem.color  = new Color(1,1,1,.05f);
       }

       if (itemshown== 1)
       {
         displayeditem.sprite = item1;
         displayeditem.color = Color.white;
       }

       if (itemshown== 2)
       {
         if ((item2 != null))
         {
            displayeditem.sprite = item2;
         }
         else
         {
           itemshown--;
         }
       }
       if (itemshown ==3)
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
