using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TimerText : MonoBehaviour {
	public Timer timer;
	string timerString;
	float timerInteger;
	Text timerTextObject;

	// Use this for initialization
	void Start () {
		timer = GameObject.Find("Timer").GetComponent<Timer>();
		timerTextObject = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
		timerInteger = Mathf.Round(timer.time);
		timerString = timerInteger.ToString();
		timerTextObject.text = timerString;
	}
}
