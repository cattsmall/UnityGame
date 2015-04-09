using UnityEngine;
using System.Collections;

public class Rotatable : MonoBehaviour {
	Vector3 mousePos;
	Vector3 worldPos;
	float currentAngle = 0;
	// float nextAngle = transform.rotation.z;
	public float speed = 3.0f;

	public void Rotate(){
		Quaternion quat = Quaternion.identity;
		currentAngle += 1.0f;
		quat.eulerAngles = new Vector3(0,0, currentAngle + speed); 
		transform.rotation = quat;
	}
}