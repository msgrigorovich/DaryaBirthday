using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Ball : MonoBehaviour
{
    public float maxBallSpeed = 50f;

    public float force = 1000f;
    public GameObject ballPrediction;

    private Vector2 startPostition;
    private Vector2 endPosition;

    private Rigidbody physics;

    void Awake()
    {
        physics = GetComponent<Rigidbody>();
    }
    void Start()
    {
        physics.isKinematic = true;
        gameObject.tag = "Player";
    }
    void Update()
    {
        physics.velocity = Vector3.ClampMagnitude(physics.velocity, maxBallSpeed);
        if (Input.GetMouseButtonDown(0))
        {
            startPostition = GetMousePosition();
        }
        if (Input.GetMouseButton(0))
        {
            Vector2 dragPosition = GetMousePosition();
            Vector2 power = startPostition - dragPosition;

        }
        if (Input.GetMouseButtonUp(0))
        {
            endPosition = GetMousePosition();

            Vector2 power = startPostition - endPosition;
            physics.isKinematic = false;

            physics.AddForce(power * force, ForceMode.Force);
        }
    }

    void FixedUpdate()
    {

    }

    private Vector2 GetMousePosition()
    {
        return Camera.main.ScreenToViewportPoint(Input.mousePosition);
    }
    private void OnTriggerEnter(Collider collision)
    {
        
    }
}
