using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyAI : MonoBehaviour  // old Enemy AI
{

    public NavMeshAgent agent;
    
    public Transform positon1;
    public Transform positon2;
    public Transform positon3;
    public Transform positon4;
    public Transform positon5;
    int destination;

    public Transform[] positions;


    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        destination = 0;

        agent.SetDestination(positions[destination].position);
        //agent.SetDestination(positon1.position);
    }

    // Update is called once per frame
    void Update()
    {
        //if (agent.transform.position.x == positon1.position.x && agent.transform.position.z == positon1.position.z)
        //{
        //    agent.SetDestination(positon2.position);
        //}
        //else if (agent.transform.position.x == positon2.position.x && agent.transform.position.z == positon2.position.z)
        //{
        //    agent.SetDestination(positon3.position);
        //}
        //else if (agent.transform.position.x == positon3.position.x && agent.transform.position.z == positon3.position.z)
        //{
        //    agent.SetDestination(positon4.position);
        //}
        //else if (agent.transform.position.x == positon4.position.x && agent.transform.position.z == positon4.position.z)
        //{
        //    agent.SetDestination(positon5.position);
        //}
        //else if (agent.transform.position.x == positon5.position.x && agent.transform.position.z == positon5.position.z)
        //{
        //    agent.SetDestination(positon1.position);
        //}

        //if (agent.transform.position.x == positions[destination].position.x && agent.transform.position.z == positions[destination].position.z)
        //{
        //    if (destination == 4)
        //    {
        //        destination = 0;
        //    }
        //    else
        //    {
        //        destination = destination + 1;
        //    }

        //    agent.SetDestination(positions[destination].position);
        //}




        if (agent.transform.position.x == positions[destination].position.x && agent.transform.position.z == positions[destination].position.z)
        {
            destination = Random.Range(0, 4);

            agent.SetDestination(positions[destination].position);
        }

    }


}
