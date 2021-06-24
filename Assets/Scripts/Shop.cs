using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
namespace HGK
{
    public class Shop : MonoBehaviour
    {
        //BuildManager buildManager;

        //void Start()
        //{
        //    buildManager = BuildManager.instance;
        //}


        //public void PurchaseStandardTower()
        //{
        //    Debug.Log("Standard Tower Selected");
        //    buildManager.SetTowerToBuild(buildManager.standardTowerPrefab); //choose what tower to build by calling public void SetTowerToBuild(GameObject tower) in BuildManager

        //}

        //public void PurchaseAnotherTower()
        //{
        //    Debug.Log("Another Tower Selected");
        //    buildManager.SetTowerToBuild(buildManager.anotherTowerPrefab);
        //}
        public Cody_Towers.TowerBluePrint standardTower;
        public Cody_Towers.TowerBluePrint anothertower;
        public Cody_Towers.TowerBluePrint wallTower;
        Cody_Towers.BuildManager buildManager;
        private void Start()
        {
            buildManager = Cody_Towers.BuildManager.instance;
        }
        public void SelectStandardTower()
        {
            Debug.Log("Standard Tower Selected");
            buildManager.SelectTowerToBuild(standardTower);
        }
        public void SelectAnotherTower()
        {
            Debug.Log("Another Tower Selected");
            buildManager.SelectTowerToBuild(anothertower);
        }
        public void SelectWall()
        {
            buildManager.SelectTowerToBuild(wallTower);
        }
    }

}
