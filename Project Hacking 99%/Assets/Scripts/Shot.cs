using UnityEngine;
using System.Collections;

public class Shot : MonoBehaviour
{
    public Transform player;
    public float shotSpeed;
    public float timeLeft;

	// Use this for initialization
	void Start ()
    {
        
    }

    // Update is called once per frame
    void Update ()
    {
        //Shot move
        transform.Translate(Vector3.up * Time.deltaTime * shotSpeed);
        //Shot move

        //Shot timer
        timeLeft -= Time.deltaTime;
        if (timeLeft <= 0)
        {
            Destroy(gameObject);
        }
        //Shot timer
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag != "teta")
        {
            Destroy(gameObject);
        }
    }
}
