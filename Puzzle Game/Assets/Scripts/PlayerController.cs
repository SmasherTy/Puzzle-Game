using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public static PlayerController Instance;
    
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private Animator animator;

    [SerializeField] private float moveSpeed;
    [SerializeField] private float runSpeed;
    public Vector3 playerMoveDirection;

    void Update()
    {
        float inputX = Input.GetAxisRaw("Horizontal");
        float inputY = Input.GetAxisRaw("Vertical");
        playerMoveDirection = new Vector3(inputX, inputY).normalized;

         bool isRunning = Input.GetKey(KeyCode.LeftShift);
        float currentSpeed = isRunning ? runSpeed : moveSpeed;

        rb.linearVelocity = playerMoveDirection * currentSpeed;

        animator.SetFloat("moveX", inputX);
        animator.SetFloat("moveY", inputY);
        animator.SetFloat("speed", rb.linearVelocity.magnitude);
        animator.SetBool("isRunning", isRunning);
        if (playerMoveDirection == Vector3.zero){
            animator.SetBool("moving", false);
        } else {
            animator.SetBool("moving", true);
        }
    }
    void FixedUpdate(){
        float currentSpeed = Input.GetKey(KeyCode.LeftShift) ? runSpeed : moveSpeed;
        rb.linearVelocity = new Vector2(playerMoveDirection.x * currentSpeed, playerMoveDirection.y * currentSpeed);
    }
}
