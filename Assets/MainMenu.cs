﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
   public void PlayGame (){
   Debug.Log("Starting game...");
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
   }

   public void Quit(){
       Debug.Log ("quitting game...");
       Application.Quit();
   }
}