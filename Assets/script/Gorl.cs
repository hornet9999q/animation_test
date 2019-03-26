using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gorl : MonoBehaviour {
    public GameObject Player = null;
    public Animeta anime;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter(Collision coll){
        if (coll.gameObject.name == "Player"){
            anime.Gorl();
        }
    }
}
