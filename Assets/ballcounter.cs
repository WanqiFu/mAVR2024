using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ballcounter : MonoBehaviour
{

    private int numberofballs;
    public TextMeshPro ballCounterText;
    private void OnTriggerEnter(Collider possibleball)
    {
        if (possibleball.gameObject.tag == "Ball")
        {
            numberofballs++;
            Destroy(possibleball.gameObject, 0.5f);
            Debug.Log("Ball Entered total balls = " + numberofballs);
            ballCounterText.text = "Balls:" + numberofballs;
            ballCounterText.color = new Color(
                Random.Range(0f, 1f),
                Random.Range(0f, 1f),
                Random.Range(0f, 1f));
        }
       
    }
}
