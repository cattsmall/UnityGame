using UnityEngine;
using System.Collections;

public class Draggable : MonoBehaviour {
	public bool movable;
	public bool rotatable;

	void Update(){
	}

	void OnMouseOver() {
		if (Input.GetMouseButton(0)){ // if left button pressed...
			if (movable){ // if left button pressed...
				transform.GetComponentInParent<Movable>().Move();
			} else if (rotatable) {
				transform.GetComponentInParent<Rotatable>().Rotate();
			}
		}
	}
}
