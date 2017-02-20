using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chest : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void OpenChest(){

		// Animator is not working! I dont think the chest has a top or bottom gameobjects. so this will not work
		GetComponent<Animator>().SetTrigger("trigger");
		GetComponent<AudioSource> ().Play ();
	}
}
