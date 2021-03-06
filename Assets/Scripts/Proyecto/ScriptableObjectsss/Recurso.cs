using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "Audio_", menuName = "AudiosObj/insertarAudios", order = 1)]
public class Recurso : ScriptableObject
{
    public static int juegoSeleccionado = 0;

    [System.Serializable]
    public struct Recursos
    {
        public string nombre;
        public AudioClip audio;
        public Sprite CharacterImage;

    }

    public Recursos[] recursos;

    public int lenghtRecursos()
    {
        return recursos.Length -1;
    }

 
}
