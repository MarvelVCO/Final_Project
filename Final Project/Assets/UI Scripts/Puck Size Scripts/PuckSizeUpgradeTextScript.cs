using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PuckSizeUpgradeTextScript : MonoBehaviour
{
    public TMP_Text text;
    public PuckSizeUpgradeScript puckSizeUpgradeScript;

    void Update()
    {
        if (puckSizeUpgradeScript.maxUpgradesReached()) {
            text.SetText("MAX");
        }
        else {
            text.SetText("Puck Size * " + Mathf.Pow(0.95f, puckSizeUpgradeScript.getNumberOfUpgrades()) +
                       "\nCost: " + puckSizeUpgradeScript.getCost());
        }
    }
}
