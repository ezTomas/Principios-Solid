using UnityEngine;

public class PlayerSprint : MonoBehaviour
{
    private PlayerController playerMovement;

    public bool isSprinting;
    public float multiplierSpeed = 6f;
    public float normalSpeed = 3f;
    public bool run;

    void Start()
    {
        playerMovement = GetComponent<PlayerController>();
        playerMovement.speed = normalSpeed; 
    }

    void Update()
    {
        runCheck();
    }

    public void runCheck()
    {
        run = Input.GetKeyDown(KeyCode.LeftShift);

        if (run)
        {
            isSprinting = !isSprinting;
        }

        if (isSprinting)
        {
            playerMovement.speed = multiplierSpeed;
        }
        else
        {
            playerMovement.speed = normalSpeed;
        }
    }
}