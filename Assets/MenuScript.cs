using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    public void BacktoMain (){
   Debug.Log("Going to main menu...");
    SceneManager.LoadScene(0);
   }
}
