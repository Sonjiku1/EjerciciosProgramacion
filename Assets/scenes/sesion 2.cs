using UnityEngine;

public class sesion2 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int fue = 0;

        fue = (Random.Range(1, 7) + Random.Range(1, 7) + Random.Range(1, 7)) * 5;

        int con = 0;

        con = (Random.Range(1, 7) + Random.Range(1, 7) + Random.Range(1, 7)) * 5;

        int des = 0;

        des = (Random.Range(1, 7) + Random.Range(1, 7) + Random.Range(1, 7)) * 5;

        int Apa = 0;

        Apa = (Random.Range(1, 7) + Random.Range(1, 7) + Random.Range(1, 7)) * 5;

        int Pod = 0;

        Pod = (Random.Range(1, 7) + Random.Range(1, 7) + Random.Range(1, 7)) * 5;

        int Sue = 0;

        Sue = (Random.Range(1, 7) + Random.Range(1, 7) + Random.Range(1, 7)) * 5;

        int TAM = 0;

        TAM = (Random.Range(1, 7) + Random.Range(1, 7)) + 6 ) *5;

        int INT = 0;

        INT = (Random.Range(1, 7) + Random.Range(1, 7)) + 6 ) *5;

        int EDU = 0;

        EDU = (Random.Range(1, 7) + Random.Range(1, 7)) + 6 ) *5;

        int Edad = Random.Range(15, 19);
    }
        if (Edad => 15 && Edad <= 19)
        {
     Debug.Log("Modificado Edad");
        fue -= 5;
        TAM -= 5;
        EDU -= 5;

        int SueReroll = Random.Range(1, 7) + Random.Range(1, 7) + Random.Range(1, 7));
        
        if (SueReroll > Sue){

       
         Sue = SueReroll;
        } 

     else if (20 <= Edad && Edad <= 39) 
      { 
      //Mejora de EDU
      int Und100 = Random.Range(1, 101);
      }

     if (Und100 <= 90)
     {
        EDU += 5;
     }
     else if (40 <= Edad && Edad <= 49)
     {
        //Mejora de EDU
        int Und100 = Random.Range(1, 101);
     }

     if (Und100 > EDU)
{
    Debug.Log("Has mejorado tu EDU");
    EDU = EDU + Random.Range(1, 11);
}
}



    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
