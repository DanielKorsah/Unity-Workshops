using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{

    [SerializeField]
    private float movementSpeed, rotationSpeed, jumpForce;

    [SerializeField]
    GameObject projectile;

    Rigidbody rb;

    Camera myCamera;
    bool isJumping = false;

    public float currentHealth, maximumHealth;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
        myCamera = Camera.main;
    }
    // Use this for initialization
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;

        currentHealth = maximumHealth;
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetButtonDown("Jump") && !isJumping)
        {
            Jump();
        }

        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }

    void FixedUpdate()
    {
        //negate any accidental impulses
        rb.velocity = new Vector3(0, rb.velocity.y, 0);
        Movement();
    }

    void Movement()
    {
        Vector3 inputVelocity = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        inputVelocity = inputVelocity.normalized * movementSpeed * Time.deltaTime;

        rb.MovePosition(transform.position + (transform.forward * inputVelocity.z) + (transform.right * inputVelocity.x));

        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");

        float horizontalRotation = mouseX * rotationSpeed * Time.deltaTime;
        float verticalRotation = mouseY * rotationSpeed * Time.deltaTime;

        transform.Rotate(Vector3.up, horizontalRotation);
        myCamera.transform.rotation = myCamera.transform.rotation * Quaternion.Euler(new Vector3(-verticalRotation, 0, 0));
    }

    void Jump()
    {
        Vector3 v = Vector3.up * jumpForce;
        rb.velocity += v;
        isJumping = true;
    }

    void Shoot()
    {
        //spawn spawnDistance units in front of the camera
        float spawnDistance = 1.0f;
        Vector3 spawnPoint = myCamera.transform.position + myCamera.transform.forward * spawnDistance;

        Instantiate(projectile, spawnPoint, myCamera.transform.rotation);
    }

    void OnCollisionEnter(Collision col)
    {
        isJumping = false;

        if (col.gameObject.tag == "Enemy")
        {
            currentHealth -= 20;
            col.gameObject.GetComponent<Renderer>().material.color = Color.yellow;
        }

        if (col.gameObject.name.Contains("Enemy"))
        {
            currentHealth -= 20;
            col.gameObject.GetComponent<Renderer>().material.color = Color.magenta;
        }

    }

}