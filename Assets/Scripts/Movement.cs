using UnityEngine;
using UnityEngine.InputSystem;

public class Movement : MonoBehaviour
{
    public Rigidbody2D rb;
    public Transform groundCheck;
    public LayerMask groundLayer;
    public float moveInput;

    public float moveSpeed;
    public float moveAcceleration;
    public float moveDeceleration;

    public float jumpPower;

    void Start()
    {
        
    }

    public void FixedUpdate()
    {
        float targetSpeed = moveInput * moveSpeed;
        float speedDifference = targetSpeed - rb.linearVelocityX;
        float AccelRate = (Mathf.Abs(rb.linearVelocityX) > 0.01f) ? moveAcceleration : moveDeceleration;
        float movement = speedDifference * AccelRate;

        rb.AddForce(movement * Vector2.right);
        
    }

    void Jump()
    {
        rb.linearVelocityY = jumpPower;
    }

    public void OnMove(InputAction.CallbackContext context)
    {
        moveInput = context.ReadValue<Vector2>().x;
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
