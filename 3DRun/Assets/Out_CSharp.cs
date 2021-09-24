using UnityEngine;
using System.Collections;

public class Out_CSharp : MonoBehaviour {

	void OnTriggerEnter(Collider col){
		if (col.gameObject.tag == "Player") {
			Application.LoadLevel(Application.loadedLevel);
		}
	}
}
