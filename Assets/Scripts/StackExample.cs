using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StackExample : MonoBehaviour
{
    
    public Stack<int> myStack = new Stack<int>();
    public Queue<float> myQueue = new Queue<float>();

    // Start is called before the first frame update
    void Start()
    {

        List<int> exampleList = new List<int>();

        Debug.Log(exampleList[1]);
        exampleList.RemoveAt(1);
        exampleList.Add(1);


        #region STACK_EXAMPLE
        myStack.Push(10);
        myStack.Push(9);
        myStack.Push(8);
        
        Debug.Log(myStack.Peek()); //PRINTS: 8

        Debug.Log(myStack.Pop());   //PRINTS: 8
        #endregion

        #region QUEUE_EXAMPLE


        myQueue.Enqueue(5.2f);
        myQueue.Enqueue(10.5f);
        myQueue.Enqueue(2.4444f);

        Debug.Log(myQueue.Peek()); //PRINTS: 5.2f

        Debug.Log(myQueue.Dequeue()); //PRINTS: 5.2f

        Debug.Log(myQueue.Dequeue()); //PRINTS: 10.5f

        Debug.Log(myQueue.Peek()); //PRINTS: 2.444f

        #endregion

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
