using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreCounter : MonoBehaviour
{
    public TMP_Text scoreText;


    void Update()
    {
        scoreText.SetText($"Points: " + Points.amount());
    }
}
