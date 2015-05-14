/* taken from https://github.com/dat290/Unity-3D-Small-Scripting-Assignment */

using UnityEngine;
using System.Collections;

public class PlayerHealth : MonoBehaviour {
	public bool hasDied = false;

	public int health = 100;
	
	void Update () {
		if (health <= 0) {
			lose();
		}
	}

	public IEnumerator lose () {
		if (!hasDied) {
			hasDied = true;
			yield return new WaitForSeconds(2f);  // or however long you want it to wait
			Application.LoadLevel("LoseState");
		}
	}

	public IEnumerator win () {
		if (!hasDied) {
			hasDied = true;
			yield return new WaitForSeconds(2f);  // or however long you want it to wait
			Application.LoadLevel("WinState");
		}
	}
}
