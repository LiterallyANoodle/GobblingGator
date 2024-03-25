using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;

public class RightFlipper : MonoBehaviour
{

    private bool isUp = false;
    private const float turnSpeed = 5f;
    private const int duration = 20;
    private int counter = 0;
    private readonly Vector3 downAngle = new Vector3(-90f, -45f, 0f);
    private readonly Vector3 upAngle = new Vector3(-90f, 0f, 0f);

    // signals 
    void OnEnable() {
        InputHandler.OnRightPressed += OnRightPressed;
        InputHandler.OnRightReleased += OnRightReleased;
    }

    void OnDisable() {
        InputHandler.OnRightPressed -= OnRightPressed;
        InputHandler.OnRightReleased -= OnRightReleased;
    }

    void FixedUpdate()
    {
        // if (this.isUp) {
        //     if (this.transform.eulerAngles.y != upAngle) {
        //         currentAngle += turnSpeed;
        //         currentAngle = currentAngle % 360f;
        //     }
        //     // currentAngle = Mathf.Clamp(this.transform.eulerAngles.y, downAngle, upAngle); // ensure doesn't exceed 0
        //     this.transform.eulerAngles = new Vector3(-90f, currentAngle, 0f);
        // } else {
        //     if (this.transform.eulerAngles.y != downAngle) {
        //         currentAngle -= turnSpeed;
        //         currentAngle = currentAngle % 360f;
        //     }
        //     // currentAngle = Mathf.Clamp(this.transform.eulerAngles.y, downAngle, upAngle); // ensure doesn't exceed 0
        //     this.transform.eulerAngles = new Vector3(-90f, currentAngle, 0f);
        // }
        // print(currentAngle);

        if (isUp) {
            // this.transform.eulerAngles = new Vector3(-90, upAngle, 0);
            counter += 1;
            counter = Math.Clamp(counter, 0, duration);
            this.transform.eulerAngles = Vector3.Lerp(downAngle, upAngle, counter / duration);

        } else {
            counter -= 1;
            counter = Math.Clamp(counter, 0, duration);
            this.transform.eulerAngles = Vector3.Lerp(downAngle, upAngle, counter / duration);
        }
    }

    void OnRightPressed() {
        this.isUp = true;
    }
    void OnRightReleased() {
        this.isUp = false;
    }

}
