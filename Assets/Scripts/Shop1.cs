using UnityEngine;
namespace Cody_Towers
{
    public class Shop : MonoBehaviour
    {
        public TowerBluePrint standardTower;
        public TowerBluePrint anothertower;
        BuildManager buildManager;
        private void Start()
        {
            buildManager = BuildManager.instance;
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
    }
}