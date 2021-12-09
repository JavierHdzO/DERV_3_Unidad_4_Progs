using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjecutaAnimacionM : MonoBehaviour
{
    // Start is called before the first frame update
    Animator animator;
    [SerializeField]
    GameObject personaje;

    private void Start()
    {
        animator = personaje.GetComponent<Animator>();
    }
    
    public void PlayAnimacion1()
    {
        animator.Play("Warming_Up");
    }
    public void PlayAnimacion2()
    {
        animator.Play("Flip_Kick");
    }
    public void PlayAnimacion3()
    {
        animator.Play("Running_Arc");
    }
}
