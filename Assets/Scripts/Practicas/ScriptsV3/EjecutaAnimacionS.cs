using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjecutaAnimacionS : MonoBehaviour
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
        animator.Play("silly");
    }
    public void PlayAnimacion2()
    {
        animator.Play("taunt");
    }
    public void PlayAnimacion3()
    {
        animator.Play("idle");
    }
}
