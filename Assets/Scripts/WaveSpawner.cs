using System.Collections;//needed for Ienumerator
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

namespace HGK
{
    public class WaveSpawner : MonoBehaviour
    {
        public Transform enemyPrefab;
        public Transform spawnPoint;

        public float timeBetweenWaves = 5f;
        private float countdown = 2f;

        //refernce to text objetc for wave countdown
        public TMP_Text waveCountDownText;
             
        //the inital wave index
        private int waveIndex = 0;

        private void Update()
        {
            if (countdown <= 0f)
            {
                //call the enumerator method below
                StartCoroutine(SpawnWave());
                countdown = timeBetweenWaves;
            }
            countdown -= Time.deltaTime;  //every second 

            //show the countdown on gui
            //cuts off the decimals
            waveCountDownText.text = Mathf.Round(countdown).ToString();
        }


        /// <summary>
        /// Iterates or increase index of the wave
        /// coroutine is uded to have delay before each spawn of enemy
        /// </summary>
        IEnumerator SpawnWave()
        {
            //increase the wave index
            waveIndex++;
            //Count the nu,ber of waves for GameOver UI-Static
            PlayerStats.Rounds++;

            for (int i = 0; i < waveIndex; i++)
            {
                SpawnEnemy();
                yield return new WaitForSeconds(0.5f);
            }
           
        }

        /// <summary>
        /// Called by method avove to instantiate enemies according to wave
        /// </summary>
        void SpawnEnemy()
        {
            // what will be spawnwd , then where ot wil be spawned
            Instantiate(enemyPrefab, spawnPoint.position, spawnPoint.rotation);
        }


    }

}
