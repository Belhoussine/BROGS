using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectionManager : MonoBehaviour
{

    public Text text;
    private SelectionLogic selected;
    private bool flag = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                if (flag)
                {
                    selected.unSelect();
                }
                var selection = hit.transform;
                if (selection.tag.Equals("Player"))
                {
                    SelectionLogic sl = selection.gameObject.GetComponent<SelectionLogic>();
                    sl.Select();
                    flag = true;
                    selected = sl;
                    //Debug.Log(selection.gameObject.GetComponent<BrogProperties>().Name);
                    text.text = "Name: " + selection.gameObject.GetComponent<BrogProperties>().Name;
                }
            }
        }
    }
}
