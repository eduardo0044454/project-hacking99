using UnityEngine;
using System.Collections;

public class CameraScript : MonoBehaviour
{
    public GameObject player;
    public GameObject camera;
    public bool followPlayer;

    // Use this for initialization
    void Start()
    {
        followPlayer = true;
    }

    // Update is called once per frame
    void Update()
    {
        //Camera follows Player
        if (followPlayer)
        {
            camera.transform.position = new Vector3(player.transform.position.x, player.transform.position.y, camera.transform.position.z);
        }
        else
        {
            camera.transform.position = camera.transform.position;
        }
        //Camera follows Player
    }

    //Camera Limit
    void OnTriggerStay2D(Collider2D col)
    {
        if (col.gameObject.tag == "stageLimit")
        {
            followPlayer = false;
        }
    }

    void OnTriggerExit2D(Collider2D col)
    {
        if (col.gameObject.tag == "stageLimit")
        {
            followPlayer = true;
        }
    }
    //Camera Limit
}