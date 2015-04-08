using UnityEngine;
using System.Collections;

public class BodyGizmo : MonoBehaviour {

	void OnDrawGizmos() {
	  Gizmos.DrawCube(transform.position, transform.localScale);
	}
}
