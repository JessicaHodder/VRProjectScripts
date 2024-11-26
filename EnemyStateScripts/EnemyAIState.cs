using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyAIState : MonoBehaviour
{

    public NavMeshAgent agent;

    public Transform positon1;
    public Transform positon2;
    public Transform positon3;
    public Transform positon4;
    public Transform positon5;
    int destination;

    public Transform[] positions;  // array of transforms


    public GameObject target;


    // Start is called before the first frame update




    private void Awake()
    {
        agent = GetComponent<NavMeshAgent>();  //sets navmesh
        destination = 0;

        agent.SetDestination(positions[destination].position);  // initiates wandering
        InitalizeStateMachine();   // initalizes state machine
    }

    private void InitalizeStateMachine()  // set states
    {
        //Dictionary<Type, EnemyBaseState> states = new Dictionary<Type, EnemyBaseState>();
        Dictionary<Type, EnemyBaseState> states = new Dictionary<Type, EnemyBaseState>();

        states.Add(typeof(WanderState), new WanderState(this));
        states.Add(typeof(ExamenState), new ExamenState(this));
        states.Add(typeof(AttackState), new AttackState(this));

        GetComponent<EnemyStateMachine>().SetStates(states);

    }

    public void Wander()  // wander state
    {
        if (agent.transform.position.x == positions[destination].position.x && agent.transform.position.z == positions[destination].position.z)  // if enemy reaches destination
        {
            destination = UnityEngine.Random.Range(0, positions.Length);  // randomized from the array

            agent.SetDestination(positions[destination].position);  // sets destination
        }
    }

    public void Examen()  // examen state
    {
        agent.isStopped = true;  // stop agent
        transform.LookAt(target.transform);  // looks at player
    }

    public void Attack()  // attack state
    {
        agent.isStopped = false;  // resumes navmesh
        agent.speed = 30;  // increase speed
        agent.SetDestination(target.transform.position);  // set destination to player

        float agentx = Mathf.Round(agent.transform.position.x * 10.0f) * 0.1f;  // rounds value to account for player movement
        float agentz = Mathf.Round(agent.transform.position.z * 10.0f) * 0.1f;

        float playerx = Mathf.Round(target.transform.position.x * 10.0f) * 0.1f;
        float playerz = Mathf.Round(target.transform.position.z * 10.0f) * 0.1f;

        print(agentx + "," + playerx + "     " + agentz + "," + playerz);

        if (agentx == playerx && agentz == playerz)
        {
            Debug.Log("Killed");
            GameControllerScript.b_playerDead = true;  // passes status to game controller
        }

    }


}
