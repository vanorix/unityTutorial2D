using UnityEngine;
using System.Collections;

public class SpawnManager : MonoBehaviour {

    public int maxPlatform = 20;
    public GameObject platform;
    public float horizontalMin = 6.5f;
    public float horizontalMax = 14f;
    public float verticalMin = -6f;
    public float verticalMax = 6f;

    private Vector2 originalPosition;

	// Use this for initialization
	void Start () {
        originalPosition = transform.position;
        Spawn();
	}
	
	// Spawn is called once per frame
	void Spawn () {
        for (int i = 0; i < maxPlatform; i++)
        {
            Vector2 randomPosition = originalPosition + new Vector2(Random.Range(horizontalMin, horizontalMax), Random.Range(verticalMin, verticalMax));
            Instantiate(platform, randomPosition, Quaternion.identity);
            originalPosition = randomPosition;
        }
	}
}
