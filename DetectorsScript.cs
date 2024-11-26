using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectorsScript : MonoBehaviour
{
    public GameObject m_rightHandController;

    public GameObject m_rightHandBase;
    public GameObject m_rhya;
    public GameObject m_rhxa;
    public GameObject m_rhza;

    public GameObject m_rhyd;
    public GameObject m_rhxd;
    public GameObject m_rhzd;


    public GameObject m_rhydd;
    public GameObject m_rhxdd;
    public GameObject m_rhzdd;



    public GameObject m_leftHandController;

    public GameObject m_leftHandBase;
    public GameObject m_lhya;
    public GameObject m_lhxa;
    public GameObject m_lhza;

    public GameObject m_lhyd;
    public GameObject m_lhxd;
    public GameObject m_lhzd;


    public GameObject m_lhydd;
    public GameObject m_lhxdd;
    public GameObject m_lhzdd;

    public bool b_isSeen;

    private ControlTest testinput;

    private void Awake()
    {
        testinput = new ControlTest();
    }

    private void OnEnable()
    {
        testinput.Enable();
    }

    private void OnDisable()
    {
        testinput.Disable();
    }

    // Start is called before the first frame update
    void Start()
    {
        b_isSeen = false;
    }

    

    // Update is called once per frame
    void Update()
    {

        //Debug.Log(b_isSeen);
        m_rightHandBase.transform.position = m_rightHandController.transform.position;  //track position for detectors
        m_rightHandBase.transform.rotation = m_rightHandController.transform.rotation;



        m_leftHandBase.transform.position = m_leftHandController.transform.position;
        m_leftHandBase.transform.rotation = m_leftHandController.transform.rotation;

        if (b_isSeen == false)  // check if player is seen
        {
            m_rhyd.transform.position = m_rhya.transform.position;
            m_rhyd.transform.rotation = m_rhya.transform.rotation;

            m_rhxd.transform.position = m_rhxa.transform.position;
            m_rhxd.transform.rotation = m_rhxa.transform.rotation;

            m_rhzd.transform.position = m_rhza.transform.position;
            m_rhzd.transform.rotation = m_rhza.transform.rotation;


            m_rhydd.transform.position = m_rhya.transform.position;
            m_rhydd.transform.rotation = m_rhya.transform.rotation;

            m_rhxdd.transform.position = m_rhxa.transform.position;
            m_rhxdd.transform.rotation = m_rhxa.transform.rotation;

            m_rhzdd.transform.position = m_rhza.transform.position;
            m_rhzdd.transform.rotation = m_rhza.transform.rotation;




            m_lhyd.transform.position = m_lhya.transform.position;
            m_lhyd.transform.rotation = m_lhya.transform.rotation;

            m_lhxd.transform.position = m_lhxa.transform.position;
            m_lhxd.transform.rotation = m_lhxa.transform.rotation;

            m_lhzd.transform.position = m_lhza.transform.position;
            m_lhzd.transform.rotation = m_lhza.transform.rotation;



            m_lhydd.transform.position = m_lhya.transform.position;
            m_lhydd.transform.rotation = m_lhya.transform.rotation;

            m_lhxdd.transform.position = m_lhxa.transform.position;
            m_lhxdd.transform.rotation = m_lhxa.transform.rotation;

            m_lhzdd.transform.position = m_lhza.transform.position;
            m_lhzdd.transform.rotation = m_lhza.transform.rotation;
        }

        bool b_spaceDown = testinput.FreezeToggle.FreezeDetectors.ReadValue<float>() > 0.1f;

        if(b_spaceDown)  // debug
        {

            GameControllerScript.gameOver = false;
            Debug.Log("Space Pressed");
            if (b_isSeen == false)
            {
                b_isSeen = true;
            }
            else if (b_isSeen == true)
            {
                b_isSeen = false;
            }
                    
        }

    }
}
