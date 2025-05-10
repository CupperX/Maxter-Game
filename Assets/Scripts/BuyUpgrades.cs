using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuyUpgrades : MonoBehaviour
{
    public int IndexInUpgradesList;
    public List<int> cost;
    public int costNow;
    public int lastUpgrade;
    public Button button;
    public Text text;
    public FindAndTransform FindAndTransform;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        costNow = cost[0];
    }

    // Update is called once per frame
    void Update()
    {
        if(DATA.coins < costNow){
            button.interactable = false;
        }
        else
        {
            button.interactable = true;
        }
    }
    public void BuyUpgrade()
    {
        DATA.coins-=costNow;
        lastUpgrade++;
        costNow = cost[lastUpgrade - 1];
        FindAndTransform.upgrades[IndexInUpgradesList]++;
    }
}
