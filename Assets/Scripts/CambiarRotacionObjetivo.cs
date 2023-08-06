using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambiarRotacionObjetivo : MonoBehaviour
{
    [Header("MovimientoCamara")]
    [SerializeField] private Transform objetivo;
    [SerializeField] private float anguloInicial;

    private void Update()
    {
        float anguloRadianes = Mathf.Atan2(objetivo.position.y - transform.position.y, objetivo.position.x - transform.position.x);
        float anguloGrados = (180 / Mathf.PI) * anguloRadianes - anguloInicial;
        transform.rotation = Quaternion.Euler(0, 0, anguloGrados);
    }
}
