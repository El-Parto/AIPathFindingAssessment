using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class AgentMaxwell : MonoBehaviour
{
    private NavMeshAgent agentMax;
    private Waypoints[] waypoints;

    // Will give us a random waypoint in the array as a variable everytime I access it
    private Waypoints RandomPoint => waypoints[Random.Range(0, waypoints.Length)];

    // Start is called before the first frame update
    void Start()
    {
        agentMax = gameObject.GetComponent<NavMeshAgent>();
        // FindObjectsOfType gets every instance of this component in the scene
        waypoints = FindObjectsOfType<Waypoints>();
    }

    // Update is called once per frame
    void Update()
    {
        // Has the agent reached it's position?
        if (!agentMax.pathPending && agentMax.remainingDistance < 0.1f)
        {
            // Tell the agent to move to a random position in the scene waypoints
            agentMax.SetDestination(RandomPoint.Position);
        }
    }
}