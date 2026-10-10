using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.UI;
using UnityEngine.UI;
using Image = UnityEngine.UI.Image;

public class readtoggles : MonoBehaviour
{
    [SerializeField] private Iteminfo toggleinfo;
    [SerializeField] private Sprite checkmark;
    [SerializeField] private Sprite Default;
     private Image _image;

  
     public void Start()
     {
         _image = GetComponent<Image>();
         ShowToggle();
     }

     private void ShowToggle()
     {
         if (toggleinfo.Item)
         {
             _image.sprite = checkmark;
         }
         else if (!toggleinfo.Item)
         {
             _image.sprite = Default;
         }
     }

     public void toggle()
    {
        if (!toggleinfo.Item)
        {
             toggleinfo.Item = true;
             _image.sprite = checkmark;
        }
        else if(toggleinfo.Item)
        {
            toggleinfo.Item = false;
            _image.sprite = Default;
        }
    }
}
