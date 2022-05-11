using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Upgrade : MonoBehaviour
{
    
    [SerializeField] internal UpgradeName myUpgrade;
    [SerializeField] int cost;
    [SerializeField] string _name;
    [SerializeField] string description;
    [SerializeField] internal int maxUpgradeNum;
    [SerializeField] int eggsToAdd;

    private void OnEnable()
    {
        PlayerData.Instance.passiveEggs += eggsToAdd;
    }
}
