using System.Runtime.CompilerServices;

namespace AsperandLabs.Tests.Shared;

public static class TestHelpers
{
    public static string TestName([CallerMemberName] string name = "NoName") => name;
}