using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Boton : MonoBehaviour
{
    [SerializeField] GameObject pauseMenu;  //Creamos una funcion llamada "pauseMenu", que nos seervirá para la función de pausar la escena


    public void Pause()
    {
        pauseMenu.SetActive(true);         //Decimos que si nuestra funcion "pauseMenu" es positiva, la escena parará
        Time.timeScale = 0f;
    }

    public void Resume()
    {
        pauseMenu.SetActive(false);        //Decimos que si nuestra funcion "pauseMenu" es negativa, la escena continuará
        Time.timeScale = 1f;
    }

   
}
