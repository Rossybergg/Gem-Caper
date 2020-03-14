﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour {
 
 public Rigidbody body;
 public float speed;
 public bool marbleOnGround;
public float jumpForce;
public float fallMultiplier = 2.5f;
public float lowJumpMultiplyer = 2f;
    private void Update() {
        playerControl();
    }


    void playerControl() {
        movement();
        jump();
    }

    void movement() {
            float horizontal = Input.GetAxis("Horizontal");
            float vertical = Input.GetAxis("Vertical");
            Vector3 movement = new Vector3 (horizontal, 0.0f, vertical);
            Vector3 relativeMovement = Camera.main.transform.TransformVector(movement);
            body.AddForce (relativeMovement * speed * Time.deltaTime);
    }

    void jump() {
        if ( Input.GetButtonDown("Jump") && marbleOnGround) {
            body.AddForce( 0 , jumpForce , 0, ForceMode.Impulse);
            marbleOnGround = false;
        };
         if ( body.velocity.y < -5 ) {
          body.velocity += Vector3.up * Physics.gravity.y * (fallMultiplier - 1) * Time.deltaTime;
      }
    }

    private void OnCollisionEnter(Collision collision) {
        if ( collision.gameObject.tag == "ground" ) {
                marbleOnGround = true;
            }

    }
}