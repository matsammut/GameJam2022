using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


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
  private string healTag = "Heal";
  private string BirdTag = "Bird";

  public GameObject Candle1;
  public GameObject Candle2;
  public GameObject Candle3;
  public GameObject Candle4;
  public GameObject Candle5;

  public GameObject BirdAsset;

  //Press to start
  private bool isStarted = false;
  public Text startText;
  private Rigidbody2D rb2d;
  public bool isWalking = false;
  public bool h;

  public bool isJumping = false;
  // private string JUMP_ANIMATION = "jump";
  private float movementY;

  private Animator anim;
  private string WALK_ANIMATION = "Walk";
  private float movementX;

  private Rigidbody2D myBody;

  private SpriteRenderer sr;

  public Renderer rend;
  
  private void Awake()
    {

        
        anim = GetComponent<Animator>();

        sr = GetComponent<SpriteRenderer>();

    }
    // Start is called before the first frame update
    void Start()
    {
        rb2d = this.gameObject.GetComponent<Rigidbody2D>();
        jump_charge_remaining = 0;
        Time.timeScale = 0f;
        Candle1.SetActive(true);
        Candle2.SetActive(false);
        Candle3.SetActive(false);
        Candle4.SetActive(false);
        Candle5.SetActive(false);

        rend = BirdAsset.GetComponent<Renderer>();
        // rend.enabled = false;
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

            // if (Input.GetKey(KeyCode.D))
            // {
            //   //movementX = Input.GetAxisRaw("Horizontal");
            //   transform.Translate(Vector3.right * Time.deltaTime * player_movement_speed);
            //   //AnimatePlayer();
            // }

            // if (Input.GetKey(KeyCode.A))
            // {
            //   //movementX = Input.GetAxisRaw("Horizontal");
            //   transform.Translate(Vector3.left * Time.deltaTime * player_movement_speed);
            //   //AnimatePlayer();
            // }

            // if (jump_charge_remaining > 0 && isGrounded)
            // {
            //     if (Input.GetKeyDown(KeyCode.Space))
            //     {
            //         isGrounded = false;
            //         transform.Translate(Vector3.up * player_jump_speed);


            //     }

            // }



            movementX = Input.GetAxisRaw("Horizontal");
            movementY = Input.GetAxisRaw("Vertical");
            if (Input.GetKey(KeyCode.D)) {
                transform.Translate(Vector3.right * Time.deltaTime * player_movement_speed);
                isWalking = true;
                transform.localScale = new Vector3(0.4f,0.4f,0.4f);
            }

            if (Input.GetKey(KeyCode.A)) {
                transform.Translate(Vector3.left * Time.deltaTime * player_movement_speed);
                isWalking =true;
               
                transform.localScale = new Vector3(-0.4f,0.4f,0.4f);
            }

            


            if (jump_charge_remaining > 0) {
              if (Input.GetKeyDown(KeyCode.Space)) {
                jump_charge_remaining --;
                rb2d.AddForce(Vector2.up*player_jump_speed, ForceMode2D.Impulse);
                anim.SetTrigger("jump");
              }
            }
            //anim.SetBool(JUMP_ANIMATION, false);

            AnimatePlayer();

          // isWalking = false;
            timer();

    }

  // Start is called before the first frame update

IEnumerator DieCoroutine()
    {
        anim.SetTrigger("die");
        Debug.Log("Waiting");
        yield return new WaitForSecondsRealtime(4);
        SceneManager.LoadScene("Defeat");

    }

  void gameOverLoose()
  {
      //  anim.SetTrigger("die");
      StartCoroutine(DieCoroutine());
      // Destroy(this.gameObject);
      
  }


  // Update is called once per frame

  void AnimatePlayer() {
        // we are going to the right side
        if (movementX > 0)
        {
            anim.SetBool(WALK_ANIMATION, true);
            sr.flipX = false;
        }
        else if (movementX < 0)
        {
            // we are going to the left side
            anim.SetBool(WALK_ANIMATION, true);
        }
        else 
        {
            Debug.Log("False");
            anim.SetBool(WALK_ANIMATION, false);
        }


    }





   void OnCollisionEnter2D(Collision2D collision)
    {

      if (collision.gameObject.CompareTag(GROUND_TAG))
          {
            Debug.Log("Ground");
            jump_charge_remaining = max_jumps;
          }

      if (collision.gameObject.CompareTag(DamageTag)) {
        Debug.Log("Damage");
        rb2d.AddForce(Vector2.up*player_jump_speed/5, ForceMode2D.Impulse);
        candleCharge++;
        candleSegment();

      }
      if (collision.gameObject.CompareTag(WinTag)) {
        Debug.Log("Win");
        SceneManager.LoadScene("Victory");

      }
      if (collision.gameObject.CompareTag(healTag)) {
        Debug.Log("heal");
        health++;
        candleCharge--;
        candlehealSegment();

      }

      if (collision.gameObject.CompareTag(BirdTag)) {
        Debug.Log("Bird");
        BirdAsset.SetActive(false);

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
    else if (candleCharge >= 5) {
       health--;
       gameOverLoose();
       //Game over
     }
 }


  void candlehealSegment()
 {
   if (candleCharge == 1) {
    //  health--;
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
      // health--;
      //Activate the corresponding segmeent
      Candle1.SetActive(false);
      Candle2.SetActive(false);
      Candle3.SetActive(true);
      Candle4.SetActive(false);
      Candle5.SetActive(false);
    }
    else if (candleCharge == 3) {
    //  health--;
     //Activate the corresponding segmeent
     Candle1.SetActive(false);
     Candle2.SetActive(false);
     Candle3.SetActive(false);
     Candle4.SetActive(true);
     Candle5.SetActive(false);
    }
    else if (candleCharge == 4) {
      // health--;
      //Activate the corresponding segmeent
      Candle1.SetActive(false);
      Candle2.SetActive(false);
      Candle3.SetActive(false);
      Candle4.SetActive(false);
      Candle5.SetActive(true);
    }
      else if (candleCharge == 0) {
      // health--;
      //Activate the corresponding segmeent
      Candle1.SetActive(true);
      Candle2.SetActive(false);
      Candle3.SetActive(false);
      Candle4.SetActive(false);
      Candle5.SetActive(false);
    }
    else
    {
      candleCharge = 0;
    }
 }






}
