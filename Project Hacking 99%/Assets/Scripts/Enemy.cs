using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour
{
    public float enemyLife;

	// Use this for initialization
	void Start ()
    {
        
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (enemyLife <= 0)
        {
            Destroy(gameObject);
        }
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "shot")
        {
            Destroy(other.gameObject);
            enemyLife--;
        }
    }
}
