using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayExample : MonoBehaviour
{

    #region ARRAYS
    public int movement = 100;
    public int[] arrayOfNumbers = { 2, 5, 6, 7 };


    private int[,] gridOfNumbers = new int[5, 5];
    private int[,,] cubeOfNumbers = new int[10, 10, 10];
    // Start is called before the first frame update
    

    void DebugTheSecretSpecialNumber()
    {
        Debug.Log(arrayOfNumbers[5]);
    }

    float x = 0;
    float y = 0;
    float z = 0;

    // [ ] [2] [ ] [ ] [ ]
    // [ ] [ ] [ ] [ ] [ ]
    // [ ] [ ] [ ] [ ] [ ]
    // [ ] [ ] [ ] [ ] [ ]
    // [10] [ ] [ ] [ ] [ ]
    #endregion


    public List<string> cityNames = new List<string>(10);
    void Start()
    {
        
        #region ARRAY_IMPLEMENTATION
        int[] tempArray = arrayOfNumbers;
        arrayOfNumbers = new int[5];

        arrayOfNumbers[0] = tempArray[0]; //Number 2 in here
        arrayOfNumbers[1] = tempArray[1]; //Number 5 in here
        arrayOfNumbers[2] = 8; //new element
        arrayOfNumbers[3] = tempArray[2]; //number 6

        arrayOfNumbers[4] = tempArray[3]; //number 7


        gridOfNumbers[2, 5] = 2;
        gridOfNumbers[0, 0] = 10;
        gridOfNumbers[2, 0] = 10;

        /*
        foreach(int number in arrayOfNumbers)
        {
            if(number == 5)
            {
                Debug.Log("We found the 5");

            }
        }
        */
        #endregion

        #region LIST_IMPLEMENTATION
        cityNames.Add("Toronto");
        cityNames.Add("Vancouver");
        cityNames.Add("A");
        cityNames.Add("B");
        cityNames.Add("C");
        cityNames.Add("New York");
        cityNames.Add("New York");
        cityNames.Add("New York");
        cityNames.Add("New York");
        cityNames.Add("New York");
        cityNames.Add("New York");
        cityNames.Add("New York");
        


        cityNames.Remove("Toronto");

        cityNames.RemoveAt(1);

        cityNames.RemoveAll(x => x.Contains("o"));
        List<string> tempList = cityNames.FindAll(x => x.Contains("o"));


        #endregion

        int[] newArray = { 0, 0, 0, 0, 0 };

        newArray[0] = 0;
        newArray[1] = 1;
        newArray[2] = 1;
        newArray[3] = 1;
        newArray[4] = 1;

        int[] newLongerArray = new int[newArray.Length + 1];

        newLongerArray[0] = newArray[0];
        newLongerArray[1] = newArray[1];
        newLongerArray[2] = newArray[2];
        newLongerArray[3] = newArray[3];
        newLongerArray[4] = newArray[4];

        newLongerArray[5] = 1;

        newArray = newLongerArray;


    }


}


