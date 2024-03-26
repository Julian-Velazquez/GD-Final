using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class TreasureTrans : MonoBehaviour
{
    [SerializeField] CreatureSO creatureSO;

   void OnTriggerEnter2D(Collider2D other){

        if(other.GetComponent<Creature>() != null){
            creatureSO.doubleJump = 1;
             SceneManager.LoadScene("Treasure1"); 
        }

    
      
    
    }
}
