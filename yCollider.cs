using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yCollider : MonoBehaviour
{
    // Start is called before the first frame update

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

    private void OnTriggerExit(Collider other)
    {
        //Debug.Log("collision Exit");
        if (other.gameObject.name == "yAxisBar")
        {
            //Debug.Log("y Bar Triggered");
            gameOverScript.b_gameOver = true;
        }
    }
}
