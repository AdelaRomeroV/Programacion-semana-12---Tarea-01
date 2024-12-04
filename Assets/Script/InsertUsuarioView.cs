using TMPro;
using UnityEngine;
using UnityEngine.UI;
public class InsertAllUsuariosView : MonoBehaviour
{
    [SerializeField] private TMP_InputField usernameInputField;
    [SerializeField] private TMP_InputField lastscoreInputField;
    [SerializeField] private Button executeButton;
    private InsertUsuarioController iUC;
    private SelectAllUsuariosView sAUV;
    private void Awake()
    {
        iUC = GetComponent<InsertUsuarioController>();
        sAUV = GetComponent<SelectAllUsuariosView>();
        executeButton.onClick.AddListener(Execute);
    }
    private void Execute()
    {
        iUC.Execute(usernameInputField.text, lastscoreInputField.text, OnResult);
    }
    private void OnResult(MessageModel message)
    {
        if (message.message == "success")
        {
            sAUV.Execute();
        }
        else
        {
        }
    }
}
