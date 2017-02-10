using UnityEngine;
using System.Collections;

public class ObjectRespawner : MonoBehaviour {

	public void restart(){
		StartCoroutine(reset());
	}

	private IEnumerator reset(){
		yield return new WaitForSeconds (3);
		Application.LoadLevel (Application.loadedLevel);
	}

}
