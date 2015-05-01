/* taken from https://github.com/dat290/Unity-3D-Small-Scripting-Assignment */

using UnityEngine;
using System.Collections;

public class PlayerHealth : MonoBehaviour {
	public bool hasDied = false;

	public int health = 100;
	
	void Update () {
		if (health <= 0) {
			kill();
		}
	}

	public IEnumerator kill () {
		if (!hasDied) {
			hasDied = true;
			yield return new WaitForSeconds(5f);  // or however long you want it to wait
			Application.LoadLevel(Application.loadedLevel);
		}
	}
}
