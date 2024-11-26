using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UiScript : MonoBehaviour
{
    public GameObject loadingWindow;
    public Text loadingStatus; 

    public void StartButton()
    {
        //SceneManager.LoadScene("MainLevel");

        StartCoroutine(LoadAsync());  // starts thread
        
    }

    IEnumerator LoadAsync ()  //leading thread
    {
        loadingWindow.SetActive(true);  // displays loading panel

        AsyncOperation loadingOp = SceneManager.LoadSceneAsync("MainLevel");  // loads scene async

        while (!loadingOp.isDone)
        {
            loadingStatus.text = "Loading :" + (loadingOp.progress * 10).ToString("F0");  // displayes loading status as whole number

            yield return null;
        }
    }

}
