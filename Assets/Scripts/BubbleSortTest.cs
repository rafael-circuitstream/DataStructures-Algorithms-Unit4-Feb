using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BubbleSortTest : MonoBehaviour
{
    public int[] sortedArray;


    // Start is called before the first frame update
    IEnumerator Start()
    {
        int N = sortedArray.Length;
        int sortedElements = 0;

        while (sortedElements < N)
        {
            int currentElement = 0;

            while(currentElement <= N - 2 - sortedElements) //
            {
                if(sortedArray[currentElement] > sortedArray[currentElement + 1])
                {
                    //SwitchBothElements();
                    int tempVariable = sortedArray[currentElement];
                    sortedArray[currentElement] = sortedArray[currentElement + 1];
                    sortedArray[currentElement + 1] = tempVariable;

                    Debug.Log("Switched numbers");

                }
                
                yield return new WaitForSeconds(0.2f);

                currentElement += 1;
            }
            Debug.Log("sorted one more number");
            sortedElements += 1;
        }

        Debug.Log("Finished Sorting");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
