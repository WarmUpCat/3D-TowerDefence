using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Cody_Towers
{
    public class Towers : MonoBehaviour
    {
        [SerializeField] private Transform target;

        [Header("TowerStats")]
        [SerializeField] private float range = 15f;
        public float fireRate = 1f;

        [Header("Unity setup data")]
        public string enemyTag = "Enemy";
        public Transform partToRotate;
        private float turnSpeed = 10f;
        private float fireCountDown = 0f;
        public GameObject bulletPrefab;
        public Transform firePoint;

        // Start is called before the first frame update
        void Start()
        {
            InvokeRepeating("UpdateTarget", 0f, 0.5f);
        }

        // Update is called once per frame
        void Update()
        {

            if (target == null)
                return;
            //target lock on 
            Vector3 dir = target.position - transform.position;
            Quaternion lookRotation = Quaternion.LookRotation(dir);
            Vector3 rotation = Quaternion.Lerp(partToRotate.rotation, lookRotation, Time.deltaTime * turnSpeed).eulerAngles;
            partToRotate.rotation = Quaternion.Euler(0f, rotation.y, 0f);

            if (fireCountDown <= 0)
            {
                shoot();
                fireCountDown = 1f / fireRate;
            }
            fireCountDown -= Time.deltaTime;
        }
        void UpdateTarget()
        {
            //finds closest target
            GameObject[] enemies = GameObject.FindGameObjectsWithTag(enemyTag);
            float shortestDistance = Mathf.Infinity;
            GameObject nearestEnemy = null;



            foreach (GameObject enemy in enemies)
            {
                //foreach enemy check distance
                float distanceToEnemy = Vector3.Distance(transform.position, enemy.transform.position);
                //check if distance is the shortest foreach enemy
                if (distanceToEnemy < shortestDistance)
                {
                    //closest enemy becomes enemy
                    shortestDistance = distanceToEnemy;
                    nearestEnemy = enemy;

                }


            }

            if (nearestEnemy != null && shortestDistance <= range)
            {
                target = nearestEnemy.transform;
            }

        }

        void shoot()
        {
           GameObject bulletGO = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
            HGK.BulletHandler bullet = bulletGO.GetComponent<HGK.BulletHandler>();
            if(bullet != null)
                bullet.Seek(target);
            

        }




        private void OnDrawGizmosSelected()
        {
            Gizmos.color = Color.red;
            Gizmos.DrawWireSphere(transform.position, range);
        }

    }
}