using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controlCamara : MonoBehaviour
{
    public Transform objetivo;
    public Vector3 compensacion;
    public bool usoCompensacion;
    public float velocidadRotacion;
    public Transform pivot;
    public float anguloMaximo;
    public float anguloMinimo;
    public bool ivertirEjeY;
    // Start is called before the first frame update
    void Start()
    {
        if (!usoCompensacion)
        {
            compensacion = objetivo.position - transform.position;
        }
        
        pivot.transform.position = objetivo.transform.position;
        pivot.transform.parent = objetivo.transform;

        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame

    void LateUpdate() {
        {
            float horizontal = Input.GetAxis("Mouse X") * velocidadRotacion;
            objetivo.Rotate(0, horizontal, 0);

            float vertical = Input.GetAxis("Mouse Y") * velocidadRotacion;
            pivot.Rotate(-vertical, 0, 0);

            if(ivertirEjeY)
            {
                pivot.Rotate(vertical, 0, 0);
            } else
            {
                pivot.Rotate(-vertical, 0, 0);
            }

            if(pivot.rotation.eulerAngles.x > anguloMaximo && pivot.rotation.eulerAngles.x < 180f);
            {
                pivot.rotation = Quaternion.Euler(anguloMaximo, 0, 0);
            } 

            if(pivot.rotation.eulerAngles.x > 180 && pivot.rotation.eulerAngles.x < 360f + anguloMinimo);
            {
                pivot.rotation = Quaternion.Euler(360f + anguloMinimo, 0, 0);
            }

            float anguloY = objetivo.eulerAngles.y;
            float anguloX = pivot.eulerAngles.x;
            Quaternion rotation = Quaternion.Euler(anguloX, anguloY, 0);
            transform.position = objetivo.position - (rotation * compensacion);

            if(transform.position.y < objetivo.position.y)
            {
                transform.position = new Vector3(transform.position.x, objetivo.position.y - 0.5f, transform.position.z);
            }

            transform.LookAt(objetivo);
        }
    }
}
