using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class healthtanks : MonoBehaviour
{
    [SerializeField] private Sprite item1;
    [SerializeField] private Sprite item2;
    
    private Image displayeditem;
    private float itemshown = 0;
    private int textnumber = 0;
    [SerializeField] private TextMeshProUGUI text;
    [SerializeField] private ItemLogic ItemTrigger;
    [SerializeField] private Iteminfo _itemStatus1;
    [SerializeField] private Iteminfo _itemStatus2;
    [SerializeField] private Iteminfo _itemStatus3;
    [SerializeField] private Iteminfo _itemStatus4;
    [SerializeField] private Iteminfo _itemStatus5;

    public void Start()
    {
        displayeditem = GetComponent<Image>();
    }
    public void OnrightClick()
    {
        displayeditem = GetComponent<Image>();
        textnumber-=1;
        if (textnumber < 0)
        {
            textnumber = 0;}
        DisplayText();
    }
   
    public void OnleftClick()
    {
        displayeditem = GetComponent<Image>();
        textnumber+=1;
        DisplayText();
    }

    private void DisplayText()
    {
        text.text = textnumber.ToString();
        if (textnumber == 0)
        {
            displayeditem.sprite = item1;
            _itemStatus1.Item = false;
            ItemTrigger.TriggerEvent();
        }

        if (textnumber == 1)
        { 
            displayeditem.sprite = item2;
            _itemStatus1.Item = true;
            _itemStatus2.Item = false;
            ItemTrigger.TriggerEvent();
        }

        if (textnumber == 2)
        {
            displayeditem.sprite = item2;
            _itemStatus2.Item = true;
            _itemStatus3.Item = true;
            ItemTrigger.TriggerEvent();
        }
        if (textnumber == 3)
        { 
            displayeditem.sprite = item2;
            _itemStatus3.Item = true;
            _itemStatus4.Item = false; 
            ItemTrigger.TriggerEvent();
        }
        if (textnumber == 4)
        { 
            displayeditem.sprite = item2;
            _itemStatus4.Item = true;
            _itemStatus5.Item = false;
            ItemTrigger.TriggerEvent();
        }
        if (textnumber == 5)
        { 
            displayeditem.sprite = item2;
            _itemStatus5.Item = true;
            ItemTrigger.TriggerEvent();
        }
       
        
    } 
}

