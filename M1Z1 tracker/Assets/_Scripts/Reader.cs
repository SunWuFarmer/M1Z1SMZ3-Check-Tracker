using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;
using UnityEngine.UI;

public class Reader : MonoBehaviour
{
    private Image buttonClick;
    public Image SmallCheck;
    private bool green = true;
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
        buttonClick = GetComponent<Image>();
        if (green)
        {
            buttonClick.color = Color.gray;
            SmallCheck.color = Color.grey;
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
                buttonClick.color = Color.green;
                SmallCheck.color = Color.green; 
                green = true;
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
