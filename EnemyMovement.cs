using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyMovement : MonoBehaviour
{

    public NavMeshAgent agent;
    public Transform position1;
    public Transform position2;
    public Transform position3;
    public Transform position4;
    Vector3 destination;

    //int currentDestination;


    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        destination = agent.destination;
        //currentDestination = 1;
        agent.SetDestination(position1.position);
    }

    // Update is called once per frame
    void Update()
    {
        //if (currentDestination == 1)
        //{


        //    if (Vector3.Distance(destination, position1.position) > 1.0f)
        //    {
        //        Debug.Log(Vector3.Distance(destination, position1.position));
        //        destination = position1.position;
        //        agent.destination = destination;
        //        //Debug.Log(destination);
        //    }
        //    else
        //    {
        //        Debug.Log(Vector3.Distance(destination, position1.position));
        //        currentDestination = 2;
        //        //Debug.Log("Else Hit");
        //    }
        //}
        //else if (currentDestination == 2)
        //{
        //    if (Vector3.Distance(destination, position2.position) > 1.0f)
        //    {
        //        destination = position2.position;
        //        agent.destination = destination;
        //        //Debug.Log(destination);
        //    }
        //    else
        //    {
        //        currentDestination = 1;
        //        //Debug.Log("Other Else Hit");
        //    }
        //}


        //if (Vector3.Distance(destination, position1.position) > 1.0f)
        //{
        //    destination = position1.position;
        //    agent.destination = destination;
        //}

        if (agent.transform.position.x == position1.position.x && agent.transform.position.z == position1.position.z)
        {
            agent.SetDestination(position2.position);
        }
        else if (agent.transform.position.x == position2.position.x && agent.transform.position.z == position2.position.z)
        {
            agent.SetDestination(position3.position);
        }
        else if (agent.transform.position.x == position3.position.x && agent.transform.position.z == position3.position.z)
        {
            agent.SetDestination(position4.position);
        }
        else if (agent.transform.position.x == position4.position.x && agent.transform.position.z == position4.position.z)
        {
            agent.SetDestination(position1.position);
        }
        //agent.SetDestination(position1.position);

    }


}
