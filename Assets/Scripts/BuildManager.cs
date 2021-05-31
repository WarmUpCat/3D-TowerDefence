using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildManager : MonoBehaviour
{
    public static BuildManager instance;

    void Awake()  //singletone instance
    {
        if(instance != null)
        {
            Debug.LogError("More than one build manager in scene!");
            return;
        }
        instance = this;

    }



    public GameObject standardTowerPrefab;
    public GameObject anotherTowerPrefab;


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
