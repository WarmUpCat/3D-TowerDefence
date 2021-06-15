using HGK;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HGK
{
    public class GameManager : MonoBehaviour
    {
        //check if game ednded already - make it available everywhere
        public static bool GameIsOver;

        /// <summary>
        /// Game over UI objetc which will be enabled on gmae over - then game over script will do everything else
        /// </summary>
        public GameObject gameOverUI;

        private void Start()
        {
            //as this is static we need to set at the beginning of each scene to reset to false
            GameIsOver = false;
        }



        /// <summary>
        /// check bool if game ednded already so does not repeat game end
        /// if lives reaches zero ocall the endgame function
        /// </summary>
        void Update()
        {
            //check if game ednded already
            if (GameIsOver)
            {
                return;
            }

            //ends the game instantly
            if (Input.GetKeyDown("escape"))
            {
                EndGame();
            }
            //if lives reaches zero ocall the endgame function
            if (PlayerStats.Lives <= 0)
            {
                EndGame();
            }
        }
        /// <summary>
        /// Ends the game
        /// </summary>
        void EndGame()
        {
            GameIsOver = true;
            Debug.Log("Game over!");

            //enable th egmaeover ui when game is over
            gameOverUI.SetActive(true); 
        }
    }
}
