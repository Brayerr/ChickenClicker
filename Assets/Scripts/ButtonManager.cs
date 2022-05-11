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
    public void BuyUpgrade(Upgrade upgradeToAdd)
    {
        switch (upgradeToAdd)
        {
            case Upgrade.barrel:
                PlayerData.Instance.maxBarrels 
                break;
            case Upgrade.bucket:
                break;
            case Upgrade.hanpan:
                break;
            case Upgrade.haybale:
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