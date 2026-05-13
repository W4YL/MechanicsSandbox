using UnityEngine;

public class ScarfPhysics : MonoBehaviour
{
    public Rigidbody2D rb;
    public Movement playerScript;
    public float dampeningMult;
    public float gravityScaleRatio;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.linearDamping = Mathf.Abs(rb.linearVelocityY) * dampeningMult;

        rb.gravityScale = 1 - (playerScript.transform.position.y - rb.position.y) * gravityScaleRatio * Mathf.Clamp(Mathf.Abs(playerScript.rb.linearVelocityX), 0, 1);
    }
}
