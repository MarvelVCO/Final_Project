using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pad : MonoBehaviour
{
    public int num;
    public int cost;
    public int points;
    private bool bought;

    public Pad(int num, int cost, int points)
    {
        this.num = num;
        this.cost = cost;
        this.points = points;
        bought = false;
    }

    public int getNum()
    {
        return num;
    }

    public int getCost()
    {
        return cost;
    }

    public int getPoints()
    {
        return points;
    }

    public bool isBought()
    {
        return bought;
    }

    public void purchase()
    {
        bought = true;
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Player")
        {
            if (bought)
            {
                Points.increase(points);
            }

            else
            {
                if (Points.amount() >= cost)
                {
                    Points.decrease(cost);
                    purchase();
                }
            }
        }
    }
}
