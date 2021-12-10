using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class conversaMaestraF : MonoBehaviour
{
    public static string nombreReto = "";

    [SerializeField]
    DialogoF dialogo;
    [SerializeField]
    Recurso recursos;

    public GameObject mainContainer;
    public GameObject missionContainer;
    public Image imageCharacter;
    public TextMeshProUGUI textMesh;
    public TextMeshProUGUI currentMission;
   // public GameObject Mario;

    private AudioSource source;
    static string nameObject;

    int indice = 0;
    bool isOnTrigger;
    bool isItRunning;
    int indiceAud;

    private void Awake()
    {
        mainContainer = GameObject.Find("DialogoJuegoF");
       // imageCharacter = mainContainer.GetComponentInChildren<Image>();
        textMesh = mainContainer.GetComponentInChildren<TextMeshProUGUI>();
        missionContainer = GameObject.Find("CanvasTablero");
        imageCharacter = missionContainer.GetComponentInChildren<Image>();
        currentMission = missionContainer.GetComponentInChildren<TextMeshProUGUI>();
        source = GetComponent<AudioSource>();
      //  Mario = GameObject.Find("Mario");
    }



    void Start()
    {
        mainContainer.SetActive(false);
        isOnTrigger = false;
        missionContainer.SetActive(false);
    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        if (other.name.Equals("TPoseP"))
        {
            if (indice < dialogo.conversacioMaestraLength())
            {
                mainContainer.SetActive(true);
                textMesh.text = dialogo.conversacionMaestra[indice].nombrePersonaje + ": " + dialogo.conversacionMaestra[indice].Message;
                //imageCharacter.sprite = dialogo.conversacionKarolina[indice].CharacterImage;
                textMesh.maxVisibleCharacters = 0;
                StopAllCoroutines();
                StartCoroutine("mostrarTexto");
            }

            isOnTrigger = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        isOnTrigger = false;
        mainContainer.SetActive(false);
    }

    void Update()
    {
        if ((isOnTrigger) && (Input.GetKeyDown(KeyCode.E)) &&
            (indice < dialogo.conversacioMaestraLength() - 1) &&
            (!isItRunning))
        {
            indice++;
            textMesh.text = dialogo.conversacionMaestra[indice].nombrePersonaje +
             ": " + dialogo.conversacionMaestra[indice].Message;
         //   imageCharacter.sprite = dialogo.conversacionMaestra[indice].CharacterImage;

            textMesh.maxVisibleCharacters = 0;
            StopAllCoroutines();
            StartCoroutine("mostrarTexto");
        }
        if ((isOnTrigger) && (Input.GetKeyDown(KeyCode.Q)) && (indice > 0) && (!isItRunning))
        {
            indice--;
            textMesh.text = dialogo.conversacionMaestra[indice].nombrePersonaje +
             ": " + dialogo.conversacionMaestra[indice].Message;
          //  imageCharacter.sprite = dialogo.conversacionKarolina[indice].CharacterImage;

            textMesh.maxVisibleCharacters = 0;
            StopAllCoroutines();
            StartCoroutine("mostrarTexto");
        }

        if (indice == dialogo.conversacioMaestraLength() - 1)
        {/*MODIFICAR ESTA PARTE*/
            missionContainer.SetActive(true);
            
            indiceAud =   Random.Range(0, recursos.lenghtRecursos());
            //recursos.recursos[indiceAud].
            StartCoroutine("reto");
            

            // Mario.SetActive(true);

        }
    }


    IEnumerator mostrarTexto()
    {
        isItRunning = true;
        while (true)
        {
            textMesh.maxVisibleCharacters += 1;

            if (textMesh.maxVisibleCharacters == textMesh.text.Length)
            {
                isItRunning = false;
                break;
            }
            yield return new WaitForSeconds(0.03f);
        }

    }

    IEnumerator reto()
    {
        for (int i = 0; i < 1; i++)
        {
            yield return new WaitForSeconds(1f);
        }
        

        nameObject = recursos.recursos[indiceAud].nombre;
        currentMission.SetText(nameObject);
        imageCharacter.sprite = recursos.recursos[indiceAud].CharacterImage;
        source.clip = recursos.recursos[indiceAud].audio;
        source.Play();
        indice++;

        nombreReto = nameObject;
        RayCastC.juegoSelecionado = 2;
    }

}
