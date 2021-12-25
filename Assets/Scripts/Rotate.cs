using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    //Creates a variable, which will decide how fast the Platform will be rotating
	float speed = 30.0f;
    //Creates a variable which is later used to decide if you can rotate the Platform or not
    bool TOUCHED = false;

    //Unused Code for Mobile Version
    //float screenWidth = 1080;
	
    //This Code sets the TOUCHED Bool to true or false depending on if you are touching the platform
    // If an object touches and keeps touching the Platform
    private void OnTriggerEnter2D(Collider2D other)
    {
        print ("TOUCHED");
        //Then the TOUCHED variable / Bool gets set to true
        TOUCHED = true;
    }

    //If an object stops touching the Platform
    private void OnTriggerExit2D(Collider2D other)
    {
        print ("Exit");
        //Then the TOUCHED variable / Bool gets set to false
        TOUCHED = false;
    }

    //This code rotates the platform to the left or right if you press either UP or DOWN
    //Void Update is called every Frame
    void Update ()
    {
        //If the TOUCHED Variable / Bool is currently true
        if (TOUCHED == true)
        {
                //Then check if the UP key is pressed
                if (Input.GetKey("up"))
                {   
                    //If it is then rotate the Platform to the right
                    transform.Rotate(Vector3.back * speed * Time.deltaTime);
                    print("BACK");
                }
                //Afterwards check if the DOWN key is pressed
                if (Input.GetKey("down"))
                {
                    //If it is then rotate the Platform to the left
                    transform.Rotate(Vector3.forward * speed * Time.deltaTime);
                    print("Forward");
                }
            
        }
    }

}

    //Unused Code for Mobile Version of the Game
    //void Update ()
    //{
    //    if (TOUCHED == true)
    //    {
    //    if(Input.touchCount > 0)
    //    {
    //        Touch touch = Input.GetTouch(0);        
    //            if (touch.position.x < screenWidth / 2)
    //            {
    //                transform.Rotate(Vector3.forward * speed * Time.deltaTime);
    //                print("FORWARD");
    //            }
    //            if (touch.position.x > screenWidth / 2)
    //            {
    //                transform.Rotate(Vector3.back * speed * Time.deltaTime);
    //                print("BACK");
    //            }
    //        }
    //    }
    //}
    //}
