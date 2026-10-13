using UnityEngine;

// Versión integrada (Caso 10):
// - De Feature_Puzzle: validación del código y desbloqueo del cofre (ChestController).
// - De Feature_Interaction: límite de intentos y estado "resuelto".
public class PuzzleManager : MonoBehaviour
{
    [SerializeField] private string correctCode = "1234";
    [SerializeField] private int maxAttempts = 3;
    [SerializeField] private ChestController chest;

    private int attempts;
    private bool solved;

    public bool ValidateCode(string code)
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

        if (code == correctCode)
        {
            solved = true;
            Debug.Log("Código correcto.");
            if (chest != null)
            {
                chest.Unlock();
            }
            return true;
        }

        Debug.Log("Código incorrecto. Intentos restantes: " + (maxAttempts - attempts));
        return false;
    }

    [ContextMenu("Probar código correcto")]
    private void TestCorrectCode()
    {
        ValidateCode(correctCode);
    }

    [ContextMenu("Probar código incorrecto")]
    private void TestWrongCode()
    {
        ValidateCode("0000");
    }
}
