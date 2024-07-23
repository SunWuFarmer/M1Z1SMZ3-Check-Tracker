using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

public class ButtonColorSwitch : MonoBehaviour
{
    
    [SerializeField] private NormalLogic _normalLogic;
    [SerializeField] private bool green = true; 
    [SerializeField] private ItemsReamaining stats;
    [SerializeField] private int numberOfChecks;
    [SerializeField] private int numberOfRequiredItems;
    [SerializeField] private bool m1; 
    [SerializeField] private bool z1;
    [SerializeField] private bool z3;
    [SerializeField] private bool m3;
    
    private bool itemrequirement =false;
    private bool itemrequirement1;
    private bool itemrequirement2;
    private bool itemrequirement3;
    private bool itemrequirement4;
    private bool itemrequirement5;
    private bool itemrequirement6;
    private bool itemrequirement7;
    private bool itemrequirement8;
    private bool itemrequirement9;
    private bool pressed;

    public void SetNormal()
    {
        if (!pressed)
            {
                Debug.Log("YO");
                Image check = GetComponent<Image>();
                if (numberOfRequiredItems == 0)
                {
                        check.color = Color.green;
                        Debug.Log("bro");
                }
                if (numberOfRequiredItems == 1)
                { 
                    if (itemrequirement)
                    {
                        check.color = Color.green;
                    }
                    else
                    {
                        check.color = Color.clear;
                    }
                }

                if (numberOfRequiredItems == 2)
                {
                    if (itemrequirement && itemrequirement1)
                    {
                        check.color = Color.green;
                    }
                }

                if (numberOfRequiredItems == 3)
                {
                    if (itemrequirement && itemrequirement1 && itemrequirement2)
                    {
                        check.color = Color.green;
                    }
                }

                if (numberOfRequiredItems == 4)
                {
                    if (itemrequirement && itemrequirement1 && itemrequirement2 && itemrequirement3)
                    {
                        check.color = Color.green;
                    }
                }

                if (numberOfRequiredItems == 5)
                {
                    if (itemrequirement && itemrequirement1 && itemrequirement2 && itemrequirement3 && itemrequirement4)
                    {
                        check.color = Color.green;
                    }
                }

                if (numberOfRequiredItems == 6)
                {
                    if (itemrequirement && itemrequirement1 && itemrequirement2 && itemrequirement3 &&
                        itemrequirement4 &&
                        itemrequirement5)
                    {
                        check.color = Color.green;
                    }
                }

                if (numberOfRequiredItems == 7)
                {
                    if (itemrequirement && itemrequirement1 && itemrequirement2 && itemrequirement3 &&
                        itemrequirement4 &&
                        itemrequirement5 && itemrequirement6)
                    {
                        check.color = Color.green;
                    }
                }

                if (numberOfRequiredItems == 8)
                {
                    if (itemrequirement && itemrequirement1 && itemrequirement2 && itemrequirement3 &&
                        itemrequirement4 &&
                        itemrequirement5 && itemrequirement6 && itemrequirement7)
                    {
                        check.color = Color.green;
                    }
                }

                if (numberOfRequiredItems == 9)
                {
                    if (itemrequirement && itemrequirement1 && itemrequirement2 && itemrequirement3 &&
                        itemrequirement4 &&
                        itemrequirement5 && itemrequirement6 && itemrequirement7 && itemrequirement8)
                    {
                        check.color = Color.green;
                    }
                }

                if (numberOfRequiredItems == 10)
                {
                    if (itemrequirement && itemrequirement1 && itemrequirement2 && itemrequirement3 &&
                        itemrequirement4 &&
                        itemrequirement5 && itemrequirement6 && itemrequirement7 && itemrequirement8 &&
                        itemrequirement9)
                    {
                        check.color = Color.green;
                    }
                }
               
            }
    }
    
