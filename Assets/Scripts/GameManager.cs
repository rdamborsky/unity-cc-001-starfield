using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.SceneManagement;

public class GameManager : MonoBehaviour {

	float width = 20f;
	float height = 20f;

	float initialDistance = 50f;

	GameObject star;

	void Start() {
		GameObject Star = Resources.Load("Prefabs/Star", typeof(GameObject)) as GameObject;

		star = Instantiate(Star);

		Vector3 position = new Vector3(
			              Random.Range(-width / 2, width / 2),
			              Random.Range(-height / 2, height / 2),
			              initialDistance);
		star.GetComponent<StarScript>().Init(position);

		star.SetActive(true);
	}

	void Update() {
		
	}
}
