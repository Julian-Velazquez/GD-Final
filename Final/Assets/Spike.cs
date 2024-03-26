using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Spike : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other){

        if(other.GetComponent<Creature>() != null){
            other.GetComponent<Creature>().deathTrigger();
            GetComponent<SpriteRenderer>().color = Color.red;
        }

    }
}
