using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class END3 : MonoBehaviour
{ 
    //This code sends you to the next Level if you touch the END
    //When something touches the 3. End (This Object/Green Box)
    private void OnTriggerEnter2D(Collider2D other)
    {
       print ("GAMEOVER");
       //The scene switches to the Last Scene / "ENDOFGAME" so that you can play the last Level
       SceneManager.LoadScene("ENDOFGAME");
    }
}

