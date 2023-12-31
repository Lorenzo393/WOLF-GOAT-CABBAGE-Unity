using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class End_Middle_Platform_Controller : MonoBehaviour
{
    public GameObject scripter;    
    private void OnCollisionEnter(Collision collision){
        if(collision.gameObject.CompareTag("Player")){
            scripter.GetComponent<Win_Or_Lose>().player_midend = true;
        }
        if(collision.gameObject.CompareTag("Wolf")){
            scripter.GetComponent<Win_Or_Lose>().wolf_midend = true;
        }
        if(collision.gameObject.CompareTag("Goat")){
            scripter.GetComponent<Win_Or_Lose>().goat_midend = true;
        }
        if(collision.gameObject.CompareTag("Cabbage")){
           scripter.GetComponent<Win_Or_Lose>().cabbage_midend = true;
        }
    }
    private void OnCollisionExit(Collision collision){
        if(collision.gameObject.CompareTag("Player")){
            scripter.GetComponent<Win_Or_Lose>().player_midend = false;
        }
        if(collision.gameObject.CompareTag("Wolf")){
            scripter.GetComponent<Win_Or_Lose>().wolf_midend = false;
        }
        if(collision.gameObject.CompareTag("Goat")){
            scripter.GetComponent<Win_Or_Lose>().goat_midend = false;
        }
        if(collision.gameObject.CompareTag("Cabbage")){
            scripter.GetComponent<Win_Or_Lose>().cabbage_midend = false;
        }
    }
}
