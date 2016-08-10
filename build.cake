#tool "nuget:?package=Fixie"
#tool "nuget:?package=NUnit.ConsoleRunner"
#addin "nuget:?package=Cake.Watch"

var solution = "TrySharpYaml.sln";
var testDll = "TrySharpYaml/bin/Debug/TrySharpYaml.dll";
var testCsDll = "TrySharpYaml.Cs/bin/Debug/TrySharpYaml.Cs.dll";

Task("Test-TrySharpYaml")
    .Does(() => {
            DotNetBuild(solution);
            //Fixie(testDll);
            NUnit3(testDll);
    });

Task("Test-TrySharpYaml.Cs")
    .Does(() => {
            DotNetBuild(solution);
            //Fixie(testCsDll);
            NUnit3(testCsDll);
    });

var target = Argument("target", "default");
RunTarget(target);