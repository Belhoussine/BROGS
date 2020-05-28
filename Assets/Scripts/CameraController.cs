using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
	public float panSpeed = 20f;
	public float panBorder = 1f;
    public Vector2 panLimits;
    public float scrollSpeed = 40f;
    public float minZoom = 3f;
    public float maxZoom = 13f;

    // Update is called once per frame
    void FixedUpdate()
    {

		Vector3 pos = transform.position;

        //Change positions in the four directions depending on which botona brekti 3liha
		if (Input.GetKey("z") || Input.mousePosition.y >= Screen.height - panBorder)
		{
			pos.z += panSpeed * Time.deltaTime;
		}
        if (Input.GetKey("s") || Input.mousePosition.y <= panBorder)
        {
            pos.z -= panSpeed * Time.deltaTime;
        }
        if (Input.GetKey("d") || Input.mousePosition.x >= Screen.width - panBorder)
        {
            pos.x += panSpeed * Time.deltaTime;
        }
        if (Input.GetKey("q") || Input.mousePosition.x <= panBorder)
        {
            pos.x -= panSpeed * Time.deltaTime;
        }

       //Limitations on camera, basically bach mat3iye9ch (Clamp function mtitza)
        pos.x = Mathf.Clamp(pos.x, -panLimits.x, panLimits.x);
        pos.z = Mathf.Clamp(pos.z, -panLimits.y, panLimits.y);

        float scroll = Input.GetAxis("Mouse ScrollWheel");

        pos.y += -scroll * scrollSpeed * Time.deltaTime;

        pos.y = Mathf.Clamp(pos.y, minZoom, maxZoom);


        transform.position = pos;
        
    }
}
