using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneTransistor : MonoBehaviour
{
[SerializeField] CreatureSO creature;
    void OnTriggerEnter2D(Collider2D other){

        if(other.GetComponent<Creature>() != null){
             SceneManager.LoadScene("Ruin1"); 
             creature.sceneLoad = "Ruin1"; 
        }

    
      
    
    }

  
}
