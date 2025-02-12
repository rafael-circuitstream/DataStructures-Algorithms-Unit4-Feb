using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkillTreeNode : MonoBehaviour
{
    public Image skillImage;
    public SkillTreeNode childSkillA;
    public SkillTreeNode childSkillB;

    public void LoadChildrenNodeStatus()
    {
        if (skillImage.color == Color.red) return;

        if(skillImage.color == Color.green) //Is Unlocked
        {
            if(childSkillA) childSkillA.skillImage.color = Color.white;
            if (childSkillB) childSkillB.skillImage.color = Color.white;
        }
        else
        {
            if (childSkillA) childSkillA.skillImage.color = Color.red;
            if (childSkillB) childSkillB.skillImage.color = Color.red;
        }

        if (childSkillA)
            childSkillA.LoadChildrenNodeStatus();

        if(childSkillB)
            childSkillB.LoadChildrenNodeStatus();
    }

    public void Unlock()
    {
        if(skillImage.color == Color.white)
        {
            skillImage.color = Color.green;
        }
    }
}
