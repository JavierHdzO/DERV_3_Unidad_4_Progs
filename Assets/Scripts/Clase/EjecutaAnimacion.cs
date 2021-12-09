using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjecutaAnimacion : MonoBehaviour
{
    [SerializeField]
    GameObject personaje;

    Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = personaje.GetComponent<Animator>();
    }

   
    public void PlayAnimacion1()
    {
        animator.Play("Flair");
    }

    public void PlayAnimacion2()
    {
        animator.Play("Bboy_Hip_Hop_Move");
    }

    public void PlayAnimacion3()
    {
        animator.Play("Rumba_Dancing");
    }
}
