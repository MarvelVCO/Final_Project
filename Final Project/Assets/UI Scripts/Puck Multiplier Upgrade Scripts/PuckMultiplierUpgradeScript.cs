using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuckMultiplierUpgradeScript : MonoBehaviour
{
    private int upgradeCost = 1000; 
    private int numberOfUpgrades;
    private const int maxUpgrades = 15;
    private int totalUpgrades = 0;

    void Update()
    {
        numberOfUpgrades = 1;
        if (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift))
        {
            numberOfUpgrades = Mathf.Min(10, maxUpgrades - totalUpgrades);
        }
        else if (Input.GetKey(KeyCode.LeftControl) || Input.GetKey(KeyCode.RightControl))
        {
            numberOfUpgrades = Mathf.Min(100, maxUpgrades - totalUpgrades);
        }
        else if (Input.GetKey(KeyCode.LeftAlt) || Input.GetKey(KeyCode.RightAlt))
        {
            numberOfUpgrades = Mathf.Min(CalculateMaxUpgrades(), maxUpgrades - totalUpgrades);
        }
    }

    public int getNumberOfUpgrades() {
        return numberOfUpgrades;
    }

    public bool maxUpgradesReached() {
        return totalUpgrades == maxUpgrades;
    }

    public int getCost() 
    {
        int totalCost = 0;
        int baseCost = upgradeCost;
        for (int i = 0; i < numberOfUpgrades; i++)
        {
            totalCost += Mathf.RoundToInt(baseCost * Mathf.Pow(2, totalUpgrades + i));
        }
        return totalCost;
    }

    public void UpgradePuck()
    {
        if (Stats.getPoints() >= getCost() && totalUpgrades + numberOfUpgrades <= maxUpgrades)
        {
            Stats.setPoints(Stats.getPoints() - getCost());
            totalUpgrades += numberOfUpgrades;
            Stats.setMultiplierMultiplier(Mathf.RoundToInt(Stats.getMultiplierMultiplier() * Mathf.Pow(2f, numberOfUpgrades)));
        }
    }

    public int CalculateMaxUpgrades()
    {
        int tempPoints = Stats.getPoints();
        int baseCost = upgradeCost;
        int upgrades = 0;

        while (tempPoints >= Mathf.RoundToInt(baseCost * Mathf.Pow(2, totalUpgrades + upgrades)) && (totalUpgrades + upgrades) < maxUpgrades)
        {
            tempPoints -= Mathf.RoundToInt(baseCost * Mathf.Pow(2, totalUpgrades + upgrades));
            upgrades++;
        }

        return upgrades;
    }
}
