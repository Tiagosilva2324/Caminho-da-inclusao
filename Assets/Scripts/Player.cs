using UnityEngine;
using UnityEngine.SceneManagement;


public class Animation : MonoBehaviour
{
    public Animator playerAnimator;
    float input_x = 0;
    float input_y = 0;
    bool isWalking = false;
    public float speed;
    public Rigidbody2D rb;
    public KeyCode InventoryKey = KeyCode.Q;
    public GameObject inventoryPanel; 
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        isWalking = false;
    }

    // Update is called once per frame
    void Update()
    {
        input_x = Input.GetAxisRaw("Horizontal");
        input_y = Input.GetAxisRaw("Vertical");
        isWalking = (input_x != 0 || input_y != 0);

        if (isWalking)
        {
            var move = new Vector3(input_x, input_y, 0).normalized;
            rb.linearVelocity = new Vector2(input_x * speed, input_y * speed);
            //transform.position += move * speed * Time.deltaTime;
            playerAnimator.SetFloat("input_x", input_x);
            playerAnimator.SetFloat("input_y", input_y);
        }
        else {
            rb.linearVelocity = Vector3.zero;
        
        }
        playerAnimator.SetBool("isWalking", isWalking);

        if (Input.GetKeyDown(InventoryKey))
        {
            inventoryPanel.SetActive(!inventoryPanel.activeSelf);
        }
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == 3)
        {
            SceneManager.LoadScene("Dentrodaescola");
        }
        if (collision.gameObject.layer == 6)
        {
            SceneManager.LoadScene("Fora");
        }
    }


}
