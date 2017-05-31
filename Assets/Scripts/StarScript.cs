using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarScript : MonoBehaviour {

	void Start () {
	}

	public void Init(float width, float height, float distance) {
		transform.position = new Vector3(
			Random.Range(-width / 2, width / 2),
			Random.Range(-height / 2, height / 2),
			distance);
	}
		
	void Update () {
		transform.Translate(new Vector3(0, 0, -0.1f));
	}
}
