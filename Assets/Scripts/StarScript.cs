using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarScript : MonoBehaviour {

	float size = 0.3f;
	float distPerFrame = 0.08f;

	float width = 40f;
	float height = 30f;
	float distanceMax = 100f;
	float distanceMin = 40f;

	void Start () {
		transform.position = RandomPosition();
		transform.localScale = new Vector3(size, size, size);
	}

	void Update () {
		if (transform.position.z < -5.0f) {
			transform.position = RandomPosition();
		} else {
			transform.Translate(new Vector3(0, 0, -(distPerFrame / Time.deltaTime)));
		}
	}

	Vector3 RandomPosition() {
		return new Vector3(
			Random.Range(-width / 2, width / 2),
			Random.Range(-height / 2, height / 2),
			Random.Range(distanceMin, distanceMax));
	}
}
