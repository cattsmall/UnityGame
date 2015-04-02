using UnityEngine;
using System.Collections;

public class Traffic : MonoBehaviour {
	public float waitTime = 1F;
	public float moveAmount = 5F;
	public bool moveOn = true;
	Vector3 endPos = new Vector3(0,0,0);
	// Use this for initialization
	void Start () {
		StartCoroutine(MoveShape());
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	IEnumerator MoveShape() {
		while(moveOn) {
			endPos = transform.position + transform.right * moveAmount;
			transform.position = Vector3.Lerp(transform.position, endPos, moveAmount);
	        yield return new WaitForSeconds(waitTime);
	    }
    }
}
