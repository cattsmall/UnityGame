using UnityEngine;
using System.Collections;

public class Rotator : MonoBehaviour {
	public float waitTime = 1F;
	public float rotationAmount = 5;
	public bool rotationOn = true;
	// Use this for initialization
	void Start () {
		StartCoroutine(RotateShape());
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	IEnumerator RotateShape() {
		while(rotationOn) {
			transform.Rotate(transform.rotation.x, transform.rotation.y, transform.rotation.z+rotationAmount);
	        yield return new WaitForSeconds(waitTime);
	    }
    }
}
