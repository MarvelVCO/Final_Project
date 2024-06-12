using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PuckGravityUpgradeTextScript : MonoBehaviour
{
    public TMP_Text scoreText;
    public PuckGravityUpgradeScript puckGravityUpgradeScript;

    void Update()
    {
        scoreText.SetText("Gravity Multiplier + " + (0.5f * puckGravityUpgradeScript.getNumberOfUpgrades()) +
                        "\nCost: " + puckGravityUpgradeScript.getCost());
    }
}
