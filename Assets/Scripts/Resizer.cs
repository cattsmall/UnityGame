using UnityEngine;
using System.Collections;

public class Resizer : MonoBehaviour {
	public float waitTime = 1F;
	public float scaleAmount = 5;
	public bool scaleOn = true;
	bool sizedUp = false;
	// Use this for initialization
	void Start () {
		StartCoroutine(ResizeShape());
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	IEnumerator ResizeShape() {
		while(scaleOn) {
			if (!sizedUp) {
				transform.localScale = new Vector3(transform.localScale.x+scaleAmount, transform.localScale.y+scaleAmount, transform.localScale.z+scaleAmount);
				sizedUp = true;
			} else {
				sizedUp = false;
				transform.localScale = new Vector3 (transform.localScale.x-scaleAmount, transform.localScale.y-scaleAmount, transform.localScale.z-scaleAmount);
			}
	        yield return new WaitForSeconds(waitTime);

	    }
    }
}
