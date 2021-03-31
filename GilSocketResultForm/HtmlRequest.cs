using System;
using System.Text;
using System.IO;
using System.Net;
using System.Net.Http;

namespace GilSocketResultForm
{
    class HtmlRequest
    {
        // HttpRequest를 실행하는 함수
        public string GetRequest(String url, HttpMethod method, object param = null)
        {
            // 파라미터가 있을 경우, 익명 클래스로 만들기 때문에 Reflection을 이용해서 데이터를 가져온다.
            if (param != null)
            {
                StringBuilder parameter = new StringBuilder();
                // 파라미터키=파라미터값&파라미터키=파라미터값&파라미터키=파라미터값 의 형태로 만든다.
                foreach (var p in param.GetType().GetProperties())
                {
                    if (parameter.Length > 0)
                    {
                        parameter.Append("&");
                    }
                    parameter.AppendFormat("{0}={1}", p.Name, p.GetValue(param));
                }
                param = parameter.ToString();
            }
            else
            {
                param = "";
            }
            // Http method가 GET 방식의 경우 파라미터를 url 주소 뒤에 붙인다.
            if (HttpMethod.Get.Equals(method))
            {
                if (url.Contains("?"))
                {
                    url += "&" + param;
                }
                else
                {
                    url += "?" + param;
                }
            }
            // url를 통해 HttpWebRequest 클래스를 생성한다.
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            // 해더의 메소드를 정의한다.
            request.Method = method.ToString();
            // 해더의 ContentType를 정의한다.
            request.ContentType = "application/x-www-form-urlencoded";
            // request에 프로퍼티로 정의되지 않는 해더의 경우는 Indexer의 형식으로 정의할 수 있다.
            // 프로퍼티로 정의된 해더의 경우, 아래와 같이 정의할 경우 에러가 발생한다.
            request.Headers["Upgrade-Insecure-Requests"] = "1";
            // Http method가 POST 방식의 경우, 해더 아래에
            if (HttpMethod.Post.Equals(method))
            {
                byte[] byteArray = Encoding.UTF8.GetBytes((string)param);
                request.ContentLength = byteArray.Length;
                using (Stream dataStream = request.GetRequestStream())
                {
                    dataStream.Write(byteArray, 0, byteArray.Length);
                }
            }
            // Http 프로토콜을 접속해서 response 받기
            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            {
                // 프로토콜의 반환 코드를 받을 수 있다. (200이면 정상이다.)
                Console.WriteLine((int)response.StatusCode);
                // 스트림으로 반환 결과값을 받는다.
                using (StreamReader reader = new StreamReader(response.GetResponseStream()))
                {
                    return reader.ReadToEnd();
                }
            }
        }
    }
}
