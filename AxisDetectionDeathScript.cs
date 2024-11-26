using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AxisDetectionDeathScript : MonoBehaviour
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
        if (other.gameObject.tag == "DetectorBar" && GameControllerScript.b_gameStart == true)  // checks if object was detector and the game has been started
        {
            GameControllerScript.gameOver = true;  // triggers game over in game controller
        }
    }
}
