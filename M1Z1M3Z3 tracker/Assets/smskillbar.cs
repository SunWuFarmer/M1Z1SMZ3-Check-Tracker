using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class smskillbar : MonoBehaviour
{
    private Scrollbar _scrollbar;
    [SerializeField] private int scrollbarmulti;
    [SerializeField] private NormalLogic basic;
    [SerializeField] private Iteminfo medium;
    [SerializeField] private Iteminfo hard;
    private float _scrollvalue = 1;

    void Start()
    {
        _scrollbar = GetComponent<Scrollbar>();

    }


    public void Setlogic()
    {
        _scrollvalue = (scrollbarmulti * _scrollbar.value);
Debug.Log(_scrollvalue);

        if (_scrollvalue == 0)
        {
            basic.normalLogic = true;
            medium.Item = false;
            hard.Item = false;
        }
        else if (_scrollvalue == 1.5f)

        {
            basic.normalLogic = false;
            medium.Item = true;
            hard.Item = false;
        }
        else if (_scrollvalue == 3)

        {
            basic.normalLogic = false;
            medium.Item = false;
            hard.Item = true;
        }

    }
}

