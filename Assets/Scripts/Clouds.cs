using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clouds : MonoBehaviour
{
    //Public int HP = 0;
    public float speed = 1.5f;

    // Update is called once per frame

    void Update()
    {
        //We store the current position value of the tranform of the object this component is in
        //Basically we store the current position of the object
        Vector3 temp = this.transform.position;

        //Same thing as temp.x + speed;
        temp.x += speed * Time.deltaTime;

        //We assign temp as the new position of the object
        // We're teleporting the object in very small amounts really quickly
        this.transform.position = temp;
    }
}
