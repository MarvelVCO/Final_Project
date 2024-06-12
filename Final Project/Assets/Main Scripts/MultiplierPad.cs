using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultiplierPad : MonoBehaviour
{
    public int startingMultiplier;
    private int multiplier;

    void Update() {
        multiplier = startingMultiplier * Stats.getMultiplierMultiplier();
    }

    public MultiplierPad(int multiplier)
    {
        this.multiplier = multiplier;
    }

    public int getMultiplier() 
    {
        return multiplier;
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Puck(Clone)")
        {
            Puck puck = collision.gameObject.GetComponent<Puck>();
            if (puck != null)
            {
                Stats.setPoints(Stats.getPoints() + multiplier * Stats.getPuckValue());
                puck.Disappear();
            }
        }
    }
}
