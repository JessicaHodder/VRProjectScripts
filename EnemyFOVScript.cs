using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFOVScript : MonoBehaviour
{

    public DetectorsControler m_detectors;

    public float radius;
    [Range(0, 360)]
    public float angle;

    public GameObject player;
    

    public LayerMask playerMask;
    public LayerMask obsticalMask;

    public bool b_playerSeen;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        GameObject detectors = GameObject.FindGameObjectWithTag("DetectorsTag");
        m_detectors = detectors.GetComponent<DetectorsControler>();
        StartCoroutine(FOVRoutine());
    }

    private IEnumerator FOVRoutine()
    {
        //float delay = 0.2f;

        WaitForSeconds wait = new WaitForSeconds(0.2f);

        while (true)
        {
            yield return wait;
            FieldOfViewCheck();
            
        }
    }

    private void FieldOfViewCheck()
    {
        Collider[] rangeChecks = Physics.OverlapSphere(transform.position, radius, playerMask);

        if(rangeChecks.Length != 0)
        {
            Transform target = rangeChecks[0].transform;
            Vector3 directionToTarget = (target.position - transform.position).normalized;

            if (Vector3.Angle(transform.forward, directionToTarget) < angle / 2)
            {
                float distanceToTarget = Vector3.Distance(transform.position, target.position);

                if(!Physics.Raycast(transform.position, directionToTarget, distanceToTarget, obsticalMask))
                {
                    b_playerSeen = true;
                    //Debug.Log("player Seen");
                    Debug.DrawRay(transform.position, directionToTarget, Color.green);
                    //m_detectors.b_isSeen = true;
                }
                else
                {
                    b_playerSeen = false;
                }

            }
            else
            {
                b_playerSeen = false;
            }
        }
        else if (b_playerSeen == true)
        {
            b_playerSeen = false;
        }


        if (b_playerSeen == true)
        {
            m_detectors.b_isSeen = true;
        }
        else
        {
            m_detectors.b_isSeen = false;
        }
    }



}
