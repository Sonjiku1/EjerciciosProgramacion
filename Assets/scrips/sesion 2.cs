using UnityEngine;

public class sesion2 : MonoBehaviour
{
    void Start()
    {
        // Atributos base (estilo Call of Cthulhu)
        int fue = (Random.Range(1, 7) + Random.Range(1, 7) + Random.Range(1, 7)) * 5;
        int con = (Random.Range(1, 7) + Random.Range(1, 7) + Random.Range(1, 7)) * 5;
        int des = (Random.Range(1, 7) + Random.Range(1, 7) + Random.Range(1, 7)) * 5;
        int Apa = (Random.Range(1, 7) + Random.Range(1, 7) + Random.Range(1, 7)) * 5;
        int Pod = (Random.Range(1, 7) + Random.Range(1, 7) + Random.Range(1, 7)) * 5;
        int Sue = (Random.Range(1, 7) + Random.Range(1, 7) + Random.Range(1, 7)) * 5;
        int TAM = (Random.Range(1, 7) + Random.Range(1, 7) + 6) * 5;
        int INT = (Random.Range(1, 7) + Random.Range(1, 7) + 6) * 5;
        int EDU = (Random.Range(1, 7) + Random.Range(1, 7) + 6) * 5;

        int Edad = Random.Range(15, 91); // Ahora genera de 15 a 90 para que las otras ramas tengan sentido

        // Modificaciones por edad
        if (Edad >= 15 && Edad <= 19)
        {
            Debug.Log("Modificado Edad (15-19)");
            fue -= 5;
            TAM -= 5;
            EDU -= 5;

            int SueReroll = (Random.Range(1, 7) + Random.Range(1, 7) + Random.Range(1, 7)) * 5;
            if (SueReroll > Sue)
            {
                Sue = SueReroll;
            }
        }
        else if (Edad >= 20 && Edad <= 39)
        {
            // Mejora de EDU
            int Und100 = Random.Range(1, 101);
            if (Und100 <= 90)
            {
                EDU += 5;
            }
        }
        else if (Edad >= 40 && Edad <= 49)
        {
            // Mejora de EDU
            int Und100 = Random.Range(1, 101);
            if (Und100 > EDU)
            {
                Debug.Log("Has mejorado tu EDU");
                EDU += Random.Range(1, 11);
            }
        }

        // Cálculo de Movimiento (MOV)
        int Mov = 8; // Valor por defecto razonable

        if (des < TAM && fue < TAM)
        {
            Mov = 7;
        }
        else if (des >= TAM && fue >= TAM)
        {
            Mov = 9;
        }
        // Si uno es mayor y otro menor se queda en 8

        // Reducciones de MOV por edad avanzada
        if (Edad >= 40 && Edad <= 49)
        {
            Mov -= 1;
        }
        else if (Edad >= 50 && Edad <= 59)
        {
            Mov -= 2;
        }
        else if (Edad >= 60 && Edad <= 69)
        {
            Mov -= 3;
        }
        else if (Edad >= 70 && Edad <= 79)
        {
            Mov -= 4;
        }
        else if (Edad >= 80)
        {
            Mov -= 5;
        }

      
    }




    // Update is called once per frame
    void Update()
    {
        
    }
}
