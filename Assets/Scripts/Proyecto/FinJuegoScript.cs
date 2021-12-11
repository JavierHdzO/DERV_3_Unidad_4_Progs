using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class FinJuegoScript : MonoBehaviour
{
    [SerializeField]
    TextMeshProUGUI usu;

    // Start is called before the first frame update
    void Start()
    {
        string usuario = PlayerPrefs.GetString("usu");

        usu.text = usuario;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
