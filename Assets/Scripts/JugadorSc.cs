using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JugadorSc : MonoBehaviour
{
    public float jumpForce;
    public float fallForce;
    private Rigidbody2D _rigidbody;
    private bool canJump;
    private Animator _animator;
    private BoxCollider2D _collider;
    public GameObject textoGameOver;
    public GameObject textoScoreGameOver;
    public GameObject textoScore;
    public GameObject botonRestart;
    public GameObject botonExit;

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
            _animator.SetBool("Crouch", false);
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
        }

        if (Input.GetKeyUp(KeyCode.DownArrow) && canJump == true)
        {
            _collider.enabled = true;
            _animator.SetBool("Crouch", false);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
       if (collision.gameObject.CompareTag("Piso"))
        {
            _animator.SetBool("Jump", false);
            canJump = true;
        }

        if (collision.gameObject.CompareTag("Obstaculo"))
        {
          
            Time.timeScale = 0;
           textoGameOver.active = true;
           textoScoreGameOver.active = true;
           textoScore.active = false;
            botonRestart.active = true;
            botonExit.active = true;
        }
    }
}
