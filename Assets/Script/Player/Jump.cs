using Unity.VisualScripting;
using UnityEngine;

public class Jump : MonoBehaviour
{
    private Rigidbody player;

    public float jumpForce;


    public bool onGround;
    public bool jump;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        player = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        jump = Input.GetKeyDown(KeyCode.Space);

        if (jump & onGround)
        {
            player.AddForce(Vector3.up *  jumpForce, ForceMode.Impulse);
            onGround = false;
        }
}

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Floor"))
        {
            onGround = true;
        }
}
}
