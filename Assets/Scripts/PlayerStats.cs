using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HGK
{
    public class PlayerStats : MonoBehaviour
    {
        public static int Lives;
        public int startLives = 20;

        //Statoic varibale :Rounds = Waves;  thsi will be how many waves the player survived-will be displayed in GameOver
        public static int Rounds;

        void Start()
        {
            Lives = startLives;

            //set it to zero every time game restarts
            Rounds = 0;
        }

        
    }
}

