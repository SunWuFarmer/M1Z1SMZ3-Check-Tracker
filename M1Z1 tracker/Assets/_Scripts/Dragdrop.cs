using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Dragdrop : MonoBehaviour, IPointerDownHandler,IBeginDragHandler,IEndDragHandler,IDragHandler
{
   [SerializeField] private Canvas Canvas;

   private CanvasGroup canvasGroup;
   private RectTransform _rectTransform;

   private void Awake()
   {
      _rectTransform = GetComponent<RectTransform>();
      canvasGroup = GetComponent<CanvasGroup>();

   }

   public void OnBeginDrag(PointerEventData eventData)
   {
      Debug.Log("onbeighnDrag");
      canvasGroup.alpha = .5f;
      canvasGroup.blocksRaycasts = false;
   }

   public void OnDrag(PointerEventData eventData)
   {
      Debug.Log("Ondrag");
      _rectTransform.anchoredPosition += new Vector2(eventData.delta.x *.95f,eventData.delta.y*1.25f)/Canvas.scaleFactor;
   }

   public void OnEndDrag(PointerEventData eventData)
   {
      Debug.Log("OnEndDrag");
      canvasGroup.alpha = 1;
      canvasGroup.blocksRaycasts = true;
      
   }
   public void OnPointerDown(PointerEventData eventData)
   {
      Debug.Log("OnPointerdown");
      
   }
}
