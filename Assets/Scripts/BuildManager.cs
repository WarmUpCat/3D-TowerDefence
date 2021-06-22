using HGK;
using UnityEngine;

namespace Cody_Towers
{
    public class BuildManager : MonoBehaviour
    {
        public static BuildManager instance;
        private void Awake()
        {
            if (instance != null)
            {
                Debug.LogError("More than one BuildManager in scene!");
            }
            instance = this;

        }
        public GameObject standartTowerPrefab;
        public GameObject anotherTowerPrefab;
        //private GameObject towerToBuild;
        private TowerBluePrint towerToBuild;

        public bool canBuild {get { return towerToBuild != null; } }
        
        public void SelectTowerToBuild(TowerBluePrint tower)
        {
            towerToBuild = tower;

        }
        public void BuildTowerOn(HGK.Node node)
        {
            if (PlayerStats.Money < towerToBuild.cost)
            {
                Debug.Log("Not enough money to build that!");
                return;
            }
            PlayerStats.Money -= towerToBuild.cost;
            GameObject tower = (GameObject)Instantiate(towerToBuild.prefab, node.GetBuildPosition(), Quaternion.identity);
            node.tower = tower;

            Debug.Log("Tower build! Money left: " + PlayerStats.Money);
        }
    }
}