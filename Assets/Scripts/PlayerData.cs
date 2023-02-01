using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
public class PlayerData
{
    public int numUpgrades;
    public float totalHits;

    public PlayerData (Game player)
    {
        numUpgrades = player.numUpgrades;
        totalHits = player.TotalClicks;
    }
}
