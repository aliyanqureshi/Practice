using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Player : MonoBehaviour
{
    Rigidbody rb;
    public GameObject Wintext;
    float Xinput;
    float Yinput;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        // 1. Destroying Game Object in the start of the game
        /* Destroy(gameObject);
        // 2. Destroying Game Object after 3 Seconds
        Destroy(gameObject,3f);*/
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        // 3. Destroying by the specfic key pressed
        /*if (Input.GetKeyDown(KeyCode.Tab)) {
            Destroy(gameObject);
        }*/

        // 4. Jumping Game Object to the upwards direction
        /* if (Input.GetKeyDown(KeyCode.Tab)) {
             rb.AddForce(Vector3.up * 500);
        }*/
        // Moving gameobject into straight using velocity
        /*rb.velocity = Vector3.forward * 10f;*/

        //Switching Scenes
        /* if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene("Level2");
        }*/
        // Moving player 
        /*
        Xinput = Input.GetAxis("Horizontal");
        Yinput = Input.GetAxis("Vertical");
        rb.AddForce(Xinput * speed, 0, Yinput * speed);
        */
        }
    // 5. Destroying By clicking on the object
    /*private void OnMouseDown()
        {
       Destroy(gameObject);
    }*/

    private void OnCollisionEnter(Collision collision)
    {
        // Enemy will be distroyed 
       /* if (collision.gameObject.tag == "Enemy")
        {
            Destroy(collision.gameObject);
            // Text comes out when you win the game
            Wintext.SetActive(true);
        }*/
        // Gameobject will be distroyed
        /*if (collision.gameObject.tag == "Enemy")
        {
            Destroy(gameObject);
        }*/
    }
}
