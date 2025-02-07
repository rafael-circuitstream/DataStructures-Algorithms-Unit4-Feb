using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InClassActivity : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(IsPrimeNumber(1));
        Debug.Log(IsPrimeNumber(2));
        Debug.Log(IsPrimeNumber(50));
        Debug.Log(IsPrimeNumber(12));
        Debug.Log(IsPrimeNumber(13));
        
    }


    
    // 2 pow 2 = 4
    // 2 pow 5 = 32
    // 2 pow 10 = 2x 2x 2x 2x 2x 2x 2x

    int PowerOf(int number, int power)
    {
        int value = number;
        for(int i = 1; i < power; i++)
        {
            value = value * number;
        }

        return value;
    }



    public bool IsPrimeNumber(int number)
    {
        int amountOfDivisibles = 0;

        for(int i = 1; i <= number; i++)
        {
            if(number % i == 0)
            {
                amountOfDivisibles++;
            }
        }

        if(amountOfDivisibles == 2 || number == 1)
        {
            Debug.Log("Prime number");
            return true;
        }
        else
        {
            Debug.Log("Not prime");
            return false;
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
