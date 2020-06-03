using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectionLogic : MonoBehaviour
{

    public bool isSelected = false;
    public GameObject Pyramid;

    // Start is called before the first frame update
    void Start()
    {
        Pyramid.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (isSelected)
        {
            Pyramid.SetActive(true);
        }
        if (!isSelected)
        {
            Pyramid.SetActive(false);
        }
    }

    public void Select()
    {
        isSelected = true;
        Debug.Log("I've been selected");
    }
    public void unSelect()
    {
        isSelected = false;
    }

}
