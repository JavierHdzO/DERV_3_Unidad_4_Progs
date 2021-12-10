using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "Audio_", menuName = "AudiosObj/insertarAudios", order = 1)]
public class Prueba : ScriptableObject
{
    [System.Serializable]
    public struct Recurso
    {
        public string nombre;
        public AudioClip audio;
        public Sprite CharacterImage;

    }

    public Recurso[] recursos;

    public int lenghtRecursos()
    {
        return recursos.Length;
    }

 
}
