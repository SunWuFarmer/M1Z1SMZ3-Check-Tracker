using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OnStartChecks : MonoBehaviour
{
    [SerializeField] private int numberOfChecks;
    [SerializeField] private bool m1; 
    [SerializeField] private bool z1;
    [SerializeField] private bool z3;
    [SerializeField] private bool m3;
    [SerializeField] private Sprite SmallCheckSprite;
    [SerializeField] private Sprite NormalCheckSprite;
    [SerializeField] private NormalLogic _normalLogic;
    [SerializeField] private bool green = true; 
    [SerializeField] private ItemsReamaining stats;
    private bool pressed;
    public void SetNormal()
    {
        if (!pressed)
        {
            Image check = GetComponent<Image>();
                check.color = Color.green;
        }
    }
    public void OnClick()
    {
        Image check = GetComponent<Image>();
        if (green)
        {
            check.color = Color.gray;
            green = false;
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
    }
    public void OnRightClick()
    { 
        Image check = GetComponent<Image>();
      
        check.color =Color.green;
        green = true;
    
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
