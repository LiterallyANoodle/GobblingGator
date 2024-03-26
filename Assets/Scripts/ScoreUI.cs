using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ScoreUI : MonoBehaviour
{

    private int score = 0;
    public TMP_Text text;

    // signals 
    void OnEnable() {
        Bouncer.OnCollision += OnBouncerCollision;
    }

    void OnDisable() {
        Bouncer.OnCollision -= OnBouncerCollision;
    }

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        text.text = score.ToString();
    }

    void OnBouncerCollision() {

        score += 1000;
        text.text = score.ToString();

    }
}
