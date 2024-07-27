using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FlipsOnlyChecks : MonoBehaviour
{
    [SerializeField] private ItemLogic flips;
   public bool green = true;
     public ItemsReamaining stats;
     public bool M1;
     public bool Z1;
     public bool Z3;
     public bool SM;
     private Image check;
     public event EventHandler OnItemActive;

     public void Start()
     {     check = GetComponent<Image>();
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
         
         if (green)
         {
             check.color = Color.gray;
             green = false;
             Debug.Log("hit");
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
