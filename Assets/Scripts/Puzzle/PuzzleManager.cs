using UnityEngine;

public class PuzzleManager : MonoBehaviour
{
    [SerializeField] private string secretCode = "1234";
    [SerializeField] private int maxAttempts = 3;

    private int attempts;
    private bool solved;

    public bool TrySolve(string input)
    {
        if (solved)
        {
            Debug.Log("El puzzle ya fue resuelto.");
            return true;
        }

        if (attempts >= maxAttempts)
        {
            Debug.Log("Sin intentos disponibles.");
            return false;
        }

        attempts++;

        if (input == secretCode)
        {
            solved = true;
            Debug.Log("Puzzle resuelto.");
            return true;
        }

        Debug.Log("Código incorrecto. Intentos restantes: " + (maxAttempts - attempts));
        return false;
    }
}
