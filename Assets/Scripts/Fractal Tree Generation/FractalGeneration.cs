using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FractalGeneration : MonoBehaviour
{
    [SerializeField] private GameObject branchPrefab;
    [SerializeField] private int amountOfBranches;
    [SerializeField] private float angleToIncrease = 30;
    [SerializeField] private float distanceOffset = 1;
    [SerializeField] private float sizeDecreaseMultiplier = 0.9f;

    [SerializeField] private float minimumSizeOfBranch = 0.1f;
    void Start()
    {
        GenerateTree(gameObject, 0, Vector3.zero); 
    }
    public void GenerateTree(GameObject currentBranch, int branchCounter, Vector3 eulerangleToRotate)
    {
        if(currentBranch.transform.localScale.x <= minimumSizeOfBranch)
        {
            return;
        }

        Vector3 branchPosition = currentBranch.transform.position;
        if(branchCounter != 0)
        {
            branchPosition += currentBranch.transform.up * distanceOffset * currentBranch.transform.localScale.x;
        }

        GameObject newBranch = Instantiate(branchPrefab, branchPosition, Quaternion.identity);

        //Apply rotation
        newBranch.transform.Rotate(eulerangleToRotate);

        newBranch.transform.localScale = currentBranch.transform.localScale * sizeDecreaseMultiplier;

        //Euler rotation (angles) of the next branch
        //Vector3 anglesInVector3 = newBranch.transform.eulerAngles + new Vector3(angleToRotateBranch, 0, 0);

        GenerateTree(newBranch, branchCounter + 1, (Vector3.right) * angleToIncrease);
        GenerateTree(newBranch, branchCounter + 1, (Vector3.left) * angleToIncrease);
        GenerateTree(newBranch, branchCounter + 1, Vector3.forward * angleToIncrease);
        //GenerateTree(newBranch, branchCounter + 1, Vector3.forward * angleToIncrease);
        //GenerateTree(newBranch, branchCounter + 1, Vector3.back * angleToIncrease);

        //GenerateTree(newBranch, branchCounter + 1, +Random.Range(angleToRotateBranch - (5 *  branchCounter), angleToRotateBranch + (5 * branchCounter)));
        //GenerateTree(newBranch, branchCounter + 1, -Random.Range(angleToRotateBranch - (5 * branchCounter), angleToRotateBranch + (5 * branchCounter)));
    }
}
