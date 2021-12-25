using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OutofBounce : MonoBehaviour
{
    //This code resets the Game if the player falls down / dies
    //If the Player falls down an touches this Object
    private void OnTriggerEnter2D(Collider2D other)
    {
        print ("GAMEOVER");
        //You get sent back to Level1 because you fell down and died
        SceneManager.LoadScene("Level1");
    }
}