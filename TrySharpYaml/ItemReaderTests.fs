module ItemReaderTests

open System.IO
open SharpYaml.Serialization
open NUnit.Framework

type Item() =

      [<YamlMember("part_no")>]
      member val PartNo = "" with set,get

      [<YamlMember("descrip")>]
      member val Description = "" with set,get

type Order () =
      member val Company = "" with set,get
      member val Items = Array.empty<Item> with set,get

let text = """
      company: B Circle
      items:
            - part_no:   A4786
              descrip:   Water Bucket (Filled)
              price:     1.47
              quantity:  4
            - part_no:   E1628
              descrip:   High Heeled ""Ruby"" Slippers
              price:     100.27
              quantity:  1
"""

[<Test>]
let shouldReadYam() = 

      let deserializer = new Serializer();
      let input = new StringReader(text);
      //let order = deserializer.Deserialize(input, typeof<Order>) 
      let order = deserializer.Deserialize(input) 

      ()


