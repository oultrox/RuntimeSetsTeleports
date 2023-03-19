using UnityEngine;


namespace Gameplay.Player
{
    public class PlayerMovement : MonoBehaviour
    {
        [SerializeField] private float movementSpeed;
        [SerializeField] private float jumpForce = 8;
        private CharacterController playerController;
        private Vector3 movementDirection = Vector3.zero;
        private readonly float gravityScale = 10;

        private void Awake()
        {
            playerController = GetComponent<CharacterController>();
        }

        private void Update()
        {
            ApplyGravity();
            GetInputs();
            MovePlayer();
        }

        private void MovePlayer()
        {
            // Movement based on transform rotation. 
            // playerController.Move(transform.rotation * movementDirection * movementSpeed * Time.deltaTime);
            playerController.Move(movementDirection * (movementSpeed * Time.deltaTime));
        }

        private void ApplyGravity()
        {
            movementDirection.y -= gravityScale * Time.deltaTime;
        }

        private void GetInputs()
        {
            movementDirection.x = Input.GetAxisRaw("Horizontal");
            movementDirection.z = Input.GetAxisRaw("Vertical");
            
            if (Input.GetButton("Jump"))
            {
                movementDirection.y = jumpForce;
            }
        }
    }

}
