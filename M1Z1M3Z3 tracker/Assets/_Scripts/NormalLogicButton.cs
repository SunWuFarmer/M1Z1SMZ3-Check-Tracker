using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class NormalLogicButton : MonoBehaviour
{
    [SerializeField] private NormalLogic _normalLogic1;
    [SerializeField] private ItemLogic ItemTrigger1;
    [SerializeField] private ArrayOfItems Items;

    [SerializeField] private Button _button;
   

    private void Start()
    {
        Items.ClearItems();
    }

    public void OnClick()
    {
           
          // ItemTrigger1.TriggerEvent();
            
           
    }
}
