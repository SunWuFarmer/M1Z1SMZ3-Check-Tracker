using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Dungeonchests : MonoBehaviour
{
    [SerializeField] private Sprite item1;
    [SerializeField] private Sprite item2;
  
    private Image displayeditem;
    private float itemshown = 0;
    [SerializeField] private int checks;
  private int textnumber = 0;
    [SerializeField] private TextMeshProUGUI text;
   
    public void Start()
    {
        textnumber = checks;
        displayeditem = GetComponent<Image>();
    }
    public void OnrightClick()
    {
        displayeditem = GetComponent<Image>();
        textnumber+=1;
        if (textnumber > checks)
        {
            textnumber = checks;}
        DisplayText();
    }
   
    public void OnleftClick()
    {
        displayeditem = GetComponent<Image>();
        textnumber-=1;
        if (textnumber < 0)
        {
            textnumber = 0;}
        DisplayText();
    }

    private void DisplayText()
    {
        text.text = textnumber.ToString();
        if (textnumber ==0)
        {
            displayeditem.sprite = item2;
        }

        if (textnumber != 0)
        {
            displayeditem.sprite = item1;
        }
        
    }
}
