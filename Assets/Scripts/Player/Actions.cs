using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Actions : MonoBehaviour
{
    private Rigidbody2D Object;
    private Vector3 InitialPos ;
    private bool Growth = false;
    private Jump jumpScript ;
    private  AudioSource Victory;
    void Start()
    {
        this.jumpScript = GetComponent<Jump>();
        this.Object = GetComponent<Rigidbody2D> ();
        this.InitialPos = transform.position;
        this.Victory = GetComponent<AudioSource>();
    }
    
    void OnCollisionEnter2D(Collision2D col) {
        if (col.gameObject.tag == "planta_1" ) {
            this.PowerUp();
        }
        if (col.gameObject.tag == "planta_2" ) {
            this.Teleport();
        }
        if (col.gameObject.tag == "planta_3" ) {
            this.Restart();
        } 
        if (col.gameObject.tag == "planta_4" ) {
           this.ToDoor();
        }
        if (col.gameObject.name == "Jumper" ) {
            this.Jumping();
        }
        if (col.gameObject.name == "Flag" ) {
            this.Victory.Play();
        }
    }
    void Jumping() {
        this.jumpScript.Jumpaction();
    }
    void PowerUp() {
        if (!this.Growth) {
            this.Growth = true;
            transform.localScale =new Vector3(3.5f,3.5f,1);
        }
    }
    void Teleport() {
        if (this.Growth) {
            transform.position = GameObject.FindGameObjectWithTag("Point").transform.position;
        } else {
            this.Restart();
        }
    }
    public void Restart() {
        this.Growth = false;
        transform.position = this.InitialPos;
        transform.localScale =new Vector3(2,2,1);
    }

    void ToDoor() {
        if (this.Growth) {
            transform.position = GameObject.Find("ToDoor").transform.position;
        } else {
            this.Restart();
        }
    }

}
