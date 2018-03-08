using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotationManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        float rotationSpeed = 5.0f;
        float xMouse = Input.GetAxis("Mouse X") * rotationSpeed;
        float yMouse = Input.GetAxis("Mouse Y") * rotationSpeed;

        transform.localRotation = Quaternion.Euler(0, xMouse, 0) * transform.localRotation;
        Camera camera = GetComponentInChildren<Camera>();
        camera.transform.localRotation = Quaternion.Euler(yMouse, 0, 0) * camera.transform.localRotation;
	}
}
