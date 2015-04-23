using UnityEngine;
using System.Collections;

public class Timer : MonoBehaviour {
	public float time = 30f;

	void Update () {
	  if(time > 0) {
	  	time -= Time.deltaTime;
	  } else {
	  	
	  }
	}
}