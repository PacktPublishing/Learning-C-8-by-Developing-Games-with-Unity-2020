using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningCurve : MonoBehaviour
{
    // Integer variables
    private int currentAge = 30;
    public int addedAge = 1;

    // Float variables
    public float pi = 3.14f;

    // String variables
    public string firstName = "Harrison";

    // Boolean variables
    public bool isAuthor = true;

    // Start is called before the first frame update
    void Start()
    {
        ComputeAge();

        Debug.Log($"A string can have variables like {firstName} inserted directly!");

        //Debug.Log(firstName * pi);

        // Testing methods
        int characterLevel = 3;
        int nextSkillLevel = GenerateCharacter("Spike", characterLevel);
        Debug.LogFormat("Next skill at level {0}", nextSkillLevel);
    }

    // Update is called once per frame
    void Update()
    {

    }

    /// <summary>
    /// Computes a modified age integer
    /// </summary>
    void ComputeAge()
    {
        Debug.Log(currentAge + addedAge);
    }

    // Generates and returns a character with a name and level
    public int GenerateCharacter(string name, int level)
    {
        Debug.LogFormat("Character: {0} - Level: {1}", name, level);
        return level + 5;
    }
}