    public void UnderStandColor()
    {
        if (_normalLogic)
        {
            if (!pressed)
            {
                Image check = GetComponent<Image>();
                if (numberOfRequiredItems == 1)
                {
                    if (itemrequirement)
                    {
                        check.color = Color.green;
                    }
                }

                if (numberOfRequiredItems == 2)
                {
                    if (itemrequirement && itemrequirement1)
                    {
                        check.color = Color.green;
                    }
                }

                if (numberOfRequiredItems == 3)
                {
                    if (itemrequirement && itemrequirement1 && itemrequirement2)
                    {
                        check.color = Color.green;
                    }
                }

                if (numberOfRequiredItems == 4)
                {
                    if (itemrequirement && itemrequirement1 && itemrequirement2 && itemrequirement3)
                    {
                        check.color = Color.green;
                    }
                }

                if (numberOfRequiredItems == 5)
                {
                    if (itemrequirement && itemrequirement1 && itemrequirement2 && itemrequirement3 && itemrequirement4)
                    {
                        check.color = Color.green;
                    }
                }

                if (numberOfRequiredItems == 6)
                {
                    if (itemrequirement && itemrequirement1 && itemrequirement2 && itemrequirement3 &&
                        itemrequirement4 &&
                        itemrequirement5)
                    {
                        check.color = Color.green;
                    }
                }

                if (numberOfRequiredItems == 7)
                {
                    if (itemrequirement && itemrequirement1 && itemrequirement2 && itemrequirement3 &&
                        itemrequirement4 &&
                        itemrequirement5 && itemrequirement6)
                    {
                        check.color = Color.green;
                    }
                }

                if (numberOfRequiredItems == 8)
                {
                    if (itemrequirement && itemrequirement1 && itemrequirement2 && itemrequirement3 &&
                        itemrequirement4 &&
                        itemrequirement5 && itemrequirement6 && itemrequirement7)
                    {
                        check.color = Color.green;
                    }
                }

                if (numberOfRequiredItems == 9)
                {
                    if (itemrequirement && itemrequirement1 && itemrequirement2 && itemrequirement3 &&
                        itemrequirement4 &&
                        itemrequirement5 && itemrequirement6 && itemrequirement7 && itemrequirement8)
                    {
                        check.color = Color.green;
                    }
                }

                if (numberOfRequiredItems == 10)
                {
                    if (itemrequirement && itemrequirement1 && itemrequirement2 && itemrequirement3 &&
                        itemrequirement4 &&
                        itemrequirement5 && itemrequirement6 && itemrequirement7 && itemrequirement8 &&
                        itemrequirement9)
                    {
                        check.color = Color.green;
                    }
                }
                else
                {
                    check.color = Color.clear;
                }
            }
        }
    }

    public void OnClick()
   {
       Image check = GetComponent<Image>();
       if (green)
       {
           check.color = Color.gray;
           green = false;
           pressed = true;
           if (_normalLogic)
           {
               check.color = Color.clear;
           }
         /*  stats.TotalItemsleft--;
           if (m1)
           {
               stats.ItemsleftM1--;
           }

           if (z1)
           {
               stats.ItemsleftZ1--;
           }

           if (z3)
           {
               stats.ItemsleftZ3--;
           }

           if (m3)
           {
               stats.ItemsleftSM--;
           }*/
       }
   }

   public void OnRightClick()
   { 
       Image check = GetComponent<Image>();
      
           check.color =Color.green;
           green = true;
    
        /*   stats.TotalItemsleft++;
           if (m1)
           {
               stats.ItemsleftM1++;
           }
           if (z1)
           {
               stats.ItemsleftZ1++;
           }
           if (z3)
           {
               stats.ItemsleftZ3++;
           }
           if (m3)
           {
               stats.ItemsleftSM++;
           } */
    
   }

   public void ItemRequirement()
   {
       itemrequirement = true;
       UnderStandColor();
   }
   public void ItemRequirement1()
   {
       itemrequirement1 = true;
       UnderStandColor();
   }
   public void ItemRequirement2()
   {
       itemrequirement2 = true;
       UnderStandColor();
   }
   public void ItemRequirement3()
   {
       itemrequirement3 = true;
       UnderStandColor();
   }

   public void ItemRequirement4()
   {
       itemrequirement4 = true;
       UnderStandColor();
   }
   public void ItemRequirement5()
   {
       itemrequirement5 = true;
       UnderStandColor();
   }
   public void ItemRequirement6()
   {
       itemrequirement6 = true;
       UnderStandColor();
   }
   public void ItemRequirement7()
   {
       itemrequirement7 = true;
       UnderStandColor();
   }
   public void ItemRequirement8()
   {
       itemrequirement8 = true;
       UnderStandColor();
   }
   public void ItemRequirement9()
   {
       itemrequirement9 = true;
       UnderStandColor();
   }
}
   
   