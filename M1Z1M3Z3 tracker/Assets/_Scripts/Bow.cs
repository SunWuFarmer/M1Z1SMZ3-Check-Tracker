using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bow : MonoBehaviour
{
   [SerializeField] private Sprite item0;
     [SerializeField] private Sprite item1;
     [SerializeField] private Sprite item2;
     [SerializeField] private Image displayeditem2;
     [SerializeField] private ItemLogic itemTrigger;
     [SerializeField] private Iteminfo iteminfo1;
     
     private Image displayeditem;
     private float itemshown = 0;
     private float itemshown2 =0 ;

     public void Start()
     {
       displayeditem = GetComponent<Image>();
     }
   
     public void OnrightClick()
     {displayeditem = GetComponent<Image>();
       itemshown+=1;
       if (itemshown > 1.5f)
       {
         itemshown = 0;
       }
   
       DisplayImage();
     }
     public void OnLeftClick()
     {displayeditem = GetComponent<Image>();
       itemshown2+=1;
       if (itemshown2 > 1.5f)
       {
         itemshown2 = 0;
       }
   
       DisplayImage2();
     }

     private void DisplayImage()
     {
       if (itemshown == 0)
       {
         displayeditem.sprite = item0;
         iteminfo1.Item = false;
         itemTrigger.TriggerEvent();
       }
       if (itemshown == 1)
       {
         displayeditem.sprite = item1;
         iteminfo1.Item = true;
         itemTrigger.TriggerEvent();
       }
     }
     private void DisplayImage2()
     {
       if (itemshown2 == 0)
       {
         displayeditem2.color = Color.clear;
        
       }

       if (itemshown2 == 1)
       {
         displayeditem2.color = Color.white;
         
       }
     }
}
