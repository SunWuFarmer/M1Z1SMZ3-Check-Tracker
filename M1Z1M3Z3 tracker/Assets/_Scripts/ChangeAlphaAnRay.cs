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
   public CanvasGroup z3R;
   public CanvasGroup SmKeysCanvasGroup;
   public CanvasGroup Z3KeyscanCanvasGroup;
   public CanvasGroup startscreen;
   public CanvasGroup smitems;
   public CanvasGroup z3items;
   public CanvasGroup z1items;
   public CanvasGroup m1items;

   public RectTransform SmTransform;
   public RectTransform AlttpTransform;
   public RectTransform ZebesTransform;
   public RectTransform ZeldaTransform;
   public RectTransform ZeldaErTransform;
   public RectTransform Zelda3ErTransform;
   [SerializeField] private Sprite checkmark;
   private Image _button;
   private Vector2 ZeldaERstrat;
   private Vector2 Zelda3ERstrat;
   private Vector2 smstart;
   private Vector2 alttpstart;
   private Vector2 m1start;
   private Vector2 z1start;
   [SerializeField] private Iteminfo Z1ER;
   [SerializeField] private Iteminfo Z3Keysinfo;
   [SerializeField] private Iteminfo SMKeysinfo;
   [SerializeField] private Iteminfo Z3ER;
   [SerializeField] private Iteminfo z1;
   [SerializeField] private Iteminfo z3;
   [SerializeField] private Iteminfo m1;
   [SerializeField] private Iteminfo m3;
   [SerializeField] private Iteminfo maprando;
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
      Zelda3ERstrat = Zelda3ErTransform.anchoredPosition;
      _button = GetComponent<Button>().image;
      startingsprite = _button.sprite;
   }

   public void Starttracker()
   { Debug.Log("started");
      startscreen.alpha = 0;
      startscreen.blocksRaycasts = false;
      startscreen.interactable = false;
      if (z1.Item && z3.Item && m1.Item && m3.Item)
      {
         Debug.Log("started2");

         if (maprando.Item)
         {
            FullQuad();
            
            Debug.Log("started3");
         }
         else
         {
            RunFunQuadgame(); 
           
         }
      }
      else if (z1.Item && z3.Item && m1.Item)
      {
         RunTrigame();
      }
      else if (z1.Item && z3.Item && m3.Item)
      {
         RunZeldatri();
      }
      else if (z1.Item && m1.Item && m3.Item)
      {
         Runmetroidtri();
      }
      else if (z3.Item && m1.Item && m3.Item)
      {
         RunMetroidZelda();
      }
      else if (m1.Item && m3.Item)
      {
         RunDuelmetroid();
      }
      else if (z1.Item && m3.Item)
      {
         RunDuelgame();
      }
      else if (z3.Item && m3.Item)
      {
         RunSMZ3();
      }
      else if (z3.Item && m1.Item)
      {
         RunJank();
      }
      else if (m1.Item && z1.Item)
      {
         RunRetro();
      }
      else if (z1.Item && z3.Item)
      {
         RunZeldatri();
      } 

}

   private void RunMetroidZelda()
   {
      RunFunQuadgame();
      zelda.alpha = 0;
      zelda.blocksRaycasts = false;
      zelda.interactable = false;
      Z1R.alpha = 0;
      Z1R.blocksRaycasts = false;
      Z1R.interactable = false;
      z1items.alpha = 0;
      z1items.blocksRaycasts = false; 
      z1items.interactable = false;
      SmTransform.anchoredPosition = new Vector2(-60, 113);
      SmTransform.localScale = new Vector3(0.6f, 0.4f,1);
      
      if (SMKeysinfo.Item || Z3Keysinfo.Item)
      {
           
         AlttpTransform.localScale = new Vector3(0.73f, 0.49f, 1);
         AlttpTransform.anchoredPosition = new Vector2(501, 220.8f);
        
         Zelda3ErTransform.localScale = new Vector3(0.72f, 0.42f, 1f);
         Zelda3ErTransform.anchoredPosition = new Vector2(501,260f);
        
         
      }
      else
      {
         AlttpTransform.localScale = new Vector3(0.79f, 0.49f, 1);
         AlttpTransform.anchoredPosition = new Vector2(501, 222.8f);
         Zelda3ErTransform.localScale = new Vector3(0.82f, 0.42f, 1f);
         Zelda3ErTransform.anchoredPosition = new Vector2(501,260f);
        
      }
   }

   private void RunRetro()
   {
      throw new NotImplementedException();
   }

   private void RunJank()
   {
      throw new NotImplementedException();
   }

   private void RunSMZ3()
   {
      throw new NotImplementedException();
   }

   private void RunDuelgame()
   {
      throw new NotImplementedException();
   }

   private void RunDuelmetroid()
   {
      throw new NotImplementedException();
   }

   private void Runmetroidtri()
   {
      
   }

   private void RunZeldatri()
   {
      Debug.Log("tri gsme");
      //z1z3m3
     RunFunQuadgame();
         // if (triforcehunt.item)
      //{
      //}
      ZeldaErTransform.localScale = new Vector3(1.06f, .37f, 1);
      ZeldaTransform.localScale = new Vector3(1.06f, .43f, 1);
      ZeldaErTransform.anchoredPosition = new Vector2(107, 125);
      ZeldaTransform.anchoredPosition = new Vector2(107,114);
      m1items.alpha = 0; 
      m1items.blocksRaycasts = false;
      m1items.interactable = false;
      zebes.alpha = 0;
      zebes.blocksRaycasts = false;
      zebes.interactable = false;
      
   }

   private void RunTrigame()
   {
      Debug.Log("tri gsme2");
    // z1z3m1
   // if (triforcehunt.item)
    //{
    //}
    FullQuad();
    smitems.alpha = 0;
    smitems.blocksRaycasts = false; 
    smitems.interactable = false;
    Sm.alpha = 0;
    Sm.blocksRaycasts = false;
    Sm.interactable = false;
    
   }

   private void FullQuad()
   {
      { 
         SmTransform.anchoredPosition = smstart;
      AlttpTransform.anchoredPosition = alttpstart;
       ZebesTransform.anchoredPosition = m1start;
        ZeldaTransform.anchoredPosition = z1start;
        ZeldaErTransform.anchoredPosition = ZeldaERstrat;
      Zelda3ErTransform.anchoredPosition = Zelda3ERstrat;
      smitems.alpha = 1;
      smitems.blocksRaycasts = true;
      m1items.alpha = 1;
      m1items.blocksRaycasts = true;
      z1items.alpha = 1;
      z1items.blocksRaycasts = true;
      z3items.alpha = 1;
      z3items.blocksRaycasts = true;
      
        if (SMKeysinfo.Item || Z3Keysinfo.Item)
        {
           
           AlttpTransform.localScale = new Vector3(0.73f, 0.49f, 1);
          AlttpTransform.anchoredPosition = new Vector2(501, 220.8f);
           ZeldaTransform.localScale = new Vector3(0.67f, 0.41f, 1);
           ZeldaErTransform.localScale = new Vector3(0.66f, 0.353f, 1);
           Zelda3ErTransform.localScale = new Vector3(0.72f, 0.42f, 1f);
           Zelda3ErTransform.anchoredPosition = new Vector2(501,260f);
           ZebesTransform.localScale = new Vector3(.39f,.39f,1);
           if (SMKeysinfo.Item)
           {
              SmKeysCanvasGroup.alpha = 1;
              SmKeysCanvasGroup.blocksRaycasts = true;
              SmKeysCanvasGroup.interactable = true;
           }

           if (Z3Keysinfo.Item)
           {
              Z3KeyscanCanvasGroup.alpha = 1;
              Z3KeyscanCanvasGroup.blocksRaycasts = true;
              Z3KeyscanCanvasGroup.interactable = true;
           }
        }
        else
        {
           AlttpTransform.localScale = new Vector3(0.79f, 0.49f, 1);
           AlttpTransform.anchoredPosition = new Vector2(501, 222.8f);
          
           ZeldaTransform.localScale = new Vector3(0.67f, 0.41f, 1f);
           ZeldaErTransform.localScale = new Vector3(0.66f, 0.353f, 1f);
           Zelda3ErTransform.localScale = new Vector3(0.82f, 0.42f, 1f);
           Zelda3ErTransform.anchoredPosition = new Vector2(501,260f);
           ZebesTransform.localScale = new Vector3(.39f,.39f,1);
        }
      
        
        Sm.alpha = 0;
        Sm.blocksRaycasts = false;
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
      if (Z3ER.Item)
      {
         z3R.blocksRaycasts = true;
         z3R.alpha = 1;
         alttp.alpha = 0;
         alttp.blocksRaycasts = false;
      }
      else
      {
         z3R.blocksRaycasts = false;
         z3R.alpha = 0;
         alttp.alpha = 1;
         alttp.blocksRaycasts = true;
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
   }

   private void RunFunQuadgame()
   {
      { 
         SmTransform.anchoredPosition = smstart;
      AlttpTransform.anchoredPosition = alttpstart;
       ZebesTransform.anchoredPosition = m1start;
        ZeldaTransform.anchoredPosition = z1start;
        ZeldaErTransform.anchoredPosition = ZeldaERstrat;
      Zelda3ErTransform.anchoredPosition = Zelda3ERstrat;
      smitems.alpha = 1;
      smitems.blocksRaycasts = true;
      m1items.alpha = 1;
      m1items.blocksRaycasts = true;
      z1items.alpha = 1;
      z1items.blocksRaycasts = true;
      z3items.alpha = 1;
      z3items.blocksRaycasts = true;
      
        if (SMKeysinfo.Item || Z3Keysinfo.Item)
        {
           
           AlttpTransform.localScale = new Vector3(0.36f, 0.45f, 1);
           SmTransform.localScale = new Vector3(0.46f, 0.52f, 1);
           
           ZeldaTransform.localScale = new Vector3(0.67f, 0.41f, 1);
           ZeldaErTransform.localScale = new Vector3(0.66f, 0.353f, 1);
           Zelda3ErTransform.localScale = new Vector3(0.38f, 0.42f, 1f);
           ZebesTransform.localScale = new Vector3(.39f,.39f,1);
           
        
           
           if (SMKeysinfo.Item)
           {
              SmKeysCanvasGroup.alpha = 1;
              SmKeysCanvasGroup.blocksRaycasts = true;
              SmKeysCanvasGroup.interactable = true;
           }

           if (Z3Keysinfo.Item)
           {
              Z3KeyscanCanvasGroup.alpha = 1;
              Z3KeyscanCanvasGroup.blocksRaycasts = true;
              Z3KeyscanCanvasGroup.interactable = true;
           }
        }
        else
        {
           SmTransform.localScale = new Vector3(0.46f, 0.52f, 1);
           AlttpTransform.localScale = new Vector3(0.46f, 0.45f, 1);
           ZeldaTransform.localScale = new Vector3(0.67f, 0.41f, 1f);
           ZeldaErTransform.localScale = new Vector3(0.66f, 0.353f, 1f);
           Zelda3ErTransform.localScale =  new Vector3(0.47f, 0.42f, 1f);
           ZebesTransform.localScale = new Vector3(.39f,.39f,1);
           
          
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
      if (Z3ER.Item)
      {
         z3R.blocksRaycasts = true;
         z3R.alpha = 1;
         alttp.alpha = 0;
         alttp.blocksRaycasts = false;
      }
      else
      {
         z3R.blocksRaycasts = false;
         z3R.alpha = 0;
         alttp.alpha = 1;
         alttp.blocksRaycasts = true;
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
   }

  
   public void all()

   {
      SmTransform.anchoredPosition = smstart;
      AlttpTransform.anchoredPosition = alttpstart;
       ZebesTransform.anchoredPosition = m1start;
        ZeldaTransform.anchoredPosition = z1start;
        ZeldaErTransform.anchoredPosition = ZeldaERstrat;
      Zelda3ErTransform.anchoredPosition = Zelda3ERstrat;
      if (maprando.Item || !m3.Item)
      {
         if (SMKeysinfo.Item || Z3Keysinfo.Item)
         {
            AlttpTransform.localScale = new Vector3(0.68f, 0.49f, 1);
            AlttpTransform.anchoredPosition = new Vector2(501, 220.8f);
            
            ZebesTransform.localScale = new Vector3(.39f,.39f,1);
            ZeldaTransform.localScale = new Vector3(0.67f, 0.41f, 1);
            ZeldaErTransform.localScale = new Vector3(0.66f, 0.353f, 1);
            Zelda3ErTransform.localScale = new Vector3(0.7f, 0.42f, 1f);
            Zelda3ErTransform.anchoredPosition = new Vector2(501, 263.8f);
         }
         else
         {
            AlttpTransform.localScale = new Vector3(0.75f, 0.49f, 1);
            AlttpTransform.anchoredPosition = new Vector2(501, 220.8f);
            ZebesTransform.localScale = new Vector3(.39f,.39f,1f);
            ZeldaTransform.localScale = new Vector3(0.67f, 0.41f, 1f);
            ZeldaErTransform.localScale = new Vector3(0.66f, 0.353f, 1f);
            Zelda3ErTransform.localScale =  new Vector3(0.8f, 0.42f, 1f);
            Zelda3ErTransform.anchoredPosition = new Vector2(501, 263.8f);
         }
         Sm.alpha = 0;
         Sm.blocksRaycasts = false;
      }
      else if (!z3.Item && !z1.Item)
      {//sm m1 needs value change
         ZebesTransform.localScale = new Vector3(.39f,.39f,1f);
         SmTransform.localScale = new Vector3(0.46f, 0.52f, 1f);
         SmTransform.anchoredPosition = new Vector2(501, 220.8f);
         ZebesTransform.anchoredPosition = new Vector2(501, 263.8f);
         zelda.alpha = 0;
         zelda.blocksRaycasts = false;
         zelda.interactable = false;
        
      }
      else if (!m3.Item && !m1.Item)
      {
         ZeldaTransform.localScale = new Vector3(0.67f, 0.41f, 1);
         ZeldaErTransform.localScale = new Vector3(0.66f, 0.353f, 1);
         Zelda3ErTransform.localScale = new Vector3(0.382f, 0.42f, 1f);
         AlttpTransform.localScale = new Vector3(0.382f, 0.45f, 1f);
         ZeldaTransform.anchoredPosition = new Vector2(501, 263.8f);
         Zelda3ErTransform.anchoredPosition = new Vector2(501, 263.8f);
         ZeldaErTransform.anchoredPosition = new Vector2(501, 263.8f);
         AlttpTransform.anchoredPosition = new Vector2(501, 263.8f);
         Sm.alpha = 0;
         Sm.blocksRaycasts = false;
         Sm.interactable = false;
         zebes.alpha = 0;
         zebes.blocksRaycasts = false;
         zebes.interactable = false;
      }
      else if  (SMKeysinfo.Item || Z3Keysinfo.Item)
      { 
         Sm.alpha = 1;
         Sm.blocksRaycasts = true;
         AlttpTransform.localScale = new Vector3(0.382f, 0.45f, 1f);
         SmTransform.localScale = new Vector3(0.46f, 0.52f, 1);
         ZebesTransform.localScale = new Vector3(.39f,.39f,1);
         ZeldaTransform.localScale = new Vector3(0.67f, 0.41f, 1);
         ZeldaErTransform.localScale = new Vector3(0.66f, 0.353f, 1);
         Zelda3ErTransform.localScale = new Vector3(0.382f, 0.42f, 1f);
      }
      else
      {
         SmTransform.localScale = new Vector3(0.46f, 0.52f, 1f);
         AlttpTransform.localScale = new Vector3(0.47f, 0.45f, 1);
         ZebesTransform.localScale = new Vector3(.39f,.39f,1f);
         ZeldaTransform.localScale = new Vector3(0.67f, 0.41f, 1f);
         ZeldaErTransform.localScale = new Vector3(0.66f, 0.353f, 1f);
         Zelda3ErTransform.localScale =  new Vector3(0.47f, 0.42f, 1f);
      }
      
        
    
     
     
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
      if (Z3ER.Item)
      {
         z3R.blocksRaycasts = true;
         z3R.alpha = 1;
         alttp.alpha = 0;
         alttp.blocksRaycasts = false;
      }
      else
      {
         z3R.blocksRaycasts = false;
         z3R.alpha = 0;
         alttp.alpha = 1;
         alttp.blocksRaycasts = true;
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
      SmTransform.localScale = new Vector3(0.8f, 0.8f,1);
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
      z3R.blocksRaycasts = false;
      z3R.alpha = 0;
   }

   public void Alttp()
   {
      if (Z3ER.Item)
      {
         z3R.blocksRaycasts = true;
         z3R.alpha = 1;
         Zelda3ErTransform.anchoredPosition = new Vector2(500, 66);
         Zelda3ErTransform.localScale = new Vector3(.71f, .70f,1);
         alttp.alpha = 0;
         alttp.blocksRaycasts = false;
      }
      else
      {
         z3R.blocksRaycasts = false;
         z3R.alpha = 0;
         alttp.alpha = 1;
         alttp.blocksRaycasts = true;
         AlttpTransform.anchoredPosition = new Vector2(500, 14);
         AlttpTransform.localScale = new Vector3(0.69f, 0.8f,1);
      }
      Z1R.blocksRaycasts = false;
      Z1R.alpha = 0;
      Sm.alpha = 0;
      Sm.blocksRaycasts = false;
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
      z3R.blocksRaycasts = false;
      z3R.alpha = 0;
      Z1R.blocksRaycasts = false;
      Z1R.alpha = 0;
      Sm.alpha = 0;
      Sm.blocksRaycasts = false;
      alttp.alpha = 0;
      alttp.blocksRaycasts = false;
      zebes.alpha = 1;
      zebes.blocksRaycasts = true;
      ZebesTransform.anchoredPosition = new Vector2(455, 42);
      ZebesTransform.localScale = new Vector3(0.8f, 0.8f,1);
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
         ZeldaErTransform.localScale = new Vector3(.95f, .8f,1);
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
         ZeldaTransform.localScale = new Vector3(.95f, .9f,1);
      }
      z3R.blocksRaycasts = false;
      z3R.alpha = 0;
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
      z3R.blocksRaycasts = false;
      z3R.alpha = 0;
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
   {  
      z3R.blocksRaycasts = false;
      z3R.alpha = 0;
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
      z3R.blocksRaycasts = false;
      z3R.alpha = 0;
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
      z3R.blocksRaycasts = false;
      z3R.alpha = 0;
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
      z3R.blocksRaycasts = false;
      z3R.alpha = 0;
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
      z3R.blocksRaycasts = false;
      z3R.alpha = 0;
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
      z3R.blocksRaycasts = false;
      z3R.alpha = 0;
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
      z3R.blocksRaycasts = false;
      z3R.alpha = 0;
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
   { z3R.blocksRaycasts = false;
      z3R.alpha = 0;
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
      z3R.blocksRaycasts = false;
      z3R.alpha = 0;
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
