/* taken from https://github.com/drfuzzyness/Hunty2 */

using UnityEngine;
using System.Collections;

[RequireComponent (typeof (ExPartner))]
public class ExDebug : MonoBehaviour {

	void OnDrawGizmos() {
		// if( GetComponent<ExPartner>().chasing ) {
			Vector3 vectorToPrey = GetComponent<ExPartner>().transform.position - transform.position;
			Gizmos.DrawRay( transform.position, vectorToPrey);
		// }
	}
}
