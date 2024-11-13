using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Raycaster : MonoBehaviour
{
    // Reference to the NavMeshAgent (the character that will move)
    public NavMeshAgent agent;

    // The maximum distance for the ray
    public float rayDistance = 100f;

    // The color of the ray (used for debugging in the scene)
    public Color rayColor = Color.red;

    void Update()
    {
        // Check if the Spacebar is pressed
        if (Input.GetKeyDown(KeyCode.Space))
        {
            FireRay();
        }
    }

    public void FireRay()
    {
        // Create the ray from the camera's position and direction
        Ray ray = new Ray(transform.position, transform.forward);

        RaycastHit hit;

        // Cast the ray to detect where it hits
        if (Physics.Raycast(ray, out hit, rayDistance))
        {
            // If the ray hits something, log the object name
            Debug.Log("Ray hit: " + hit.collider.gameObject.name);

            // Move the NavMeshAgent to the hit point
            MoveAgentToPoint(hit.point);
        }
        else
        {
            // If the ray doesn't hit anything, log that it missed
            Debug.Log("Ray did not hit anything.");
        }

        // Optionally, draw the ray in the Scene view for debugging
        Debug.DrawRay(ray.origin, ray.direction * rayDistance, rayColor, 0.1f); // Visible for 0.1s
    }

    void MoveAgentToPoint(Vector3 targetPosition)
    {
        // Move the NavMeshAgent to the target position
        if (agent != null)
        {
            agent.SetDestination(targetPosition);
        }
        else
        {
            Debug.LogWarning("NavMeshAgent is not assigned!");
        }
    }
}
