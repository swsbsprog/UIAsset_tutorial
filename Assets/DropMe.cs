using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DropMe : MonoBehaviour, IDropHandler
{
    public Image icon;
    public void OnDrop(PointerEventData eventData)
    {
        print(eventData);
        icon.enabled = true;
        icon.sprite = eventData.pointerDrag.GetComponent<InventoryItem>().icon.sprite;
    }
}