using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CSRuin2 : MonoBehaviour
{
    [SerializeField] CreatureSO creatureSO;
    [SerializeField] Creature creature;
    [SerializeField] GameObject checkpoint;
    // Start is called before the first frame update
    void Start()
    {
       if(creatureSO.sceneLoad == "Puzzle2"){
            creature.transform.position = new Vector3(7,1,0);
            checkpoint.transform.position = new Vector3(7,1,0);
       }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}