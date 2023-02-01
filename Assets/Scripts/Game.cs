using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Game : MonoBehaviour
{
    public TextMeshProUGUI ClicksTotalText;

    public float TotalClicks;

    public int numUpgrades;

    public int autoClicksPerSecond;
    public int minimumClicksToUnlockUpgrade;


    public void AddClicks()
    {
        TotalClicks++;
        ClicksTotalText.text = TotalClicks.ToString("0");
    }

    private void Update()
    {
        TotalClicks += autoClicksPerSecond * Time.deltaTime * numUpgrades;

        ClicksTotalText.text = TotalClicks.ToString("0");

        if (Input.GetKeyDown("space"))
        {
            AddClicks();
        }
    }

    public void SaveGame()
    {
        SaveAndLoad.SaveData(this);
    }

    public void LoadGame()
    {
        PlayerData data = SaveAndLoad.LoadData();
        TotalClicks = data.totalHits;
        numUpgrades = data.numUpgrades;
    }


}
