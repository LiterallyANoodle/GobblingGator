using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PitBox : MonoBehaviour
{
    void OnTriggerEnter(Collider other) {
        print(other);
    }
}
