using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;

public class LeftFlipper : MonoBehaviour
{

    private bool isUp = false;
    private const float turnSpeed = 5f;
    private const float downAngle = 45f;
    private const float upAngle = 0f;

    // signals 
    void OnEnable() {
        InputHandler.OnLeftPressed += OnLeftPressed;
    }

    void OnDisable() {
        InputHandler.OnLeftPressed -= OnLeftPressed;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (isUp) {
            if (this.transform.rotation.y != upAngle) {
                this.transform.Rotate(new Vector3(0, -turnSpeed, 0));
            }
            Mathf.Clamp(this.transform.rotation.y, upAngle, downAngle); // ensure doesn't exceed 0
        } else {
            if (this.transform.rotation.y != downAngle) {
                this.transform.Rotate(new Vector3(0, turnSpeed, 0));
            }
            Mathf.Clamp(this.transform.rotation.y, upAngle, downAngle); // ensure doesn't exceed 0
        }
    }

    void OnLeftPressed() {
        this.isUp = true;
    }
    void OnLeftReleased() {
        this.isUp = false;
    }

}
