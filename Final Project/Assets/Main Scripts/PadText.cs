using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PadText : MonoBehaviour
{
    public TMP_Text text;
    public Pad pad;

    void Update()
    {
        if (pad.isBought())
        {
            text.SetText($"Pad {pad.getNum()}:\r\nPoints: {pad.getPoints()}");
        }
        else
        {
            text.SetText($"Pad {pad.getNum()}:\r\nPoints: {pad.getPoints()}\r\nCost: {pad.getCost()}");
        }
    }
}
