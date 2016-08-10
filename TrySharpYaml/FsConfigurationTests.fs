module FsConfigurationTests

open FSharp.Configuration
open FluentAssertions
open NUnit.Framework

type TestConfig = YamlConfig<"Config.yaml">
type TestOrder = YamlConfig<"Order.yaml">

[<Test>]
let shouldReadConfig() =
    let config = TestConfig()
    config.DB.ConnectionString.Should().Be("Data Source=server1;Initial Catalog=Database1;Integrated Security=SSPI;", "st")

[<Test>]
let shouldReadOrder() =
    let config = TestOrder()
    config.customer.family.Should().Be("Gale", "family")

