using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class SequenceOrder : MonoBehaviour
{
    public Rigidbody rigidbody;
    Renderer myRenderer;
    SpriteRenderer sprite;
    public UnityEvent myEvent;
    private void Awake()
    {
        rigidbody = GetComponent<Rigidbody>();
        myRenderer = GetComponent<Renderer>();
        sprite = GetComponent<SpriteRenderer>();
        myEvent = new UnityEvent();
    }

    // Start is called before the first frame update
    void Start()
    {

        Debug.Log("Test");
        Debug.Log("1");
        Debug.Log("2");
        MyMethodExample();
        Debug.Log("3...");
        Debug.Log("Starting...");
    }

    void MyMethodExample()
    {
        Debug.Log("Command 1");
        Debug.Log("Command 2");
        AnotherMethod();
        Debug.Log("Command 3");
        Debug.Log("Command 4");
    }

    void AnotherMethod()
    {
        Debug.Log("Red");
        Debug.Log("green");
        Debug.Log("Blue");
    }
}
