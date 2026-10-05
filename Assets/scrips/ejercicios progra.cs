using UnityEngine;

public class ejerciciosprogra : MonoBehaviour
{
    void Start()
    {
        // 1. Calcular f(x) = 10*x³ + 5*x² + 10*x + 15
        float x = 2.0f;
        float resultado = 10f * Mathf.Pow(x, 3) + 5f * Mathf.Pow(x, 2) + 10f * x + 15f;
        Debug.Log("Resultado de f(x): " + resultado);


        // 2. Calcular edad a partir del año de nacimiento
        int añoNac = 2005;
        int añoActual = 2026;
        int edadCalculada = añoActual - añoNac;
        Debug.Log("Edad: " + edadCalculada);


        // 3. Verificar si puede acceder (mayor de 18)
        int edad = 20;
        if (edad > 18)
        {
            Debug.Log("Puede acceder");
        }
        Debug.Log("Fin del programa");


        // 4. Límites de Flappy Bird
        int flappyPoseY = 5;                 // posición actual (ejemplo)
        int upperLimitflappyPoseY = 10;      // límite superior
        int lowerLimitflappyPoseY = 0;       // límite inferior

        if (flappyPoseY > upperLimitflappyPoseY)
        {
            Debug.Log("Muerto (por arriba)");
        }
        if (flappyPoseY < lowerLimitflappyPoseY)
        {
            Debug.Log("Muerto (por abajo)");
        }


        // 5. Día de la semana según índice
        int indiceDia = 1;

        if (indiceDia == 1)
        {
            Debug.Log("Lunes");
        }
        else if (indiceDia == 2)
        {
            Debug.Log("Martes");
        }
        else if (indiceDia == 3)
        {
            Debug.Log("Miércoles");
        }
        else if (indiceDia == 4)
        {
            Debug.Log("Jueves");
        }
        else if (indiceDia == 5)
        {
            Debug.Log("Viernes");
        }
        else if (indiceDia == 6)
        {
            Debug.Log("Sábado");
        }
        else if (indiceDia == 7)
        {
            Debug.Log("Domingo");
        }
        else
        {
            Debug.Log("Día inválido");
        }


        // 6. Determinar cuadrante
        int posX = 3;
        int posY = -2;

        if (posX > 0 && posY > 0)
        {
            Debug.Log("Cuadrante 1");
        }
        else if (posX < 0 && posY > 0)
        {
            Debug.Log("Cuadrante 2");
        }
        else if (posX < 0 && posY < 0)
        {
            Debug.Log("Cuadrante 3");
        }
        else if (posX > 0 && posY < 0)
        {
            Debug.Log("Cuadrante 4");
        }
        else
        {
            Debug.Log("Está en un eje");
        }


        // 7. Piedra, papel o tijera (ejemplo simple)
        int rock = 1;
        int paper = 2;
        int scissors = 3;

        // Ejemplo: piedra vs papel
        if (rock == 1 && paper == 2)
        {
            Debug.Log("Paper wins");
        }
    }



// Update is called once per frame
void Update()
    {
        
    }
}
