using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPatrol : MonoBehaviour
{
    Rigidbody2D rb;
    public float PatrolSpeed;
    bool Facing = true;

    void Start(){
        rb = GetComponent<Rigidbody2D>();
    }

    void Update(){
        
        if(Facing){
            rb.velocity = new Vector2(PatrolSpeed,0f);
        }
        else{
            rb.velocity = new Vector2(-PatrolSpeed,0f);
        }
    }
    // bool IsFacingRight(){   
    //     return transform.localScale.x > Mathf.Epsilon;
    // }

    void OnCollisionEnter2D(Collision2D  col){
        if(Facing){
            Facing=false;
        }
        else{
            Facing=true;
        }
    }
}
