using UnityEngine;
using UnityEngine.EventSystems;

public class InventoryItem: MonoBehaviour,IPointerClickHandler
{
    Image itemIcon;

    public CanvasGroup canvasGroup {  get; private set; }

    public Item myItem { get; set; }

    public InventorySlot activeSlot { get; set; }


    void Awake()
    {
        canvasGroup = GetComponent<CanvasGroup>();
        itemIcon = GetComponent<Image>();
    }
    public void Initialize(Item item, InventorySlot paerent)                                   
    {
        activeSlot = paerent;
        activeSlot.myItem = this;
        myItem = item;
        itemIcon.sprite = item.sprite;
        
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        if (eventData.button == PointerEventData.InputButton.Left) 
        { 
           
        }
    }
  
}
