using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    public float jumpforce;
    public Rigidbody reggiebody;
    public GameObject particle;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            //Vector3.up = (0, 1, 0)
            Vector3 forceVector = Vector3.up * jumpforce;
            reggiebody.AddForce(forceVector);
            print("Down");
        }
        else if (Input.GetButton("Jump"))
        {
            print("Hold");
        }
        else if (Input.GetButtonUp("Jump"))
        {
            print("Up");
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        Instantiate(particle, this.transform.position, Quaternion.identity);
    }
}
