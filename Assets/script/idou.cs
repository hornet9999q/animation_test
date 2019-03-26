using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class idou : MonoBehaviour {
    private float speed = 2;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.position += new Vector3(Input.GetAxis("Horizontal")*Time.deltaTime*speed, 0, Input.GetAxis("Vertical")*Time.deltaTime*speed);
	}
}
