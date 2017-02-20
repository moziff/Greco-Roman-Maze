using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour 
{
	public GameObject coinPoof;
	private AudioSource source;
    //Create a reference to the CoinPoofPrefab
	void Start(){
		source = GetComponent<AudioSource> ();
	}
    public void OnCoinClicked() {
		Instantiate (coinPoof,transform.position,coinPoof.transform.rotation,transform.parent);
        // Instantiate the CoinPoof Prefab where this coin is located
        // Make sure the poof animates vertically
        // Destroy this coin. Check the Unity documentation on how to use Destroy 
		AudioSource.PlayClipAtPoint(source.clip, transform.position);
		Destroy (gameObject);
    }

}
