using UnityEngine;
using UnityEngine.EventSystems;




public class InventorySlot : MonoBehaviour, IPointerClickHandler
{
    public InventoryItem myItem { get; set; }
    public SlotTag myTag;
    
    public void OnPointerClick(PointerEventData eventData)
    {

    }


    public void  SetItem(InventoryItem item)
    {

    }
}
