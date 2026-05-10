using UnityEngine;

public class BackgroundParallax : MonoBehaviour
{
    public Camera cameraObject;

    public float parallaxValue;
    public float cloudSpeed;

    float cloudMovement;
    float parallaxMult;

    void Start()
    {

    }

    void FixedUpdate()
    {
        cloudMovement -= Time.deltaTime * cloudSpeed;
        parallaxMult = parallaxValue * 0.0625f;

        if (cloudMovement <= -77.5f)
        {
            cloudMovement = 0;
        }

        transform.position = new Vector2(cameraObject.transform.position.x * parallaxMult + cloudMovement, transform.position.y);
    }
}