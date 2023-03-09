using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimations : MonoBehaviour
{
    public CharacterController characterController;
    public Animator animator;
    private Vector3 inputs;
    public bool rollForce;

    private float speed = 2f;


    private void Start()
    {
        characterController = GetComponent<CharacterController>();
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        inputs.Set(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        characterController.Move(inputs * Time.deltaTime * speed);
        characterController.Move(Vector3.down * Time.deltaTime);

        if(inputs != Vector3.zero)
        {
            animator.SetBool("Run", true);
            transform.forward = Vector3.Slerp(transform.forward, inputs, Time.deltaTime * 10);
        }

        else
        {
            animator.SetBool("Run", false);
        }

        if (Input.GetMouseButton(0))
        {
            GetComponent<Animator>().SetBool("Roll", true);
        }

        else
        {
            GetComponent<Animator>().SetBool("Roll", false);
        }

    }
}
