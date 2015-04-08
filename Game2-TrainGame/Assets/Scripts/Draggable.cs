using UnityEngine;
using System.Collections;

public class Draggable : MonoBehaviour {

	void Update(){
		if (Input.GetMouseButton(0)){ // if left button pressed...
			transform.GetComponentInParent<Movable>().Move();
		}
	}
}
