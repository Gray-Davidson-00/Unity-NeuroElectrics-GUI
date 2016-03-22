﻿using UnityEngine;
using System.Collections;

public class Lr_IntegerVariable : MonoBehaviour {
    public int IntegerVariable = 1;
    public int ScaleFactor = 1;
    // Corresponding IntegerVaribles whenever a different button is clicked 

    // Important: The series in which electrode names have been assigned corresponds to the sequence of IntegerVariable for easy functioning of the GUI.

    public void ButtonP7Clicked()
    {
        IntegerVariable = 1;
    }

    public void ButtonCZClicked()
    {
        IntegerVariable = 2;
    }

    public void ButtonPZClicked()
    {
        IntegerVariable = 3;
    }
    public void ButtonPOZClicked()
    {
        IntegerVariable = 4;
    }
    public void ButtonP8Clicked()
    {
        IntegerVariable = 5;
    }
    public void ButtonPO7Clicked()
    {
        IntegerVariable = 6;
    }
    public void ButtonPO8Clicked()
    {
        IntegerVariable = 7;
    }
    public void ButtonC4Clicked()
    {
        IntegerVariable = 8;
    }
    public void ButtonF6Clicked()
    {
        IntegerVariable = 9;
    }
    public void ButtonFP2Clicked()
    {
        IntegerVariable = 10;
    }
    public void ButtonFZClicked()
    {
        IntegerVariable = 11;
    }
    public void ButtonC3Clicked()
    {
        IntegerVariable = 12;
    }
    public void ButtonF5Clicked()
    {
        IntegerVariable = 13;
    }
    public void ButtonFP1Clicked()
    {
        IntegerVariable = 14;
    }
    public void ButtonAFZClicked()
    {
        IntegerVariable = 15;
    }
    public void ButtonE1Clicked()
    {
        IntegerVariable = 16;
    }
    public void ButtonE2Clicked()
    {
        IntegerVariable = 17;
    }
    public void ButtonE3Clicked()
    {
        IntegerVariable = 18;
    }
    public void ButtonE4Clicked()
    {
        IntegerVariable = 19;
    }
    public void ButtonE5Clicked()
    {
        IntegerVariable = 20;
    }

    public void ArrowUpClicked() // Function attached to ArrowUp button: the IntegerVariable value decreases by 1 and from the LineRenderer Script the previous Renderer in series gets higHlighted with the corresponfing electrodes
    {
        if(IntegerVariable<21 && IntegerVariable > 1)
        {
            IntegerVariable = IntegerVariable - 1;
        }
    
    }
    public void ArrowDownClicked() // Function attached to ArrowDown button: The next renderer in series gets highlighted with corresponding electrode
    {
        if(IntegerVariable>0 && IntegerVariable < 20)
        {
            IntegerVariable = IntegerVariable + 1;
        }
    }


    public void ScaleUpClicked() // Function attached to ArrowUp button: the IntegerVariable value decreases by 1 and from the LineRenderer Script the previous Renderer in series gets higHlighted with the corresponfing electrodes
    {
        if (ScaleFactor < 21 && ScaleFactor > 1)
        {
            ScaleFactor = ScaleFactor - 1;
        }

    }
    public void ScaleDownClicked() // Function attached to ArrowDown button: The next renderer in series gets highlighted with corresponding electrode
    {
        if (ScaleFactor > 0 && ScaleFactor < 20)
        {
            ScaleFactor = ScaleFactor + 1;
        }
    }


}


