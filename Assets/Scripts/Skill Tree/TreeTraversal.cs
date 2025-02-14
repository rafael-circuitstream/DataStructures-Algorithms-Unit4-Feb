using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeTraversal : MonoBehaviour
{
    [SerializeField] private SkillTreeNode root;
    Stack<SkillTreeNode> queueOfPath = new Stack<SkillTreeNode>();
    // Start is called before the first frame update
    void Start()
    {
        root.skillImage.color = Color.green;
        //root.LoadChildrenNodeStatus();

        SkillTreeNode nextPath = root;
        SkillTreeNode tempA = root.childSkillA;
        SkillTreeNode tempB = root.childSkillB;

        while(tempA != null || tempB != null)
        {
            Debug.Log(tempA.gameObject.name);
            Debug.Log(tempB.gameObject.name);

            queueOfPath.Push(tempB);

            tempA = tempA.childSkillA;
            tempB = tempA.childSkillB;

        }

    }


    public void TraversalSkill()
    {

    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
