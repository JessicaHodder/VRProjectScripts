using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameCompleteScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)  // detects if player reaches exit
    {
        if (other.gameObject.tag == "DetectorBar")
        {
            GameControllerScript.b_gameComplete = true;
        }
    }
}
