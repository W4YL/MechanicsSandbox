using UnityEngine;
using UnityEngine.InputSystem;

public class Movement : MonoBehaviour
{
    public Rigidbody2D rb;
    public Transform groundCheck;
    public LayerMask groundLayer;
    public float horizontal;

    public float speed;
    public float jumpPower;

    void Start()
    {
        
    }

    public void FixedUpdate()
    {
        rb.linearVelocityX = horizontal * speed;
    }

    void Jump()
    {
        rb.linearVelocityY = jumpPower;
    }

    public void OnMove(InputAction.CallbackContext context)
    {
        horizontal = context.ReadValue<Vector2>().x;
    }

    public void OnJump(InputAction.CallbackContext context)
    {
        if (context.performed && IsGrounded()) 
        {
            Jump();
        }
    }

    private bool IsGrounded()
    {
        return Physics2D.OverlapCircle(groundCheck.position, 0.1f, groundLayer);
    }
}
