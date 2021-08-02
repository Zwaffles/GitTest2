using UnityEngine;

public class FizzBUS : MonoBehaviour
{
    void Start()
    {
        for(int i = 1; i<=100; i++)
        {
            string _fizzBuzz = "";

            if (i % 3 == 0) { _fizzBuzz += "fizz"; }

            if (i % 5 == 0) { _fizzBuzz += "buzz"; }

            if(_fizzBuzz == "") { _fizzBuzz = i.ToString(); }

            Debug.Log(_fizzBuzz+"\n");
        }
    }
}
