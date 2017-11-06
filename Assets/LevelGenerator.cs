﻿using UnityEngine;

public class LevelGenerator : MonoBehaviour {

    public GameObject platformPrefab;

    public int numberOfPlatforms;
    public float levelWidth = 3.0f;
    public float minY = 0.2f;
    public float maxY = 1.5f;

	// Use this for initialization
	void Start () {

        Vector3 spawnPosition = new Vector3();

        for (int i = 0; i < numberOfPlatforms; i++)
        {
            spawnPosition.y += Random.Range(minY, maxY);
            spawnPosition.x = Random.Range(-levelWidth, levelWidth);
            Instantiate(platformPrefab, spawnPosition, Quaternion.identity);
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
