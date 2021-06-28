using HGK;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace HGK
{
    public class LivesUI : MonoBehaviour
    {
        public Text livesText;
        int maxLives;
        public GameObject gameMaster;

        private void Start()
        {
            gameMaster = GameObject.Find("GameMaster"); 
            PlayerStats playerStats = gameMaster.GetComponent<PlayerStats>();
            maxLives = playerStats.startLives;
        }

        // Update is called once per frame
        void Update()
        {
            //gets the lives fromplayer stats to display in LivesUI
            livesText.text = PlayerStats.Lives.ToString() + "/" + maxLives.ToString() + " Lives";
        }
    }
}