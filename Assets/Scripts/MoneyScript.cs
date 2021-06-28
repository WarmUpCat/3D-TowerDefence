using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace HGK 
{ 
public class MoneyScript : MonoBehaviour
{
    public GameObject gameMaster;
    public Text moneyText;
    public int money;
    // Start is called before the first frame update
    void Start()
    {
        gameMaster = GameObject.Find("GameMaster");
    }

    // Update is called once per frame
    void Update()
        {
            money = PlayerStats.Money;
            moneyText.text = money.ToString() + " Gold";
        }
} }
