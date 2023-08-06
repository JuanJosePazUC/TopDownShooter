using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoJugador : MonoBehaviour
{
    [Header("MovimientoJugador")]
    [SerializeField] private float velocidadMovimiento;
    private Vector2 direccion;
    private Rigidbody2D rb2D;
    private Vector2 input;
    
    private void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        input.x = Input.GetAxisRaw("Horizontal");
        input.y = Input.GetAxisRaw("Vertical");
        direccion = input.normalized;
    }

    private void FixedUpdate()
    {
        rb2D.MovePosition(rb2D.position + direccion * velocidadMovimiento * Time.fixedDeltaTime);
    }
}
