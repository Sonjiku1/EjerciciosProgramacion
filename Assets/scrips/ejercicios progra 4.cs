using UnityEngine;

public class ejerciciosprogra4 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        // crea una función y devuelva true si es par y false si es impar

        int n = 4;
        if (n % 2 == 0)
        {
            return  true;

        }
        else
        {
            return false;
        }

        // crea una función que calcule el factorial de un numero (3!--1*2*3)

        int factorial = 1;

        for (int i = 1; i < n; i++)
        {
            factorial = factorial * i; 
        }
        return factorial; 
    // CREA UNA FUNCION QUE RECIBA UN ARRAY DE ENTEROS Y DEVUELVA EL DE MAYOR VALOR
    int ObtenerMayorValor (int[] numeros)
        {
            int MayorValor = 0;

            for (int i = 0; i < numeros.lenght; i++)
            {
                int num = numeros[i];

                if (num>  MayorValor)
                    MayorValor = num;
            }
            
        }
        return MayorValor; 


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
