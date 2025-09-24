using UnityEngine;

public class BalaController : MonoBehaviour
{
    private Rigidbody bullet;

    public float power = 20f;
    public float timeLife = 2f;

    private float time = 0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        bullet = GetComponent<Rigidbody>();
        bullet.linearVelocity = this.transform.forward * power;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        time += Time.deltaTime;

        if (time >= timeLife) 
        {
            Destroy(this.gameObject);
        }
    }
}
