using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class NormalCheck : MonoBehaviour
{
    [SerializeField] private int numberOfChecks;
    [SerializeField] private bool m1; 
    [SerializeField] private bool z1;
    [SerializeField] private bool z3;
    [SerializeField] private bool m3;
    [SerializeField] private Sprite SmallCheckSprite;
    [SerializeField] private Sprite NormalCheckSprite;
    [SerializeField] private NormalLogic _normalLogic;
    [SerializeField] private ItemsReamaining stats;
    
    private bool green;
   [SerializeField] private bool pressed;
    private bool yellow;
    private bool blue;

    public void SetNormal(string color)
    {
        
        if (!pressed)
        {
            Image check = GetComponent<Image>();
                if (color=="green")
                {
                    check.sprite = NormalCheckSprite;
                    check.color = Color.green;
                }

                else if (color=="yellow")
                {
                    check.sprite = NormalCheckSprite;
                    check.color = new Color(1f,.8f,.1f);
                }
                else if (color=="orange")
                {
                    check.sprite = NormalCheckSprite;
                    check.color = new Color(1,.5f,.5f);
                }
                
                else if (color=="blue")
                {
                    check.sprite = NormalCheckSprite;
                    check.color = new Color(.3f,.5f,1);
                }
                else if (color=="red")
                {
                    check.sprite = SmallCheckSprite;
                    check.color = Color.red;
                    
                } 
        }
    }
    
    public void OnClick()
    {
        Image check = GetComponent<Image>();
        
            check.color = Color.black;
            pressed = true;
            if (_normalLogic)
            {
                check.color = Color.clear;
            }
            stats.TotalItemsleft--;
            if (m1)
            {
                stats.ItemsleftM1-=stats.ItemsleftM1;
            }

            if (z1)
            {
                stats.ItemsleftZ1-=stats.ItemsleftZ1;
            }

            if (z3)
            {
                stats.ItemsleftZ3-=stats.ItemsleftZ3;
            }

            if (m3)
            {
                stats.ItemsleftSM-=stats.ItemsleftSM;
            }
    }
    public void OnRightClick()
    { 
        Image check = GetComponent<Image>();
      
        check.color =Color.gray;
        green = true;
        pressed = false;
    
        stats.TotalItemsleft+=stats.TotalItemsleft;
        if (m1)
        {
            stats.ItemsleftM1+=stats.ItemsleftM1;
        }

        if (z1)
        {
            stats.ItemsleftZ1+=stats.ItemsleftZ1;
        }

        if (z3)
        {
            stats.ItemsleftZ3+=stats.ItemsleftZ3;
        }

        if (m3)
        {
            stats.ItemsleftSM+=stats.ItemsleftSM;
        }
    }
}
