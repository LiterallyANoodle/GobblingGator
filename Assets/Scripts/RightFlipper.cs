using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;

public class RightFlipper : MonoBehaviour
{

    private bool isUp = false;
    private Rigidbody rigidBody;

    // signals 
    void OnEnable() {
        InputHandler.OnRightPressed += OnRightPressed;
        InputHandler.OnRightReleased += OnRightReleased;
    }

    void OnDisable() {
        InputHandler.OnRightPressed -= OnRightPressed;
        InputHandler.OnRightReleased -= OnRightReleased;
    }

    void Start() {
        rigidBody = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        if (isUp) {
            // add torque, spring joint will reset it
            rigidBody.AddRelativeTorque(new Vector3(0, 0, 100000000), ForceMode.Force);
        }
    }

    void OnRightPressed() {
        this.isUp = true;
    }
    void OnRightReleased() {
        this.isUp = false;
    }

}
