namespace NRK.Dotnetskolen

module Domain = 

    open System
    open System.Text.RegularExpressions

    type Sending = {
        Tittel: string
        Kanal: string
        Starttidspunkt: DateTimeOffset
        Sluttidspunkt: DateTimeOffset
    }

    type Epg = Sending list

    let isTittelValid (tittel: string) : bool =
        let tittelRegex = Regex(@"^[\p{L}0-9\.,-:!]{5,100}$")
        tittelRegex.IsMatch(tittel)

    let isKanalValid (kanal: string) : bool =
        let kanaelRegex = Regex(@"^NRK[12]")
        kanaelRegex.IsMatch(kanal)