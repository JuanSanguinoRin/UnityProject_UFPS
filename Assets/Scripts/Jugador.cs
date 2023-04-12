using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jugador : MonoBehaviour
{
    // Start is called before the first frame update
    public float fuerzaSalto;
    public Animator animator;
    //ivate Animator animator;
    private Rigidbody2D rgidbody2D;
    void Start()
    {
        animator = GetComponent<Animator>();
        rgidbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)) {
            //animator.setBool("estaSaltando", true);
            rgidbody2D.AddForce(new Vector2(0, fuerzaSalto));
            animator.SetBool("estaSaltando", true);
          
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "suelo")
        {
            animator.SetBool("estaSaltando", false);
        }
    }
}
