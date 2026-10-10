using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DisplayValue : MonoBehaviour
{
    private Scrollbar _scrollbar;
    public TextMeshProUGUI displayTextField;
    [SerializeField] private int scrollbarmulti;
    private float _scrollvalue = 1;
    [SerializeField] private int endgoalstartingnumber;
    void Start()
    {
        _scrollbar = GetComponent<Scrollbar>();
        _scrollvalue = (scrollbarmulti * _scrollbar.value);
                    displayTextField.text = _scrollvalue.ToString();
    }
    

    public void Sendtext()
    {
        _scrollvalue = (scrollbarmulti * _scrollbar.value);
        
        displayTextField.text = _scrollvalue.ToString();
        
    }
    
}
