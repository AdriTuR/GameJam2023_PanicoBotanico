using UnityEngine;
#if ENABLE_INPUT_SYSTEM && STARTER_ASSETS_PACKAGES_CHECKED
using UnityEngine.InputSystem;
#endif

/* Note: animations are called via the controller for both the character and capsule using animator null checks
 */

namespace StarterAssets
{

    public class ThirdPersonController : MonoBehaviour
    {
        [Header("Player")]
        [Tooltip("Move speed of the character in m/s")]
        public float MoveSpeed = 8.0f;


        [Tooltip("How fast the character turns to face movement direction")]
        [Range(0.0f, 0.3f)]
        public float RotationSmoothTime = 0.12f;

        // player
        private float _speed;
        private float _targetRotation = 0.0f;
        private float _rotationVelocity;
        private float _verticalVelocity;
        public float gravity = 9.8f;
        private float delay = 20.0f;
        float timer = 0.0f;

#if ENABLE_INPUT_SYSTEM && STARTER_ASSETS_PACKAGES_CHECKED
        private PlayerInput _playerInput;
#endif

        private CharacterController _controller;
        private StarterAssetsInputs _input;
        private GameObject _mainCamera;

        private bool IsCurrentDeviceMouse
        {
            get
            {
#if ENABLE_INPUT_SYSTEM && STARTER_ASSETS_PACKAGES_CHECKED
                return _playerInput.currentControlScheme == "KeyboardMouse";
#else
                return false;
#endif
            }
        }


        private void Awake()
        {
            delay = 20.0f;
            // get a reference to our main camera
            if (_mainCamera == null)
            {
                _mainCamera = GameObject.FindGameObjectWithTag("MainCamera");
            }
        }

        private void Start()
        {
            _controller = GetComponent<CharacterController>();
            _input = GetComponent<StarterAssetsInputs>();

        }

        private void Update()
        {
            Move();
            
            gravedad();

            
            
        }


        private void Move()
        {
            // set target speed based on move speed, sprint speed and if sprint is pressed
            //float targetSpeed = _input.sprint ? SprintSpeed : MoveSpeed;
            float targetSpeed = MoveSpeed;
            // a simplistic acceleration and deceleration designed to be easy to remove, replace, or iterate upon
            
            // note: Vector2's == operator uses approximation so is not floating point error prone, and is cheaper than magnitude
            // if there is no input, set the target speed to 0
            if (_input.move == Vector2.zero) targetSpeed = 0.0f;

        


            _speed = targetSpeed;



            // normalise input direction
            Vector3 inputDirection = new Vector3(_input.move.x, 0.0f, _input.move.y).normalized;

            // note: Vector2's != operator uses approximation so is not floating point error prone, and is cheaper than magnitude
            // if there is a move input rotate player when the player is moving
            if (_input.move != Vector2.zero)
            {
                _targetRotation = Mathf.Atan2(inputDirection.x, inputDirection.z) * Mathf.Rad2Deg +
                                  _mainCamera.transform.eulerAngles.y;
                float rotation = Mathf.SmoothDampAngle(transform.eulerAngles.y, _targetRotation, ref _rotationVelocity,
                    RotationSmoothTime);

                // rotate to face input direction relative to camera position
                transform.rotation = Quaternion.Euler(0.0f, rotation, 0.0f);
            }


            Vector3 targetDirection = Quaternion.Euler(0.0f, _targetRotation, 0.0f) * Vector3.forward;

            // move the player
            _controller.Move(targetDirection.normalized * (_speed * Time.deltaTime) +
                             new Vector3(0.0f, _verticalVelocity, 0.0f) * Time.deltaTime);

            if (Input.GetKeyDown(KeyCode.Space))
            {
                while (timer < 3.0f)
                {
                    timer += Time.fixedDeltaTime;
                    _controller.Move(targetDirection.normalized * (_speed * Time.deltaTime * 1.01f) +
                      new Vector3(0.0f, _verticalVelocity, 0.0f) * Time.deltaTime);
                }
                targetSpeed = MoveSpeed;
                timer = 0.0f;
            }
        }
        void gravedad()
        {
            //vector that points down and pulls the player using grounded from controller
            Vector3 gravityVector = new Vector3(0.0f, -1.0f, 0.0f);
            //if the player is grounded, the vertical velocity is 0
            if (_controller.isGrounded)
            {
                _verticalVelocity = 0.0f;
            }
            //if the player is not grounded, the vertical velocity is the gravity
            else
            {
                _verticalVelocity -= gravity * Time.deltaTime;
            }
            //move the player using the gravity vector
            _controller.Move(gravityVector * Time.deltaTime);
            
            


        }
    }

    
}

