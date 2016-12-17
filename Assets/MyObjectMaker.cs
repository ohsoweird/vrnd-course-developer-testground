﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyObjectMaker : MonoBehaviour {

	public GameObject objectToCreate;

	// Use this for initialization
	void Start () {

		for (int i = 0; i < 50; i++) {
		//Object.Instantiate (objectToCreate, new Vector3 (i, 4, 6), Quaternion.identity);
			GameObject newSeagull = (GameObject)Object.Instantiate(objectToCreate, new Vector3(i, 0, 0), Quaternion.identity);
			Renderer objectRenderer = newSeagull.GetComponentInChildren<Renderer> ();
			objectRenderer.material.color = Color.white * Random.value;
		}
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
