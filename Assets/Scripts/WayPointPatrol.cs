using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class WayPointPatrol : MonoBehaviour
{

    public NavMeshAgent navMeshAgent;
    public Transform[] waypoints;

    int m_CurrentWaypointsIndex;

    void Start()
    {
        navMeshAgent.SetDestination(waypoints[0].position);
    }

    
    void Update()
    {
        if (navMeshAgent.remainingDistance < navMeshAgent.stoppingDistance)
        {
            m_CurrentWaypointsIndex = (m_CurrentWaypointsIndex + 1) % waypoints.Length;
            navMeshAgent.SetDestination(waypoints[m_CurrentWaypointsIndex].position);
        }
    }
}
