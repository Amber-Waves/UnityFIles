using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Reset : MonoBehaviour
{
   
    public void RestartScene(){
     SceneManager.LoadScene("Level1");
     Debug.Log("Reset Scene...");
	}

}
