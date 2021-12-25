using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Debug : MonoBehaviour
{   
    //Void Update is called every frame
    void Update()
    {
        //If the Button "G" is pressed
        if (Input.GetKey("g"))
            {
                print("DEBUG");
                //Then the scene "DebugMenu" is Loaded, where you are able to choose between the 3 different levels without playing
                SceneManager.LoadScene("DebugMenu");
            }
    }
}
