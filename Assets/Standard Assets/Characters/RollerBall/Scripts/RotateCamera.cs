using UnityEngine;
using System.Collections;
using UnityStandardAssets.CrossPlatformInput;

public class RotateCamera : MonoBehaviour {
    public float RotateSpeed ;
    Vector3 direction;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        direction = Vector3.zero;

        if (Input.GetKey(KeyCode.RightArrow))
            direction = Vector3.up * 90;
        if (Input.GetKey(KeyCode.LeftArrow))
            direction = Vector3.up * -90;
       
        transform.Rotate(direction *Time.deltaTime);
	}
}
