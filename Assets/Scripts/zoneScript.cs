using UnityEngine;
using System.Collections;

public class zoneScript : MonoBehaviour {
	public gameManagerScript gm;
	void OnTriggerEnter(Collider other){
		if(other.gameObject.tag == "capsule"){
			Destroy(other.gameObject);
		}
		if(other.gameObject.tag == "ball"){
			gm.gameOver();
		}
	}


}
