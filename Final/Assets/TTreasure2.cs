using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TTreasure2 : MonoBehaviour
{
    [SerializeField] CreatureSO creature;
    void OnTriggerEnter2D(Collider2D other){

        if(other.GetComponent<Creature>() != null){
             SceneManager.LoadScene("Treasure2"); 
             creature.sceneLoad = "Door1";   
        }

    
      
    
    }

  
}