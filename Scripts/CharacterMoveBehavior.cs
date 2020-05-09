using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Скрипт прикриплен к Character
public class CharacterMoveBehavior : MonoBehaviour
{
    [SerializeField]
	private CharacterController characterController;
	public float speed = 6.0f;
    public float jumpSpeed = 8.0f;
    public float gravity = 20.0f;
	[SerializeField]
	private Vector3 moveDirection = Vector3.zero;
	
	void Start()
	{
		characterController = GetComponent<CharacterController>();
	}
	
	void Update ()
	{		
		//Передвижение персонажа+прыжок
		if (characterController.isGrounded)
        {
            moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0.0f, Input.GetAxis("Vertical"));
			moveDirection = transform.TransformDirection(moveDirection);
            moveDirection *= speed;

            if (Input.GetButton("Jump"))
            {
                moveDirection.y = jumpSpeed;
            }
        }
        moveDirection.y -= gravity * Time.deltaTime;
        characterController.Move(moveDirection * Time.deltaTime);
	}
}