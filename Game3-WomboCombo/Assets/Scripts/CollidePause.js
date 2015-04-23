/* taken from https://github.com/cw1208/LinearPlatformer */

// When game objects collide, pause at current position
function OnCollisionEnter2D (coll: Collision2D) {
	Debug.Log("collided");	
	// Stop X movement
	GameObject.Find("Player").GetComponent.StopCoroutine("CharMover").Mover();
	// Stop EyeRoll rotation
	GameObject.Find("Player").GetComponent.StopCoroutine("Eyeroll").Rolling();
}