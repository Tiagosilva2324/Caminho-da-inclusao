using UnityEngine;

public class Animation : MonoBehaviour
{
    public Animator playerAnimator;
    float input_x = 0;
    float input_y = 0;
    bool isWalking = false;
    public float speed;
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

        if (isWalking) { 
        var move = new Vector3(input_x, input_y, 0).normalized;
            transform.position += move * speed * Time.deltaTime;
            playerAnimator.SetFloat("input_x", input_x);
            playerAnimator.SetFloat("input_y", input_y);
        }
        playerAnimator.SetBool("isWalking", isWalking);
    }

}