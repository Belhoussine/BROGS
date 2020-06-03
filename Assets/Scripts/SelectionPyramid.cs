using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectionPyramid : MonoBehaviour
{
    public float minpos = 2.5f;
    public float maxpos = 4f;
    public float movSpeed = 0.25f;
    public float rotSpeed = 2f;
    private bool isRising = true;
    float EPSILON = 0.1f;
    Vector3 newPos;
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //transform.Rotate(0f, rotSpeed, 0f);
        transform.RotateAround(transform.position, transform.up, Time.deltaTime * rotSpeed);
        newPos = transform.position;
        if (isRising)
        {
            newPos.y += movSpeed * Time.deltaTime;
            
            if (System.Math.Abs(newPos.y - maxpos) < EPSILON)
            {
                isRising = false;
            }
        }
        if (!isRising)
        {
            newPos.y -= movSpeed * Time.deltaTime;

            if (System.Math.Abs(newPos.y - minpos) < EPSILON)
            {
                isRising = true;
            }
        }

        rb.MovePosition(newPos);
    }
}
