using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HealthText : MonoBehaviour {
	public PlayerHealth playerHealth;
	float health;
	string healthString;
	Text healthTextObject;

	// Use this for initialization
	void Start () {
		health = playerHealth.health;
		// Debug.Log(health);
		healthTextObject = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
		
		healthString = health.ToString();
		healthTextObject.text = "Health: " + healthString;
	}
}
