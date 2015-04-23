/* taken from https://github.com/oligb/WellArchitechted */

using UnityEngine;
using System.Collections;

public class LoseOnTimeout : MonoBehaviour {

	// Use this for initialization
	public float startTime=0f;
	public float lifeTime=5f;
	void Start () {
		startTime=Time.time;
	}
	
	// Update is called once per frame
	void Update () {
	
		if(Time.time-startTime>lifeTime){
			Destroy(gameObject);
	}
	}
}
