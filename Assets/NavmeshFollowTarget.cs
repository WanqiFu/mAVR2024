using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class NavmeshFollowTarget : MonoBehaviour
{
    // Start is called before the first frame update
    NavMeshAgent agent;
    public Transform target;
    public Transform home;
    public Animator animator;
    public float minimumdistance = 10f;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(target.position, transform.position) < minimumdistance)
        {
            agent.SetDestination(target.position);

        }
        else { 

            agent.SetDestination(home.position);
        }

        animator.SetFloat("Speed", agent.velocity.magnitude);
    }       
}
