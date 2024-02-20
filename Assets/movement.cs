using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] private Rigidbody rb;


    void Start()
    {
        Debug.Log("start");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            Debug.Log("space");
            rb.AddForce(Vector3.forward * 10f);
        }

        if (Input.GetKey(KeyCode.A))
        {
            Debug.Log("space");
            rb.AddForce(Vector3.left * 10f);
        }

        if (Input.GetKey(KeyCode.S))
        {
            Debug.Log("space");
            rb.AddForce(Vector3.back * 10f);
        }

        if (Input.GetKey(KeyCode.D))
        {
            Debug.Log("space");
            rb.AddForce(Vector3.right * 10f);
        }

        if (Input.GetKey(KeyCode.Space))
        {
            Debug.Log("space");
            rb.AddForce(Vector3.up * 10f);
        }

        if (Input.GetKey(KeyCode.LeftControl))
        {
            Debug.Log("space");
            rb.AddForce(Vector3.down * 10f);
        }
    }
    private void OnCollisionEnter(Collision collision){
        if(collision.gameObject.tag == "coin")
        Destroy(collision.gameObject);

    }
}