﻿using UnityEngine;
using System.Collections;
using System.Net;

public class PlayerMovement : MonoBehaviour {

    public float Speed = 10.0f;
    public float Jump = 1.0f;
    public LayerMask GroundLayers;
    public GameObject JumpSound;



    private Animator m_Animator;
    private Transform m_GroundCheck;

	// Use this for initialization
	void Start () 
    {
        m_Animator = GetComponent<Animator>();
        m_GroundCheck = transform.FindChild("GroundCheck");
	}

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (Time.timeScale == 1)
                Time.timeScale = 0;
            else Time.timeScale = 1;
        }
    }

	// Update is called once per frame
	void FixedUpdate () 
    {
        bool isGrounded = Physics2D.OverlapPoint(m_GroundCheck.position, GroundLayers);
        if (Input.GetButton("Jump"))
        {
            if (isGrounded)
            {
                GameObject jumpSound = Instantiate(JumpSound, this.transform.position, 
                       this.transform.rotation) as GameObject;
                
                rigidbody2D.AddForce(Vector2.up * Jump, ForceMode2D.Impulse);
                isGrounded = false;
            }
        }

        m_Animator.SetBool("IsGrounded", isGrounded);

	    float hSpeed = Input.GetAxis("Horizontal");

        m_Animator.SetFloat("Speed", Mathf.Abs(hSpeed));

        if (hSpeed > 0)
        {
            transform.localScale = new Vector3(1, 1, 1);
        }
        else if (hSpeed < 0)
        {
            transform.localScale = new Vector3(-1, 1, 1);
        }

        this.rigidbody2D.velocity = new Vector2(hSpeed * Speed,
                rigidbody2D.velocity.y);
	}
}
