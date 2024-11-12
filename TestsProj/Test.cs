namespace TestsProj;
using System.IO;
using Xunit;
using Xunit.Abstractions;

public class UnitTest1
{
    private readonly ITestOutputHelper output;

    public UnitTest1(ITestOutputHelper output)
    {
        this.output = output;
    }

    [Fact]
    public void DoesMyFirstApiDirectoryExist()
    {
        string path = @"../../../../MyFirstApi";
        Assert.True(Directory.Exists(path), "The file directory \"MyFirstApi\" does not exist at the root of this GitHub repository");
        output.WriteLine(Directory.GetCurrentDirectory());
    }

    [Fact]
    public void DoesProgramFileInMyFirstApiExist()
    {
        string curFile = @"../../../../MyFirstApi/Program.cs";
        Assert.True(File.Exists(curFile), "The file \"Program.cs\" does not exist within the \"MyFirstApi\" directory at the root of this GitHub repository");
        output.WriteLine(Directory.GetCurrentDirectory());
    }


}