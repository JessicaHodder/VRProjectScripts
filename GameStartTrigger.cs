using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStartTrigger : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerExit(Collider other)  // trigger to start game
    {
        if (other.gameObject.tag == "DetectorBar")
        {
            GameControllerScript.b_gameStart = true;
        }
    }
}
