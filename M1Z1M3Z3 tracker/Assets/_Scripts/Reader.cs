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
    [SerializeField] private Sprite SmallCheckSprite;
    [SerializeField] private Sprite NormalCheckSprite;
    [SerializeField] private NormalLogic _normalLogic;
    private bool green = true;
    public ItemsReamaining stats;
    public bool M1;
    public bool Z1;
    public bool Z3;
    public bool SM;
    private bool pressed;

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

    public void SetNormal(string color)
    {
        
        if (!pressed)
        {
            Image check = GetComponent<Image>();
            if (color=="green")
            {
                check.sprite = NormalCheckSprite;
                check.color = Color.green;
                SmallCheck.sprite = NormalCheckSprite;
                SmallCheck.color = Color.green;
            }

            else if (color=="yellow")
            {
                check.sprite = NormalCheckSprite;
                check.color = new Color(1f,.8f,.1f);;
                SmallCheck.sprite = NormalCheckSprite;
                SmallCheck.color = new Color(1f,.8f,.1f);
              
            }
            else if (color=="blue")
            {
                check.sprite = NormalCheckSprite;
                check.color =new Color(.3f,.5f,1);;
                SmallCheck.sprite = NormalCheckSprite;
                SmallCheck.color = new Color(.3f,.5f,1);;
            }
            else if (color=="red")
            {
                check.sprite = SmallCheckSprite;
                check.color = Color.red;
                SmallCheck.sprite = SmallCheckSprite;
                SmallCheck.color = Color.red;
                
            } 
        }
    }
    public void OnClick()
    {
        buttonClick = GetComponent<Image>();

        pressed = true;
            buttonClick.color = Color.clear;
            SmallCheck.color = Color.clear;
            

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
    

    public void OnRightClick()
            {   
                buttonClick.color = Color.green;
                SmallCheck.color = Color.green;
                pressed = false;
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
