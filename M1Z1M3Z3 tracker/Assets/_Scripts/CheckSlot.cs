using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Mime;
using UnityEditor;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class CheckSlot : MonoBehaviour, IDropHandler
{  
   [SerializeField] private Sprite checkmark;
   [SerializeField] private Sprite Default;
   private Image _image;
   private Vector2 storedpostion;
   private Camera _cam;
   private bool checked1;
   
   
   public void OnDrop(PointerEventData eventData)
   {
      Debug.Log("OnDrop");
      if (eventData.pointerDrag != null)
      {
         eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition =
            GetComponent<RectTransform>().anchoredPosition;
      }
   }

   public void Start()
   {
      _image = GetComponent<Image>();
   }

   public void OnRightClick()
   {
      if (!checked1)
      {
         checked1 = true;
         _image.sprite = checkmark;
      }
      else
      {
         checked1 = false;
         _image.sprite = Default;
      }
      
   }
   public void OnBeginDrag(PointerEventData eventData)
   { Debug.Log("starting");
     // eventData.position += eventData.delta / Canvas.scaleFactor;
      storedpostion = eventData.position;
   }

   public void OnDrag(PointerEventData eventData)
   {
     
   }

   public void OnEndDrag(PointerEventData eventData)
   {
      Debug.Log("dorp");
      
   }
   public void OnPointerDown(PointerEventData eventData)
   {
     
      
   }
}
