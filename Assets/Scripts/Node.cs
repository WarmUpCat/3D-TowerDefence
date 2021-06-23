using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

namespace HGK
{
    public class Node : MonoBehaviour
    {
        public Material hoverMat;
        public Vector3 positionOffset;
        public Material notEnoughMoneyMat;

        [Header("Optional")]
        public GameObject tower;

        private Renderer rend;
        public Material startMat;
        Cody_Towers.BuildManager buildManager;
        void Start()
        {

            rend = GetComponent<Renderer>();
            rend.material = startMat;
            buildManager = Cody_Towers.BuildManager.instance;

        }

        public Vector3 GetBuildPosition()
        {
            return transform.position + positionOffset;

        }
        private void OnMouseDown()
        {
            if (EventSystem.current.IsPointerOverGameObject())
                return;

            if (!buildManager.canBuild)
                return;
            if (tower != null)
            {
                Debug.Log("Cant Build There!!! - TODO: Display on screen");
                return;

            }
            buildManager.BuildTowerOn(this);

        }
        private void OnMouseEnter()
        {
            if (EventSystem.current.IsPointerOverGameObject())
                return;

            if (!buildManager.canBuild)
            {
                return;
            }
            if (buildManager.HasMoney)
            {
                rend.material = hoverMat;

            }
            else 
            {
                rend.material = notEnoughMoneyMat;
            }
            

        }

        private void OnMouseExit()
        {

            rend.material = startMat;

        }

    }

}
