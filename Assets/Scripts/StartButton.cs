using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//This code makes UI Buttons function in menus
public class StartButton : MonoBehaviour
{
   //If the button is pressed
   public void LoadScene(string sceneName)
   {   
       //Then Load the scene
       SceneManager.LoadScene(sceneName);
       //Also start the Timer
       bool isRunning = true;
   }

}
