using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotatearound : MonoBehaviour {
	public float rotateSpeed;
	public GameObject rotateCenter;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		gameObject.transform.RotateAround (rotateCenter.transform.position,Vector3.up,rotateSpeed/3600);
	}
}
