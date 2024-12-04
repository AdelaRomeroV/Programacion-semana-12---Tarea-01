using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Networking;
public class SelectAllUsuariosController : MonoBehaviour
{
    public void Execute(Action<UsuarioDataModel> OnResult)
    {
        StartCoroutine(SendRequest(OnResult));
    }
    IEnumerator SendRequest(Action<UsuarioDataModel> OnResult)
    {
        using (UnityWebRequest www = UnityWebRequest.Get("http://localhost/242progra/Semana13/Tarea/select_all_users.php"))
        {
            yield return www.SendWebRequest();
            if (www.result == UnityWebRequest.Result.ConnectionError ||
                www.result == UnityWebRequest.Result.ProtocolError)
            {
                Debug.Log("Error");
            }
            else
            {
                OnResult(JsonUtility.FromJson<UsuarioDataModel>(www.downloadHandler.text));
            }
        }
    }
}
