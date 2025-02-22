using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundController : MonoBehaviour
{
    public float GroundSpeed;

    public float incrementSpeed;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GroundSpeed = GroundSpeed + incrementSpeed * Time.deltaTime;
        Vector3 moveVector = new Vector3(0, 0, -1); //vector porusza nia siê, dyktuje kierunek
        transform.Translate(moveVector * Time.deltaTime * GroundSpeed);
    }
}
