using UnityEngine;
using System.Collections;

public class enemySpawn : MonoBehaviour
{
    public GameObject enemy;
    public Vector3 spawnValues;
    public int enemyCount;
    public float spawnWait;
    public float spawnStart;

	// Use this for initialization
	void Start ()
    {
        spawnWaves();
    }
	
	// Update is called once per frame
	void Update ()
    {
	    
	}

    void spawnWaves()
    {
        for (int i = 0; i < enemyCount; i++)
        {
            Vector3 spawnPosition = new Vector3(Random.Range(-spawnValues.x, spawnValues.x), Random.Range(-spawnValues.y, spawnValues.y), 0);
        }
    }
}
