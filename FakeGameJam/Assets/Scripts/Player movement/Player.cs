using System.Collections;
using System.Collections.Generic;
using UnityEngine;
<<<<<<< HEAD
using UnityEngine.UI;

=======
using UnityEngine.SceneManagement;
>>>>>>> main

public class Player : MonoBehaviour
{

  public int player_movement_speed ;
  public int player_jump_speed ;

  public int jump_charge_remaining = 1;
  public int max_jumps = 1;

  public int health = 5;

  private bool isGrounded;
  private string GROUND_TAG = "Ground";
  private string DamageTag = "Damage";
  private string WinTag = "Win";

  public GameObject Candle1;
  public GameObject Candle2;
  public GameObject Candle3;
  public GameObject Candle4;
  public GameObject Candle5;

  //Press to start
  private bool isStarted = false;
  public Text startText;
  private Rigidbody2D rb2d;


<<<<<<< HEAD
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
=======
  // Start is called before the first frame update
  void Start()
  {
    //rb = GetComponent<Rigidbody>();
    Candle1.SetActive(true);
    Candle2.SetActive(false);
    Candle3.SetActive(false);
    Candle4.SetActive(false);
    Candle5.SetActive(false);

  }

  // Update is called once per frame
  void Update()
  {
        if (Input.GetKey(KeyCode.D)) {
            transform.Translate(Vector3.right * Time.deltaTime * player_movement_speed);
        }

        if (Input.GetKey(KeyCode.A)) {
            transform.Translate(Vector3.left * Time.deltaTime * player_movement_speed);
        }


        if (jump_charge_remaining > 0) {
          if (Input.GetKeyDown(KeyCode.Space)) {
            jump_charge_remaining --;
            transform.Translate(Vector3.up * player_jump_speed);
          }
        }



        if (health == 0)
        {
          Destroy(this.gameObject);
          SceneManager.LoadScene("Defeat");
        }

        timer();
  }






   void OnCollisionEnter2D(Collision2D collision)
>>>>>>> main
    {

      if (collision.gameObject.CompareTag(GROUND_TAG))
          {
            jump_charge_remaining = max_jumps;
          }

      if (collision.gameObject.CompareTag(DamageTag)) {

        transform.Translate(Vector3.up * player_jump_speed * 2);
        health--;

      }
      if (collision.gameObject.CompareTag(WinTag)) {

        SceneManager.LoadScene("Victory");

      }
    }



public float timerPassed = 0f;
public int candleCharge = 0;
public int timeTillChange = 60;



 void timer()
 {
   timerPassed += Time.deltaTime;

   if (timerPassed > timeTillChange) {
     candleCharge++;
     timerPassed = 0f;
     candleSegment();
   }

 }



 void candleSegment()
 {
   if (candleCharge == 1) {
     health--;
     //Activate the corresponding segmeent
     //Number 2 enabled
     //number 1 disabled
     Candle1.SetActive(false);
     Candle2.SetActive(true);
     Candle3.SetActive(false);
     Candle4.SetActive(false);
     Candle5.SetActive(false);
   }
   else if (candleCharge == 2) {
      health--;
      //Activate the corresponding segmeent
      Candle1.SetActive(false);
      Candle2.SetActive(false);
      Candle3.SetActive(true);
      Candle4.SetActive(false);
      Candle5.SetActive(false);
    }
    else if (candleCharge == 3) {
     health--;
     //Activate the corresponding segmeent
     Candle1.SetActive(false);
     Candle2.SetActive(false);
     Candle3.SetActive(false);
     Candle4.SetActive(true);
     Candle5.SetActive(false);
    }
    else if (candleCharge == 4) {
      health--;
      //Activate the corresponding segmeent
      Candle1.SetActive(false);
      Candle2.SetActive(false);
      Candle3.SetActive(false);
      Candle4.SetActive(false);
      Candle5.SetActive(true);
    }
    else if (candleCharge == 5) {
       health--;
       //Game over
     }
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
<<<<<<< HEAD
    }*/
=======
    }*/
>>>>>>> main
