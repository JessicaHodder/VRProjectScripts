using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class xCollider : MonoBehaviour
{
    // Start is called before the first frame update

    bool isSeen;

    public GameOverScript gameOverScript;

    private void Start()
    {
        GameObject maintDetector = GameObject.FindGameObjectWithTag("DetectorsTag");
        gameOverScript = maintDetector.GetComponent<GameOverScript>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //private void OnCollisionEnter(Collision col)
    //{
    //    Debug.Log("collision");
    //    if (col.gameObject.name == "TestWall")
    //    {
    //        Debug.Log("Collision with wall");
    //    }
    //}

    //private void OnTriggerEnter(Collider other)
    //{
    //    //Debug.Log("collision");
    //    if (other.gameObject.name == "TestWall")
    //    {
    //        Debug.Log("Collision with wall");
    //    }

    //    //isSeen = ;
    //}

    private void OnTriggerExit(Collider other)
    {
        //Debug.Log("collision Exit");
        if (other.gameObject.name == "xAxisBar")
        {
            //Debug.Log("x BarTriggerd");
            gameOverScript.b_gameOver = true;
        }
    }


}
