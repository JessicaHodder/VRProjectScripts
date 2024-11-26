using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameControllerScript : MonoBehaviour
{

    public static bool b_gameStart;

    public static bool b_enemyExamening;
    public static bool gameOver;
    public static bool b_gameComplete;
    public static bool b_playerDead;
    //public Text playerDeathStatus;

    public static int keysRemaining;
    public Text playerKeysRemaining;
    public GameObject GameCompletePanel;
    public GameObject GameOverPanel;

    public GameObject ExitDoor;
    public GameObject Enemy;

    private float time;

    // Start is called before the first frame update
    void Start()  // resets level
    {
        gameOver = false;
        //playerDeathStatus = GetComponent<Text>();
        keysRemaining = 10;
        b_gameStart = false;
        b_gameComplete = false;
        GameCompletePanel.SetActive(false);
        b_playerDead = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (b_playerDead == true)
        {
            //playerDeathStatus.text = "Game Over";
            Enemy.SetActive(false);  //removes enemy
            time += Time.deltaTime;
            if (time > 3)
            {
                time = 0;
                SceneManager.LoadScene("MainMenu");  // load scene after 3 seconds
            }
            GameOverPanel.SetActive(true);  // displays game over


        }
        else if (b_enemyExamening == true)
        {
            //playerDeathStatus.text = "Enemy Examening";
        }
        else
        {
            //playerDeathStatus.text = "Alive";
        }


        if (b_gameComplete == true)  // if player completes game
        {
            time += Time.deltaTime;
            if (time > 3)
            {
                time = 0;
                SceneManager.LoadScene("MainMenu");  // loads scene

            }
            //playerKeysRemaining.text = "LevelComplete";
            GameCompletePanel.SetActive(true);  // displayes info panel
        }
        else if (keysRemaining == 0)  // if player finds all keys
        {
            ExitDoor.SetActive(false);  // removes door
            playerKeysRemaining.text = "Door Open";
        }
        else
        {
            ExitDoor.SetActive(true);  // sets door
            playerKeysRemaining.text = "Keys Remaining:" + keysRemaining.ToString();  // displays keys remaining
        }
        
    }

    
}
