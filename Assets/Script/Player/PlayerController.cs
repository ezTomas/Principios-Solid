using UnityEngine;

public class PlayerController : MonoBehaviour
{


    private Rigidbody player;


    public float speed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        player = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveY = Input.GetAxis("Vertical");

        Vector3 movimiento = new Vector3(moveX, 0f , moveY);

        transform.Translate(movimiento * speed * Time.deltaTime);

    }


}


