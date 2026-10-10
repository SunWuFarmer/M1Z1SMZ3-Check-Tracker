using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndGoalcount : MonoBehaviour
{
    private Scrollbar _scrollbar;
    [SerializeField] private int scrollbarmulti;
    [SerializeField] private ItemCount _itemCount;
    
    private float _scrollvalue = 1;
  
    

    void Start()
    {
        _scrollbar = GetComponent<Scrollbar>();
        
    }


    public void Setlogic()
    {
        
        _scrollvalue = (scrollbarmulti * _scrollbar.value);

        _itemCount.itemcount = (int)_scrollvalue;


    }
}
