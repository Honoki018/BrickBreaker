using UnityEngine;
using System.Collections;

public class paddleScript : MonoBehaviour {
	public float paddleSpeed = 8f;
	
	// Update is called once per frame
	void Update () {

		if(Input.touchCount > 0){
			if(Input.GetTouch(0).phase == TouchPhase.Moved){
				Vector2 touchDeltaPosition = Input.GetTouch(0).deltaPosition;
				transform.position = new Vector3(Mathf.Clamp(transform.position.x + (touchDeltaPosition.x * paddleSpeed) * Time.deltaTime, -6.9f, 6.9f), -10f, 0f);
			}
		}

		//tilt controls
		/*playerPos = new Vector2(Mathf.Clamp(transform.position.x + (Input.acceleration.x * paddleSpeed), -3.9f, 3.9f), -9f);
		transform.position = playerPos;*/
	}
}
