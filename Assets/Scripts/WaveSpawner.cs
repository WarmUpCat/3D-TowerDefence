using System.Collections;//needed for Ienumerator
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

namespace HGK
{
    public class WaveSpawner : MonoBehaviour
    {
        //we want static as enemies need to change this value whn they die
        public static int EnemiesALive;

        //public Transform enemyPrefab; into array
        public Wave[] waves;

        public Transform spawnPoint;

        public float timeBetweenWaves = 5f;

        //keeps track of when to spawn next
        private float countdown = 2f;

        //refernce to text objetc for wave countdown
        public TMP_Text waveCountDownText;
             
        //the inital wave index
        private int waveIndex = 0;

        private void Update()
        {
            //Only bypass if enemeies =0
            if(EnemiesALive > 0){
                return;
            }

            //if no enemies do the follwing
            if (countdown <= 0f)
            {
                //call the enumerator method below
                StartCoroutine(SpawnWave());
                countdown = timeBetweenWaves;
            }
            countdown -= Time.deltaTime;  //every second 

            //show the countdown on gui
            //cuts off the decimals
            countdown -= Time.deltaTime;

            countdown = Mathf.Clamp(countdown, 0f, Mathf.Infinity);

            //waveCountDownText.text = Mathf.Round(countdown).ToString();
            waveCountDownText.text = string.Format("{0:00.00}", countdown);

        }


        /// <summary>
        /// Iterates or increase index of the wave
        /// coroutine is uded to have delay before each spawn of enemy
        /// </summary>
        IEnumerator SpawnWave()
        {
            //increase the wave index
            //Count the nu,ber of waves for GameOver UI-Static
            PlayerStats.Rounds++;

            Wave wave = waves[waveIndex];

            for (int i = 0; i < wave.count; i++)
            {
                SpawnEnemy(wave.enemy);
                yield return new WaitForSeconds(1f / wave.rate);
            }
            //increment after loop
            waveIndex++;
           
        }

        /// <summary>
        /// Called by method avove to instantiate enemies according to wave
        /// </summary>
        void SpawnEnemy(GameObject enemy)
        {
            // what will be spawnwd , then where ot wil be spawned
            Instantiate(enemy, spawnPoint.position, spawnPoint.rotation);
            //increase enemies alive static int every time enemy is instantiate, then later reduce when killed in Enemy script die()
            EnemiesALive++;
        }


    }

}
