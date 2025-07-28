using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    private Rigidbody rb;
    public float score = 0;
    void Start() 
    {
        speed = 5;
        rb = GetComponent<Rigidbody>();
    }
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(horizontal, 0, vertical); // ( X, Y, Z )
        rb.AddForce (movement * speed);
        
    }
    private void OnTriggerEnter(Collider other)
    {
       if (other.gameObject.CompareTag("Box"))
        {
            other.gameObject.SetActive(false);
            score += 10;
        }
       else if (other.gameObject.CompareTag("Obstacle"))
        {
            other.gameObject.SetActive(false);
            speed--;
        }
    }
}