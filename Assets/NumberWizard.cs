using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    int max = 1000;
    int min = 1;
    int guess = 500;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hey dude. This is Number Wizard. ");
        Debug.Log("Are you smarter than a machine? Here's your chance to find out...");
        Debug.Log("I want you to pick a number, and I'll try to guess it.");
        Debug.Log("The highest number you can pick is " + max + ".");
        Debug.Log("The lowest number you can pick is " + min + ".");
        Debug.Log("Tell me if your number is higher or lower than " + guess);
        Debug.Log("Press UP arrow for higher, DOWN arrow for lower, and ENTER if the guess is correct.");
        max = max + 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Debug.Log("Higher, you say? OK then...");
            min = guess;
            guess = (max + min) / 2;
            Debug.Log("Is your number " + guess + "?");
        }

        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Debug.Log("Lower? Hmmm. OK...");
            max = guess;
            guess = (max + min) / 2;
            Debug.Log("Is your number " + guess + "?");
        }

        else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("OMG I AM SO FRICKIN' SMRT!!!! *happy dance*");
            Debug.Log("Your number is " + guess + "!");
        }

        else if (Input.anyKeyDown)
        {
            Debug.Log("What you talkin' bout, Willis?");
            Debug.Log("That key wasn't in the plan, doofus.");
            Debug.Log("Is your number " + guess + "?");
        }
    }
}
