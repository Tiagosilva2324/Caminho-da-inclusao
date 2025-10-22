using UnityEngine;
using UnityEngine.EventSystems;




public class InventorySlot : MonoBehaviour, IPointerClickHandler
{
    public InventoryItem myItem { get; set; }
    public SlotTag myTag;
    
    public void OnPointerClick(PointerEventData eventData)
    {
        if(eventData.button == PointerEventData.InputButton.Left)
        {
            // TOdo
        }
    }


    public void  SetItem(InventoryItem item)
    {

    }
}
