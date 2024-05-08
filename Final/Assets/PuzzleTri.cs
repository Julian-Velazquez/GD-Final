using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleTri : MonoBehaviour
{
    public List<GameObject> triangles = new List<GameObject>();
    public List<GameObject> trianglesList = new List<GameObject>();

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    void OnTriggerEnter2D(Collider2D other){

        if(other.gameObject.name == "Creature"){
        Debug.Log("TEST" + gameObject.name);
        trianglesList.Add(gameObject);
         if(trianglesList.Count == 3){
            Debug.Log("fiexe");
        }
        }
    }
}
