using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NormalLogicButton : MonoBehaviour
{
    [SerializeField] private NormalLogic _normalLogic1;
    [SerializeField] private ItemLogic ItemTrigger1;
    public void OnClick()
    {
        if (!_normalLogic1.normalLogic)
        {
            _normalLogic1.normalLogic = true;
            ItemTrigger1.TriggerEvent();
        }
        else
        {
            _normalLogic1.normalLogic = false;
        }
    }
}
