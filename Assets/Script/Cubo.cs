using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cubo : MonoBehaviour
{

    public float rotationSpead = 60.0f; //velocidade de retoação em grav por segundo

    
    // Update is called once per frame
    void Update()
    {
        //Rotation o cubo em torno de seu eixo vertical (eixoy)
        transform.Rotate((Vector3.up * rotationSpead * Time.deltaTime));
    }
}
