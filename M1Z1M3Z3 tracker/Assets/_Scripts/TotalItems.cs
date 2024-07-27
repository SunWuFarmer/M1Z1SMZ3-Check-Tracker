using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TotalItems : MonoBehaviour
{
   public ItemsReamaining stats;
   private TextMeshProUGUI _textMeshPro;

   public void Start()
   {
      _textMeshPro = GetComponent<TextMeshProUGUI>();
   }

   public void FixedUpdate()
   {
      _textMeshPro.text = "Total Items Remaining:"+ stats.TotalItemsleft;
   }
}
