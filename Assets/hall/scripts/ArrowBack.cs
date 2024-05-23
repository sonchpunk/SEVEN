using UnityEngine;
using UnityEngine.SceneManagement;

public class ArrowBack : MonoBehaviour
{
    public int NumScene;

    public void ToLocation()
    {
        SceneManager.LoadScene(NumScene);
    }
}
