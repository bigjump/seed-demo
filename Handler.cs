using Amazon.Lambda.Core;

[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.SystemTextJson.DefaultLambdaJsonSerializer))]

namespace AwsDotnetCsharp
{
  public class Handler
  {
    public MyResponse Hello(MyRequest req)
    {
      return new MyResponse() { Message = $"Hello {req.Name}" };
    }
  }

  public class MyResponse
  {
    public string Message { get; set; }
  }

  public class MyRequest
  {
    public string Name { get; set; }
  }
}
