using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moves : MonoBehaviour
{
    public float timegame;
    private Rigidbody2D Object;
    private SpriteRenderer Sprite;
    // Start is called before the first frame update
    private Actions actionScript;
    
    void Start()
    {
        this.actionScript = GetComponent<Actions>();
        this.Object = GetComponent<Rigidbody2D> ();
        this.Sprite = GetComponent<SpriteRenderer>();

    }

    // Update is called once per frame
    void Update()
    {
        float H = Input.GetAxis("Horizontal");
        this.Move(H);
        this.Flip(H);
        this.outlimit();
    }
    void Move(float horizontal)
    {
        // Debug.Log(this.CanJump);
        // controllers
        float x = horizontal * this.timegame;
        // float y; 
        // controllers
        this.Object.velocity = new Vector2(x,this.Object.velocity.y);    
    }
    void Flip(float horizontal)
    {
        if (horizontal < 0) {
            this.Sprite.flipX = false;
        }
        if ( horizontal > 0 ) {
            this.Sprite.flipX = true;
        }

    }
    void outlimit() {
        if (transform.position[1] < -15) {
            this.actionScript.Restart();
        }
    }
}
