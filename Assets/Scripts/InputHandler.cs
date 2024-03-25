using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

// This class is used to decouple input from other scripts which may need to listen for it
public class InputHandler : MonoBehaviour
{
    // set of signals for keypresses 
    public static event Action OnLeftPressed;
    public static event Action OnRightPressed;
    public static event Action OnDownPressed;
    public static event Action OnDownReleased;
    public static event Action OnSpacePressed;
    public static event Action OnSpaceReleased;

    void Update() {

        // left
        if (Input.GetKeyDown(KeyCode.LeftArrow)) {
            OnLeftPressed?.Invoke();
        }

        // right
        if (Input.GetKeyDown(KeyCode.RightArrow)) {
            OnRightPressed?.Invoke();
        }

        // down
        if (Input.GetKeyDown(KeyCode.DownArrow)) {
            OnDownPressed?.Invoke();
        }
        if (Input.GetKeyUp(KeyCode.DownArrow)) {
            OnDownReleased?.Invoke();
        }

        // space
        if (Input.GetKeyDown(KeyCode.Space)) {
            OnSpacePressed?.Invoke();
        }
        if (Input.GetKeyUp(KeyCode.Space)) {
            OnSpaceReleased?.Invoke();
        }

    }
}
