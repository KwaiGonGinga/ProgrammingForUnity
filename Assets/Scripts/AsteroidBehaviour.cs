using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidBehaviour : MonoBehaviour {

    // Prefab for spawning Asteroids
    public GameObject asteroidPrefab;

    // Rate at which Asteroids are spawned
    public float secsBetweenAsteroids = 1f;

	// Use this for initialization
	void Start () {
        InvokeRepeating("SpawnAsteroid", 1f, secsBetweenAsteroids);
	}

    void SpawnAsteroids()
    {
        GameObject asteroid = Instantiate(asteroidPrefab) as GameObject;
    }
	
	// Update is called once per frame
	void Update () {
        transform.position -= Vector3.forward * Time.deltaTime;
    }

    void OnLeaveScreen()
        {
            // Destroy Asteroids that leave screen
            Destroy(gameObject);
        }
}
