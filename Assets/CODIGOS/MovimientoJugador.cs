using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoJugador : MonoBehaviour
{
    private Rigidbody2D rig;
    private Animator anim;
    private SpriteRenderer spritePersonaje;
    [SerializeField] private float velocidadPersonaje;

    private void Awake()
    {
        rig = GetComponent<Rigidbody2D>();
        anim = GetComponentInChildren<Animator>();
        spritePersonaje = GetComponentInChildren<SpriteRenderer>();
    }
    private void FixedUpdate()
    {
        float velocidadInput = Input.GetAxisRaw("Horizontal");
        rig.velocity = new Vector2(velocidadInput * velocidadPersonaje, rig.velocity.y);
        anim.SetFloat("Camina", velocidadInput);

        if (velocidadInput < 0)
        {
            spritePersonaje.flipX = true;
        }
        else if (velocidadInput > 0)
        {
            spritePersonaje.flipX = false;
        }
    }
}
