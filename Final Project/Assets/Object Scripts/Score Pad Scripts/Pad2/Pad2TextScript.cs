using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Pad2TextScript : MonoBehaviour
{
    public TMP_Text pad2Text;
    public static bool bought;

    void start()
    {
        if (bought)
        {
            pad2Text.SetText("Pad 2:\r\nPoints: 2");

        }
    }
}
