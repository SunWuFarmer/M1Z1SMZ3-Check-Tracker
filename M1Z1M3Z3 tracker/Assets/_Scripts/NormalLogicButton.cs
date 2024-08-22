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
    [SerializeField] private Image _image;
    [SerializeField] private TMP_Text text;

    private void Start()
    {
        Items.ClearItems();
        _normalLogic1.normalLogic = false;
    }

    public void OnClick()
    {
            _normalLogic1.normalLogic = true;
            ItemTrigger1.TriggerEvent();
            _button.interactable = false;
            _image.color = Color.gray;
            text.color = Color.gray;
    }
}
