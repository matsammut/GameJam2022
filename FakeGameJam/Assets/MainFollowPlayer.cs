 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainFollowPlayer : MonoBehaviour
{
    public GameObject target;
    public float EnemySpeed;
    Rigidbody2D rb;
    Vector2 moveDir;

    void Start(){
        rb = this.gameObject.GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if(target){
            Vector3 direction = (target.transform.position - transform.position).normalized;
            float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
            rb.rotation = angle;
            moveDir = direction;
        }
    }
    
    void FixedUpdate(){
        if(target){
            rb.velocity = new Vector2(moveDir.x, moveDir.y)*EnemySpeed;
        }
    }


    void OnCollisionEnter2D(Collision2D collision){
        if (collision.gameObject.tag == "Player"){
            Debug.Log("Hit");
            
        }
    }
}
