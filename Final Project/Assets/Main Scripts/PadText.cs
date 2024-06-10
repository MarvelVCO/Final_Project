using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PadText : MonoBehaviour
{
    public TMP_Text padText;
    public Pad pad;
    void Update()
    {
        padText.SetText($"Spawner {pad.getNum()}:\nMultiplier: {pad.getMultiplier()}\nCost: {pad.getCost()}");
    }
}
