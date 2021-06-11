// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// public class Player : MonoBehaviour
// {
//     // Start is called before the first frame update
//     public float timegame;
//     public Rigidbody2D Object;
    
//     void Start()
//     {   
//         this.Object = GetComponent<Rigidbody2D> ();
        
//     }

//     // Update is called once per frame
//     void Update()
//     {

//         this.Moves(
//             Input.GetAxis("Horizontal"),
//             Input.GetAxis("Vertical"),
//             Input.GetKey("space"));
//     }

//     void Moves(float horizontal, float vertical,bool space) {
//         // Debug.Log(this.CanJump);
//         // controllers
//         float x = horizontal * this.timegame;
//         // float y; 
//         // controllers
//         this.Object.velocity = new Vector2(x,this.Object.velocity.y);    
//     }
// }
