using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bouncer : MonoBehaviour
{

    public static event Action OnCollision;
    private AudioSource sfx;

    void Start() {
        sfx = GetComponent<AudioSource>();
    }

    void OnTriggerEnter(Collider other) {
        print("Bouncer Collide!");
        sfx?.Play();
        OnCollision?.Invoke();
    }

}
