using UnityEngine;
using System.Collections;

public class ExPartner: MonoBehaviour {
	public PlayerHealth playerHealth;

	void Update() {
		transform.LookAt(GameObject.Find("Player").transform.position);

        RaycastHit hit;

        if (Physics.Raycast(transform.position, transform.forward, out hit)) {

        }
    }

    void OnDrawGizmos() {
    	Gizmos.DrawRay(transform.position, transform.forward*20);
    }
}
