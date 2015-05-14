/* taken from https://github.com/oligb/WellArchitechted */

using UnityEngine;
using System.Collections;

public class PlayerMouseInput : MonoBehaviour {
	public bool movable = true;
	public Vector3 targetPos;
	PlayerMovement movement;

	void Start () {
		movement = GetComponent<PlayerMovement>();
	}
	
	// Update is called once per frame
	void Update () {
		
		if (Input.GetMouseButtonDown(0) && movable){
			Ray cursorRay= Camera.main.ScreenPointToRay(Input.mousePosition);
			RaycastHit cursorRayHit= new RaycastHit();
		
			if(Physics.Raycast(cursorRay, out cursorRayHit, 1000f)){
			
					targetPos=cursorRayHit.point;
			}

			targetPos.y=transform.position.y;
			transform.LookAt(targetPos);
			movement.Move(targetPos);
		} else if (!movable) {
			movement.StopMoving();
		}

	}
}


