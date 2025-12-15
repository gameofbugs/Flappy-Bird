using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class TouchInput : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    [SerializeField] private RectTransform panel;
    public bool isTouch = false;
    private int touchId;
 
    public void OnPointerDown(PointerEventData eventData)
    {
        if (RectTransformUtility.RectangleContainsScreenPoint(panel, eventData.position))
        {
            isTouch = true;
            touchId = eventData.pointerId;
        }
    }
    public void OnPointerUp(PointerEventData eventData)
    {
        if (touchId == eventData.pointerId)
        {
            isTouch = false;
        }
    }
}