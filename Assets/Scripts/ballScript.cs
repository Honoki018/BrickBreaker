using UnityEngine;
using System.Collections;

public class ballScript : MonoBehaviour {
	public gameManagerScript gm;
	public float ballInitialVelocity = 600f;
	private Rigidbody rb;
	private bool ballInPlay;
	void Start () {
		rb = GetComponent<Rigidbody>();
		gm = GameObject.Find("GameManager").GetComponent<gameManagerScript>();
	}
	void OnCollisionEnter(Collision collision){
		if(collision.gameObject.tag == "capsule"){
			Instantiate(gm.particlePrefab, collision.transform.position, gm.particlePrefab.transform.rotation);
			Destroy(collision.gameObject);
			gm.scoreChange();
		}
	}
	// Update is called once per frame
	void Update () {
		if((Input.touchCount > 0 && ballInPlay == false) || (Input.anyKeyDown == true && ballInPlay == false)){
			transform.parent = null;
			ballInPlay = true;
			rb.isKinematic = false;
			rb.AddForce(new Vector3(ballInitialVelocity, ballInitialVelocity, 0));
		}
	}
}
