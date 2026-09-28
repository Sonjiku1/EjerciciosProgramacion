using UnityEngine;

public class ejerciciosprogra : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //hacer f(x)=10*x^3+5*x^"+10*x+15

        float x;
        {
            x = 2.0f;
            float resultado = 10f * Mathf.pow(x, 3) + 5 * Mathf.pow(x, 2) + 10 * x + 15;
        }
        

        //hacer un programa considerando el año de nacimiento obtenga edad.

        int añoNac = 2005;
        {
            int añoActual = 2026;
            int edad = añoActual - añoNac;
        }
      
      

       
        int edad = 20;
        {
            if (edad > 18)
            {
                debug.log(true "puede acceder");
            }
            Debug.log(++"fin del programa");


        }

        int flappyPoseY;

        int upperLimitflappyPoseY;
        int lowerLimitflappyPoseY;

        if (flappyPoseY > upperLimitflappyPoseY)
        {
            Debug.log("muerto");
        }
        if (flappyPoseY < lowerLimitflappyPoseY)
        {
            Debug.log("muerto");
        }

        int indiceDia = 1;

        if (indiceDia == 1)
        {
            Debug.log("lunes");
        }

        if (indiceDia == 2)
        {
            Debug.log("Martes");
        }

        if (indiceDia == 3)
        {
            Debug.log("miercoles");
        }

        if (indiceDia == 4)
        {
            Debug.log("jueves");
        }

        if (indiceDia == 5)
        {
            Debug.log("viernes");
        }

        if (indiceDia == 6)
        {
            Debug.log("sabado");
        }

        if (indiceDia == 7)
        {
            Debug.log("Domingo");
        }


         
        int x 
        int y

    if ( x > 0 && y > 0) {

            Debug.log("cuadrante1");
    }
        else { 
            if(x<0 && y < 0) {
                Debug.log("cuadrante 3")
            }

            int rock = 1;
            int paper = 2;
            int scissors = 3;

            if ( rock == 1 && paper == 2 )
            {
                Debug.log("paper wins");
            }

        


    // Update is called once per frame
    void Update()
    {
        
    }
}
