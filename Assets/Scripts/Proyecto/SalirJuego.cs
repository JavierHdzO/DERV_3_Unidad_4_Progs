using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SalirJuego : MonoBehaviour
{
    // Start is called before the first frame update

    private void OnTriggerEnter(Collider other)
    {
        if (other.name.Equals("TPoseP"))
        {
            SceneManager.LoadScene(2);
        }
    }
}
