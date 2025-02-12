using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeTraversal : MonoBehaviour
{
    [SerializeField] private SkillTreeNode root;

    // Start is called before the first frame update
    void Start()
    {
        root.skillImage.color = Color.green;
        root.LoadChildrenNodeStatus();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
