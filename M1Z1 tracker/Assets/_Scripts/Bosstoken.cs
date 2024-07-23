using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;



public class Bosstoken : MonoBehaviour
{
    [SerializeField] private Sprite item1;
    [SerializeField] private Sprite item2;
  
    private Image displayeditem;
    private float itemshown = 0;
    private int textnumber = 0;
    private bool light;
    [SerializeField] private TextMeshProUGUI text;
    [SerializeField] private int bossnumber;

    public void Start()
    {
        textnumber = bossnumber;
        displayeditem = GetComponent<Image>();
    }
    public void OnrightClick()
    {
        displayeditem = GetComponent<Image>();
        textnumber-=1;
        if (textnumber < 0)
        {
            textnumber = bossnumber;
        }
        DisplayText();
    }
   
    public void OnleftClick()
    {
        displayeditem = GetComponent<Image>();
        if (light)
        {
            light = false;
            displayeditem.sprite = item1;
        }
        else
        {
            light = true;
            displayeditem.sprite = item2;
        }
    }

    private void DisplayText()
    {
        text.text = textnumber.ToString();
    }
}
