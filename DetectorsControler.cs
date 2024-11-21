using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectorsControler : MonoBehaviour
{
    public GameObject m_XDetector;
    public GameObject m_YDetector;
    public GameObject m_ZDetector;

    public GameObject m_XBar;
    public GameObject m_YBar;
    public GameObject m_ZBar;

    public bool b_isSeen;


    // Start is called before the first frame update
    void Start()
    {
        b_isSeen = false;
    }

    // Update is called once per frame
    void Update()
    {

        if(Input.GetKeyDown(KeyCode.Space))
        {
            if (b_isSeen == false)
            {
                b_isSeen = true;
            }
            else if (b_isSeen == true)
            {
                b_isSeen = false;
            }
        }

        if (b_isSeen == false)
        {
            m_XDetector.transform.position = m_XBar.transform.position;
            m_XDetector.transform.rotation = m_XBar.transform.rotation;

            m_YDetector.transform.position = m_YBar.transform.position;
            m_YDetector.transform.rotation = m_YBar.transform.rotation;

            m_ZDetector.transform.position = m_ZBar.transform.position;
            m_ZDetector.transform.rotation = m_ZBar.transform.rotation;
        }

    }

    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "TestWall")
        {
            Debug.Log("Y axis left");
        }
    }
    public bool GetIsSeen()
    {
        return b_isSeen;
    }
}
