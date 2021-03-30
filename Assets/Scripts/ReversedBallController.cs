using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReversedBallController : MonoBehaviour
{
    public float ballSpeed;
    public Rigidbody ballRigidbody;
    public float xSpeed, ySpeed;
    Gyroscope m_Gyro;

    //For the end of the game
    public GameObject gameMenu;

    // Start is called before the first frame update
    void Start()
    {
        //Input.gyro.enabled = true;
        ballRigidbody = GetComponent<Rigidbody>();
        m_Gyro = Input.gyro;
        m_Gyro.enabled = true;
        ballSpeed = 50;

    }

    // Update is called once per frame
    void Update()
    {
        xSpeed = m_Gyro.attitude.x;
        ySpeed = m_Gyro.attitude.y;
        ballRigidbody.AddTorque(new Vector3(xSpeed, ySpeed, 0) * ballSpeed * Time.deltaTime);
    }
    void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.name == "Goal")
        {
            Destroy(collision.gameObject);
            //To set the menu active
            gameMenu.SetActive(true);
            //To pause the game
            Time.timeScale = 0;
        }

    }
}
