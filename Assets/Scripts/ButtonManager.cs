using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonManager : MonoBehaviour
{
    [SerializeField] GameObject BucketPrefab, HayPrefab, HenPrefab, BarrlePrefab;
    [SerializeField] GameObject shopMenuButton;
    [SerializeField] GameObject shopMenu;

    public void AddEggs()
    {
        //Activate Effect
        //Print Added Eggs
    }

    public void BuyUpgrade(UpgradeName upgradeToAdd)
    {
        switch (upgradeToAdd)
        {
            case UpgradeName.Barrel:
                PlayerData.Instance.ActivateUpgrade(BarrlePrefab);
                break;
            case UpgradeName.Bucket:
                PlayerData.Instance.ActivateUpgrade(BucketPrefab);
                break;
            case UpgradeName.HenPen:
                PlayerData.Instance.ActivateUpgrade(HenPrefab);
                break;
            case UpgradeName.Haybale:
                PlayerData.Instance.ActivateUpgrade(HayPrefab);
                break;
            default:
                break;
        }
    }

    public void OpenShop()
    {

    }
    public void ClsoeShoop()
    {

    }
}