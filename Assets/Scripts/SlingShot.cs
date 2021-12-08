using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlingShot : MonoBehaviour
{
    //The force that will be applied to th force whe we release our mouse
    public float SlingShotForce;
    //The rigidbody on this oject
    public Rigidbody2D reggiebody;

    //The start position of the dragging motion
    Vector3 startMousePos;
    //Keeps track f whenever you start clicking on the ball
    bool draggingBallZ = false;
    Vector3 mouseVector;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonUp(0) && draggingBallZ == true)
        {
            mouseVector = Input.mousePosition - startMousePos;
            reggiebody.AddForce(-mouseVector * SlingShotForce);
            draggingBallZ = false;
        }
    }

    private void OnMouseDown()
    {
        startMousePos = Input.mousePosition;
        draggingBallZ = true;
    }
}
