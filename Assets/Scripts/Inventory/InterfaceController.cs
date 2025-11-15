using UnityEngine;

public class InterfaceController : MonoBehaviour
{
    public GameObject inventoryPanel;

    bool invActive = false;
    void Start()
    {
        
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q)) {

            invActive = !invActive;
            inventoryPanel.SetActive(invActive);
        }


    }
}
