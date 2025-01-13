using System.Runtime.InteropServices;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] public int movementSpeed;
    [SerializeField] SpriteRenderer spriteRenderer;
    [SerializeField] Animator animationController;
    [SerializeField] Rigidbody2D rigidBody;
    private void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(horizontalInput, 0, verticalInput) * movementSpeed * Time.deltaTime;
        transform.Translate(movement, Space.Self);
    }
}
