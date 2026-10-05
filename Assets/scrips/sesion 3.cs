using UnityEngine;

public class sesion3 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        for (int i = 0; i < 10; i++) 
        {
            Debug.Log("Hola mundo");
        }

       // escribir el codifo para sumar las secuemcias de números del 1 al n, siendo n una variable entera. ej= 5; 1+2+3+4+5 = 15
        int 5;
        int suma = 0;
        for (int i = 1; i <= n; i++) 
        {
            suma += i;
        }

        Debug.Log("La suma de los números del 1 al " + n + " es: " + suma);


        // escribe rl codigo para mostrar la cuenta atras de un explosivo,  empezando por un valor de almacenamiento en initial_time y mostrando "EXPLOSION" cuando termine la cuenta atras

        int initial_time = 10;

        for (int i = initial_time; i > 0; i--)
        {
            Debug.Log(i);
        }

        Debug.Log("EXPLOSION");

        // Escribe un programa que muestre los numeros pares de 1 hasta n_pares, que almacenará el limite maximo 

        int n_pares = 20;
         
        for (int i = 1; i <= n_pares; i++)
        {
            if (i % 2 == 0)
            {
                Debug.Log(i);
            }
        }

        Debug.Log("Fin del programa");

        // queremos simular n tiradas de 3 dados de 6 e ir registrando resultados,para registrar un histograma de resultados 
        
        int max_tiradas = 100;
        
        for (int i = 0; i < max_tiradas; i++)
        {
            int dado1 = Random.Range(1, 7);
            int dado2 = Random.Range(1, 7);
            int dado3 = Random.Range(1, 7);
            int suma_dados = dado1 + dado2 + dado3;
            Debug.Log("Tirada " + (i + 1) + ": Dado 1: " + dado1 + ", Dado 2: " + dado2 + ", Dado 3: " + dado3 + ", Suma: " + suma_dados);
        }
        
        



    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
