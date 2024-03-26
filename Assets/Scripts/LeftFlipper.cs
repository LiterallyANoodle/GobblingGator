using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;

public class LeftFlipper : MonoBehaviour
{

    private bool isUp = false;
    private const float turnSpeed = 5f;
    public int duration = 3;
    private int counter = 0;
    private Vector3 downAngle = new Vector3(-90f, 45f, 0f);
    private Vector3 upAngle = new Vector3(-90f, 0f, 0f);
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
        // if (isUp) {
        //     counter += 1;
        //     counter = Math.Clamp(counter, 0, duration);
        //     float t = (float)counter / duration;
        //     this.transform.localEulerAngles = Vector3.Lerp(downAngle, upAngle, t);
        // } else {
        //     counter -= 1;
        //     counter = Math.Clamp(counter, 0, duration);
        //     float t = (float)counter / duration;
        //     this.transform.localEulerAngles = Vector3.Lerp(downAngle, upAngle, t);
        // }
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
