using System;
using System.Diagnostics;

class Checker
{
    static bool bpmIsOk(float bpm){
        if(bpm < 70 || bpm > 150) {
            return false;
        }
        return true;
    }
    static bool spo2IsOk(float spo2){
        if(spo2 < 90) {
            return false;
        }
        return true;
    }
    static bool respRate2IsOk(float respRate){
        if(respRate < 30 || respRate > 95) {
            return false;
        }
        return true;
    }
    static bool vitalsAreOk(float bpm, float spo2, float respRate) {
        if(!bpmIsOk(bpm) || !spo2IsOk(spo2) || !respRateIsOk(respRate)) {
            return false;
        } 
        return true;
    }
    static void ExpectTrue(bool expression) {
        if(!expression) {
            Console.WriteLine("Expected true, but got false");
            Environment.Exit(1);
        }
    }
    static void ExpectFalse(bool expression) {
        if(expression) {
            Console.WriteLine("Expected false, but got true");
            Environment.Exit(1);
        }
    }
    static int Main() {
        ExpectTrue(vitalsAreOk(100, 95, 60));
        ExpectFalse(vitalsAreOk(40, 91, 92));
        Console.WriteLine("All ok");
        return 0;
    }
}
