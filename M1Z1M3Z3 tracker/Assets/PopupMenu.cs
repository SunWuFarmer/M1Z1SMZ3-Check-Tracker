using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using Image = UnityEngine.UI.Image;

public class PopupMenu : MonoBehaviour
{
    [SerializeField] private Sprite checkmark;
    [SerializeField] private CanvasGroup _canvasGroup;
    [SerializeField] private Image button;
    private Sprite startingsprite;
    private bool checkpopup;

    private void Start()
    {
        startingsprite = button.sprite;
    }

    public void togglePopup()
    {
        
        if (!checkpopup)
        {
            checkpopup = true;
            button.sprite = checkmark;
            _canvasGroup.alpha = 1;
        }
        else
        {
            checkpopup = false;
            button.sprite = startingsprite;
            _canvasGroup.alpha = 0;
        }
      
     
    }
}
