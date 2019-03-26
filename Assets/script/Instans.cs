using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instans : MonoBehaviour {

	// Use this for initialization
	void Start () {
        GameObject corse = Resources.Load("stage") as GameObject;
        GameObject stage = Instantiate(corse);
        Vector3 pos = new Vector3(0, 0, 0);
        stage.transform.position = pos;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
