using UnityEngine;
using System.Collections;

public class RingFXScript : MonoBehaviour {

	public float startSize = 1.0f;
	public float minSize = 0.5f;
	public float maxSize = 1.5f;
	public float increment = 0.01f;

	public float speed = 2.0f;

	private Vector3 targetScale;
	private Vector3 baseScale;
	private float currScale;
	private bool up;

	void Start() {
		baseScale = transform.localScale;
		transform.localScale = baseScale * startSize;
		currScale = startSize;
		targetScale = baseScale * startSize;
		up = true;
	}

	// Update is called once per frame
	void Update () {

		transform.localScale = Vector3.Lerp (transform.localScale, targetScale, speed * Time.deltaTime);
		ChangeSize ();


	}

	public void ChangeSize() {
		if (currScale >= maxSize)
			up = false;
		if (currScale <= minSize)
			up = true;

		if (up)
			currScale+=increment;
		else
			currScale-=increment;

		currScale = Mathf.Clamp (currScale, minSize, maxSize+1);

		targetScale = baseScale * currScale;
	} 


}
