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
        private GameObject TowerToBuild;

        public GameObject GetTowerToBuild()
        {
            return TowerToBuild;
        }
        public void setTurretToBuild(GameObject tower)
        {
            TowerToBuild = tower;


        }
    }
}