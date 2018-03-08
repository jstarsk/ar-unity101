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
        float xMouse = Input.GetAxis("Mouse X");;
        float yMouse = Input.GetAxis("Mouse Y"); ;
        print("X: " + xMouse + " Y: " + yMouse);
	}
}
