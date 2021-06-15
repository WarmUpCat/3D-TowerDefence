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


        // Update is called once per frame
        void Update()
        {
            //gets the lives fromplayer stats to display in LivesUI
            livesText.text = PlayerStats.Lives.ToString() + " Lives";
        }
    }
}