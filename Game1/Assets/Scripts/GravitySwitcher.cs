using UnityEngine;
using System.Collections;

public class GravitySwitcher : MonoBehaviour {
	public float waitTime = 1F;
	public float rotationAmount = 5;
	public bool gravitySwitchOn = true;
	// Use this for initialization
	void Start () {
		StartCoroutine(SwitchGravity());
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	IEnumerator SwitchGravity() {
		while(gravitySwitchOn) {
			for (i = 0; i < rotationAmount ; i++) {
				transform.Rotate(transform.rotation.x, transform.rotation.y, transform.rotation.z+rotationAmount);
			}
	        yield return new WaitForSeconds(waitTime);
	    }
    }
}
