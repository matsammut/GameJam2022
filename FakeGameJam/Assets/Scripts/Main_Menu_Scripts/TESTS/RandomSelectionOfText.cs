using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RandomSelectionOfText : MonoBehaviour
{
  string[] quotes = new string[] {"Mental health… is not a destination, but a process.", "Happiness can be found even in the darkest of times, if one only remembers to turn on the light.",
  "Not until we are lost do we begin to understand ourselves.", "You, yourself, as much as anybody in the entire universe, deserve your love and affection.",
  "Being able to be your true self is one of the strongest components of good mental health.", "The truth may be out there, but the lies are inside your head.",
  "Even if we don’t have the power to choose where we come from, we can still choose where we go from there.", "I am not afraid of storms for I am learning how to sail my ship.",
  "I am not afraid of storms for I am learning how to sail my ship.", "Life doesn’t make any sense without interdependence. We need each other, and the sooner we learn that, the better for us all.",
  "Your present circumstances don’t determine where you go; they merely determine where you start.", "There is a crack in everything, that’s how the light gets in"};

  public string QouteToDisplay;

    // Start is called before the first frame update
    void Start()
    {
       QouteToDisplay = quotes[Random.Range(0,quotes.Length)];
    }

    // Update is called once per frame
    void Update()
    {
    }
    // public void SetText(string QouteToDisplay) {
    //     myText.text = text;
    // }
}
