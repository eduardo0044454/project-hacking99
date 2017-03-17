using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour
{
    public GameObject CameraCollider;
    public bool setController;
    public float playerSpeed;
    public float playerRotation;
    public GameObject pivot;
    public GameObject playerShot;
    public Transform firepoint;

    // Use this for initialization
    void Start ()
    {
        
    }
	
	// Update is called once per frame
	void Update ()
    {
        //Player movement
        float moveX = Input.GetAxis("Horizontal");
        float moveY = Input.GetAxis("Vertical");
        transform.Translate(Vector3.up * Time.deltaTime * moveY * playerSpeed, Space.World);
        transform.Translate(Vector3.right * Time.deltaTime * moveX * playerSpeed, Space.World);
        //Player movement

        //Player rotates toward to the pivot
        float rotateX = Input.GetAxis("Right Analog Horizontal");
        Vector3 mousePos = UnityEngine.Camera.main.ScreenToWorldPoint(Input.mousePosition);
        if (!setController)
        {
            transform.rotation = Quaternion.LookRotation(Vector3.forward, mousePos - transform.position);
        }
        else
        {
            transform.Rotate(Vector3.forward * Time.deltaTime * rotateX * playerRotation, Space.World);
        }
        //Player rotates toward to the pivot

        //Player Shot
        if (setController)
        {
            if (Input.GetButtonDown("RB Button"))
            {
                Instantiate(playerShot, firepoint.position, firepoint.rotation);
            }
        }
        else
        {
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                Instantiate(playerShot, firepoint.position, firepoint.rotation);
            }
        }
        //Player Shot
    }

//    void OnTriggerEnter2D(Collider2D other)
//    {
//        //Camera Limit
//        if (other.gameObject.tag == "CameraCollider")
//        {
//            CameraCollider.GetComponent<CameraScript>().followPlayer = true;
//        }
//        //Camera Limit
//    }
}
