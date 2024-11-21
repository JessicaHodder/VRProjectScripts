using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5.0f;

    public CharacterController controller;

    //public Transform orientation;

    float horizontalInput;
    float verticalInput;

    //Vector3 moveDirection;

    Rigidbody rb;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        //rb.freezeRotation = true;
        Debug.Log("test");
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxisRaw("Horizontal");
        verticalInput = Input.GetAxisRaw("Vertical");

        Vector3 moveDirection = new Vector3(horizontalInput, 0f, verticalInput).normalized;

        if (moveDirection.magnitude >= 0.1f)
        {
            controller.Move(moveDirection * speed * Time.deltaTime);
        }

        //transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);
        //transform.Translate(Vector3.right * Time.deltaTime * speed * horizontalInput);

        //if (Input.GetKeyDown(KeyCode.W))
        //{
        //    rb.AddForce(Vector3.forward * speed, ForceMode.Force);
        //}
        //else if (Input.GetKeyDown(KeyCode.S))
        //{
        //    rb.AddForce(Vector3.back * speed, ForceMode.Force);
        //}
        //else if (Input.GetKeyDown(KeyCode.A))
        //{
        //    rb.AddForce(Vector3.left * speed, ForceMode.Force);
        //}
        //else if (Input.GetKeyDown(KeyCode.D))
        //{
        //    rb.AddForce(Vector3.right * speed, ForceMode.Force);
        //    Debug.Log("test");
        //}


        
    }

 

}
