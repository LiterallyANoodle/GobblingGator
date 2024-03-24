using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Launcher : MonoBehaviour
{
    // signals 
    void OnEnable() {
        InputHandler.OnLeftPressed += OnLeftPressed;
        InputHandler.OnRightPressed += OnRightPressed;
        InputHandler.OnSpacePressed += OnSpacePressed;
    }

    void OnDisable() {
        InputHandler.OnLeftPressed -= OnLeftPressed;
        InputHandler.OnRightPressed -= OnRightPressed;
        InputHandler.OnSpacePressed -= OnSpacePressed;
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
}
