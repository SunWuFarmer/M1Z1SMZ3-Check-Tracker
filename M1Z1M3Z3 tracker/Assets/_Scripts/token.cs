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
     private Image displayeditem;
     private bool light;
     private float itemshown = 1;
   
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
       if (!light)
       {


         if (itemshown == 1)
         {
           displayeditem.sprite = item5;
           light = true;
         }

         if (itemshown == 2)
         {
           if ((item2 != null))
           {
             displayeditem.sprite = item6;
             light = true;
           }
         }

         if (itemshown == 3)
         {
           if (item3 != null)
           {
             displayeditem.sprite = item7;
             light = true;
           }
         }

         if (itemshown == 4)
         {
           if (item4 != null)
           {
             displayeditem.sprite = item8;
             light = true;
           }
         }
       }
       else
       {
         DisplayImage();
       }
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
          

          
          {
            
          }
        }
}
