using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class validaJuegoDos : MonoBehaviour
{

    public GameObject missionContainer;
    public Image imageCharacter;
    public TextMeshProUGUI currentMission;
    public GameObject Maestra;

    private Animator animator;

    private void Awake()
    {
        missionContainer = GameObject.Find("CanvasTablero");
        imageCharacter = missionContainer.GetComponentInChildren<Image>();
        currentMission = missionContainer.GetComponentInChildren<TextMeshProUGUI>();
    }

    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Recurso.juegoSeleccionado == 2)
        {
            //Verificar si el nombre del objeto seleccionado es igual al que se le pide

            if (RayCastC.nombreSeleccionado.Equals(conversaMaestraF.nombreReto))
            {
                imageCharacter.color = Color.green;
                currentMission.text = "Excelente";

                Recurso.juegoSeleccionado = 0;

                AnimacionMiss.isCorrect = true;

                StopCoroutine("restaurar");
                StartCoroutine("restaurar");

            }

            //Mostar en la pantalla una felicitación

            //Si fue correcto, cambiar el juego seleccionado a 0

            //Reiniciar el indice del dialog
        }
    }

    IEnumerator restaurar() 
    {
        for (int i = 0; i < 1; i++)
        {
            yield return new WaitForSeconds(4f);
        }

        imageCharacter.color = Color.white;
        imageCharacter.sprite = null;
        currentMission.text = "";
        conversaMaestraF.indice = 0;
    }
}
