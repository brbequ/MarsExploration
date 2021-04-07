using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Solution
{
    // A space explorer's ship crashed on Mars! They send a series of SOS
    // messages to Earth for help. Letters in some of the SOS messages are
    // altered by cosmic radiation during transmission. Given the signal
    // received by Earth as a string, s, determine how many letters of the
    // SOS message have been changed by radiation.

    // Complete the marsExploration function below.
    static int marsExploration(string s)
    {
        const string expected = "SOS";

        int errors = 0;

        for(int idx = 0; idx < s.Length; idx++)
        {
            if (s[idx] != expected[idx % 3])
                errors++;
        }

        return errors;
    }

    static void Main(string[] args)
    {
        string s = "SOSSPSSQSSOR";

        int result = marsExploration(s);

        Console.WriteLine(result);
    }
}
