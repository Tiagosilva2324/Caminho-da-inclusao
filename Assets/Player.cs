using UnityEngine;

public class Player : MonoBehaviour
{
   private Rigidbody2D  playerRigidibody2D;
    public float speed;
    private Vector2 playerDirection;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerRigidibody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        playerDirection = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));

    }
     void FixedUpdate()
    {
        playerRigidibody2D.MovePosition(playerRigidibody2D.position + playerDirection * speed * Time.fixedDeltaTime); 
    }
}
