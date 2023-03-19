using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonDash : MonoBehaviour
{
    ThirdPersonMovement moveScript;

    public float dashSpeed;
    public float dashTime;
    bool canDash = true;


    void Start()
    {
        moveScript = GetComponent<ThirdPersonMovement>();
    }

    private void Update()
    {
        if(canDash && Input.GetMouseButton(0))
        {
            StartCoroutine(Dash());
        }
    }

    IEnumerator Dash()
    {
        canDash = false;
        float startTime = Time.time;
        while (Time.time < startTime + dashTime)
        {
            moveScript.controller.Move(moveScript.moveDir * dashSpeed * Time.deltaTime);

            yield return null;
        }
        yield return new WaitForSeconds(2f);
        canDash = true;
    }

}
