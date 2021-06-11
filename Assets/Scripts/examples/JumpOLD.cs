using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpOLD : MonoBehaviour
{
    public float fuerza;
    public Transform pie;
    public LayerMask suelo;
    public float radioPie;
    public Rigidbody2D Object;
    public bool verificar;
    
    public AudioSource[] jump;
    void Start()
    {
        this.jump = GetComponents<AudioSource>();
        this.Object = GetComponent<Rigidbody2D> ();
    }

    // Update is called once per frame
    void Update()
    {
       this.verificar = Physics2D.OverlapCircle(this.pie.position,this.radioPie,this.suelo);
       if (Input.GetKey("space") && verificar == true) {
           this.Object.velocity = new Vector2(0,this.fuerza);
           this.jump[0].Play();
       }
    }
    // void OnCollisionEnter2D(Collision2D col) {
    //     if (col.gameObject.tag == this.plataforma) {
    //         this.CanJump = true;
    //     }
    // }
}
