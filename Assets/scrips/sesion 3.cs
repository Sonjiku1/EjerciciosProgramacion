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
        int a = 5;
        int suma = 0;
        for (int i = 1; i <= a; i++) 
        {
            suma += i;
        }

        Debug.Log("La suma de los números del 1 al " + a + " es: " + suma);


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
            int sumadados = dado1 + dado2 + dado3;
            Debug.Log("Tirada " + (i + 1) + ": Dado 1: " + dado1 + ", Dado 2: " + dado2 + ", Dado 3: " + dado3 + ", Suma: " + suma_dados);
        }

        int sumadados = 0;

        for (int j = 0;  j < 10; j++)
        {
            Debug.Log("Iteración " + (j + 1));
        }

        sumadados += Random.Range(1, 7);


        // mas generalizado, para n tiradas de n dados de n caras, y registrar el histograma de resultados

        
        int n_dados = 3;

        int n_caras = 6;

        int n_tiradas = 100;

        int array tiradas = new int[n_dados * n_caras + 1];

        for (int i = 0; i < n_tiradas; i++)
        {
             sumadados = 0;
            for (int j = 0; j < n_dados; j++)
            {
                int sumaresultado = 0;
            }
          
            for (int j = 0; j < n_dados; j++)
            {
    
                suma_resultado += Random.Range (1, n_caras +1);
            }

            Tiradas[suma_resultados]++;
        }
        for ( int i=1; i < Tiradas.Length; i++)
        {
            Debug.Log("Suma: " + i + ", Frecuencia: " + Tiradas[i]);
        }

        // ahora hacerlo con while 

        int n_tiradas_while = 100;

        while (n_tiradas_while > 0)
        {
            int suma_dados = 0;
            for (int j = 0; j < n_dados; j++)
            {
                suma_dados += Random.Range(1, n_caras + 1);
            }
            Tiradas[suma_dados]++;
            n_tiradas_while--;
        }

        Debug.Log("Resultados con while:");

        // estructura de datos estatica para la vida de enemigos 

        int n_enemigos = 5;
        
        int array vida_enemigos = new int [n_enemigos];

        while (n_enemigos > 0)
        {
            int vida = Random.Range(50, 101);
            vida_enemigos[n_enemigos - 1] = vida;
            Debug.Log("Enemigo " + n_enemigos + " tiene vida: " + vida);
            n_enemigos--;
        }
        Debug.Log("Fin de la simulación de enemigos");

        // estructura de datos dinamica para la vida de enemigos

        List<int> vida_enemigos_dinamica = new List<int>();

        enemies.Add(4);

        enemies.Add(10);

        enemies.Add(45);

       foreach (int vida in vida_enemigos_dinamica)
        {
            Debug.Log("Enemigo tiene vida: " + vida);
        }
        Debug.Log("Fin de la simulación de enemigos dinamica");



    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
