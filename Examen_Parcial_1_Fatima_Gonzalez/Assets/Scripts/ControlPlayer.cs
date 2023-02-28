using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//Este script va a hacer que el jugador se pueda mover utilizando las teclas preestablecidas en Unity Axis (Up, Down, Left, Right y WASD)
public class ControlPlayer : MonoBehaviour
{
    public float rotVelocidad = 100f; //Esta variable modificable es para la velocidad a la que va a rotar el objeto
    public float movVelocidad = 400f; //Esta variable modificable es para la velocidad a la que se va a mover el objeto

    //Estas variables son para poder utilizar el Axis que ya viene preestablecido en unity, al no ser números enteros se denomina float.
    float movimiento;
    float rotación;

    // Update is called once per frame
    void Update()
    {
        //Lo que se hace aqui es llamar al Axis (teclas horizontales) que se van a utilizar para cambiar la rotación del objeto al que 
        //se le va a adjuntar este script.

        rotación = Input.GetAxis("Horizontal") * rotVelocidad * Time.deltaTime;
        transform.Rotate(0f, rotación, 0f);

        //Aqui se va a hacer lo mismo que lo de arriba pero ahora debemos llamar al Axis (teclas verticales) que se van a utilizar para
        //cambiar el movimiento del objeto al que se le va a adjuntar este script.

        movimiento = Input.GetAxis("Vertical") * movVelocidad * Time.deltaTime;
        transform.Translate(0f, 0f, movimiento);
    }
}

//Notas
/* Revisar que el axis (Eje) si este configurado desde el menú de 
 * EDIT < PROYECT SETTINGS < INPUT MANAGER < AXES ("Horizontal" y "Vertical").*/
// Al inicio le puse en velocidad 5f, pero lo recomendado para que vaya fluido es 100f de rotación y 400f de movimiento.
// Si salen preestablecidos 5f hay que cambiarlos.