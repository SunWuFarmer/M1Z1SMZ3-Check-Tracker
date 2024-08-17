using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class MEDs : MonoBehaviour
{
  
  
     private Image displayeditem;
     private float itemshown = 0;
     private float textnumber = 0;
    [SerializeField] private TextMeshProUGUI text;
    [SerializeField] private Sprite item0;
    [SerializeField] private Sprite item1;
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
       }
       if (textnumber == 2)
       {
         text.text = "TR";
       }
   
       if (textnumber == 3)
       {
         text.text = "Both";
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
     }
     private void DisplayImage()
        {
          if (itemshown == 0)
          {
            displayeditem.sprite = item0;
          }
   
          if (itemshown== 1)
          {
            displayeditem.sprite = item1;
          }
   
        
        }
}
