using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TBDoor1 : MonoBehaviour
{
    [SerializeField] CreatureSO creature;
    void OnTriggerEnter2D(Collider2D other){

        if(other.GetComponent<Creature>() != null){
             SceneManager.LoadScene("Door1"); 
             creature.sceneLoad = "Ruin2";   
        }

    
      
    
    }

  
}
