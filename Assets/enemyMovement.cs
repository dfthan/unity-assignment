using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class enemyMovement : MonoBehaviour
{
    NavMeshAgent enemyAgent;
    [SerializeField]
    Transform target;
    void Start()
    {
        enemyAgent = GetComponent<NavMeshAgent>();
    }
    void Update()
    {
        enemyAgent.SetDestination(target.position);
    }
}
