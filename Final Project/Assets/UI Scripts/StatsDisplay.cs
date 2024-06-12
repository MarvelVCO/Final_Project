using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreCounter : MonoBehaviour
{
    public TMP_Text text;


    void Update()
    {
        text.SetText("Points: " + Stats.getPoints() +
                   "\nPuck Value: " + Stats.getPuckValue() + 
                   "\nPuck Size: " + Stats.getPuckSize() +
                   "\nGravity Multiplier: " + Stats.getGravityMultiplier());
    }
}
