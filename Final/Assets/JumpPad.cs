using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpPad : MonoBehaviour
{
    public void OnTriggerEnter2D(Collider2D other){
       
        other.GetComponent<Creature>().JumpCall(25);
    }

    //void OnTriggerExit2D(Collider2D other){
    
    //}

}
