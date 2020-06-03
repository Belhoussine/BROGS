using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BrogProperties : MonoBehaviour
{

    public string Name;
    public GameObject nameGenObject;
    private Lexic.NameGenerator namegen;

    // Start is called before the first frame update
    void Start()
    {
        namegen = nameGenObject.GetComponent<Lexic.NameGenerator>();
        Name = namegen.GetNextRandomName();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
