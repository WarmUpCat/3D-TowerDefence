using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace HGK
{
    public class WaveSpawner : MonoBehaviour
    {
        public Transform enemyPrefab;
        public Transform spawnPoint;

        public float timeBetweenWaves = 5f;
        private float countdown = 2f;


        private int waveNumber = 1;

        private void Update()
        {
            if (countdown <= 0f)
            {
                SpawnWave();
                countdown = timeBetweenWaves;
            }
            countdown -= Time.deltaTime;  //every second 
        }



        void SpawnWave()
        {

            //Count the nu,ber of waves for GameOver UI-Static
            PlayerStats.Rounds++;

            //for (int i = 0; i < waveNumber; i++)
            //{
            SpawnEnemy();

            //}
            waveNumber++;
        }

        void SpawnEnemy()
        {
            Instantiate(enemyPrefab, spawnPoint.position, spawnPoint.rotation);
        }


    }

}
