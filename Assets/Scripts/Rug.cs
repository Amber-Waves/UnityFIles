 using System.Collections;
 using System.Collections.Generic;
 using UnityEngine;
 using UnityEngine.UI;
 
 public class Timer : MonoBehaviour
 {
     public Text counterText;
     public bool TimerOn;
     
 
     public float seconds, minutes;
 
     void Start()
     {
         TimerOn = false;
         Text counterText = GetComponent<Text>();
         counterText = GetComponent<Text>() as Text;
     }
 
     void Update()
     {
         if (TimerOn = true)
         {
 
             seconds = (int)(Time.time % 60f);
             counterText.text = seconds.ToString("0");
         }
     }
 
     void OnCollisionEnter2D(Collision2D col)
     {
 
         if (col.gameObject.tag == "Player")
         {
             TimerOn = false;
         }
     }
 
 }