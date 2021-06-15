using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

namespace HGK
{
    public class GameOver : MonoBehaviour
    {
        public TMP_Text roundsText;

        /// <summary>
        /// called every time gameobjetc is enabled at end of game
        /// </summary>
        private void OnEnable()
        {
            //grabs the counter in wave spawner
            roundsText.text = PlayerStats.Rounds.ToString();

        }

        //reload the level
        public void Retry()
        {
            //to get the currently active scen and reload this level
            //Instaead of SceneManager.LoadScene(0);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        public void Menu()
        {
            Debug.Log("Show Menu Screen");
        }
    }
}