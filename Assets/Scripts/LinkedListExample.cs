using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LinkedListExample : MonoBehaviour
{
    
    //public string example;
    //public char[] stringCharacters;
    //public char character;

    
    public LinkedList<char> alphabet = new LinkedList<char>();
    // Start is called before the first frame update
    void Start()
    {
        alphabet.AddLast('a');
        alphabet.AddLast('b');
        alphabet.AddLast('c');

        Debug.Log(alphabet.First.Value);
        Debug.Log(alphabet.First.Next.Value);
        Debug.Log(alphabet.First.Next.Previous.Value);
        Debug.Log(alphabet.First.Next.Next.Value);

        alphabet.AddAfter(alphabet.First.Next, 'i');
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
