using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankScript : MonoBehaviour
{

    public float Speed;
    public float RotSpeed;

    public float HInput;
    public float VInput;

    public float JumpVelocity;

    public Rigidbody PlayerRB;

    void Update()
    {
        HInput = Input.GetAxis("Horizontal");
        VInput = Input.GetAxis("Vertical");

        transform.Rotate(Vector3.up, HInput * RotSpeed * Time.deltaTime); //Horizontnal Rotation
        transform.Translate(Vector3.forward * VInput * Speed * Time.deltaTime); //Forward and Backward Movement
    }
}