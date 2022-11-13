using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryUI : MonoBehaviour
{
    public List<Sprite> itemSprites;
    public InventoryItem baseItem;

    private void Start()
    {
        var parent = baseItem.transform.parent;
        baseItem.gameObject.SetActive(true);
        foreach (var item in itemSprites)
        {
            var newItem = Instantiate(baseItem, parent);
            newItem.Init(item);
        }
        baseItem.gameObject.SetActive(false);
    }
}
