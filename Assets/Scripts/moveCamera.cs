using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class moveCamera : MonoBehaviour {
	public float rotateSpeed;
	public float moveSpeed;
	public Slider speedSlider;
	public Slider hightSlider;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		//控制前进后退
		transform.Translate(Vector3.forward*speedSlider.value);
		//控制上下
		transform.Translate(Vector3.up*hightSlider.value);

		//旋转视角
		if (Input.touchCount == 1) {
			Touch touch = Input.GetTouch (0);
			Vector2 dif = touch.deltaPosition;
			transform.Rotate (-Vector3.down * dif.x*rotateSpeed);
			transform.Rotate (Vector3.left * dif.y*rotateSpeed);
		}

	}
}
