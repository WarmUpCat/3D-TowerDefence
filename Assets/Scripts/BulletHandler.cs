using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HGK
{
    public class BulletHandler : MonoBehaviour
    {
        
        // codies varibales code
        private Transform target;
        public float speed = 70f;
        public GameObject bulletImpactEffect;


        //doing damage value varibale
        public int damage = 50;

        /// <summary>
        /// codies code
        /// </summary>
        public void Seek(Transform _target)
        {
            target = _target;
        }

        /// <summary>
        /// codies code
        /// </summary>
        void Update()
        {
            if (target == null)
            {
                Destroy(gameObject);
                return;
            }

            Vector3 dir = target.position - transform.position;
            float distanceThisFrame = speed * Time.deltaTime;

            if (dir.magnitude <= distanceThisFrame)
            {
                HitTarget();
                return;
            }
            transform.Translate(dir.normalized * distanceThisFrame, Space.World);

        }


        /// <summary>
        /// codies code
        /// </summary>
        void HitTarget()
        {
            GameObject effectIns = Instantiate(bulletImpactEffect, transform.position, transform.rotation);
            Destroy(effectIns, 2f);

            Damage(target);
           // Destroy(gameObject);

        }

        /// <summary>
        /// Transform enemy-entire Transform
        /// </summary>
        /// <param name="enemy"></param>
        void Damage(Transform enemy)
        {
            //get the Enemy script component of whole GameObjetc Transform Enemy
            Enemy e= enemy.GetComponent<Enemy>();

            //in the case the object does not have enemy script
            if(e != null)
            {
                e.TakeDamage(20);
                Debug.Log("took Damage" + damage);
            }
            
        }
    }
}