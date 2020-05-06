using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningCurve : MonoBehaviour
{
    // Integer variables
    public int currentAge = 30;
    public int addedAge = 1;

    // Start is called before the first frame update
    void Start()
    {
        ComputeAge();
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
}
