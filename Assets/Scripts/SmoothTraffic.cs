using UnityEngine;
using System.Collections;

public class SmoothTraffic : MonoBehaviour {
	public float waitTime = 1F;
 	public bool moveOn = true;
	public float speed = 5;
	// Use this for initialization
	void Start () {
		StartCoroutine(MoveShape());
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	IEnumerator MoveShape() {
		while(moveOn) {
	        rigidbody.AddForce(transform.right * speed);
			yield return new WaitForSeconds(waitTime);

			rigidbody.velocity = Vector3.zero;
			rigidbody.angularVelocity = Vector3.zero;
			yield return new WaitForSeconds(waitTime);
	    }
    }
}
