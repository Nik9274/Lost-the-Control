using UnityEngine;

public class textfollow : MonoBehaviour
{

    public Transform target;
    //Creates a Variable which will decide how fast the text will Move to the Player
    public float smoothSpeed = 0.125f;
    public Vector3 offset;

    void LateUpdate ()
    {
        //Calculates the new Next Position
        transform.position = target.position + offset;
    }


}