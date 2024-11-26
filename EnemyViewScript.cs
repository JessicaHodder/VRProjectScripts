using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyViewScript : MonoBehaviour
{

    public DetectorsScript m_detectors;

    public float radius;
    [Range(0, 360)]

    public float angle;

    public GameObject playerRH;


    public LayerMask PlayerMask;
    public LayerMask ObsticalMask;

    public bool b_playerSeen;


    // Start is called before the first frame update
    void Start()
    {
        
        playerRH = GameObject.FindGameObjectWithTag("Player");
        GameObject detectors = GameObject.FindGameObjectWithTag("DetectorsTag");
        m_detectors = detectors.GetComponent<DetectorsScript>();  // gets the detectors script
        StartCoroutine(FOVRoutine());  // starts thread


    }


    private IEnumerator FOVRoutine()  // runs script every 0.2 seconds
    {
        WaitForSeconds wait = new WaitForSeconds(0.2f);

        while (true)
        {
            yield return wait;
            FieldOfViewCheck();
        }
    }

    private void FieldOfViewCheck()
    {
        //Debug.Log("FOVStarted");
        Collider[] rangeChecks = Physics.OverlapSphere(transform.position, radius, PlayerMask);  // gets arrays of player colliders within radious

        if(rangeChecks.Length != 0)
        {
            
            Transform target = rangeChecks[0].transform;  //gets position
            Vector3 directionToTarget = (target.position - transform.position).normalized;  //gets direction

            if (Vector3.Angle(transform.forward, directionToTarget) < angle / 2)  // to account for both angles
            {
                float distanceToTarget = Vector3.Distance(transform.position, target.position);

                if (!Physics.Raycast(transform.position, directionToTarget, distanceToTarget, ObsticalMask))  //checks if player is behind wall
                {
                    b_playerSeen = true;  // indicates player is seen by enemy

                    Debug.DrawRay(transform.position, directionToTarget, Color.green);
                    
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
            //Debug.Log("SeenPlayer");
            m_detectors.b_isSeen = true;  // singnals to detectors
        }
        else
        {
            m_detectors.b_isSeen = false;
        }




    }
        

    // Update is called once per frame
    void Update()
    {
        
    }
}
