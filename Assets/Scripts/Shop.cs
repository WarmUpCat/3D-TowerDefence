using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shop : MonoBehaviour
{
    BuildManager buildManager;
    private void Start()
    {
        buildManager = BuildManager.instance;
    }


    public void PurchaseStandardTower()
    {
        Debug.Log("Standard Tower purchased");
        buildManager.SetTowerToBuild(buildManager.standardTowerPrefab); //choose what tower to build by calling public void SetTowerToBuild(GameObject tower) in BuildManager

    }

    public void PurchaseAnotherTower()
    {
        Debug.Log("Another Tower purchased");
        buildManager.SetTowerToBuild(buildManager.anotherTowerPrefab);
    }
}
