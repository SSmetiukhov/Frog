
using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerScript : MonoBehaviour
{

    public float power = 6f;
    public float horizontalMultiplier= 1.5f;
    private float _horizontalVelocity = 0f;
    public float jumpActivation = 0.3f;
    private float _lastJump;

    private bool _isJumping = false;
    private bool _isGrounded = true;
    public LayerMask whatIsGround;
    public Transform feetPos;
    public float checkRadius = 0.1f;

    public Rigidbody2D rb;

    public GameObject shadow;
    
    private Camera _cam;
    
    void Start()
    {
        _cam = Camera.main;
        rb = GetComponent<Rigidbody2D>();
        shadow.SetActive(false);
    }

    

    private void Update()
    {
        _isGrounded = Physics2D.OverlapCircle(feetPos.position, checkRadius, whatIsGround);
        if (_isGrounded && Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = Vector2.up * power * 2;
            shadow.SetActive(true);
            _isJumping = true;
            _lastJump = jumpActivation;
        }

        if (Input.GetKey(KeyCode.Space) && _isJumping)
        {
            if (_lastJump > 0)
            {
                rb.velocity = Vector2.up * power;
                _lastJump -= Time.deltaTime;
            }
        }
        else
        {
            shadow.SetActive(false);
            _isJumping = false;
        }

        if (Input.GetKeyUp(KeyCode.Space))
        {
            _isJumping = false;
        }
    }
    private void FixedUpdate()
    {
        _horizontalVelocity = Input.GetAxis("Horizontal") * horizontalMultiplier;
        rb.velocity = new Vector2(_horizontalVelocity, rb.velocity.y);
    }

    public void OnCollisionEnter2D(Collision2D other)
    {
        if (other.collider.name == "DeadZone")
        {
            ScoreDisplay.RemoveScore();

            SceneManager.LoadScene(1);
        }
    }
    
    
}
