using UnityEngine.SceneManagement;
using UnityEngine;

public class ArrowLeft : MonoBehaviour
{
    public int NumScene;

    public void ToLocation()
    {
        SceneManager.LoadScene(NumScene);
    }
}
