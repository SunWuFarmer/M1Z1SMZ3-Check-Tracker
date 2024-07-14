using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class rightclick : MonoBehaviour, IPointerClickHandler, IPointerDownHandler, IPointerUpHandler
{
    public UnityEvent OnRightClick;
 
    [SerializeField] private Color rightClickColor = Color.gray;
 
    [SerializeField] private float rightClickColorDuration = 0.1f;
 
    private Button button;
  [SerializeField]  private Color Color =Color.green;
 
 
    private void Awake()
    {
        button = GetComponent<Button>();
    }
 
    public void OnPointerClick(PointerEventData eventData)
    {
        if (eventData.button == PointerEventData.InputButton.Right)
        {
            OnRightClick?.Invoke();
        }
    }
 
    public void OnPointerDown(PointerEventData eventData)
    {
        if (eventData.button == PointerEventData.InputButton.Right)
        {
            StartCoroutine(FadeToRightClickColor());
        }
    }
 
    public void OnPointerUp(PointerEventData eventData)
    {
        if (eventData.button == PointerEventData.InputButton.Right)
        {
            StartCoroutine(FadeToNormalColor());
        }
    }
 
    private IEnumerator FadeToRightClickColor()
    {
        Color originalColor = button.targetGraphic.color;
        float timeElapsed = 0;
 
        while (timeElapsed < rightClickColorDuration)
        {
            timeElapsed += Time.deltaTime;
            float t = timeElapsed / rightClickColorDuration;
            button.targetGraphic.color = Color.Lerp(originalColor, rightClickColor, t);
            yield return null;
        }
 
        button.targetGraphic.color = rightClickColor;
    }
 
    private IEnumerator FadeToNormalColor()
    {
        Color originalColor = button.targetGraphic.color;
        float timeElapsed = 0;
 
        while (timeElapsed < rightClickColorDuration)
        {
            timeElapsed += Time.deltaTime;
            float t = timeElapsed / rightClickColorDuration;
            button.targetGraphic.color = Color.Lerp(originalColor, button.colors.normalColor, t);
            yield return null;
        }
 
        button.targetGraphic.color = Color;
    }
}
