using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bola : MonoBehaviour
{
    public float Vbola;
    public Rigidbody2D oRigidbody2D; 

    
    // Start is called before the first frame update
    void Start()
    {
        oRigidbody2D.velocity = new Vector2(Vbola, Vbola) * Time.deltaTime;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
