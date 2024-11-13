using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallCreator : MonoBehaviour
{
    public GameObject ball;
    public Transform hand;


    public void SpawnBall()
    {
        Instantiate(ball, hand.position, hand.rotation);
    }
}
