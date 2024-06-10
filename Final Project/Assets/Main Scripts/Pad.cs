using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pad : MonoBehaviour
{
    public int num;
    public int cost;
    public float points;
    public float multiplier;
    public PuckSpawner puckSpawner;
    

    public Pad(int num, int cost, float points, float multiplier)
    {
        this.num = num;
        this.cost = cost;
        this.points = points;
        this.multiplier = multiplier;
    }

    public int getNum()
    {
        return num;
    }

    public int getCost()
    {
        return cost;
    }

    public float getPoints()
    {
        return points;
    }

    public float getMultiplier() 
    {
        return multiplier;
    }

    public void purchase()
    {
        puckSpawner.SpawnPuck(multiplier);
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Player")
        {
            if (Points.amount() >= cost)
            {
                Points.decrease(cost);
                purchase();
            }
        }

        if (collision.gameObject.name == "Puck(Clone)")
        {
            Puck puck = collision.gameObject.GetComponent<Puck>();
            if (puck != null)
            {
                Points.increase(points * puck.GetMultiplier());
                puck.Disappear();
            }
        }
    }
}
