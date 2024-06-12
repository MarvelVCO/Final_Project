using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PuckUpgradeTextScript : MonoBehaviour
{
    public TMP_Text scoreText;
    public PuckUpgradeScript puckUpgradeScript;

    void Update()
    {
        scoreText.SetText("Puck Value + " + puckUpgradeScript.getNumberOfUpgrades() +
                        "\nCost: " + puckUpgradeScript.getCost());
    }
}
