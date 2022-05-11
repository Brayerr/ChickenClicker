using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum Upgrade { barrel, bucket, hanpan, haybale }
public class ClickerScript : MonoBehaviour
{

    public static ClickerScript Instance;
    List<Upgrade> ActiveUpgrades = new List<Upgrade>();
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
        //loop every X time 
        {
            foreach (var _upgrade in ActiveUpgrades)
            {
                switch (_upgrade)
                {

                    case Upgrade.barrel:
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
        }
    }
}

