using UnityEngine;

public class bucles : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int n= 0;
      while (n < 100)
        {
            Debug.Log("El valor hasta n es:" + n);
            n++;
        }

        int m = 7;
     int z = 5;

     // multipicar el numero m y z sin utilizar el operador de multiplicacion

     while (m > 0)
        {
            z += n;
            m--;
        }
        Debug.Log("El resultado de la multiplicacion es:" + z);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
