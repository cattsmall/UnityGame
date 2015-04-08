using UnityEngine;
using System.Collections;

public class HeadGizmo : MonoBehaviour {
	public CircleCollider2D SphereCollider;

	void OnDrawGizmos() {
	  Gizmos.DrawSphere(transform.position, SphereCollider.radius);
	}
}
