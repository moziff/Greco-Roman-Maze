using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Door : MonoBehaviour 
{

	public AudioClip[] clips;
	public bool locked = true;
	public bool opening = false;
    // Create a boolean value called "locked" that can be checked in OnDoorClicked() 
    // Create a boolean value called "opening" that can be checked in Update() 

    void Update() {
        // If the door is opening and it is not fully raised
		if (opening){
			// Animate the door raising up
			GetComponent<Animator>().SetTrigger("trigger");
		}
            

    }

    public void OnDoorClicked() {

		if (!locked) {
			AudioSource.PlayClipAtPoint(clips[0], transform.position);
			opening = true;
			GetComponent<BoxCollider> ().enabled = false;
		} else {
			AudioSource.PlayClipAtPoint(clips[1], transform.position);
			opening = false;
		}
        // If the door is clicked and unlocked
            // Set the "opening" boolean to true
        // (optionally) Else
            // Play a sound to indicate the door is locked
    }

    public void Unlock()
    {
		locked = false;
        // You'll need to set "locked" to false here
    }
}
