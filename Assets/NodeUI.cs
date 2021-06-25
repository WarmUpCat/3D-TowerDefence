using HGK;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NodeUI : MonoBehaviour
{
    public GameObject ui;
    private Node target;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void SetTarget(Node _target)
    {
        target = _target;
        transform.position = target.GetBuildPosition();

        ui.SetActive(true);
    }

    public void Hide()
    {
        ui.SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
