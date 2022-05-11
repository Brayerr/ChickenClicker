using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonManager : MonoBehaviour
{
    [SerializeField] GameObject BucketPrefab, HenPrefab;
    [SerializeField] GameObject shopMenuButton;
    [SerializeField] GameObject shopMenu;
    [SerializeField] Text eggCount;

    public void AddEggs()
    {
        //Activate Effect
        //Print Added Eggs
        PlayerData.Instance.currentEggs++;
        eggCount.text = PlayerData.Instance.currentEggs.ToString();
        Debug.Log("Egg", eggCount);
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
            case UpgradeName.Bucket:
                PlayerData.Instance.ActivateUpgrade(BucketPrefab);
                break;
            case UpgradeName.HenPen:
                PlayerData.Instance.ActivateUpgrade(HenPrefab);
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