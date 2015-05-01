using UnityEngine;
using System.Collections;

public class Timer : MonoBehaviour {
	public float time = 30f;
	public PlayerHealth playerhealth;

	void Start () {
		playerhealth = GameObject.Find("Player").GetComponent<PlayerHealth>();
	}

	void Update () {
	  if(time > 0) {
	  	time -= Time.deltaTime;
	  } else {
	  	StartCoroutine(playerhealth.kill());
	  }
	}
}