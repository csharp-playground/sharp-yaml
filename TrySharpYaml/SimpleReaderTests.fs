
module SimpleReaderTests

open System
open NUnit.Framework
open System.IO
open SharpYaml.Serialization


let text = """

processes:
- process: A, B, C
  step:
  - A
  - B
  - C  
- process: A, B, C
  step:
  - A
  - C
"""

[<Test>]
let shouldReadYam() = 

      use input = new StringReader(text);
      let yaml = YamlStream();
      yaml.Load(input);

      let mapping = yaml.Documents.[0].RootNode :?> YamlMappingNode

      ()


