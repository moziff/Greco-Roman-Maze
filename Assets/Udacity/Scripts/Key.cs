using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour 
{
	private AudioSource source;
	private bool keyCollected=false;

	public GameObject poofPrefab;
    //Create a reference to the KeyPoofPrefab and Door
	void Start()
	{
		source = GetComponent<AudioSource> ();
		//Not required, but for fun why not try adding a Key Floating Animation here :)
	}
	void Update()
	{
		//Not required, but for fun why not try adding a Key Floating Animation here :)
	}

	public void OnKeyClicked()
	{
		source.Play ();
		FindObjectOfType<Door> ().Unlock();
		keyCollected = true;
		Instantiate (poofPrefab,transform.position,poofPrefab.transform.rotation,transform.parent);
		AudioSource.PlayClipAtPoint(source.clip, transform.position);
		Destroy (gameObject);

        // Instatiate the KeyPoof Prefab where this key is located
        // Make sure the poof animates vertically
        // Call the Unlock() method on the Door
        // Set the Key Collected Variable to true
        // Destroy the key. Check the Unity documentation on how to use Destroy
    }
		
}
