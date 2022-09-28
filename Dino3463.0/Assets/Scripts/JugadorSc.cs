using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JugadorSc : MonoBehaviour
{
    public float jumpForce;
    public float fallForce;
    public Rigidbody2D _rigidbody;
    public bool canJump;
    public Animator _animator;
    public BoxCollider2D _collider;

    void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
        _animator = GetComponent<Animator>();
        _collider = GetComponent<BoxCollider2D>();
        canJump = true;
    }

    void Update()
    {
        if ((Input.GetKeyDown(KeyCode.Space) | Input.GetKeyDown(KeyCode.UpArrow)) && canJump == true)
        {
            _rigidbody.AddForce(new Vector2(0f, jumpForce));
            _animator.SetBool("Jump", true);
            canJump = false;
        }

        if (Input.GetKey(KeyCode.DownArrow) && canJump == false)
        {
            _rigidbody.AddForce(new Vector2(0f, - fallForce * Time.deltaTime));
        }

        if (Input.GetKeyDown(KeyCode.DownArrow) && canJump == true)
        {
            _collider.enabled = false;
            _animator.SetBool("Crouch", true);
           // Debug.Log("Se agacha");
        }

        if (Input.GetKeyUp(KeyCode.DownArrow) && canJump == true)
        {
            _collider.enabled = true;
            _animator.SetBool("Crouch", false);
           // Debug.Log("Se paró");
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
       if (collision.gameObject.CompareTag("Piso"))
        {
            _animator.SetBool("Jump", false);
            canJump = true;
           // Debug.Log("Toco piso");
        }

        if (collision.gameObject.CompareTag("Obstaculo"))
        {
            Time.timeScale = 0;
           // Debug.Log("Toco obstaculo");
        }
    }
}
