using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarScript : MonoBehaviour {

	float size = 0.3f;
	float speed = 40.0f;

	float distanceMax = 100f;
	float distanceMin = 40f;

	float width;
	float height;

	public void Init(float sceneWidth, float sceneHeight) {
		width = sceneWidth;
		height = sceneHeight;
	}

	void Start () {
		transform.position = RandomPosition();
		transform.localScale = new Vector3(size, size, size);
		Color c = Random.ColorHSV();
		GetComponent<Renderer>().material.color = c;
		GetComponent<TrailRenderer>().material.color = c;
	}

	void Update () {
		if (transform.position.z < -5.0f) {
			transform.position = RandomPosition();
			GetComponent<TrailRenderer>().Clear();
		} else {
			transform.Translate(new Vector3(0, 0, -(speed * Time.deltaTime)));
		}
	}

	Vector3 RandomPosition() {
		return new Vector3(
			Random.Range(-width / 2, width / 2),
			Random.Range(-height / 2, height / 2),
			Random.Range(distanceMin, distanceMax));
	}
}
