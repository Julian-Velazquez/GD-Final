using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressurePlate : MonoBehaviour
{

[SerializeField] GameObject[] puzzlePiecePrefab;
int[] arr = {2,0,3};

//x vals 2 0 -2
//y vals 3 1 -1

   void OnTriggerEnter2D(Collider2D other){

        if(other.GetComponent<Creature>() != null){
            gPuzzle(transform.position);
        }

    }
    void gPuzzle(Vector3 plate){

        switch(plate.x){
        case -3:
        arr[0]++;
        arr[1]++;
        break;
        
        case 0:
        arr[0]++;
        arr[1]++;
        arr[2]++;
        break;
        
        case 3:
        arr[1]++;
        arr[2]++;
        break;
        
         default:
         Debug.Log("ERROR: invalid x position of plates");
         break;
           
    }
    for(int i = 0; i < 3; i++){
        if(arr[i] > 3){
            arr[i] = 0;
        }
    }
    
    if(arr[0] == arr[1] && arr[1] == arr[2]){
        Debug.Log("puzzle solved");
    }
           
    

    }
    
    void spawnPuzzle(){
        
        
        ///GameObject newFloor = Instantiate(puzzlePiecePrefab,new Vector3(x,y,z),Quaternion.identity);
        
    
    }
}
