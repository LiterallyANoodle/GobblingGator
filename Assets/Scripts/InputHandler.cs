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
    public static event Action OnSpacePressed;

    void Update() {

        // left
        if (Input.GetKeyDown(KeyCode.LeftArrow)) {
            OnLeftPressed?.Invoke();
        }

        // right
        if (Input.GetKeyDown(KeyCode.RightArrow)) {
            OnRightPressed?.Invoke();
        }

        // space
        if (Input.GetKeyDown(KeyCode.Space)) {
            OnSpacePressed?.Invoke();
        }

    }
}
