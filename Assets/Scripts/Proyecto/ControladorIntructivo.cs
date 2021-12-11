using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControladorIntructivo : MonoBehaviour
{
    [SerializeField]
    GameObject ImagenControl;


    // Start is called before the first frame update
    private void Awake()
    {

        ImagenControl = GameObject.Find("ImagenControl");
    }



    public void volverInicio() 
    {
        SceneManager.LoadScene(0);
        
    }


    public void mostrarControles() 
    {

        ImagenControl.SetActive(true);
        
    }


    public void mostrarObjetivos()
    {
        ImagenControl.SetActive(false);
    }
}
