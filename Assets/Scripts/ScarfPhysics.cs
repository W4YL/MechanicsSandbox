using UnityEngine;

public class ScarfPhysics : MonoBehaviour
{
    public Movement playerScript;
    public Transform playerPos;
    public Rigidbody2D scarfEnd;

    public float scarfDrag;

    void Start()
    {
        
    }

    void Update()
    {
        if (!playerScript.IsGrounded())
        {
            scarfEnd.gravityScale -= (playerPos.transform.position.y - 5.494987f) * scarfDrag;
        }
    }
}
