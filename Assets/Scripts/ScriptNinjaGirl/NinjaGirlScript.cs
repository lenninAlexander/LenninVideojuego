using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NinjaGirlScript : MonoBehaviour
{
    public float speed = 50;
    public float upSpeed = 100;
    


    private SpriteRenderer sr;
    private Animator animator;
    private Rigidbody2D rb2d;
    
    public bool gameispaused;

    private bool puedoSaltar = false;
    private bool morir = false;
    private bool ganar = false;
    private int cont = 0;
    float secondsCounter = 0;
    float secondsToCount = 1;

    void Start()
    {
        sr = GetComponent<SpriteRenderer>(); // obtengo el objeto spriterenderer de Player
        animator = GetComponent<Animator>();
        rb2d = GetComponent<Rigidbody2D>();
       


    }

    // Update is called once per frame
    void Update()
    {
       
      
        setRunAnimation();
        rb2d.velocity = new Vector2(speed, rb2d.velocity.y);

        if (Input.GetKeyDown(KeyCode.Space) && puedoSaltar)
        {
            rb2d.velocity = Vector2.up * upSpeed;
            puedoSaltar = false;
            setJumpAnimation();
        }
        if(morir)
        {
            setDeadAnimation();
            secondsCounter += Time.deltaTime;
            if (secondsCounter >= secondsToCount)
            {
                secondsCounter = 0;
                SceneManager.LoadScene("Perdiste");

            }

            
        }
        if (ganar)
        {
            SceneManager.LoadScene("Ganaste");
        }
        if(cont>=10 && cont<20)
        {
            Debug.Log("VELOCIDAD1");
            rb2d.velocity = new Vector2(speed+20, rb2d.velocity.y);
        }else if (cont>=20 && cont<30)
        {
            Debug.Log("VELOCIDAD2");
            rb2d.velocity = new Vector2(speed + 30, rb2d.velocity.y);
        }else if(cont >= 30 && cont < 40)
        {
            Debug.Log("VELOCIDAD3");
            rb2d.velocity = new Vector2(speed + 40, rb2d.velocity.y);
        }
        else if (cont >= 40 && cont < 50)
        {
            Debug.Log("VELOCIDAD4");
            rb2d.velocity = new Vector2(speed + 50, rb2d.velocity.y);
        }
        else if (cont==50&& cont >50)
        {
            Debug.Log("VELOCIDAD5");
            rb2d.velocity = new Vector2(speed , rb2d.velocity.y);
        }

    }
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.layer == 8)
            puedoSaltar = true;
        if(other.gameObject.layer ==7)
        {
            morir = true;
        }
        if(other.gameObject.layer==9)
        {
            ganar=true;
        }
        if(other.gameObject.tag == "Contador")
        {
            cont++;
            Debug.Log(cont);

        }
    }

    private void setIdleAnimation()
    {
        animator.SetInteger("Estado", 0);
    }

    private void setRunAnimation()
    {
        animator.SetInteger("Estado", 1);
    }

    private void setJumpAnimation()
    {
        animator.SetInteger("Estado", 2);
    }

    private void setDeadAnimation()
    {
        animator.SetInteger("Estado", 3);
    }

}
