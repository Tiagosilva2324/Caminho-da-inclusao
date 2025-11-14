using UnityEngine;

public class PickupItem : MonoBehaviour
{
    public Item item;
    bool alreadyPickup = false;


    public void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.transform.tag == "Player")
        {
            if (Input.GetKeyDown(KeyCode.E) && !alreadyPickup)
            {
                Inventory.Singleton.PickupItem(item);
                alreadyPickup = true;
                Destroy(this.gameObject);
            }
        }
    }
}
