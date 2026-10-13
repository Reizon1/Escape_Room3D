using UnityEngine;

// Versión antigua del controlador de la puerta (antes de IInteractable).
public class OldDoorController : MonoBehaviour
{
    public bool isOpen;

    public void Open()
    {
        if (isOpen)
        {
            Debug.Log("La puerta ya estaba abierta.");
            return;
        }

        isOpen = true;
        Debug.Log("Puerta abierta (controlador antiguo).");
    }
}
