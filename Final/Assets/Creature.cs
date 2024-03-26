using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Creature : MonoBehaviour
{

    [Header("Stats")] 
    [SerializeField] int health = 3;
    [SerializeField] float speed = 10f;
    [SerializeField] float jumpForce = 20;

    [Header("Flavor")]
    [SerializeField] string creatureName = "cowboy16";
    [Header("Tracked Data")]
    [SerializeField] Vector3 homePosition = Vector3.zero;
    [SerializeField] int dJumpUnlock = 0;
    [SerializeField] public int dJumpnum = 0;
    
    [Header("Physics")]
    [SerializeField] LayerMask groundMask;
    [SerializeField] float jumpOffset = -.5f;
    [SerializeField] float jumpRadius = .25f;

    [SerializeField] public Rigidbody2D rb;
    [SerializeField] GameObject Checkpoint;
    [SerializeField] CreatureSO creatureSO;

    // Start is called before the first frame update
    void Start()
    {

        rb = GetComponent<Rigidbody2D>();
        if(creatureSO != null){
            if(creatureSO.doubleJump == 1){
                dJumpnum = 1;
            }
        }


    }

    // Update is called once per frame
    void Update()
    {
     if(Physics2D.OverlapCircleAll(transform.position + new Vector3(0,jumpOffset,0),0.5f,groundMask).Length > 0){
            dJumpnum = 1;
        }   
    }

    public void MoveCreature(Vector3 direction){
        Vector3 currentVel = new Vector3(0, rb.velocity.y, 0);
        rb.velocity = (currentVel) + (direction * speed);
        //rb.MovePosition(transform.position + (direction * speed * Time.deltaTime));
    }

    public void pickupcoin(){
        GetComponent<AudioSource>().Play();
        GameObject.Find("CoinCounter").GetComponent<CoinCounter>().CountCoin();
        
    }



    public void deathTrigger(){
        GameObject.Find("DeathCounter").GetComponent<DeathCounter>().CountDeath();
        Vector3 checkTest = Checkpoint.transform.position;
        transform.position = checkTest;
        //Vector3 spawn = new Vector3(Checkpoint.transform.position.x,Checkpoint.transform.position.y,0);
        //transform.position = spawn;
    }

    public void endGame(){
        
        GameObject.Find("TreasureCount").GetComponent<TreasureCount>().collectTreasure();
        
    }


    public void Jump(){
        if(Physics2D.OverlapCircleAll(transform.position + new Vector3(0,jumpOffset,0),0.5f,groundMask).Length > 0){
            rb.AddForce(Vector3.up * (jumpForce + 5), ForceMode2D.Impulse);
        }
    }

      public void JumpCall(float jumpForceCall){
        
        rb.AddForce(Vector3.up * jumpForceCall, ForceMode2D.Impulse);
        
    }

    public void DJump(){
        if(dJumpnum !=0){
        rb.AddForce(Vector3.up * (jumpForce + 5), ForceMode2D.Impulse);
        dJumpnum--;
        }
                       
    }
    
   

        

    

}
