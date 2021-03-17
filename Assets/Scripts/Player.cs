using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Rigidbody))]
public class Player : MonoBehaviour
{
    Rigidbody rb;
    Animator anim;
    [SerializeField] bool useKeyBoard = true;

    [SerializeField] float playerSpeed = 30f;
    public GameObject particleSystem;
    public GameObject gameOverState;
    public LayerMask whatIsGround;
    public Transform contactPoint;
    public int scorePerCube = 50;
    public int scorePerMovement = 1;

    Vector3 dir;
    bool isDead;
    bool isPlaying = false;
    LevelManager levelManager;
    ScoreHolder scoreHolder;


    void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
        //rb.velocity = Vector3.forward * 1000;
        anim.SetBool("run", true);
        anim.SetBool("fall", false);

        isDead = false;
        dir = Vector3.forward;
        levelManager = FindObjectOfType<LevelManager>();
        scoreHolder = FindObjectOfType<ScoreHolder>();

        //  startYPosition = transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        if (useKeyBoard)
            keyBoardInput();
        else
            Movement();

        GameOver();
    }

    void keyBoardInput()
    {
        isPlaying = true;
        if (rb.transform.position.x < -1f)
        {
            dir = Vector3.left;

        }
        else if (rb.transform.position.x  > 0.00001f)
        {
            dir = Vector3.forward;
        }
        
    }

    private void Movement()
    {
        if (Input.GetMouseButtonDown(0) && !isDead)
        {
            isPlaying = true;

            if (dir == Vector3.forward)
            {
                dir = Vector3.left;
            }
            else
            {
                dir = Vector3.forward;
            }

        }
        //float amountToMove = playerSpeed * Time.deltaTime;
        //transform.Translate(dir * amountToMove);
    }

    private void FixedUpdate()
    {
        if (!isDead)
        {
            if (dir == Vector3.left)
                transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(Vector3.down * 90), .2f);
            else
                transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.identity, .2f);
            Vector3 vel = Vector3.up * rb.velocity.y + dir * playerSpeed * Time.fixedDeltaTime;
            rb.velocity = vel;
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Pickup"))
        {
            other.gameObject.SetActive(false);
            Instantiate(particleSystem, other.transform.position + Vector3.up * .1f, Quaternion.identity);
            scoreHolder.AddToScore(scorePerCube);
        }
    }

    
    private void GameOver()
    {
        if (isFalling() && !isDead)
        {
            isDead = true;

            if (anim.GetBool("fall") == false)
            {
                anim.SetBool("fall", true);
                rb.constraints = RigidbodyConstraints.None;
            }

            gameOverState.SetActive(true);
            scoreHolder.GameOver();
        }
    }

    bool isFalling()
    {
        bool result = false;

        if (!Physics.Raycast(transform.position + Vector3.up, Vector3.down, 5, whatIsGround))
        {
            result = true;
        }

        return result;
    }
}
