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

                break;
            case UpgradeName.Bucket:

                break;
            case UpgradeName.HenPen:

                break;
            case UpgradeName.Haybale:
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