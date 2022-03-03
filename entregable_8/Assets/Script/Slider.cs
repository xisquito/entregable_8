using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slider : MonoBehaviour
{
    private AudioSource audioSrc;      //Creamos una funcion llamada "audioSrc", que nos servirá como audio

    private float musicVolume = 0.5f;    //Creamos una funcion que nos de el valor del volumen del audio
    // Start is called before the first frame update
    void Start()
    {
        audioSrc = GetComponent<AudioSource>();     //Nos metemos en el componente de AudioSource, y le damos que vale igual que AudioSrc
    }

    // Update is called once per frame
    void Update()
    {
        audioSrc.volume = musicVolume;        //Igualamos el valor del volumen del AudioSrc a nuestro volumen
    }

    public void SetVolume(float vol)
    {
        musicVolume = vol;                 //Creamos la funcion de Runtime
    }
}
