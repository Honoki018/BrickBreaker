using UnityEngine;
using System.Collections;

public class particleScript : MonoBehaviour {
	private int lastTime = 0;
	// Use this for initialization
	void Start () {
		lastTime = (int)Time.time;
	}

	void Update(){
		if((int)Time.time >= lastTime+3){
			Destroy(this.gameObject);
		}
	}

}
