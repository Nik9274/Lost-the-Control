using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    // define how fast the Camera will move to the Object
    public float smoothSpeed = 0.125f;
    public Vector3 offset;

    //FixedUpdate is called at a fixed interval
    void FixedUpdate ()
    {
        //Calculates the new Camera Position
        Vector3 desiredPosition = target.position + offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        transform.position = smoothedPosition;
    }
}

