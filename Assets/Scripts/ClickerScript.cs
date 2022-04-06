using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickerScript : MonoBehaviour
{

    [SerializeField] Text eggAmoutTxt;
    [SerializeField] float eggAmount;
    [SerializeField] int _happiness;
    [SerializeField] int eggAdded = 1;
    [SerializeField] int happinessNeeded = 100;


    public void AddEggs()
    {
        eggAmount += eggAdded;
        eggAmoutTxt.text = eggAmount.ToString();

        if (eggAmount >= (eggAdded * happinessNeeded))
        {
            eggAdded++;
        }
    }


}