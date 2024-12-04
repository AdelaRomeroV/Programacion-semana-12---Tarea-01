using TMPro;
using UnityEngine;
public class DataDump : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI dataText;
    public void SetText(string data)
    {
        dataText.text = data;
    }
}
