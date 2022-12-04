using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Epops : MonoBehaviour
{


    public GameObject popUpBox;
    public static Animator anim;
    [SerializeField] private static TMP_Text[] popUpText;
    private static TMP_Text output;
    public Text text;

    public static void popUp(bool type)
    {
        if (type == true)
        {
            output = popUpText[Random.Range(0, 6)];

        }
        else
        {
            output = popUpText[Random.Range(7, 13)];
        }

        anim.SetTrigger("up");


        float timeout = 5;
        timeout -= Time.deltaTime;

        anim.SetTrigger("down");
    }
}
