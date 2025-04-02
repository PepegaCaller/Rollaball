using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class EnemyMovement : MonoBehaviour
{
    private NavMeshAgent navMeshAgent;

    public Transform player;

    void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
    }

 
    void Update()
    {
        if (player != null)
        {
            navMeshAgent.SetDestination(player.position);
        }
    }
}
