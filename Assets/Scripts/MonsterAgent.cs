using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class MonsterAgent : MonoBehaviour
{
    private NavMeshAgent agentMonster;
    private MonsterWayPoint[] waypoints;

    [SerializeField]
    private Animator animator;

    // Will give us a random waypoint in the array as a variable everytime I access it
    private MonsterWayPoint RandomPoint => waypoints[Random.Range(0, waypoints.Length)];

    // Start is called before the first frame update
    void Start()
    {
        agentMonster = gameObject.GetComponent<NavMeshAgent>();
        // FindObjectsOfType gets every instance of this component in the scene
        waypoints = FindObjectsOfType<MonsterWayPoint>();
    }

    // Update is called once per frame
    void Update()
    {
        animator.SetBool("Run", !agentMonster.pathPending && agentMonster.remainingDistance > 0.1f);
        // Has the agent reached it's position?
        if (!agentMonster.pathPending && agentMonster.remainingDistance < 0.1f)
        {
            // Tell the agent to move to a random position in the scene waypoints
            agentMonster.SetDestination(RandomPoint.Position);
        }
    }
}
