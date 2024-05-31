using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarterScorePad :   MonoBehaviour
{

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Player")
        {
            Points.increase(1);
            Debug.LogError("awdawd");
        }
    }
}
