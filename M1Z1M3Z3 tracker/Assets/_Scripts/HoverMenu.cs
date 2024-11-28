using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.UIElements;
using Image = UnityEngine.UI.Image;

public class HoverMenu : MonoBehaviour ,IPointerEnterHandler,IPointerExitHandler
{
    
    [SerializeField] private float _popuptimer = 0.4f;
    [SerializeField] private string Checkname;
    [SerializeField] private string CheckScript;
    [SerializeField] private Sprite snip1;
    [SerializeField] private Sprite snip2;
    private GameObject Mainpopup;
    private GameObject checkname;
    private GameObject snipGameObject1;
    private GameObject snipGameObject2;
    private GameObject itemtext;
    private Image snipImage1;
    private Image snipImage2;
    private TextMeshProUGUI checknameTextMeshProUGUI;
    private TextMeshProUGUI itemsneededTextMeshProUGUI;
    private float timer;


    private void Start()
    {
        Mainpopup = GameObject.Find("CheckPopUp");
        checkname = GameObject.Find("CheckName");
        snipGameObject1 = GameObject.Find("snip");
        snipGameObject2 = GameObject.Find("snip2");
        itemtext = GameObject.Find("ItemsNeeded");
        checknameTextMeshProUGUI = checkname.GetComponent<TextMeshProUGUI>();
        itemsneededTextMeshProUGUI = itemtext.GetComponent<TextMeshProUGUI>();
        snipImage1 = snipGameObject1.GetComponent<Image>();
        snipImage2 = snipGameObject2.GetComponent<Image>();
        Invoke("ClosePopupMenu",0.5f);
    }

   


    public void OnPointerEnter(PointerEventData eventData)
    {
        
         Invoke("PopupMenu",_popuptimer);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        ClosePopupMenu();
       Invoke("ClosePopupMenu",_popuptimer); 
    }
   
    private void PopupMenu()
    {
        checknameTextMeshProUGUI.text = Checkname;
        itemsneededTextMeshProUGUI.text = CheckScript;
        snipImage1.sprite = snip1;
        snipImage2.sprite = snip2;
        Mainpopup.SetActive(true);
    }
    private void ClosePopupMenu()
    {
       Mainpopup.SetActive(false);
    }
}
