using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [Header("Move Variables")]
    [SerializeField] private float _moveSpeed;
    [SerializeField] private bool _isMoving;
    [SerializeField] private Vector2 _input;

    [Header("Raycast Variables")]
    [SerializeField] private Vector3 _groundRaycastOffset;
    [SerializeField] private float _groundRaycastLength;

    [Header("Layers")]
    [SerializeField] private LayerMask _wallLayer;

    [Header("Object Collision")]
    [SerializeField] private bool _objectUnder;
    [SerializeField] private bool _objectLeft;
    [SerializeField] private bool _objectRight;
    [SerializeField] private bool _objectAbove;

    [Header("Can Move Vars")]
    [SerializeField] private bool _canMoveDown;
    [SerializeField] private bool _canMoveLeft;
    [SerializeField] private bool _canMoveRight;
    [SerializeField] private bool _canMoveUp;

    private void Update()
    {
        if(!_isMoving)
        {
            _input.x = Input.GetAxisRaw("Horizontal");
            _input.y = Input.GetAxisRaw("Vertical");

            if (_input.x != 0) _input.y = 0;

            if (_objectAbove)
            {
                _canMoveUp = false;
            }
            else _canMoveUp = true;

            if (_objectUnder)
            {
                _canMoveDown = false;
            }
            else _canMoveDown = true;

            if (_objectRight)
            {
                _canMoveRight = false;
            }
            else _canMoveRight = true;

            if (_objectLeft)
            {
                _canMoveLeft = false;
            }
            else _canMoveLeft = true;
            

            if (_input != Vector2.zero)
            {
                var targetPos = transform.position;
                targetPos.x += _input.x;
                targetPos.y += _input.y;




                StartCoroutine(Move(targetPos));
            }
        }


    }

    private void FixedUpdate()
    {
        CheckWallCollision();
    }

    IEnumerator Move(Vector3 targetPos)
    {
        _isMoving = true;

        while((targetPos - transform.position).sqrMagnitude > Mathf.Epsilon)
        {
            transform.position = Vector3.MoveTowards(transform.position, targetPos, _moveSpeed * Time.deltaTime);
            yield return null;
        }
        transform.position = targetPos;

        _isMoving = false;
    }

    private void CheckWallCollision()
    {
        _objectUnder = Physics2D.Raycast(transform.position + _groundRaycastOffset, Vector2.down, _groundRaycastLength, _wallLayer) ||
                       Physics2D.Raycast(transform.position - _groundRaycastOffset, Vector2.down, _groundRaycastLength, _wallLayer);

        _objectLeft = Physics2D.Raycast(transform.position + _groundRaycastOffset, Vector2.left, _groundRaycastLength, _wallLayer) ||
                       Physics2D.Raycast(transform.position - _groundRaycastOffset, Vector2.left, _groundRaycastLength, _wallLayer);

        _objectRight = Physics2D.Raycast(transform.position + _groundRaycastOffset, Vector2.right, _groundRaycastLength, _wallLayer) ||
                       Physics2D.Raycast(transform.position - _groundRaycastOffset, Vector2.right, _groundRaycastLength, _wallLayer);

        _objectAbove = Physics2D.Raycast(transform.position + _groundRaycastOffset, Vector2.up, _groundRaycastLength, _wallLayer) ||
                       Physics2D.Raycast(transform.position - _groundRaycastOffset, Vector2.up, _groundRaycastLength, _wallLayer);
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawLine(transform.position, transform.position + Vector3.down * _groundRaycastLength);
        Gizmos.DrawLine(transform.position, transform.position + Vector3.left * _groundRaycastLength);
        Gizmos.DrawLine(transform.position, transform.position + Vector3.right * _groundRaycastLength);
        Gizmos.DrawLine(transform.position, transform.position + Vector3.up * _groundRaycastLength);
    }
}
