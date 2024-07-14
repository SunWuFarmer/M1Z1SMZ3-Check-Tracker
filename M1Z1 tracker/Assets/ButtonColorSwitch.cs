using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

public class ButtonColorSwitch : MonoBehaviour
{
   public bool green = true;
   public ItemsReamaining stats;
   public bool M1;
   public bool Z1;
   public bool Z3;
   public bool SM;
   public void Start()
   {
       stats.TotalItemsleft++;
       if (M1)
       {
           stats.ItemsleftM1++;
       }
       if (Z1)
       {
           stats.ItemsleftZ1++;
       }
       if (Z3)
       {
           stats.ItemsleftZ3++;
       }
       if (SM)
       {
           stats.ItemsleftSM++;
       }
   }

   public void OnClick()
   {
       Image check = GetComponent<Image>();
       if (green)
       {
           check.color = Color.gray;
           green = false;
           stats.TotalItemsleft--;
           if (M1)
           {
               stats.ItemsleftM1--;
           }

           if (Z1)
           {
               stats.ItemsleftZ1--;
           }

           if (Z3)
           {
               stats.ItemsleftZ3--;
           }

           if (SM)
           {
               stats.ItemsleftSM--;
           }
       }
   }

   public void OnRightClick()
   { 
       Image check = GetComponent<Image>();
      
           check.color =Color.green;
           green = true;
    
           stats.TotalItemsleft++;
           if (M1)
           {
               stats.ItemsleftM1++;
           }
           if (Z1)
           {
               stats.ItemsleftZ1++;
           }
           if (Z3)
           {
               stats.ItemsleftZ3++;
           }
           if (SM)
           {
               stats.ItemsleftSM++;
           }
    
   }
   
   }
   