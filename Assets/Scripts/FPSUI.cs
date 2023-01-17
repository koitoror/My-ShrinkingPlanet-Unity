using UnityEngine;
using UnityEngine.UI;

public class FPSUI : MonoBehaviour
{
    public Text text;

    // Update is called once per frame
    void Update()
    {
        text.text = Application.targetFrameRate.ToString("FPS: #.#");
    }
}
