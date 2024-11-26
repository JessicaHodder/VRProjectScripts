using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyController : MonoBehaviour
{

    private bool b_thisKeyDone;

    public Material buttonColor;
    Renderer currentMaterial;

    // Start is called before the first frame update
    void Start()
    {
        transform.localPosition = new Vector3(0.35f, 0f, 0f);  //sets button position
        b_thisKeyDone = false;  //resets parameters
        currentMaterial = GetComponent<Renderer>();
        currentMaterial.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //private void OnCollisionEnter(Collision collision)
    //{
    //    if (collision.gameObject.name == "RightHandBase")
    //    {
    //        transform.position = new Vector3(0, 0, 0);
    //    }
    //}

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "RightHandBase" || other.gameObject.name == "LeftHandBase")  // checks for player hand
        {
            transform.localPosition = new Vector3(0.22f, 0, 0);  // pushes button back

            currentMaterial.sharedMaterial = buttonColor;  // changes colour

            

            if (b_thisKeyDone == false)  // only done once per key
            {
                GameControllerScript.keysRemaining = GameControllerScript.keysRemaining - 1;  // tess game controller
                b_thisKeyDone = true;
            }
        }
    }
}
