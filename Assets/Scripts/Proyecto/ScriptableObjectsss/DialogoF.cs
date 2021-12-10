using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Conversacion", menuName = "CrearConversacion", order = 1)]
public class DialogoF : ScriptableObject
{
    [System.Serializable]
    public struct Conversation
    {
        [TextArea(2, 5)]
        public string Message;
        public string nombrePersonaje;
      //  public Sprite CharacterImage;

    }

    public Conversation[] conversacionMaestra;

    public int conversacioMaestraLength()
    {
        return conversacionMaestra.Length;
    }


}
