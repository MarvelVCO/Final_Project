using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PuckMultiplierUpgradeTextScript : MonoBehaviour
{
    public TMP_Text text;
    public PuckMultiplierUpgradeScript puckSizeUpgradeScript;

    void Update()
    {
        if (puckSizeUpgradeScript.maxUpgradesReached()) {
            text.SetText("MAX");
        }
        else {
            text.SetText("Bottom Multiplier * " + Mathf.Pow(2f, puckSizeUpgradeScript.getNumberOfUpgrades()) +
                       "\nCost: " + puckSizeUpgradeScript.getCost());
        }
    }
}
