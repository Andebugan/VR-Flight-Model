using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanePhysics : MonoBehaviour {
	float deltax = 0.0f;
	float deltay = 0.0f;
	float deltaz = 0.0f;
	public float x = 1.0f;
	public float y = 1.0f;
	public float z = 1.0f;
	public float k = 2.0f;
	public float speed = 20.0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate(deltax, 0, deltay, Space.Self);
		transform.Rotate(0,  deltaz, 0, Space.World);
		deltax += -Input.GetAxis("Mouse Y")*Time.deltaTime*x;
		deltay += -Input.GetAxis("Mouse X")*Time.deltaTime*y;
		deltaz += -deltay*Time.deltaTime*z;
		transform.position += transform.forward*Time.deltaTime*speed;
		speed -= transform.forward.y*k;
		if (speed < 10.0f){
			speed = 10.0f;
		}
	}
}
