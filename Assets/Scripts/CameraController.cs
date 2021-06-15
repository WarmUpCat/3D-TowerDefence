using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HGK
{
    public class CameraController : MonoBehaviour
    {





        // Update is called once per frame
        void Update()
        {

            //Stop the player being able to move screen on gmae over
            if (GameManager.GameIsOver)
            {
                this.enabled = false;
                return;
            }





        }


    }
}

