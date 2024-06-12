using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuckUpgradeScript : MonoBehaviour
{
    private int upgradeCost = 10; 
    private int numberOfUpgrades;

    void Update()
    {
        numberOfUpgrades = 1;
        if (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift))
        {
            numberOfUpgrades = 10;
        }
        else if (Input.GetKey(KeyCode.LeftControl) || Input.GetKey(KeyCode.RightControl))
        {
            numberOfUpgrades = 100;
        }
        else if (Input.GetKey(KeyCode.LeftAlt) || Input.GetKey(KeyCode.RightAlt))
        {
            numberOfUpgrades = CalculateMaxUpgrades();
        }
    }

    public int getNumberOfUpgrades() {
        return numberOfUpgrades;
    }

    public int getCost() 
    {
        int totalCost = 0;
        for (int i = 0; i < numberOfUpgrades; i++)
        {
            totalCost += upgradeCost + (Stats.getPuckValue() + i) - 1;
        }
        return totalCost;
    }

    public void UpgradePuck()
    {

        if (Stats.getPoints() >= getCost())
        {
            Stats.setPoints(Stats.getPoints() - getCost());
            Stats.setPuckValue(Stats.getPuckValue() + numberOfUpgrades);
        }
    }

    public int CalculateMaxUpgrades()
    {
        int tempPoints = Stats.getPoints();
        int tempCost = upgradeCost;
        int upgrades = 0;

        while (tempPoints >= tempCost)
        {
            upgrades++;
            tempPoints -= tempCost;
            tempCost = upgradeCost + Stats.getPuckValue() + upgrades - 1;
        }

        return upgrades - 1;
    }
}
