using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Key : MonoBehaviour
{
    [SerializeField] private Sprite item1;
  
    private Image displayeditem;
    private float itemshown = 0;
    private int textnumber = 0;
    [SerializeField] private TextMeshProUGUI text;
   
    public void Start()
    {
        displayeditem = GetComponent<Image>();
    }
    public void OnrightClick()
    {
        displayeditem = GetComponent<Image>();
        textnumber-=1;
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
    }
}
