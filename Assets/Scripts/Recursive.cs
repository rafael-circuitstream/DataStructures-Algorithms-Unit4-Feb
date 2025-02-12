using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Recursive : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //DecreaseNumber(20);
        FactorialOf(27);
    }


    void DecreaseNumber(int numberToDecrease)
    {
        Debug.Log(numberToDecrease);

        if (numberToDecrease <= 0)
        {
            return;
        }

        DecreaseNumber(numberToDecrease--);
    }

    //n! = n * (n - 1)!
    int FactorialOf(int number)
    {
        if(number == 1 || number == 0)
        {
            return 1;
        }

        return number * FactorialOf(number - 1);
    }
}
