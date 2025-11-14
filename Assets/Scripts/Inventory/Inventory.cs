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



    Item PickItem(Item pickItem)
    {
        Item selectedItem = null;

        foreach (var item in items)
        {
            if (item.name == pickItem.name)
            {
                selectedItem = item;
                break;

            }

        }

        return selectedItem;
    }
    public void spawnInventoryItem(Item item = null)
    {
        
    }

    public void PickupItem(Item item)
    {
        Item _item = item;
        if (_item == null) 
        { 
        _item = PickItem(item);
        }

        for (int i = 0; i < inventorySlots.Length; i++) 
        {
        if (inventorySlots[i].myItem == null) 
            {
            Instantiate(itemPrefab, inventorySlots[i].transform).Initialize(_item, inventorySlots[i]);
                break;
            
            }
        
        
        }
    }
    public void DropItem(InventoryItem item)
    {
        Debug.Log($"Drop item: {item.name}");
        SpawnObjectNearPlayer(item);
        Destroy(item.gameObject);
    }

    public void SpawnObjectNearPlayer(InventoryItem item)
    {
        Transform player = GameObject.Find("Player").transform;


        Vector2 randomDirection = Random.insideUnitCircle.normalized;
        float randomDistance = Random.Range(0.1f, 0.5f);
        Vector2 spawnPosition = (Vector2)player.position + randomDirection * randomDistance;
        

        GameObject dropItemPrefab = Instantiate(item.myItem.prefab, spawnPosition, Quaternion.identity);
        dropItemPrefab.GetComponent<SpriteRenderer>().sprite = item.myItem.sprite;
        dropItemPrefab.GetComponent<PickupItem>().item = item.myItem;
    }

}
