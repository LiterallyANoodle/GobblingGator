using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.UI;
using UnityEngine;

public class Launcher : MonoBehaviour
{

    private Rigidbody rigidBody;
    private const float downIncrement = 10f;
    private float downForce;
    private bool springPulling;

    void Start() {
        downForce = 0;
        springPulling = false;
        rigidBody = this.GetComponent<Rigidbody>();
    }

    void FixedUpdate() {
        if (springPulling) {
            downForce += downIncrement;
            rigidBody.AddRelativeForce(new Vector3(0, 0, downForce));
        }
    }

    // signals 
    void OnEnable() {
        InputHandler.OnLeftPressed += OnLeftPressed;
        InputHandler.OnRightPressed += OnRightPressed;
        InputHandler.OnSpacePressed += OnSpacePressed;
        InputHandler.OnSpaceReleased += OnSpaceReleased;
        InputHandler.OnDownPressed += OnDownPressed;
        InputHandler.OnDownReleased += OnDownReleased;
    }

    void OnDisable() {
        InputHandler.OnLeftPressed -= OnLeftPressed;
        InputHandler.OnRightPressed -= OnRightPressed;
        InputHandler.OnSpacePressed -= OnSpacePressed;
        InputHandler.OnSpaceReleased -= OnSpaceReleased;
        InputHandler.OnDownPressed -= OnDownPressed;
        InputHandler.OnDownReleased -= OnDownReleased;
    }

    void OnLeftPressed() {
        print("Left!");
    }
    void OnRightPressed() {
        print("Right!");
    }
    void OnSpacePressed() {
        print("Space!");
    }
    void OnSpaceReleased() {
        print("Release!");
    }
    void OnDownPressed() {
        this.springPulling = true;
    }
    void OnDownReleased() {
        this.springPulling = false;
        this.downForce = 0f;
    }
}
