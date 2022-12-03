using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Player : MonoBehaviour
{

  public int player_movement_speed ;
  public int player_jump_speed ;

  public int jump_charge_remaining = 1;
  public int max_jumps = 1;

  public int health = 3;

  private bool isGrounded;
  private string GROUND_TAG = "Ground";

  //Press to start
  private bool isStarted = false;
  public Text startText;
  private Rigidbody2D rb2d;


    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 0f;
    }

    // Update is called once per frame
    void Update()
    {

        //Press to start
        if (Input.GetMouseButtonDown(0) && isStarted == false)
        {
            Time.timeScale = 1f;
            startText.gameObject.SetActive(false);

        }
        //-------------------------------------------------------------------------------------------------------------

            if (Input.GetKey(KeyCode.D))
            {
                transform.Translate(Vector3.right * Time.deltaTime * player_movement_speed);
            }

            if (Input.GetKey(KeyCode.A))
            {
                transform.Translate(Vector3.left * Time.deltaTime * player_movement_speed);
            }

            if (jump_charge_remaining > 0 && isGrounded)
            {
                if (Input.GetKeyDown(KeyCode.Space))
                {
                    isGrounded = false;
                    transform.Translate(Vector3.up * player_jump_speed);


                }

            }

            if (health == 0)
            {
                Destroy(this.gameObject);
            }
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

      if (collision.gameObject.CompareTag(GROUND_TAG)) 
          isGrounded = true;
    }
}





/*
    void OnCollisionEnter(Collision collision)
    {
      if (collision.gameObject.tag == "ground")
       {
           //If the GameObject has the same tag as specified, output this message in the console
           Debug.Log("Do something else here");
           jump_charge_remaining = max_jumps;
       }
       if (collision.gameObject.tag == "powerup_jump")
        {
            //If the GameObject has the same tag as specified, output this message in the console
            Debug.Log("Do something else here");
            max_jumps++;
            jump_charge_remaining = max_jumps;
        }
        if (collision.gameObject.tag == "enemy")
         {
             //If the GameObject has the same tag as specified, output this message in the console
             Debug.Log("Do something else here");
             health--;
         }
    }*/