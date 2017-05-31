using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

	GameObject StarPrefab;

	float starsCount = 100;
	List<GameObject> stars = new List<GameObject>();

	void Start() {
		StarPrefab = Resources.Load("Prefabs/Star", typeof(GameObject)) as GameObject;
		AddStars();
	}

	void AddStars() {
		for (int i = 0; i < starsCount; i++) {
			GameObject aStar = Instantiate(StarPrefab);
			aStar.SetActive(true);
			stars.Add(aStar);
		}
	}
		
	void Update() {
		for (int i = 0; i < starsCount; i++) {
			GameObject aStar = stars[i];
			aStar.SetActive(true);
		}
	}
}
