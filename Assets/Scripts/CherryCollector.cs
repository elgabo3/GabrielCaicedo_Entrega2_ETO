using UnityEngine;
using TMPro;

public class CherryCollector : MonoBehaviour
{
    private int collectedCherries = 0;
    public int targetCherries = 10;
    public TextMeshProUGUI textoPuntaje;

    public int CollectedCherries
    {
        get { return collectedCherries; }
    }

    public int TargetCherries
    {
        get { return targetCherries; }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("cherry"))
        {
            Destroy(other.gameObject);
            collectedCherries++;
            UpdateUI();
            Debug.Log("Objeto recolectado");

            
            if (collectedCherries >= targetCherries)
            {
                // Aquí puedes agregar lógica para manejar la victoria
            }
        }
    }

    private void UpdateUI()
    {
        textoPuntaje.text = "Objetos: " + collectedCherries + "/" + targetCherries;
    }

    public void ResetCollectedCherries()
    {
    collectedCherries = 0;
    UpdateUI();
    }
}
