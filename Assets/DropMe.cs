using UnityEngine;
using UnityEngine.EventSystems;

public class DropMe : MonoBehaviour, IDragHandler
{
    public void OnDrag(PointerEventData eventData)
    {
        transform.position = eventData.position;
    }
}