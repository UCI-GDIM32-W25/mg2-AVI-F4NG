using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    [SerializeField] private float _jump = 5.0f;
    [SerializeField] private TextUpdater _textUpdater;
    private CapsuleCollider2D _collider;
    private Rigidbody2D _rb;
    private int _points;
    private bool _isGrounded;
    // Start is called before the first frame update
    void Start()
    {
        _collider= GetComponent<CapsuleCollider2D>();
        _rb = GetComponent<Rigidbody2D>();
        _points = 0;
        _textUpdater.UpdateText(_points);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && _isGrounded)
        {
            _rb.velocity = new Vector2(_rb.velocity.x, _jump);
            _isGrounded = false;
        }
        _textUpdater.UpdateText(_points);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Ground"))
        {
            _isGrounded = true;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<CapsuleCollider2D>().CompareTag("Coin"))
        {
            _points += 1;
        }
    }
}
