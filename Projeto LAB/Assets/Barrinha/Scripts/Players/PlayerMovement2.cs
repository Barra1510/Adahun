using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem.XR;

public class PlayerMovement2 : MonoBehaviour
{
    [Header("Player Movement")]
    [SerializeField] float speed;
    [SerializeField] float gravity = -9.8f;
    [SerializeField] float jumpHeight;

    //Character Controller
    [Header("Character Controller")]
    private Rigidbody2D controller;
    [SerializeField] Vector2 playerVelocity;
    [SerializeField] Vector2 moveDirection;

    //GroundCheck
    [SerializeField] Transform groundCheck;
    [SerializeField] LayerMask groundLayer;

    //Bool 
    bool isGrounded;
    public bool isRapel;

   

    void Start()
    {
        controller = GetComponent<Rigidbody2D>();
    }

    public bool IsGrounded()
    {
        return Physics2D.OverlapCircle(groundCheck.position, 0.1f, groundLayer);
    }

    public void Move(Vector2 input)
    {
        if (!isRapel)
        {
            moveDirection = Vector3.zero;
            moveDirection.x = input.x;
            moveDirection.y = input.y;
            //controller.velocity = new Vector2(moveDirection.x * speed * Time.deltaTime, 0);        
            playerVelocity.y += gravity * Time.deltaTime;
            
            if (IsGrounded())
                controller.velocity = new Vector2(moveDirection.x * speed * Time.deltaTime, playerVelocity.y * Time.deltaTime);
            controller.velocity = new Vector2(moveDirection.x * speed * Time.deltaTime, controller.velocity.y);
        }
    }
    public void Jump()
    {
        if (IsGrounded())
        {
            if (!isRapel)
                playerVelocity.y = Mathf.Sqrt(jumpHeight * -3 * gravity);
        }
    }

    public void Rapel(Vector2 input)
    {
        if (isRapel)
        {
            //playerVelocity.y += gravity * Time.deltaTime;
            moveDirection.x = input.x;
            controller.velocity = new Vector2(moveDirection.x * speed / 2 * Time.deltaTime, controller.velocity.y);
        }
    }

    void RotationController(Vector2 input)
    {
        moveDirection.y = input.y;
        moveDirection.x = input.x;
        controller.AddForce(new Vector2(5,10));
        

        //posX = rotationCenter.position.x + Mathf.Cos(angle) * rotationRadius/2;
        //posY = rotationCenter.position.y + Mathf.Sin(angle) * rotationRadius;
        //controller.position = new Vector2(posX, posY);
        //angle += Time.deltaTime * angularSpeed;

        //if (angle >= 360f)
        //    angle = 0;
    }

    public Vector2 GetPosition()
    {
        return this.transform.position;
    }

}
