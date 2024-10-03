using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class VariablesAndFunctions : MonoBehaviour
{
    //Create a variable of type integer
    int myInt = 7;


    // Start is called before the first frame update
    void Start()
    {
        //I am going to run myInt thru my function to multiply it by two
        myInt = MultiplybyTwo(myInt);

        //I'm going to print the resultd to the console
        Debug.Log(myInt);
    }

    // Update is called once per frame
    void Update()
    {

    }
    //Creating a function that takes a int and parameter and multiplies it by 2
    int MultiplybyTwo(int number)
    {
        //creating a variable to store my results
        int results;
        //multiplying the passed parameter by 2
        results = number * 2;

        //Returning the results
        return results;

    }
}