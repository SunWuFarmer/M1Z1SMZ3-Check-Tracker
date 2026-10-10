using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Scrollbar))]
public class SnappingScrollbar : MonoBehaviour
{
    private Scrollbar _scrollbar;
    public int numberOfSteps = 3; // The number of "notches"

    void Start()
    {
        _scrollbar = GetComponent<Scrollbar>();
    }

    // Call this method whenever the scrollbar's value changes
    public void SnapToClosestStep()
    {
        float stepSize = 1.0f / (numberOfSteps - 1);
        float snappedValue = Mathf.Round(_scrollbar.value / stepSize) * stepSize;
        _scrollbar.value = snappedValue;
    }
}