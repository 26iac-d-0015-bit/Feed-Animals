using System.Runtime.CompilerServices;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public float rangeX;
    public GameObject food;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");

        //Move playere
        transform.Translate(Vector3.right * speed * Time.deltaTime * horizontalInput);

        //Limit movement range
        if (transform.position.x > rangeX)
        {
            transform.position =
                new Vector3(rangeX, transform.position.y, transform.position.z);
        }
        else if (transform.position.x < -rangeX)
        {
            transform.position =
                new Vector3(-rangeX, transform.position.y, transform.position.z);
        }

        //Throw food
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(food, transform.position, Quaternion.identity);
        }
    }
        private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Animal"))
        {
            Debug.Log("Game Over!");
        }
    }

       

    
        
    

}

