using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using HGK;
using Cody_Towers;

public class MoneyUI : MonoBehaviour
{
    public TextMeshProUGUI Money;
    //public TextMeshProUGUI tower1;
    //public TextMeshProUGUI tower2;
    //[SerializeField]private int tower1Cost;
    //[SerializeField]private int tower2Cost;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      

        Money.text = "$" + PlayerStats.Money.ToString();
        //tower1.text = "Cost: " + "$" + tower1Cost;
        //tower1.text = "Cost: " + "$" + tower2Cost;
    }
}
