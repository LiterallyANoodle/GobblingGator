using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PitBox : MonoBehaviour
{
    void OnTriggerEnter(Collider other) {
        if (other.name == "Ball") {
            other.transform.position = other.transform.parent.Find("Respawn").transform.position; // goofy ahh hierarchy....
        }
    }
}
