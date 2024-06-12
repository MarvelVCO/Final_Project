using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stats : MonoBehaviour
{
    public static Stats instance;
    public static int points = 0;
    public static int puckValue = 1;
    public static float puckSize = 1f;
    public static int multiplierMultiplier = 1;
    public static float gravityMultiplier = 1;

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

    public static int getPoints() {
        return points;
    }

    public static void setPoints(int pointValue) {
        points = pointValue;
    }

    public static int getPuckValue() {
        return puckValue;
    }

    public static void setPuckValue(int pointValue) {
        puckValue = pointValue;
    }

    public static float getPuckSize() {
        return puckSize;
    }

    public static void setPuckSize(float newPuckSize) {
        puckSize = newPuckSize;
    }

    public static int getMultiplierMultiplier() {
        return multiplierMultiplier;
    }

    public static void setMultiplierMultiplier(int newMultiplierMultiplier) {
        multiplierMultiplier = newMultiplierMultiplier;
    }

    public static float getGravityMultiplier() {
        return gravityMultiplier;
    }

    public static void setGravityMultiplier(float newGravityMultiplier) {
        gravityMultiplier = newGravityMultiplier;
    }
}
