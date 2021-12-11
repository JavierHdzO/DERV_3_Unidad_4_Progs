using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ManejadorFin : MonoBehaviour
{

    [SerializeField]
    public TextMeshProUGUI NombreUsuario;



    // Start is called before the first frame update
    void Start()
    {

        string usuario = PlayerPrefs.GetString("Player");
        NombreUsuario.text = usuario.ToString();


    }



    public void JugarNuevamente()
    {

        SceneManager.LoadScene(0);
    }

}
