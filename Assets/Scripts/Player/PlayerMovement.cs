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

        void Awake()
        {
            playerController = GetComponent<CharacterController>();
        }

        void Update()
        {
            GetInputs();
            CheckJump();
            MovePlayer();
        }

        private void MovePlayer()
        {
            // Apply gravity
            movementDirection.y -= gravityScale * Time.deltaTime;

            playerController.Move(movementSpeed * Time.deltaTime * movementDirection);
        }

        private void CheckJump()
        {
            if (Input.GetButton("Jump"))
            {
                movementDirection.y = jumpForce;
            }
        }

        private void GetInputs()
        {
            movementDirection.x = Input.GetAxisRaw("Horizontal");
            movementDirection.z = Input.GetAxisRaw("Vertical");
        }
    }

}
