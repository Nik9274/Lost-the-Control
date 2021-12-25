using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class END2 : MonoBehaviour
{ 
    //This code sends you to the next Level if you touch the END
    //When something touches the 2. End (This Object/Green Box)
    private void OnTriggerEnter2D(Collider2D other)
    {
       print ("GAMEOVER");
       //The scene gets switched to "Level3" so that you can proceed into the next Level
       SceneManager.LoadScene("Level3");
    }
}

