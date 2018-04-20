using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControls : MonoBehaviour {

    float minCamSize = 20f;
    float maxCamSize = 120f;
    float sensitivity = 100f;

    float panSensitivity = 1f;
    Vector3 lastPos;


    bool awake = true;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (awake)
        {
            if (Input.GetMouseButtonDown(0))
            {
                lastPos = Input.mousePosition;
            }

            if (Input.GetMouseButton(0))
            {
                panSensitivity = Camera.main.orthographicSize / 100f;
                Vector3 delta = -Input.mousePosition + lastPos;
                transform.Translate(delta.x * panSensitivity, delta.y * panSensitivity, 0);
                lastPos = Input.mousePosition;
            }

            float camSize = Camera.main.orthographicSize;
            camSize -= Input.GetAxis("Mouse ScrollWheel") * sensitivity;
            //Debug.Log("Wheel moved: " + Input.GetAxis("Mouse ScrollWheel"));
            camSize = Mathf.Clamp(camSize, minCamSize, maxCamSize);
            Camera.main.orthographicSize = camSize;
            //fov = Mathf.Clamp(fov, minFov, maxFov);
            //Camera.main.fieldOfView = fov;
        }

    }

    public void wakeUp()
    {
        awake = true;
    }

    public void sleep()
    {
        awake = false;
    }
}
