using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public static PlayerController Instance;
    
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private Animator animator;

    [SerializeField] private float moveSpeed;
    public Vector3 playerMoveDirection;
    void Update()
    {
        float inputX = Input.GetAxisRaw("Horizontal");
        float inputY = Input.GetAxisRaw("Vertical");
        playerMoveDirection = new Vector3(inputX, inputY).normalized;

        rb.linearVelocity = playerMoveDirection * moveSpeed;
        animator.SetFloat("moveX", inputX);
        animator.SetFloat("moveY", inputY);
        if (playerMoveDirection == Vector3.zero){
            animator.SetBool("moving", false);
        } else {
            animator.SetBool("moving", true);
        }
    }
}
