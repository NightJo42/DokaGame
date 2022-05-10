using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouvement : MonoBehaviour
{
  private CharacterController controller;
    private float playerSpeed = 10.0f;
    private float gravityValue = -9.81f;
    private Vector3 playerVelocity;
      void Start()
    {
        controller = gameObject.GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        controller.Move(move * Time.deltaTime * playerSpeed);

        playerVelocity.y += gravityValue * Time.deltaTime;
       controller.Move(playerVelocity * Time.deltaTime);
    }

}
