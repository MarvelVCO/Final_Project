using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pad2Script :   MonoBehaviour
{
    public bool bought = false;
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Player")
        {
            if (bought)
            {
                Points.increase(2);
            }
            else
            {
                if (Points.amount() >= 10)
                {
                    Points.decrease(10);
                    bought = true;
                }
            }
        }
        
    }
}
