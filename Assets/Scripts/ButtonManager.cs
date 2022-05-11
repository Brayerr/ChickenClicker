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
        PlayerData.Instance.currentEggs++;
        Debug.Log("Collected 1 egg");
    }

    public void BuyUpgrade(string name)
    {
        UpgradeName _upgradeName = UpgradeName.Barrel;
        switch (name)
        {
            case "Bucket":
                _upgradeName = UpgradeName.Bucket;
                break;
            case "Barrel":
                _upgradeName = UpgradeName.Barrel;
                break;
            case "HenPen":
                _upgradeName= UpgradeName.HenPen;
                break;
            case "HayBale":
                _upgradeName = UpgradeName.Haybale;
                break;
            default:
                break;
        }

        switch (_upgradeName)
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


    public void ToggleShopMenu()
    {
        if (shopMenu.activeInHierarchy == false)
        {
            shopMenu.SetActive(true);
        }
        else
        {
            shopMenu.SetActive(false);
        }
    }
}