module Tests

open NRK.Dotnetskolen.Domain

open Xunit
[<Theory>]
[<InlineData("abc12")>]
[<InlineData(".,-:!")>]
[<InlineData("ABCDEFGHIJABCDEFGHIJABCDEFGHIJABCDEFGHIJABCDEFGHIJABCDEFGHIJABCDEFGHIJABCDEFGHIJABCDEFGHIJABCDEFGHIJ")>]
let ``isTittelValid valid tittel returns true`` (tittel: string) =
    let isTittelValid = isTittelValid tittel

    Assert.True isTittelValid

[<Theory>]
[<InlineData("abcd")>]
[<InlineData("@$%&/")>]
[<InlineData("abcdefghijabcdefghijabcdefghijabcdefghijabcdefghijabcdefghijabcdefghijabcdefghijabcdefghijabcdefghija")>]
let ``isTittelValid invalid tittel returns false`` (tittel: string) =
    let isTittelValid = isTittelValid tittel

    Assert.False isTittelValid