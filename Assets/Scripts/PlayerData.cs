using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum UpgradeName { Barrel, Bucket, HenPen, Haybale }
public class PlayerData : MonoBehaviour
{
    public static PlayerData Instance;
    public Transform BucketPos, PenPos;
    public int currentEggs = 0, passiveEggs = 0, eggsToAdd = 1, timeBetweenPassiveGain;

    public void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(this);
        }
        Instance = this;
    }

    public void Update()
    {
        if (passiveEggs > 0)
        {
            new WaitForSeconds(timeBetweenPassiveGain);
            currentEggs += passiveEggs;
        }
    }

    public void ActivateUpgrade(GameObject upgradeType)
    {
        Upgrade _upgrade = upgradeType.GetComponent<Upgrade>();

        switch (_upgrade.myUpgrade)
        {
            case UpgradeName.Bucket:
                Instantiate(upgradeType, BucketPos);
                break;
            case UpgradeName.HenPen:
                Instantiate(upgradeType, PenPos);
                break;
            default:
                break;
        }
    }

}