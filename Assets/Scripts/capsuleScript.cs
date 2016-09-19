using UnityEngine;
using System.Collections;

public class capsuleScript : MonoBehaviour {
	
	public float speed = 3f;
	// Update is called once per frame

	void Update () {
		transform.Translate(Vector3.down * speed * Time.deltaTime, Space.World);
	}
}
