using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class week4 : MonoBehaviour
{

    private Animator playerAnim;
    [Range (0,15)]
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        playerAnim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetButtonDown(KeyCode.Space))
        //{
        //    MoveForward();
        //}
    }

    void MoveForward()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
        playerAnim.SetBool("isrunning", true);
    }

    void StopMovement()
    {
        speed = 0;
        playerAnim.SetBool("isrunning", false);
    }
}
