using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Upgrades : MonoBehaviour
{
    
    [SerializeField] Upgrade myUpgrade;
    [SerializeField] int cost;
    [SerializeField] string name;
    [SerializeField] string description;
    [SerializeField] int maxUpgradeNum;
    [SerializeField] int eggsToAdd;

    private void OnEnable()
    {
        ClickerScript.Instance.passiveEggs += eggsToAdd;
    }
}
