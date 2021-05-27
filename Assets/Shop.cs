using UnityEngine;
namespace Cody_Towers
{
    public class Shop : MonoBehaviour
    {
        BuildManager buildManager;
        private void Start()
        {
            buildManager = BuildManager.instance;
        }
        public void PurchaseStandardTower()
        {
            Debug.Log("Standard Tower Selected");
            buildManager.setTurretToBuild(buildManager.standartTowerPrefab);
        }
        public void PurchaseAnotherTower()
        {
            Debug.Log("Another Tower Selected");
            buildManager.setTurretToBuild(buildManager.anotherTowerPrefab);
        }
    }
}