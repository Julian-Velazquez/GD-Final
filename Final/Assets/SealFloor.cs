using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SealFloor : MonoBehaviour
{ 
    [SerializeField] GameObject FloorPrefab;

    
    void OnTriggerEnter2D(Collider2D other){
           
        if(other.GetComponent<Creature>() != null){
            
            spawnFloor();
            
        
        }

    }

     public void spawnFloor(){
        
        GameObject newFloor = Instantiate(FloorPrefab,new Vector3(-7,-3,0),Quaternion.identity);
        
    }
}
