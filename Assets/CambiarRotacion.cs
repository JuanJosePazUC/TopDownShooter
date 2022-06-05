using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambiarRotacion : MonoBehaviour
{
    [Header("MirarCamara")]
    [SerializeField] private Vector3 Target;
    [SerializeField] private Camera camara;

    [Header("Movimiento")]
    [SerializeField] private float velocidadMovimiento;
    [SerializeField] private Vector2 direccion;
    private Rigidbody2D rb2D;
    private Vector2 input;

    private void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        Target = camara.ScreenToWorldPoint(Input.mousePosition);
        // Get Angle in Radians
        float AngleRad = Mathf.Atan2(Target.y - transform.position.y, Target.x - transform.position.x);
        // Get Angle in Degrees
        float AngleDeg = (180 / Mathf.PI) * AngleRad - 90;
        // Rotate Object
        this.transform.rotation = Quaternion.Euler(0, 0, AngleDeg);

        input.x = Input.GetAxisRaw("Horizontal");
        input.y = Input.GetAxisRaw("Vertical");
        direccion = input.normalized;
    }
    private void FixedUpdate()
    {
        rb2D.MovePosition(rb2D.position + direccion * velocidadMovimiento * Time.fixedDeltaTime);
    }
}
