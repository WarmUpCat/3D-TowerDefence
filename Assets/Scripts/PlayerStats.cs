using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HGK
{
    public class PlayerStats : MonoBehaviour
    {
        public static int Lives;
        public int startLives = 20;
        void Start()
        {
            Lives = startLives;
        }

        
    }
}

