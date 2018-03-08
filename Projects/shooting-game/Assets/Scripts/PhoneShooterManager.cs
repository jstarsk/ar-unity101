using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhoneShooterManager : MonoBehaviour {

    public GameObject PhoneXPrefab;

    public float PhoneXSpeed = 50.0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if(Input.GetKeyDown(KeyCode.Space)){
            GameObject PhoneXCopy = Instantiate(PhoneXPrefab);
            PhoneXCopy.transform.position = transform.position;
            Rigidbody rb = PhoneXCopy.GetComponent<Rigidbody>();
            rb.velocity = transform.rotation * Vector3.forward * PhoneXSpeed;
        }
	}
}
