using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CSTreasure1 : MonoBehaviour
{
    [SerializeField] CreatureSO creatureSO;
    [SerializeField] Creature creature;
    // Start is called before the first frame update
    void Start()
    {
       if(creatureSO.sceneLoad == "Door1"){
            creature.transform.position = new Vector3(8,1,0);
            
       }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
