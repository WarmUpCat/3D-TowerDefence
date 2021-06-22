using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HGK
{
    public class HGKBuildManager : MonoBehaviour
    {
        public static HGKBuildManager instance;

        void Awake()  //singletone instance
        {
            if (instance != null)
            {
                Debug.LogError("More than one build manager in scene!");
                return;
            }

            instance = this;

        }



        public GameObject standardTowerPrefab;
        //public GameObject anotherTowerPrefab;

        private void Start()
        {
            towerToBuild = standardTowerPrefab;
        }

        private GameObject towerToBuild;

        public GameObject GetTowerToBuild()
        {
            return towerToBuild;
        }


        //Below will be called from other methods- will change what tower to build  - willbe called from Shop class- purchaseStandardTower() and public void PurchaseAnotherTower()      
        public void SetTowerToBuild(GameObject tower)
        {
            towerToBuild = tower;
        }

    }

}
