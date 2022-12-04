using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObject : MonoBehaviour
{
    private string PlayerTag = "Player";
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
     void OnCollisionEnter2D(Collision2D collision)
    {

      if (collision.gameObject.CompareTag(PlayerTag))
          {
            Debug.Log("Player");
        	Destroy(this.gameObject);
          }
    }
}
