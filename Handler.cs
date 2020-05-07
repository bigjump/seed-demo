using Amazon.Lambda.APIGatewayEvents;
using Amazon.Lambda.Core;
using System;

[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.SystemTextJson.DefaultLambdaJsonSerializer))]

namespace AwsDotnetCsharp
{
  public class Handler
  {
    public Handler()
    {
      Console.WriteLine("boot");
    }

    public APIGatewayProxyResponse Hello(APIGatewayProxyRequest request)
    {
      Console.WriteLine(request);
      return new APIGatewayProxyResponse()
      {
        StatusCode = 200,
        Body = "Go Serverless v1.0! Your function executed successfully!"
      };
    }
  }
}
