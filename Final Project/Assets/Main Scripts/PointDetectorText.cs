using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PointDetectorText : MonoBehaviour
{
    public TMP_Text padText;
    public MultiplierPad pad;
    void Update()
    {
        padText.SetText($"{pad.getMultiplier()}x");
    }
}
