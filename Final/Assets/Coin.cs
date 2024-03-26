using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    
    void Update(){
        
    }


    void OnTriggerEnter2D(Collider2D other){

        if(other.GetComponent<Creature>() != null){
            other.GetComponent<Creature>().pickupcoin();
            Destroy(this.gameObject);
        }

    }


}
