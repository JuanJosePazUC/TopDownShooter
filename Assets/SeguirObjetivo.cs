using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class SeguirObjetivo : MonoBehaviour
{
    [SerializeField] private Transform objetivo;
    [SerializeField] private NavMeshSurface2d navMeshSurface2D;
    private NavMeshAgent navMeshAgent;

    private void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
        navMeshAgent.updateRotation = false;
        navMeshAgent.updateUpAxis = false;
    }

    private void Update()
    {
        navMeshAgent.SetDestination(objetivo.position);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            navMeshSurface2D.BuildNavMeshAsync();
        }
    }
}
