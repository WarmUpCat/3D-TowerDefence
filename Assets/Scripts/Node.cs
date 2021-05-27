using UnityEngine;
using UnityEngine.EventSystems;

namespace Cody_Towers
{
    public class Node : MonoBehaviour
    {
        public Color hoverColor;
        public Vector3 positionOffset;

        private GameObject tower;

        private Renderer rend;
        private Color startColor;
        BuildManager buildManager;
        void Start()
        {
            rend = GetComponent<Renderer>();
            startColor = rend.material.color;
            buildManager = BuildManager.instance;

        }
        private void OnMouseDown()
        {
            if (EventSystem.current.IsPointerOverGameObject())
                return;

            if (buildManager.GetTowerToBuild() == null)
                return;
                if (tower != null)
                {
                    Debug.Log("Cant Build There!!! - TODO: Display on screen");
                    return;

                }
            GameObject towerToBuild = BuildManager.instance.GetTowerToBuild();
            tower = (GameObject)Instantiate(towerToBuild, transform.position + positionOffset, transform.rotation);

        }
        private void OnMouseEnter()
        {
            if(EventSystem.current.IsPointerOverGameObject())
                return;
            
            if (buildManager.GetTowerToBuild() == null)
                return;

            rend.material.color = hoverColor;

        }

        private void OnMouseExit()
        {
            rend.material.color = startColor;

        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}