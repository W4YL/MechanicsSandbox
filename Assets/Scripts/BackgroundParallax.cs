using UnityEngine;

public class BackgroundParallax : MonoBehaviour
{
    public Camera cameraObject;

    public float parallaxValue;
    public float cloudSpeed;

    float cloudMovement;

    Vector2 newPos;

    void Start()
    {
        newPos = transform.position;
    }

    void Update()
    {
        cloudMovement -= Time.deltaTime * cloudSpeed;

        if (cloudMovement <= -77.5f)
        {
            cloudMovement = 0;
        }

        newPos.x = cameraObject.transform.position.x * parallaxValue + cloudMovement;
        transform.position = newPos;
    }
}