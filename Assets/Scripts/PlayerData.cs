using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum UpgradeName { Barrel, Bucket, HenPen, Haybale }
public class PlayerData : MonoBehaviour
{
    public static PlayerData Instance;
    public Transform BucketPos, BarrelPos, PenPos, HayPos;
    public int currentEggs = 0, passiveEggs = 0, eggsToAdd = 1;

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
            currentEggs += passiveEggs;
        }
    }

    public void ActivateUpgrade(GameObject upgradeType)
    {
        Upgrade _upgrade = upgradeType.GetComponent<Upgrade>();

        switch (_upgrade.myUpgrade)
        {
            case UpgradeName.Barrel:
                Instantiate(upgradeType, BarrelPos);
                break;
            case UpgradeName.Bucket:
                Instantiate(upgradeType, BucketPos);
                break;
            case UpgradeName.HenPen:
                Instantiate(upgradeType, PenPos);
                break;
            case UpgradeName.Haybale:
                Instantiate(upgradeType, HayPos);
                break;
            default:
                break;
        }
    }

}