using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    [SerializeField] Creature player;
    [SerializeField] CreatureSO creatureSO;

    int dJump = 0;
    int jumpNum = 0;
    // Update is called once per frame
    void Update()
    {

        if(creatureSO != null){
          dJump = creatureSO.doubleJump;
        }
        jumpNum = player.dJumpnum;
        Vector3 input = Vector3.zero;

        //if(Input.GetKey(KeyCode.W)){
          //  input.y += 1;
        //}
        //if(Input.GetKey(KeyCode.S)){
          //  input.y += -1;
        //}
        if(Input.GetKey(KeyCode.A)){
            input.x += -1;
        }
        if(Input.GetKey(KeyCode.D)){
            input.x += 1;
        }
        if(Input.GetKeyDown(KeyCode.Space)){
          player.Jump();
          
          
        }
        if(Input.GetKeyDown(KeyCode.E)){
          if(dJump == 1 && jumpNum != 0){
          player.DJump();
          jumpNum--;
          }
        }

        player.MoveCreature(input);
        
        
    }



}
