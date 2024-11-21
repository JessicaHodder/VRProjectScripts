using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverScript : MonoBehaviour
{
    // Start is called before the first frame update

    public bool b_gameOver = false;

    // Update is called once per frame
    void Update()
    {
        
        if (b_gameOver == true)
        {
            Debug.Log("Game Over");
            b_gameOver = false;
        }
    }
}
