using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;
using System.Collections;

public class basicMain : MonoBehaviour
{
    public Button Hello;
    public string host;
    public string port;
    public string route;            //라우트 주소

    public void Start()
    {
        this.Hello.onClick.AddListener(() =>
        {
            var url = string.Format("{0}:{1}/{2}", host, port, route);
            Debug.Log(url);

            StartCoroutine(this.GetBasic(url, (raw) =>
            {
                Debug.LogFormat("{0}", raw);
            }));
        });
    }

    private IEnumerator GetBasic(string url, System.Action<string> callback)
    {
        var WebRequest = UnityWebRequest.Get(url);
        yield return WebRequest.SendWebRequest();

        if(WebRequest.result == UnityWebRequest.Result.ConnectionError || WebRequest.result == UnityWebRequest.Result.ProtocolError)
        {
            Debug.Log("네트워크 통신 에러");
        }
        else
        {
            callback(WebRequest.downloadHandler.text);          //통신 완료 되고 해당 텍스트를 가져온다.
        }
    }
}
