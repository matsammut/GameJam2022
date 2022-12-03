using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Flash : MonoBehaviour
{

    Image SPR;
    
    void Start()
    {
        SPR = this.gameObject.GetComponent<Image>();
    }
    // Update is called once per frame
    void Update()
    {
        StartCoroutine(FlashLights());
    }

    IEnumerator FlashLights()
    {
        SPR.color = new Color(1f,1f,1f,0f);

        yield return new WaitForSeconds(2);

        SPR.color = new Color(1f, 1f, 1f, 0.6f);
    }
}
