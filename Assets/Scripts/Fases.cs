using UnityEngine;
using UnityEngine.SceneManagement;

public class Fases : MonoBehaviour
{
   public void Iniciar_Cena(string cena)
    {
        SceneManager.LoadScene(cena);
    }
   
}
