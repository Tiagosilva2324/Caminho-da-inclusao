using JetBrains.Annotations;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public static Inventory Singleton;
    public static InventoryItem carriedItem;

    [SerializeField] InventorySlot[] inventorySlots;

    [SerializeField] Transform draggablesTransform;
    [SerializeField] InventoryItem itemPrefab;

    [SerializeField] Item[] items;

    private void Awake()
    {
        Singleton = this;
    }
    private void Update()
    {
        if (carriedItem == null) 
        {
            return;
        
        
        }
        carriedItem.transform.position = Input.mousePosition;
    }

    public void SetCarriedItem(InventoryItem item)
    {
        if (carriedItem != null)
        {

            if (item.activeSlot.myTag != SlotTag.None && item.activeSlot.myTag != carriedItem.myItem.itemTag)
            {

                return;

            }
            item.activeSlot.SetItem(carriedItem);
        }

        //if(item.activeSlot.myTag != SlotTag.None)
        {
           // EquipEquipment(item.activeSlot.myTag, null);

        }

        carriedItem = item;
        carriedItem.canvasGroup.blocksRaycasts = false;
        item.transform.SetParent(draggablesTransform);

    }
    //void EquipEquipment(SlotTag tag, InventoryItem iten = null)



}
