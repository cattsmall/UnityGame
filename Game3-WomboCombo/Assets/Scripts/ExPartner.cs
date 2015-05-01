using UnityEngine;
using System.Collections;

public class ExPartner: MonoBehaviour {
	public PlayerHealth playerHealth;
	public string prevObjName;

	void Update() {
		transform.LookAt(GameObject.Find("Player").transform.position);

        RaycastHit hit;

        if (Physics.Raycast(transform.position, transform.forward, out hit)){

        	if (prevObjName != "Player" && hit.collider.gameObject.name == "Player") {
	        	playerHealth.health--;
	        }

	        prevObjName = hit.collider.gameObject.name;
        }
    }

    void OnDrawGizmos() {
    	Gizmos.DrawRay(transform.position, transform.forward*20);
    }
}
