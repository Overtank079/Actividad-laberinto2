using UnityEngine;

public class MovimientoFisico : MonoBehaviour
{
    public float velocidad = 5f;
    public float velocidadGiro = 100f;

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        float giro = Input.GetAxis("Horizontal");
        float desplazamiento = Input.GetAxis("Vertical");

        rb.MoveRotation(rb.rotation * Quaternion.Euler(0, giro * velocidadGiro * Time.fixedDeltaTime, 0));

        Vector3 movimiento = transform.forward * desplazamiento * velocidad * Time.fixedDeltaTime;
        rb.MovePosition(rb.position + movimiento);
    }
}
