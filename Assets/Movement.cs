using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Movement : MonoBehaviour
{

    public float moveSpeed = 5;
    public float sensitivity = 5;
    public Rigidbody rb;
    public bool onGround = true;

    Animator mAnimator;

    void Start()
    {
        rb = GetComponent<Rigidbody>();

        //mAnimator = GetComponent<Animator>();
        //mAnimator.SetBool("WalkBool", false);
        //mAnimator.SetBool("BackwardsBool", false);
        //mAnimator.SetBool("StrafeLBool", false);
        //mAnimator.SetBool("StrafeRBool", false);
        //mAnimator.SetBool("jumpBool", false);
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += transform.forward * moveSpeed * Time.deltaTime;
            //mAnimator.SetBool("WalkBool", true); 
        }
        else 
        {
            //mAnimator.SetBool("WalkBool", false);
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.position += -transform.forward * moveSpeed * Time.deltaTime;
            //mAnimator.SetBool("BackwardsBool", true);
        }
        else
        {
            //mAnimator.SetBool("BackwardsBool", false);
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.position += -transform.right * moveSpeed * Time.deltaTime;
            //mAnimator.SetBool("StrafeLBool", true);
        }
        else
        {
            //mAnimator.SetBool("StrafeLBool", false);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.position += transform.right * moveSpeed * Time.deltaTime;
            //mAnimator.SetBool("StrafeRBool", true);

        }
        else
        {
            //mAnimator.SetBool("StrafeRBool", false);
        }

        if (Input.GetKey(KeyCode.Space) && onGround)
        {
            rb.AddForce(new Vector3(0, 5, 0), ForceMode.Impulse);
            onGround = false;
            //mAnimator.SetTrigger("jumpTrig");
            //mAnimator.SetBool("jumpBool", true);
        }
        else 
        {
            //mAnimator.SetBool("jumpBool", false);
        }

        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");

        transform.Rotate(0, mouseX * sensitivity, 0);

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            onGround = true;
        }
    }
}
