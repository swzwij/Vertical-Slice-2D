using System;
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

    [Header("Can Move Vars")]
    [SerializeField] private bool _canMoveDown;
    [SerializeField] private bool _canMoveLeft;
    [SerializeField] private bool _canMoveRight;
    [SerializeField] private bool _canMoveUp;
    
    private static Vector3? _position;

    [Header("Facing direction")]
    [SerializeField] private bool _isFacingDown;
    [SerializeField] private bool _isFacingLeft;
    [SerializeField] private bool _isFacingRight;
    [SerializeField] private bool _isFacingUp;

    // x -1 = left
    //x 1 = right
    //y -1 = down
    //y 1 = up

    private void Awake()
    {
        // Als de static position nog geen value heeft kunnen we het negeren.
        if (!_position.HasValue) return;

        transform.position = (Vector3) _position;
    }

    private void Update()
    {
        CheckWallCollision();

        if (!_isMoving)
        { 
            _input.x = Input.GetAxisRaw("Horizontal");
            _input.y = Input.GetAxisRaw("Vertical");

            if (_input.x != 0) _input.y = 0;

            if (_input != Vector2.zero)
            {
                var targetPos = transform.position;

                if (_input.x == -1 && _canMoveLeft || _input.x == 1 && _canMoveRight) _input.x = 0;
                else targetPos.x += _input.x;

                if (_input.y == -1 && _canMoveDown || _input.y == 1 && _canMoveUp) _input.y = 0;
                else targetPos.y += _input.y;

                if (_input.x == 1) _isFacingRight = true;
                else _isFacingRight = false;

                if (_input.x == -1) _isFacingLeft = true;
                else _isFacingLeft = false;

                if (_input.y == 1) _isFacingUp = true;
                else _isFacingUp = false;

                if (_input.y == -1) _isFacingDown = true;
                else _isFacingDown = false;

                StartCoroutine(Move(targetPos));
            }
        }
    }

    IEnumerator Move(Vector3 targetPos)
    {
        _isMoving = true;

        while ((targetPos - transform.position).sqrMagnitude > Mathf.Epsilon)
        {
            transform.position = Vector3.MoveTowards(transform.position, targetPos, _moveSpeed * Time.deltaTime);
            yield return null;
        }
        transform.position = targetPos;
        _position = transform.position;

        _isMoving = false;
    }

    private void CheckWallCollision()
    {
        _canMoveDown = Physics2D.Raycast(transform.position + _groundRaycastOffset, Vector2.down, _groundRaycastLength, _wallLayer) ||
                       Physics2D.Raycast(transform.position - _groundRaycastOffset, Vector2.down, _groundRaycastLength, _wallLayer);

        _canMoveLeft = Physics2D.Raycast(transform.position + _groundRaycastOffset, Vector2.left, _groundRaycastLength, _wallLayer) ||
                       Physics2D.Raycast(transform.position - _groundRaycastOffset, Vector2.left, _groundRaycastLength, _wallLayer);

        _canMoveRight = Physics2D.Raycast(transform.position + _groundRaycastOffset, Vector2.right, _groundRaycastLength, _wallLayer) ||
                        Physics2D.Raycast(transform.position - _groundRaycastOffset, Vector2.right, _groundRaycastLength, _wallLayer);

        _canMoveUp = Physics2D.Raycast(transform.position + _groundRaycastOffset, Vector2.up, _groundRaycastLength, _wallLayer) ||
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
