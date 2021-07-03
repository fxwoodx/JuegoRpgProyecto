using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour

    
{

    public float velocidad;
    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Transform>().position = new Vector3(-2.7f, 0.5f, 0);
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float movimientoHorizontal = Input.GetAxis("Horizontal");
        MovementSystem(movimientoHorizontal);
    }

    public void MovementSystem(float x)
    {
        GetComponent<Transform>().Translate(x * velocidad * Time.deltaTime, 0, 0); 
    }

}
