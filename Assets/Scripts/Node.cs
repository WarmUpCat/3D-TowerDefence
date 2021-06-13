using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

namespace HGK
{
    public class Node : MonoBehaviour
    {
        public Color hoverColor;
        //public Vector3 positionOffset;

        private GameObject tower;

        private Renderer rend;//don't use renderer as keyword for name -then assign in start- then change the rend color in OnMouseDown

        private Color startColor; //start color + exit color

        //BuildManager buildManager;

        void Start()
        {
            rend = GetComponent<Renderer>();

            startColor = rend.material.color;

            //buildManager = BuildManager.instance;
        }


        void onMouseDown()
        {

            //if(EventSystem.current.IsPointerOverGameObject())
            //    return;

            //if (buildManager.GetTowerToBuild() == null)
            //{
            //    return;
            //}

            if (tower != null)
            {
                Debug.Log("Can't build there! - TODO: Display on screen");
                return;
            }


            GameObject towerToBuild = BuildManager.instance.GetTowerToBuild();
            tower = (GameObject)Instantiate(towerToBuild, transform.position, transform.rotation);


            //build tower
            //GameObject towerToBuild = buildManager.GetTowerToBuild();

            //build tower
            //tower = (GameObject)Instantiate(towerToBuild, transform.position + positionOffset, transform.rotation );

        }

        void OnMouseEnter() ///called every time mouse passes by collider of this object- to notify we can build a tower on the node
        {
            //if (EventSystem.current.IsPointerOverGameObject())
            //    return;

            //if(buildManager.GetTowerToBuild() == null)
            //{
            //    return;
            //}
            rend.material.color = hoverColor;
        }

        private void OnMouseExit()
        {
            rend.material.color = startColor; //chage the mouse color back when exiting the collider
        }

    }

}
