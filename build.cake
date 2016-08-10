#tool "nuget:?package=Fixie"
#addin "nuget:?package=Cake.Watch"

var solution = "TrySharpYaml.sln";
var testDll = "TrySharpYaml/bin/Debug/TrySharpYaml.dll";
var testCsDll = "TrySharpYaml.Cs/bin/Debug/TrySharpYaml.Cs.dll";

Task("Test-TrySharpYaml")
    .Does(() => {
            DotNetBuild(solution);
            Fixie(testDll);
    });

Task("Test-TrySharpYaml.Cs")
    .Does(() => {
            DotNetBuild(solution);
            Fixie(testCsDll);
    });

var target = Argument("target", "default");
RunTarget(target);