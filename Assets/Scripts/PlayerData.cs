using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum Upgrade { Barrel, Bucket, HenPen, Haybale }
public class PlayerData : MonoBehaviour
{
    public static PlayerData Instance;
    public List<Transform> BucketPos;
    public List<Transform> BarrelPos;
    public List<Transform> PenPos;
    public List<Transform> HayPos;
    public int currentEggs = 0, passiveEggs = 0, eggsToAdd = 1;
    public int currBarrels, maxBarrels, currBuckets, maxBuckets, currPens, maxPens, currHay, maxHaybales;

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

    }
}