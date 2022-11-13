using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moving : MonoBehaviour
{
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        // Destroy(gameObject);
        rb=GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector3.up*300);
            //  rb.velocity=Vector3.forward*30f;
        }
        // rb.velocity=Vector3.forward*30f;
    }
    // void OnMouseDown(){
    //     Destroy(gameObject); 
    // }
}









//         new script





// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// public class moving : MonoBehaviour
// {
//     [Header("movement")]
//     public float moveSpeed;
//     public Transform orientation;
//     float horizontalInput;
//     float verticalInput;
//     Vector3 moveDirection;
//     Rigidbody rb;
//     // Start is called before the first frame update
//     void Start()
//     {
//      rb=GetComponent<Rigidbody>();
      
//     }
// void FixedUpdate(){
//     MovePlayer();
//     void FixedUpdate ()
//     {
//         float moveHorizontal = Input.GetAxis("Horizontal");
//         float moveVertical = Input.GetAxis("Vertical");
 
//         Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
 
//         GetComponent<Rigidbody>().AddForce(movement);
 
//     }
// }
//     // Update is called once per frame
//     void Update()
//     {
//         MyInput();
//     }
//  void MyInput(){
//     horizontalInput=Input.GetAxisRaw("Horizontal");
//     verticalInput=Input.GetAxisRaw("Vertical");
//     if(Input.GetKeyDown(KeyCode.Space))
//     {
//         rb.AddForce(Vector3.up*500);
//     }
    

// }

// void MovePlayer(){
//     moveDirection=orientation.forward*verticalInput+orientation.right*horizontalInput;
//     rb.AddForce(moveDirection.normalized*moveSpeed*10f,ForceMode.Force);
// }

// }
//  using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// public class moving : MonoBehaviour
// {
// public CharacterController controller;
//   public Vector3 MovementSpeed ;
//   public float MouseSpeed;
 
//   // Start is called before the first frame update
//   void Start()
//   {
 
//   }
 
//   // Update is called once per frame
//   void Update()
//   {
//       #region BasicMovement
 
//       if (Input.GetKeyDown(KeyCode.LeftShift))
//       {
//           if (Input.GetKeyDown(KeyCode.W)) MovementSpeed.z += 4;
//           if (Input.GetKeyDown(KeyCode.A)) MovementSpeed.x -= 4;
//           if (Input.GetKeyDown(KeyCode.S)) MovementSpeed.z -= 4;
//           if (Input.GetKeyDown(KeyCode.D)) MovementSpeed.x += 4;
//           if (Input.GetKeyUp(KeyCode.W)) MovementSpeed.z -= 4;
//           if (Input.GetKeyUp(KeyCode.A)) MovementSpeed.x += 4;
//           if (Input.GetKeyUp(KeyCode.S)) MovementSpeed.z += 4;
//           if (Input.GetKeyUp(KeyCode.D)) MovementSpeed.x -= 4;
//       }
//       else
//       {
//           if (Input.GetKeyDown(KeyCode.W)) MovementSpeed.z += 2;
//           if (Input.GetKeyDown(KeyCode.A)) MovementSpeed.x -= 2;
//           if (Input.GetKeyDown(KeyCode.S)) MovementSpeed.z -= 2;
//           if (Input.GetKeyDown(KeyCode.D)) MovementSpeed.x += 2;
//           if (Input.GetKeyUp(KeyCode.W)) MovementSpeed.z -= 2;
//           if (Input.GetKeyUp(KeyCode.A)) MovementSpeed.x += 2;
//           if (Input.GetKeyUp(KeyCode.S)) MovementSpeed.z += 2;
//           if (Input.GetKeyUp(KeyCode.D)) MovementSpeed.x -= 2;
//       }
 
//       controller.SimpleMove(MovementSpeed);
 
//       #endregion
 
//       #region Rotation
 
//       if (Input.GetAxis("Mouse X") > 0) transform.Rotate((Vector3.up) * MouseSpeed);
//       if (Input.GetAxis("Mouse X") < 0) transform.Rotate((Vector3.up) * -MouseSpeed);
//       #endregion
//   }
// }