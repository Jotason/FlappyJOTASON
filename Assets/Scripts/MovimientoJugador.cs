using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoJugador : MonoBehaviour
{
    Rigidbody2D rigidbody2;
    [SerializeField] float fuerzaSalto;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody2 = GetComponent<Rigidbody2D>();
    }


    public void Saltar() { 
        rigidbody2.velocity = new Vector2(0,fuerzaSalto); 
    }

    // Update is called once per frame
    //void Update()
    //{
        
    //}
}
