using UnityEngine;
using UnityEngine.UI;

public class ButtonPanelController : MonoBehaviour
{
    public GameObject buttonPanel;
    public Button toggleButton;
    private bool isPanelVisible = false;

    private void Start()
    {
        // Asigna el método TogglePanel al evento de clic del botón de alternancia
        toggleButton.onClick.AddListener(TogglePanel);
        
        // Oculta el panel de botones al iniciar
        buttonPanel.SetActive(false);
    }

    private void TogglePanel()
    {
        // Cambia el estado del panel (visible u oculto) al hacer clic en el botón de alternancia
        isPanelVisible = !isPanelVisible;
        buttonPanel.SetActive(isPanelVisible);
        
        // Cambia el texto del botón de alternancia para reflejar el estado actual
        //toggleButton.GetComponentInChildren<Text>().text = isPanelVisible ? "Ocultar" : "Mostrar";
    }
}
