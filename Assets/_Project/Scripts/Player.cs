using UnityEngine;

namespace DragonspiritGames.ActionRPG
{
    public class Player : MonoBehaviour
    {
        [SerializeField] float _speed = 5f;
        [SerializeField] float _jumpStrength = 3f;

        float _horizontalInput;
        Rigidbody2D _rigidbody;

        void Awake()
        {
            _rigidbody = GetComponent<Rigidbody2D>();
        }

        void Update()
        {
            _horizontalInput = Input.GetAxisRaw("Horizontal");
            _rigidbody.velocity = new Vector2(_horizontalInput * _speed, _rigidbody.velocity.y);
            if (Input.GetKeyDown(KeyCode.Space)) 
            {
                _rigidbody.velocity = new Vector2(_rigidbody.velocity.x, _jumpStrength);
            }
        }
    }
}
