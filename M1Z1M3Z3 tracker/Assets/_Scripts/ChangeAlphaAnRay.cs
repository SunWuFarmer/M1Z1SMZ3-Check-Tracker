using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ChangeAlphaAnRay : MonoBehaviour
{
   public CanvasGroup Sm;
   public CanvasGroup alttp;
   public CanvasGroup zebes;
   public CanvasGroup zelda;
   public CanvasGroup d1;
   public CanvasGroup d2;
   public CanvasGroup d3;
   public CanvasGroup d4;
   public CanvasGroup d5;
   public CanvasGroup d6;
   public CanvasGroup d7;
   public CanvasGroup d8;
   public CanvasGroup d9;
   public CanvasGroup Z1R;
   public CanvasGroup SmKeysCanvasGroup;
   public CanvasGroup Z3KeyscanCanvasGroup;

   public RectTransform SmTransform;
   public RectTransform AlttpTransform;
   public RectTransform ZebesTransform;
   public RectTransform ZeldaTransform;
   public RectTransform ZeldaErTransform;
   [SerializeField] private Sprite checkmark;
   private Image _button;
   private Vector2 ZeldaERstrat;
   private Vector2 smstart;
   private Vector2 alttpstart;
   private Vector2 m1start;
   private Vector2 z1start;
   [SerializeField] private Iteminfo Z1ER;
   [SerializeField] private Iteminfo Z3Keysinfo;
   [SerializeField] private Iteminfo SMKeysinfo;
   private bool Z3er = false;
   private bool SMKeys = false;
   private bool Z3Keys = false;
   private Sprite startingsprite;


   private void Start()
   {
      smstart = SmTransform.anchoredPosition;
      alttpstart = AlttpTransform.anchoredPosition;
      m1start = ZebesTransform.anchoredPosition;
      z1start = ZeldaTransform.anchoredPosition;
      ZeldaERstrat = ZeldaErTransform.anchoredPosition;
      _button = GetComponent<Button>().image;
      startingsprite = _button.sprite;
   }

   public void toggleSMKeys()
   {
      if (SMKeysinfo.Item == false)
      {
         SMKeysinfo.Item = true;
         _button.sprite = checkmark;
         SmKeysCanvasGroup.alpha = 1;
         SmKeysCanvasGroup.blocksRaycasts = true;
         all();
      }
      else
      {
         SMKeysinfo.Item = false;
         _button.sprite = startingsprite;
         SmKeysCanvasGroup.alpha = 0;
         SmKeysCanvasGroup.blocksRaycasts = false;
         all();
      }

   }
   public void toggleZ3Keys()
   {
      if (Z3Keysinfo.Item == false)
      {
         Z3Keysinfo.Item = true;
         _button.sprite = checkmark;
         Z3KeyscanCanvasGroup.alpha = 1;
         Z3KeyscanCanvasGroup.blocksRaycasts = true;
         all();
      }
      else
      { Z3Keysinfo.Item = false;
         _button.sprite = startingsprite;
         Z3KeyscanCanvasGroup.alpha = 0;
         Z3KeyscanCanvasGroup.blocksRaycasts =false;
         all();
      }
   }
   public void toggleZ1ER()
   {
      if (Z1ER.Item == false)
      {
         Z1ER.Item = true;
         _button.sprite = checkmark;
         all();
      }
      else
      {
         Z1ER.Item = false;
         _button.sprite = startingsprite;
         all();
      }
      
     
   }

   public void toggleZ3ER()
   {
      
   }
   public void all()

   {
      SmTransform.anchoredPosition = smstart;
      AlttpTransform.anchoredPosition = alttpstart;
       ZebesTransform.anchoredPosition = m1start;
        ZeldaTransform.anchoredPosition = z1start;
        ZeldaErTransform.anchoredPosition = ZeldaERstrat;
        if (SMKeysinfo.Item || Z3Keysinfo.Item)
        {
           AlttpTransform.localScale = new Vector3(0.382f, 0.45f, .56f);
           SmTransform.localScale = new Vector3(0.46f, 0.52f, 0.53f);
           ZebesTransform.localScale = new Vector3(.39f,.39f,.41f);
           ZeldaTransform.localScale = new Vector3(0.67f, 0.41f, 0.71f);
           ZeldaErTransform.localScale = new Vector3(0.66f, 0.353f, 0.71f);
        }
        else
        {
           SmTransform.localScale = new Vector3(0.46f, 0.52f, 0.53f);
           AlttpTransform.localScale = new Vector3(0.47f, 0.45f, .56f);
           ZebesTransform.localScale = new Vector3(.39f,.39f,.41f);
           ZeldaTransform.localScale = new Vector3(0.67f, 0.41f, 0.71f);
           ZeldaErTransform.localScale = new Vector3(0.66f, 0.353f, 0.71f);
        }
      
        
     
      Sm.alpha = 1;
      Sm.blocksRaycasts = true;
      alttp.alpha = 1;
      alttp.blocksRaycasts = true;
      zebes.alpha = 1;
      zebes.blocksRaycasts = true;
      
      if (Z1ER.Item)
      {
         Z1R.blocksRaycasts = true;
         Z1R.alpha = 1;
         zelda.alpha = 0;
         zelda.blocksRaycasts = false;
      }
      else
      {
         Z1R.blocksRaycasts = false;
         Z1R.alpha = 0;
         zelda.alpha = 1;
         zelda.blocksRaycasts = true;
      }
      
      
      
      
      d1.alpha = 0;
      d1.blocksRaycasts = false;
      d2.alpha = 0;
      d2.blocksRaycasts = false;
      d3.alpha = 0;
      d3.blocksRaycasts = false;
      d4.alpha = 0;
      d4.blocksRaycasts = false;
      d5.alpha = 0;
      d5.blocksRaycasts = false;
      d6.alpha = 0;
      d6.blocksRaycasts = false;
      d7.alpha = 0;
      d7.blocksRaycasts = false;
      d8.alpha = 0;
      d8.blocksRaycasts = false;
      d9.alpha = 0;
      d9.blocksRaycasts = false;
   }
   public void SM()
   {
      Z1R.blocksRaycasts = false;
      Z1R.alpha = 0;
      Sm.alpha = 1;
      Sm.blocksRaycasts = true;
      SmTransform.anchoredPosition = new Vector2(100, 250);
      SmTransform.localScale = new Vector3(0.8f, 0.8f);
      alttp.alpha = 0;
      alttp.blocksRaycasts = false;
      zebes.alpha = 0;
      zebes.blocksRaycasts = false;
      zelda.alpha = 0;
      zelda.blocksRaycasts = false;
      d1.alpha = 0;
      d1.blocksRaycasts = false;
      d2.alpha = 0;
      d2.blocksRaycasts = false;
      d3.alpha = 0;
      d3.blocksRaycasts = false;
      d4.alpha = 0;
      d4.blocksRaycasts = false;
      d5.alpha = 0;
      d5.blocksRaycasts = false;
      d6.alpha = 0;
      d6.blocksRaycasts = false;
      d7.alpha = 0;
      d7.blocksRaycasts = false;
      d8.alpha = 0;
      d8.blocksRaycasts = false;
      d9.alpha = 0;
      d9.blocksRaycasts = false;
   }

   public void Alttp()
   {
      Z1R.blocksRaycasts = false;
      Z1R.alpha = 0;
      Sm.alpha = 0;
      Sm.blocksRaycasts = false;
      AlttpTransform.anchoredPosition = new Vector2(500, 14);
      AlttpTransform.localScale = new Vector3(0.75f, 0.8f);
      alttp.alpha = 1;
      alttp.blocksRaycasts = true;
      zebes.alpha = 0;
      zebes.blocksRaycasts = false;
      zelda.alpha = 0;
      zelda.blocksRaycasts = false;
      d1.alpha = 0;
      d1.blocksRaycasts = false;
      d2.alpha = 0;
      d2.blocksRaycasts = false;
      d3.alpha = 0;
      d3.blocksRaycasts = false;
      d4.alpha = 0;
      d4.blocksRaycasts = false;
      d5.alpha = 0;
      d5.blocksRaycasts = false;
      d6.alpha = 0;
      d6.blocksRaycasts = false;
      d7.alpha = 0;
      d7.blocksRaycasts = false;
      d8.alpha = 0;
      d8.blocksRaycasts = false;
      d9.alpha = 0;
      d9.blocksRaycasts = false;
   }
   public void Zebes()
   {
      Z1R.blocksRaycasts = false;
      Z1R.alpha = 0;
      Sm.alpha = 0;
      Sm.blocksRaycasts = false;
      alttp.alpha = 0;
      alttp.blocksRaycasts = false;
      zebes.alpha = 1;
      zebes.blocksRaycasts = true;
      ZebesTransform.anchoredPosition = new Vector2(405, -192);
      ZebesTransform.localScale = new Vector3(0.8f, 0.8f);
      zelda.alpha = 0;
      zelda.blocksRaycasts = false;
      d1.alpha = 0;
      d1.blocksRaycasts = false;
      d2.alpha = 0;
      d2.blocksRaycasts = false;
      d3.alpha = 0;
      d3.blocksRaycasts = false;
      d4.alpha = 0;
      d4.blocksRaycasts = false;
      d5.alpha = 0;
      d5.blocksRaycasts = false;
      d6.alpha = 0;
      d6.blocksRaycasts = false;
      d7.alpha = 0;
      d7.blocksRaycasts = false;
      d8.alpha = 0;
      d8.blocksRaycasts = false;
      d9.alpha = 0;
      d9.blocksRaycasts = false;
   }
   public void Zelda()
   {
      if (Z1ER.Item)
      {
         Z1R.blocksRaycasts = true;
         Z1R.alpha = 1;
         ZeldaErTransform.anchoredPosition = new Vector2(140, 270);
         ZeldaErTransform.localScale = new Vector3(.95f, .8f);
         zelda.alpha = 0;
         zelda.blocksRaycasts = false;
      }
      else
      {
          Z1R.blocksRaycasts = false;
          Z1R.alpha = 0;
         zelda.alpha = 1;
         zelda.blocksRaycasts = true;
         ZeldaTransform.anchoredPosition = new Vector2(140, 250);
         ZeldaTransform.localScale = new Vector3(.95f, .9f);
      }
      Sm.alpha = 0;
      Sm.blocksRaycasts = false;
      alttp.alpha = 0;
      alttp.blocksRaycasts = false;
      zebes.alpha = 0;
      zebes.blocksRaycasts = false;
      d1.alpha = 0;
      d1.blocksRaycasts = false;
      d2.alpha = 0;
      d2.blocksRaycasts = false;
      d3.alpha = 0;
      d3.blocksRaycasts = false;
      d4.alpha = 0;
      d4.blocksRaycasts = false;
      d5.alpha = 0;
      d5.blocksRaycasts = false;
      d6.alpha = 0;
      d6.blocksRaycasts = false;
      d7.alpha = 0;
      d7.blocksRaycasts = false;
      d8.alpha = 0;
      d8.blocksRaycasts = false;
      d9.alpha = 0;
      d9.blocksRaycasts = false;
   }
   public void D1()
   {
      Z1R.blocksRaycasts = false;
      Z1R.alpha = 0;
      Sm.alpha = 0;
      Sm.blocksRaycasts = false;
      alttp.alpha = 0;
      alttp.blocksRaycasts = false;
      zebes.alpha = 0;
      zebes.blocksRaycasts = false;
      zelda.alpha = 0;
      zelda.blocksRaycasts = false;
      d1.alpha = 1;
      d1.blocksRaycasts = true;
      d2.alpha = 0;
      d2.blocksRaycasts = false;
      d3.alpha = 0;
      d3.blocksRaycasts = false;
      d4.alpha = 0;
      d4.blocksRaycasts = false;
      d5.alpha = 0;
      d5.blocksRaycasts = false;
      d6.alpha = 0;
      d6.blocksRaycasts = false;
      d7.alpha = 0;
      d7.blocksRaycasts = false;
      d8.alpha = 0;
      d8.blocksRaycasts = false;
      d9.alpha = 0;
      d9.blocksRaycasts = false;
   }
   public void D2()
   {  Z1R.blocksRaycasts = false;
      Z1R.alpha = 0;
      Sm.alpha = 0;
      Sm.blocksRaycasts = false;
      alttp.alpha = 0;
      alttp.blocksRaycasts = false;
      zebes.alpha = 0;
      zebes.blocksRaycasts = false;
      zelda.alpha = 0;
      zelda.blocksRaycasts = false;
      d1.alpha = 0;
      d1.blocksRaycasts = false;
      d2.alpha = 1;
      d2.blocksRaycasts = true;
      d3.alpha = 0;
      d3.blocksRaycasts = false;
      d4.alpha = 0;
      d4.blocksRaycasts = false;
      d5.alpha = 0;
      d5.blocksRaycasts = false;
      d6.alpha = 0;
      d6.blocksRaycasts = false;
      d7.alpha = 0;
      d7.blocksRaycasts = false;
      d8.alpha = 0;
      d8.blocksRaycasts = false;
      d9.alpha = 0;
      d9.blocksRaycasts = false;
   }
   public void D3()
   {
      Z1R.blocksRaycasts = false;
      Z1R.alpha = 0;
      Sm.alpha = 0;
      Sm.blocksRaycasts = false;
      alttp.alpha = 0;
      alttp.blocksRaycasts = false;
      zebes.alpha = 0;
      zebes.blocksRaycasts = false;
      zelda.alpha = 0;
      zelda.blocksRaycasts = false;
      d1.alpha = 0;
      d1.blocksRaycasts = false;
      d2.alpha = 0;
      d2.blocksRaycasts = false;
      d3.alpha = 1;
      d3.blocksRaycasts = true;
      d4.alpha = 0;
      d4.blocksRaycasts = false;
      d5.alpha = 0;
      d5.blocksRaycasts = false;
      d6.alpha = 0;
      d6.blocksRaycasts = false;
      d7.alpha = 0;
      d7.blocksRaycasts = false;
      d8.alpha = 0;
      d8.blocksRaycasts = false;
      d9.alpha = 0;
      d9.blocksRaycasts = false;
   }
   public void D4()
   {
      Z1R.blocksRaycasts = false;
      Z1R.alpha = 0;
      Sm.alpha = 0;
      Sm.blocksRaycasts = false;
      alttp.alpha = 0;
      alttp.blocksRaycasts = false;
      zebes.alpha = 0;
      zebes.blocksRaycasts = false;
      zelda.alpha = 0;
      zelda.blocksRaycasts = false;
      d1.alpha = 0;
      d1.blocksRaycasts = false;
      d2.alpha = 0;
      d2.blocksRaycasts = false;
      d3.alpha = 0;
      d3.blocksRaycasts = false;
      d4.alpha = 1;
      d4.blocksRaycasts = true;
      d5.alpha = 0;
      d5.blocksRaycasts = false;
      d6.alpha = 0;
      d6.blocksRaycasts = false;
      d7.alpha = 0;
      d7.blocksRaycasts = false;
      d8.alpha = 0;
      d8.blocksRaycasts = false;
      d9.alpha = 0;
      d9.blocksRaycasts = false;
   }
   public void D5()
   {
      Z1R.blocksRaycasts = false;
      Z1R.alpha = 0;
      Sm.alpha = 0;
      Sm.blocksRaycasts = false;
      alttp.alpha = 0;
      alttp.blocksRaycasts = false;
      zebes.alpha = 0;
      zebes.blocksRaycasts = false;
      zelda.alpha = 0;
      zelda.blocksRaycasts = false;
      d1.alpha = 0;
      d1.blocksRaycasts = false;
      d2.alpha = 0;
      d2.blocksRaycasts = false;
      d3.alpha = 0;
      d3.blocksRaycasts = false;
      d4.alpha = 0;
      d4.blocksRaycasts = false;
      d5.alpha = 1;
      d5.blocksRaycasts = true;
      d6.alpha = 0;
      d6.blocksRaycasts = false;
      d7.alpha = 0;
      d7.blocksRaycasts = false;
      d8.alpha = 0;
      d8.blocksRaycasts = false;
      d9.alpha = 0;
      d9.blocksRaycasts = false;
   }
   public void D6()
   {
      Z1R.blocksRaycasts = false;
      Z1R.alpha = 0;
      Sm.alpha = 0;
      Sm.blocksRaycasts = false;
      alttp.alpha = 0;
      alttp.blocksRaycasts = false;
      zebes.alpha = 0;
      zebes.blocksRaycasts = false;
      zelda.alpha = 0;
      zelda.blocksRaycasts = false;
      d1.alpha = 0;
      d1.blocksRaycasts = false;
      d2.alpha = 0;
      d2.blocksRaycasts = false;
      d3.alpha = 0;
      d3.blocksRaycasts = false;
      d4.alpha = 0;
      d4.blocksRaycasts = false;
      d5.alpha = 0;
      d5.blocksRaycasts = false;
      d6.alpha = 1;
      d6.blocksRaycasts = true;
      d7.alpha = 0;
      d7.blocksRaycasts = false;
      d8.alpha = 0;
      d8.blocksRaycasts = false;
      d9.alpha = 0;
      d9.blocksRaycasts = false;
   }
   public void D7()
   {
      Z1R.blocksRaycasts = false;
      Z1R.alpha = 0;
      Sm.alpha = 0;
      Sm.blocksRaycasts = false;
      alttp.alpha = 0;
      alttp.blocksRaycasts = false;
      zebes.alpha = 0;
      zebes.blocksRaycasts = false;
      zelda.alpha = 0;
      zelda.blocksRaycasts = false;
      d1.alpha = 0;
      d1.blocksRaycasts = false;
      d2.alpha = 0;
      d2.blocksRaycasts = false;
      d3.alpha = 0;
      d3.blocksRaycasts = false;
      d4.alpha = 0;
      d4.blocksRaycasts = false;
      d5.alpha = 0;
      d5.blocksRaycasts = false;
      d6.alpha = 0;
      d6.blocksRaycasts = false;
      d7.alpha = 1;
      d7.blocksRaycasts = true;
      d8.alpha = 0;
      d8.blocksRaycasts = false;
      d9.alpha = 0;
      d9.blocksRaycasts = false;
   }
   public void D8()
   {
      Z1R.blocksRaycasts = false;
      Z1R.alpha = 0;
      Sm.alpha = 0;
      Sm.blocksRaycasts = false;
      alttp.alpha = 0;
      alttp.blocksRaycasts = false;
      zebes.alpha = 0;
      zebes.blocksRaycasts = false;
      zelda.alpha = 0;
      zelda.blocksRaycasts = false;
      d1.alpha = 0;
      d1.blocksRaycasts = false;
      d2.alpha = 0;
      d2.blocksRaycasts = false;
      d3.alpha = 0;
      d3.blocksRaycasts = false;
      d4.alpha = 0;
      d4.blocksRaycasts = false;
      d5.alpha = 0;
      d5.blocksRaycasts = false;
      d6.alpha = 0;
      d6.blocksRaycasts = false;
      d7.alpha = 0;
      d7.blocksRaycasts = false;
      d8.alpha = 1;
      d8.blocksRaycasts = true;
      d9.alpha = 0;
      d9.blocksRaycasts = false;
   }
   public void D9()
   {
      Z1R.blocksRaycasts = false;
      Z1R.alpha = 0;
      Sm.alpha = 0;
      Sm.blocksRaycasts = false;
      alttp.alpha = 0;
      alttp.blocksRaycasts = false;
      zebes.alpha = 0;
      zebes.blocksRaycasts = false;
      zelda.alpha = 0;
      zelda.blocksRaycasts = false;
      d1.alpha = 0;
      d1.blocksRaycasts = false;
      d2.alpha = 0;
      d2.blocksRaycasts = false;
      d3.alpha = 0;
      d3.blocksRaycasts = false;
      d4.alpha = 0;
      d4.blocksRaycasts = false;
      d5.alpha = 0;
      d5.blocksRaycasts = false;
      d6.alpha = 0;
      d6.blocksRaycasts = false;
      d7.alpha = 0;
      d7.blocksRaycasts = false;
      d8.alpha = 0;
      d8.blocksRaycasts = false;
      d9.alpha = 1;
      d9.blocksRaycasts = true;
   }
   public void Z1Rando()
   {
      Z1R.blocksRaycasts = true;
      Z1R.alpha = 1;
      Sm.alpha = 0;
      Sm.blocksRaycasts = false;
      alttp.alpha = 0;
      alttp.blocksRaycasts = false;
      zebes.alpha = 0;
      zebes.blocksRaycasts = false;
      zelda.alpha = 0;
      zelda.blocksRaycasts = false;
      d1.alpha = 0;
      d1.blocksRaycasts = false;
      d2.alpha = 0;
      d2.blocksRaycasts = false;
      d3.alpha = 0;
      d3.blocksRaycasts = false;
      d4.alpha = 0;
      d4.blocksRaycasts = false;
      d5.alpha = 0;
      d5.blocksRaycasts = false;
      d6.alpha = 0;
      d6.blocksRaycasts = false;
      d7.alpha = 0;
      d7.blocksRaycasts = false;
      d8.alpha = 0;
      d8.blocksRaycasts = false;
      d9.alpha = 0;
      d9.blocksRaycasts = false;
   }
}
