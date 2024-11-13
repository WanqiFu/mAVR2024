using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChangeOnCollision : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        // Check if the object that collided with this GameObject has the tag "VRHand"
        if (collision.gameObject.CompareTag("VRHand"))
        {
            // Change the color of the cube to a random color
            Color randomColor = new Color(Random.value, Random.value, Random.value);
            GetComponent<Renderer>().material.color = randomColor;
        }
    }
}
