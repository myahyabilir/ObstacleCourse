using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubeMovement : MonoBehaviour
{

    Rigidbody baslatici;

    // Start is called before the first frame update
    void Start()
    {
        baslatici = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 force = new Vector3(0,0,20);
        baslatici.AddForce(force);

        if(Input.GetAxis("Horizontal") > 0){
            baslatici.AddForce(new Vector3(35,0,0));
        }

        if(Input.GetAxis("Horizontal") < 0){
            baslatici.AddForce(new Vector3(-35,0,0));
        }

        if(transform.position.y < -2){
            FindObjectOfType<gameManager>().EndGame();
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        gameManager controller = FindObjectOfType<gameManager>();
        GameObject carpisilanObje = collision.gameObject;

        if(carpisilanObje.tag == "duvar"){
            controller.EndGame();
        }

        if(carpisilanObje.tag == "finisher"){
            controller.SuccessfullyFinished();
        }
    }

}
