using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Points : MonoBehaviour
{
    public static Points instance;
    public static float points = 3f;

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

    public static void increase(float i)
    {
        points += i;
    }

    public static void decrease(float d)
    {
        points -= d;
    }

    public static float amount()
    {
        return points;
    }
}
