using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonManager : MonoBehaviour
{
    //List<Upgrades> activeUpgradeList;
    [SerializeField] List<Transform> barrelPos;
    [SerializeField] List<Transform> bucketPos;
    [SerializeField] List<Transform> henPenPos;
    [SerializeField] List<Transform> hayBalePos;
    [SerializeField] GameObject shopMenu;
    [SerializeField] GameObject shopMenuButton;

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
                if (PlayerData.Instance.currBarrels < PlayerData.Instance.maxBarrels)
                {
                    
                }
                break;
            case UpgradeName.Bucket:
                if (PlayerData.Instance.currBuckets < PlayerData.Instance.maxBuckets)
                {

                }
                break;
            case UpgradeName.HenPen:
                if (PlayerData.Instance.currPens < PlayerData.Instance.maxPens)
                {

                }
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