using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{   
    public static bool  GamePaused = false;

    public GameObject PauseMenuUI;

    // Update is called once per frame
    void Update()
    //This code resumes the game if it's paused and pauses it if it is running after Pressing ESC
    {
        //If the ESC button is pressed
        if (Input.GetKeyDown(KeyCode.Escape)) 
       {
           //And if the Game is currently Paused
           if (GamePaused)
           {
               //Then Resume the game
               Resume();
           } else
           {   //If it is not Paused then Pause it
               PauseGame();
           }
       } 
    }
    //This Code decides what happens after the Game is Resumed or Paused
    public void Resume ()
    {   //Make the Pause UI invisible
        PauseMenuUI.SetActive(false);
        //Unfreezes / Unpauses the Time / Game
        Time.timeScale =  1f;
        //Sets the GamePaused variable / Bool to false
        GamePaused = false;
    }
    void PauseGame ()
    {
        //Make the Pause UI visible
        PauseMenuUI.SetActive(true);
        //Freezes / Pauses the Time / Game
        Time.timeScale =  0f;
        //Sets the GamePaused variable / Bool to true
        GamePaused = true;
    }

}
