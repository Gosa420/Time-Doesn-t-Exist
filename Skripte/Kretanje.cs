using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kretanje : MonoBehaviour
{

    public float moveSpeed = 5.0f;

    void Start()
    {
        
    }

    void Update()
    {
        transform.Translate( Vector3.forward * Time.deltaTime * Input.GetAxis("Vertical") * moveSpeed);
        
        transform.Translate(Vector3.right * Time.deltaTime * Input.GetAxis("Horizontal") * moveSpeed);
    }

}
