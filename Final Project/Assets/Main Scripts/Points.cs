using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Points : MonoBehaviour
{
    public static Points instance;
    public static int points = 0;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public static void increase(int i)
    {
        points += i;
    }

    public static void decrease(int d)
    {
        points -= d;
    }

    public static string amount()
    {
        return "" + points;
    }
}
