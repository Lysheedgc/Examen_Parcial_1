using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Contador : MonoBehaviour
{
    //Aqui se va a modificar la cantidad de tiempo del temporizador.
    public float tiempoTot = 60f;

    //Esta es la variable para imprimir el tiempo.
    public TextMeshProUGUI contadorTexto;


    // Update is called once per frame
    void Update()
    {
        //Aquí se está haciendo una equivalencia de que puede que nuestro tiempo total pueda calcularse diferente con el DeltaTime.
        tiempoTot -= Time.deltaTime;


        //Aqui estamos diciendo que el texto va a mostrar el tiempo restante en la pantalla.
        contadorTexto.text = "Tiempo restante: " + Mathf.RoundToInt(tiempoTot).ToString() + " segundos";
        //Este comando sirve para que los numeros float (decimales) se vuelvan int (enteros), básicamente los redondea y a su vez los está
        //convirtiendso en string para que se puedan mostrar en el area de texto.

        //Ejemplo: 7.8 = 8 y 10.4 = 10


        //Aqui ya estamos condicionando, si el contador llega a cero o a menos de cero(numeros negativos) el texto que establecimos del
        //contador nos arrojará un mensaje al terminar el tiempo.
        if (tiempoTot <= 0)
        {
            contadorTexto.text = "El tiempo se ha terminado!!";
        }
    }
}
