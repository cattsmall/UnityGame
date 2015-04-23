/* taken from https://github.com/drfuzzyness/Hunty2 */

using UnityEngine;
using System.Collections;

[RequireComponent (typeof (Nonplayer))]
public class NonplayerDriver : MonoBehaviour {
	public ParticipantManager manager;

	public void caught() {
		manager.nonplayer.Remove( this.GetComponent<Nonplayer>() );
		Destroy( this.gameObject );
	}

	// Update is called once per frame
	void Update () {
	}

	void FixedUpdate() {
		// turn when at wall
	}
}
