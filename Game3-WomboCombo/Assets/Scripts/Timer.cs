using UnityEngine;
using System.Collections;

public class Timer : MonoBehaviour {
	public float time = 30f;
	public PlayerHealth playerhealth;
	PlayerMouseInput mouseInput;

	void Start () {
		playerhealth = GameObject.Find("Player").GetComponent<PlayerHealth>();
		mouseInput = GameObject.Find("Player").GetComponent<PlayerMouseInput>();
	}

	void Update () {
	  if(time > 0 && playerhealth.health > 0) {
	  	time -= Time.deltaTime;
	  } else {
	  	mouseInput.movable = false;

	  	if (playerhealth.health > 0) {
			StartCoroutine(playerhealth.win());
  		} else {
			StartCoroutine(playerhealth.lose());
  		}
	  }
	}
}