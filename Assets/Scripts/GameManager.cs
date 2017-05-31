using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

	float width = 20f;
	float height = 20f;

	float initialDistance = 50f;

	GameObject StarPrefab;

	float starsCount = 5;
	List<GameObject> stars = new List<GameObject>();

	void Start() {
		StarPrefab = Resources.Load("Prefabs/Star", typeof(GameObject)) as GameObject;
		AddStars();
	}

	void AddStars() {
		for (int i = 0; i < starsCount; i++) {
			GameObject aStar = Instantiate(StarPrefab);
			aStar.GetComponent<StarScript>().Init(RandomPosition());
			aStar.SetActive(true);
		}
	}

	Vector3 RandomPosition() {
		return new Vector3(
			Random.Range(-width / 2, width / 2),
			Random.Range(-height / 2, height / 2),
			initialDistance);
	}

	void Update() {
		
	}
}
