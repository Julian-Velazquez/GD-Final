using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PuzzleTrans : MonoBehaviour
{
   void OnTriggerEnter2D(Collider2D other){

        if(other.GetComponent<Creature>() != null){
             SceneManager.LoadScene("Puzzle1"); 
        }

    
      
    
    }

}
