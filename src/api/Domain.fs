namespace NRK.Dotnetskolen

module Domain = 

    open System

    type Sending = {
        Tittel: string
        Kanal: string
        Starttidspunkt: DateTimeOffset
        Sluttidspunkt: DateTimeOffset
    }

    type Epg = Sending list