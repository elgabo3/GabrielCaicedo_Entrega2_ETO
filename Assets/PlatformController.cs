using UnityEngine;

public class PlatformController : MonoBehaviour
{
    public Animator platformAnimator;     // El componente Animator de la plataforma
    public string animationTrigger = "Activate"; // El nombre del trigger en la animación

    private void OnTriggerEnter2D(Collider2D other)
    {
        // Verifica si el objeto que se acerca es el objeto deseado (puedes usar tags, layers, etc. para identificarlo)
        if (other.CompareTag("Box")) // Cambia "Player" por la etiqueta correcta
        {
            // Activa la animación para que la plataforma comience a moverse
            platformAnimator.SetTrigger(animationTrigger);
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        // Verifica si el objeto que se aleja es el objeto deseado
        if (other.CompareTag("Box")) // Cambia "Player" por la etiqueta correcta
        {
            // Puedes detener la animación aquí si lo deseas, dependiendo de cómo quieras que funcione
            // platformAnimator.ResetTrigger(animationTrigger);
        }
    }
}
