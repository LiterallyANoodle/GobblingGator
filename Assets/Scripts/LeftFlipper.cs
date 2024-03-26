using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;

public class LeftFlipper : MonoBehaviour
{

    private bool isUp = false;
    private Rigidbody rigidBody;

    // signals 
    void OnEnable() {
        InputHandler.OnLeftPressed += OnLeftPressed;
        InputHandler.OnLeftReleased += OnLeftReleased;
    }

    void OnDisable() {
        InputHandler.OnLeftPressed -= OnLeftPressed;
        InputHandler.OnLeftReleased -= OnLeftReleased;
    }

    void Start() {
        rigidBody = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        if (isUp) {
            // add torque, spring joint will reset it
            rigidBody.AddRelativeTorque(new Vector3(0, 0, -100000000), ForceMode.Force);
        }
    }

    void OnLeftPressed() {
        this.isUp = true;
    }
    void OnLeftReleased() {
        this.isUp = false;
    }

}
