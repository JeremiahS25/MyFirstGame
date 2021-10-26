using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 1.0f;
    public CharacterController controller;

    void Update()
    {
        float x = Input.GetAxis("Horizontal");
    }
}
