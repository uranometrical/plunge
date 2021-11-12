using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using NUnit.Framework;
using Plunge.Newtonsoft.Accounts;

namespace Plunge.Newtonsoft.Tests.Accounts
{
    public static class AccountSerialization
    {
        [Test]
        public static void PrintSerializationSimple()
        {
            LauncherAccounts accounts = new()
            {
                Accounts = new Dictionary<string, LauncherAccount>
                {
                    {
                        "example-doesn't-really-matter",

                        new LauncherAccount
                        {
                            AccessToken = "",
                            AccessTokenExpiresAt = "2021-10-05T05:14:45Z",
                            Avatar = "data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAAEAAAABACAYAAACqaXHeAAAAAXNSR0IArs4c6QAAAARnQU1BAACxjwv8YQUAAAAJcEhZcwAADsMAAA7DAcdvqGQAAANqSURBVHhe7ZrPa9RAFMffJJssii1LtVt7aFk8ePAkIuJf4EUvXhQED/4H+g/4X3gWvEq9igdvXnsRxItQqSgolIIKbpNMxu/bvOJ2d2bSdq3Uznyyj5dkdl7efPNzJlFLS0tvjDGrRKRhB6YsS9LaXbXb7ZJSSpb+Pm3b95EkCal+v7+JBFcggqw+GJxAXdeyNE2e50cugG/7PjivBF4ftvH/O9xuFiBoogDigyUKID5YkqIoyGcn/Q6R8D2UG+myk048BcQHSxRAfLBEAcQHSxRAfLBEAcQHSxRAfLCoufm5DfhBszhN3s0pUYpc3aKy8A9K8qhwog6vszHorMm8jdGgKP7jpKU/p86fXR4JgL5fs2aCLMlJYXJRGX8CJuW4LVl46KYsYIoI9hjlENvXHgFSmCN9HhVW6w8/bNR1OtDGMraOit/XFFWfMcuBJkFOc7eJOiuYmaqO4KqmR68e0PutdxAyk/V74T1o63aPGozfk1vP6NLiFSrrQkrGwIH18yVifDHO/M7chAaLmJ/QiLeYJ8jx22OzoQ0NdD2dBAuw/RR7GQK46N3HUXIBM1Wz/IdGgHsvbtDbr+uUpbms34trXH9XgOd3X9Pl5atUIskpIMCPNcT4hHmHAPN3sIOWMT+xgzhanipKqrqiCo1v/LRptIwn9jarDLytnpjr0N0vehQf+o7F3mMy2XIbGepb68F0reNdIAogPlj4/Wgz4V5tNWjEE3uvWevyNBtNfHhbfDaUt+U3Kp+oxyU8JaUZ4oJgN82eWsxTn23WkWVtCsQpp+KycX7altO4OfPbwa11SOraxevNg5Ajz52tiuoChY5d2V1IKeniTHLU39z+SMPyF1S3B2gTaHVhQKey0/b/IWSxjav5ji+/DiUZCm3VsVotnFuAAMb5KFxU/pcjWSfzPurqCvcwfxu9JB0+ZGXBQlHxg5T7STDrNI/ydnAS9Pt9b1+g7e1QlkEAXElczPp2qe0Di1k+0Nj9QCJoogDigyUKID5YogDigyUKID5YogDigyUKID5YVK/X8/YG23pyvp4aM0tPkDny3uCs3wna6ozbcSdeA8QHSxRAfLBEAcQHS6sAPOrL91KXtT0HHHdaBeAGttn/TDwFxAdLFEB8sEQBcBVnZNEOl7vsX2Db7q7tB1s9NiKi3zLZVZscW2mvAAAAAElFTkSuQmCC",
                            EligibleForMigration = false,
                            HasMultipleProfiles = false,
                            Legacy = false,
                            LocalId = "guid-here-too",
                            MinecraftProfile = new MinecraftProfile
                            {
                                Id = "guid-goes-here",
                                Name = "Uranometry"
                            },
                            Persistent = true,
                            RemoteId = "00000000000000000",
                            Type = "Xbox",
                            UserProperties = Array.Empty<object>(),
                            Username = "World"
                        }
                    }
                },

                ActiveAccountLocalId = "aaaaaaaaaa",

                MojangClientToken = ""
            };

            string json = JsonConvert.SerializeObject(accounts, Formatting.Indented);
            Console.WriteLine(json);
            Assert.Pass();
        }
    }
}