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
     private Image displayeditem;
     private float itemshown = 0;
   
     public void Start()
     {
       displayeditem = GetComponent<Image>();
     }
   
     public void OnrightClick()
     {
       displayeditem = GetComponent<Image>();
       itemshown+=1;
       if (itemshown > 4)
       {
         itemshown = 1;
       }
   
       DisplayImage();
     }
     public void OnLeftClick()
     {
       if (displayeditem.color == Color.white)
       {
         displayeditem.color = new Color(1, 1, 1, .10f);
       }
       else
       {
         displayeditem.color = Color.white;
       }
     }
     private void DisplayImage()
        {
          if (itemshown == 0)
          {
            displayeditem.color  = new Color(1,1,1,.10f);
          }
   
          if (itemshown== 1)
          {
            displayeditem.sprite = item1;
            
          }
          else if (itemshown == 5)
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
          

          
          {
            
          }
        }
}
