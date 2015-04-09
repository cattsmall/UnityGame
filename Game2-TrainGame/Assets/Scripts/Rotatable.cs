using UnityEngine;
// using System.Collections;

public class Rotatable : MonoBehaviour {


	Vector3 mousePos;
	Vector3 worldPos;

	public void Rotate(){
		// distance_to_screen = Camera.main.WorldToScreenPoint(gameObject.transform.position).z;
		// pos_rotate = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, distance_to_screen ));

		// transform.Rotate( 0, 0, pos_rotate.x/pos_rotate.y );

		mousePos = Input.mousePosition;
		// mousePos.z = -(transform.position.x - Camera.main.transform.position.x);

		worldPos = Camera.main.ScreenToWorldPoint(mousePos);

		transform.LookAt(worldPos);

		Debug.Log(transform.rotation);
	}
}