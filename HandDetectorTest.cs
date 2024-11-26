using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandDetectorTest : MonoBehaviour
{

    public GameObject r_hand;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = r_hand.transform.position;
        transform.rotation = r_hand.transform.rotation;
    }
}
