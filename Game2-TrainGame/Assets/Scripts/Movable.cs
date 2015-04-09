using UnityEngine;
// using System.Collections;

public class Movable : MonoBehaviour {
	Vector3 pos_move = new Vector3( 0,0,0 );
	float distance_to_screen = 0;

	public void Move(){
		distance_to_screen = Camera.main.WorldToScreenPoint(gameObject.transform.position).z;
		pos_move = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, distance_to_screen ));

		Vector3 position = this.transform.position;
		position = new Vector3( pos_move.x, pos_move.y, pos_move.z );
		this.transform.position = position;

	}
}