using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Meds : MonoBehaviour
{
  
  
     private Image displayeditem;
     private float itemshown = 0;
     private float textnumber = 0;
    [SerializeField] private TextMeshProUGUI text;
    [SerializeField] private Sprite item0;
    [SerializeField] private Sprite item1;

    [SerializeField] private Iteminfo TRaccess;
    [SerializeField] private Iteminfo MMaccess;
    [SerializeField] private Iteminfo bombos;
    
    public void Start()
     {
       displayeditem = GetComponent<Image>();
     }
   
     public void OnrightClick()
     {displayeditem = GetComponent<Image>();
      
       
       textnumber+=1;
       if (textnumber > 3.5f)
       {
         textnumber = 0;
       }
   
       DisplayText();
     }

     private void DisplayText()
     {
       if (textnumber == 0)
       {
         text.text = "";
       }
   
       if (textnumber == 1)
       {
         text.text = "MM";
         if (itemshown == 1)
         {
           MMaccess.Item = true;
         }
         else
         {
           MMaccess.Item = false;
         }
       }
       if (textnumber == 2)
       {
         text.text = "TR";
         if (itemshown == 1)
         {
           TRaccess.Item = true;
         }
         else
         {
           TRaccess.Item = false;
         }
       }
       if (textnumber == 3)
       {
         text.text = "Both";
         if (itemshown == 1)
         {
           MMaccess.Item = true;
           TRaccess.Item = true;
         }
         else
         {
           MMaccess.Item = false;
           TRaccess.Item = false;
         }
       }

     }

     public void OnLeftClick()
     {displayeditem = GetComponent<Image>();
       itemshown+=1;
       if (itemshown > 1.5f)
       {
         itemshown = 0;
       }
      
       DisplayImage();
       DisplayText();
     }
     private void DisplayImage()
        {
          if (itemshown == 0)
          {
            displayeditem.sprite = item0;
            bombos.Item = false;
          }
   
          if (itemshown== 1)
          {
            displayeditem.sprite = item1;
            bombos.Item = true;
          }
        }
}
