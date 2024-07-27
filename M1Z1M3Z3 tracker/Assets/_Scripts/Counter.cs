using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Counter : MonoBehaviour
{
  private ButtonColorSwitch ButtonColorSwitch;
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
  
}
