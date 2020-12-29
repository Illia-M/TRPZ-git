using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Grpc.Core;
using Microsoft.Extensions.Logging;

namespace TRPZ2
{
    public class GreeterService : Greeter.GreeterBase
    {
        private readonly ILogger<GreeterService> _logger;
        public GreeterService(ILogger<GreeterService> logger)
        {
            _logger = logger;
        }

        public override Task<HelloReply> SayHello(HelloRequest request, ServerCallContext context)
        {
            var studentsList = new[]
            {
                "1. Tymchenko Kyrylo"
                 "1. Andrei Chernya"
                 "2. Tymchenko_Kyrylo"
                 "3. Nykyforova_Oleksandra"
            };
            
            return Task.FromResult(new HelloReply
            {
                Message = "Stream students list: " + string.Join("; ", studentsList),
            });
        }
    }
}
