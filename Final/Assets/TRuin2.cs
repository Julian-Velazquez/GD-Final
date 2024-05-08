using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TRuin2 : MonoBehaviour
{
    [SerializeField] CreatureSO creature;
    void OnTriggerEnter2D(Collider2D other){

        if(other.GetComponent<Creature>() != null){
             SceneManager.LoadScene("Ruin2"); 
             creature.sceneLoad = "Door1";   
        }

    
      
    
    }

  
}
