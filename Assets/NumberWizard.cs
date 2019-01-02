using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    private int _max;
    private int _min;
    private int _guess;

    // Start is called before the first frame update
    private void Start()
    {
        StartGame();
    }

    void StartGame()
    {
        _max = 1000;
        _min = 1;
        CalculateGuess();

        Debug.Log("Welcome to number wizard, yo");
        Debug.Log("Pick a number, don't tell me what it is...");
        Debug.Log("Highest number is: " + _max);
        Debug.Log("Lowest number is: " + _min);
        Debug.Log("Tell me if your number is higher or lower than " + _guess);
        Debug.Log("Push Up = higher, Push Down = lower, Push Enter = Correct");
    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Debug.Log("Up pressed!");
            _min = _guess;
            CalculateGuess();
            Debug.Log(_guess);
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Debug.Log("Down pressed!");
            _max = _guess;
            CalculateGuess();
            Debug.Log(_guess);
        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("Enter pressed!");
            Debug.Log("The number is " + _guess);
        }
        else if (Input.GetKeyDown(KeyCode.Escape))
        {
            Debug.Log("Reset!");
            StartGame();
        }
    }

    private void CalculateGuess()
    {
        int sum = _min + _max;
        _guess = sum < 1999 ? sum / 2 : 1000;
    }
}