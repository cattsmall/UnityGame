/* taken from https://github.com/drfuzzyness/Hunty2 */

using UnityEngine;
using System.Collections;

[RequireComponent (typeof (ExPartner))]
public class ExPartnerDriver : MonoBehaviour {
	public ParticipantManager manager;



	// Update is called once per frame
	void Update () {
		// if( !GetComponent<ExPartner>().chasing ) {
		// 	if( GetComponent<ExPartner>().sees( manager.player.gameObject ) && !GetComponent<ExPartner>().chasing ) {
		// 		GetComponent<ExPartner>().chase( thisPrey.gameObject );
		// 	}
		// }
	}
}
