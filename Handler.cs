using Amazon.Lambda.Core;

[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.SystemTextJson.DefaultLambdaJsonSerializer))]

namespace AwsDotnetCsharp
{
  public class Handler
  {
    public string Hello(string name)
    {
      return $"Hello {name}";
    }
  }
}
