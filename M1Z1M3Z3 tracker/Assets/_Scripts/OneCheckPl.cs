using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class OneCheckPl : MonoBehaviour
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
    [SerializeField] private ItemStatus[] Requireditems;
    [SerializeField] private ItemStatus[] Requireditems2;
    [SerializeField] private ItemStatus[] Requireditems3;
    [SerializeField] private ItemStatus[] YellowItems;
    [SerializeField] private ItemStatus[] blueItems;
    
    private bool green;
    private bool pressed;
    private bool yellow;
    private bool blue;

    public void SetNormal()
    {
        if (!pressed)
        {
            RunLogic();
            Image check = GetComponent<Image>();
                if (green)
                {
                    check.sprite = NormalCheckSprite;
                    check.color = Color.green;
                }

                else if (yellow)
                {
                    check.sprite = NormalCheckSprite;
                    check.color = Color.yellow;
                }
                else if (blue)
                {
                    check.sprite = NormalCheckSprite;
                    check.color = Color.blue;
                }
                else
                {
                    check.sprite = SmallCheckSprite;
                    check.color = Color.red;
                } 
        }
    }

    private void RunLogic()
    {
        if (Requireditems != null)
        {
             foreach (var requireditem in Requireditems)
             {
                 if (!requireditem)
                 {
                     break;
                 }
                 else
                 {
                     green = true;
                 }
             }
        }
        else if  (Requireditems2 != null)
        { 
            foreach (var requiredItem2 in Requireditems2)
            {
                if (!requiredItem2)
                {
                    break;
                }
                else
                {
                    green = true;
                }
            }
        }
        else if  (Requireditems3 != null)
        { 
            foreach (var requiredItem3 in Requireditems3)
            {
                if (!requiredItem3)
                {
                    break;
                }
                else
                {
                    green = true;
                }
            }
        }
        else if  (YellowItems != null)
        { 
            foreach (var yellowitem  in YellowItems)
            {
                if (!yellowitem)
                {
                    break;
                }
                else
                {
                    yellow = true;
                }
            }
        }
        else if  (blueItems != null)
        { 
            foreach (var blueItem in blueItems)
            {
                if (!blueItem)
                {
                    break;
                }
                else
                {
                    blue = true;
                }
            }
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
