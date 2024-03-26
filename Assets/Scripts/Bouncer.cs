using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bouncer : MonoBehaviour
{

    public static event Action OnCollision;

    void OnTriggerEnter(Collider other) {
        print("Bouncer Collide!");
        OnCollision?.Invoke();
    }

}
