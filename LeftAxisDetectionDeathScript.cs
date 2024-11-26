using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftAxisDetectionDeathScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "DetectorBarLeft" && GameControllerScript.b_gameStart == true)
        {
            GameControllerScript.gameOver = true;
        }
    }
}
