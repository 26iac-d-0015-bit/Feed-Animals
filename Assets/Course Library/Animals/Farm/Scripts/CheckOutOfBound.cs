using UnityEngine;

public class CheckOutOfBound : MonoBehaviour
{
    public float topBound;
    public float bottomBound;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.z > topBound)
        {
            Destroy(gameObject);
        }
        else if(transform.position.z < bottomBound)
        {
            Destroy(gameObject);
        }
    }
}
