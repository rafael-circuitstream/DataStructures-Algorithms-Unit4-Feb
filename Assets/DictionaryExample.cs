using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DictionaryExample : MonoBehaviour
{
    public Dictionary<string, int> myDictionary = new Dictionary<string, int>();
    // Start is called before the first frame update
    void Start()
    {
        myDictionary.Add("Rafael", 23);
        myDictionary.Add("Pat", 83);
        myDictionary.Add("Robert", 55);
        myDictionary.Add("Josh", 42);
        
        if(myDictionary.ContainsKey("Rafael"))
        {
            myDictionary["Rafael"] = 100;
        }

        myDictionary.Remove("Rafael");

        Debug.Log(myDictionary.ContainsKey("Pat"));

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
