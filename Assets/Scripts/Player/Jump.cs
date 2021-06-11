using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    private Rigidbody2D Object;
    public float Force;
    public Transform Feet;
    public LayerMask Ground;
    public float Rad;
    public bool CanJump = false;
    // Start is called before the first frame update
    void Start()
    {
        this.Object = GetComponent<Rigidbody2D> ();
    }

    // Update is called once per frame
    void Update()
    {
        this.CanJump = Physics2D.OverlapCircle(
            Feet.position,
            Rad,
            Ground
        );
        if (Input.GetKey("space") && this.CanJump) {
            this.Jumpaction();
        }
    }
    public void Jumpaction() {
        this.Object.velocity = new Vector2(0,this.Force); 
    }
}
