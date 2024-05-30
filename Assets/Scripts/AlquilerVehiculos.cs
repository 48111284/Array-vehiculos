using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlquilerVehiculos : MonoBehaviour
{
    public GameObject[] vehiculos;
    int VehiculoAlAzar;
    

    // Start is called before the first frame update
    void Start()
    {
        ResetearVehiculos();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            //activar solo un vehiculo al azar del array
            VehiculoAlAzar = Random.Range(0, vehiculos.Length);
            vehiculos[VehiculoAlAzar].SetActive(true);
        }
    }

    void ResetearVehiculos()
    {
        //desactivar todos los vehiculos
        DesactivarTodosLosVehiculos();
        //y activar el primer elemento del array
        vehiculos[0].SetActive(true);
    }

    void DesactivarTodosLosVehiculos()
    {
        for (int i = 0; i < vehiculos.Length; i++)
        {
            vehiculos[i].SetActive(false);
        }
    }
}
