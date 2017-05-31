using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

	GameObject StarPrefab;

	float width = 100f;
	float height = 60f;

	float starsCount = 200;
	List<GameObject> stars = new List<GameObject>();

	void Start() {
		StarPrefab = Resources.Load("Prefabs/Star", typeof(GameObject)) as GameObject;
		AddStars();
	}

	void AddStars() {
		for (int i = 0; i < starsCount; i++) {
			GameObject aStar = Instantiate(StarPrefab);
			aStar.GetComponent<StarScript>().Init(width, height);
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
