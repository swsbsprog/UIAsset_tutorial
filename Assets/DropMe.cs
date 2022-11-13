using UnityEngine;
using UnityEngine.EventSystems;

public class DropMe : MonoBehaviour, IDropHandler
{
    public void OnDrop(PointerEventData eventData)
    {
        print(eventData);
    }
}