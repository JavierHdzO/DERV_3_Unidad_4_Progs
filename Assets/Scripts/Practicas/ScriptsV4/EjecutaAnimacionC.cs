using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjecutaAnimacionC : MonoBehaviour
{
    [SerializeField]
    GameObject Personaje;

    Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = Personaje.GetComponent<Animator>();
    }

    public void PlayAnimacion1()
    {
        animator.Play("Walking");
    }

    public void PlayAnimacion2()
    {
        animator.Play("Sit down");
    }

    public void PlayAnimacion3()
    {
        animator.Play("HitHead");
    }

    public void PlayAnimacion4()
    {
        animator.Play("HitBody");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
