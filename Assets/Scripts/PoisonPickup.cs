using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoisonPickup : MonoBehaviour
{
    public Material red;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("Poisoned...");
            other.GetComponent<Renderer>().material = red;
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
