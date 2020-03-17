Imports System.IO
Imports System.Threading
Imports System.Net
Imports System.Net.Http
Imports System.Text.Json
Imports System.Text.Json.Serialization

' Classe LichessApi
'
' Description : classes contentant toutes les fonctionnalités
' pour communiquer avec l'API lichess.
'
' Beaucoup d'améliorations à prévoir concernant la gestion d'erreurs
' et validation des codes de retours de l'api, séparation en plusieurs
' fichiers, etc
'
' Mais ça fonctionne :D


' Classes représentant les données renvoyées par l'api
Public Class Confirmation
    <JsonPropertyName("ok")> Public Property Ok As Boolean
    <JsonPropertyName("error")> Public Property [Error] As String
End Class
Public Class PlayTime
    <JsonPropertyName("total")> Public Property Total As ULong
    <JsonPropertyName("tv")> Public Property Tv As ULong
End Class
Public Class RatingPerf
    <JsonPropertyName("games")> Public Property Games As UInteger
    <JsonPropertyName("rating")> Public Property Rating As Integer
    <JsonPropertyName("prog")> Public Property Prog As Integer
    <JsonPropertyName("rd")> Public Property Rd As Integer
    <JsonPropertyName("prov")> Public Property Prov As Boolean
End Class
Public Class Perfs
    <JsonPropertyName("chess960")> Public Property Chess960 As RatingPerf
    <JsonPropertyName("antichess")> Public Property Antichess As RatingPerf
    <JsonPropertyName("atomic")> Public Property Atomic As RatingPerf
    <JsonPropertyName("ultrabullet")> Public Property UltraBullet As RatingPerf
    <JsonPropertyName("blitz")> Public Property Blitz As RatingPerf
    <JsonPropertyName("kingOfTheHill")> Public Property KingOfTheHill As RatingPerf
    <JsonPropertyName("crazyHouse")> Public Property Crazyhouse As RatingPerf
    <JsonPropertyName("bullet")> Public Property Bullet As RatingPerf
    <JsonPropertyName("correspondence")> Public Property Correspondence As RatingPerf
    <JsonPropertyName("horde")> Public Property Horde As RatingPerf
    <JsonPropertyName("puzzle")> Public Property Puzzle As RatingPerf
    <JsonPropertyName("classical")> Public Property Classical As RatingPerf
    <JsonPropertyName("rapid")> Public Property Rapid As RatingPerf
End Class
Public Class Count
    <JsonPropertyName("ai")> Public Property Ai As Integer
    <JsonPropertyName("all")> Public Property All As Integer
    <JsonPropertyName("bookmark")> Public Property Bookmark As Integer
    <JsonPropertyName("draw")> Public Property Draw As Integer
    <JsonPropertyName("drawH")> Public Property DrawH As Integer
    <JsonPropertyName("import")> Public Property Import As Integer
    <JsonPropertyName("loss")> Public Property Loss As Integer
    <JsonPropertyName("lossH")> Public Property LossH As Integer
    <JsonPropertyName("me")> Public Property [Me] As Integer
    <JsonPropertyName("playing")> Public Property Playing As Integer
    <JsonPropertyName("rated")> Public Property Rated As Integer
    <JsonPropertyName("win")> Public Property Win As Integer
    <JsonPropertyName("winH")> Public Property WinH As Integer
End Class
Public Class Profile
    <JsonPropertyName("bio")> Public Property Bio As String
    <JsonPropertyName("country")> Public Property Country As String
    <JsonPropertyName("firstName")> Public Property FirstName As String
    <JsonPropertyName("lastName")> Public Property LastName As String
    <JsonPropertyName("links")> Public Property Links As String
    <JsonPropertyName("location")> Public Property Location As String
End Class
Public Class Account
    <JsonPropertyName("id")> Public Property Id As String
    <JsonPropertyName("username")> Public Property Username As String
    <JsonPropertyName("title")> Public Property Title As String
    <JsonPropertyName("online")> Public Property Online As Boolean
    <JsonPropertyName("playing")> Public Property Playing As Boolean
    <JsonPropertyName("streaming")> Public Property Streaming As Boolean
    <JsonPropertyName("createdAt")> Public Property CreatedAt As ULong
    <JsonPropertyName("seenAt")> Public Property SeenAt As ULong
    <JsonPropertyName("nbFollowers")> Public Property NbFollowers As Integer
    <JsonPropertyName("nbFollowing")> Public Property NbFollowing As Integer
    <JsonPropertyName("completionRate")> Public Property CompletionRate As Integer
    <JsonPropertyName("language")> Public Property Language As String
    <JsonPropertyName("patron")> Public Property Patron As Boolean
    <JsonPropertyName("disabled")> Public Property Disabled As Boolean
    <JsonPropertyName("engine")> Public Property Engine As Boolean
    <JsonPropertyName("booster")> Public Property Booster As Boolean
    <JsonPropertyName("followable")> Public Property Followable As Boolean
    <JsonPropertyName("following")> Public Property Following As Boolean
    <JsonPropertyName("blocking")> Public Property Blocking As Boolean
    <JsonPropertyName("followsYou")> Public Property FollowsYou As Boolean
    <JsonPropertyName("profile")> Public Property Profile As Profile
    <JsonPropertyName("count")> Public Property Count As Count
    <JsonPropertyName("perfs")> Public Property Perfs As Perfs
    <JsonPropertyName("playTime")> Public Property PlayTime As PlayTime
    <JsonPropertyName("url")> Public Property Url As String
End Class
Public Class Perf
    <JsonPropertyName("icon")> Public Property Icon As String
    <JsonPropertyName("name")> Public Property Name As String
End Class
Public Class TimeControl
    <JsonPropertyName("type")> Public Property Type As String
    <JsonPropertyName("limit")> Public Property Limit As Integer
    <JsonPropertyName("increment")> Public Property Increment As Integer
    <JsonPropertyName("show")> Public Property Show As String
    <JsonPropertyName("daysPerTurn")> Public Property DaysPerTurn As Integer
End Class
Public Class ChessVariant
    <JsonPropertyName("key")> Public Property Key As String
    <JsonPropertyName("name")> Public Property Name As String
    <JsonPropertyName("short")> Public Property [Short] As String
End Class
Public Class Player
    <JsonPropertyName("id")> Public Property Id As String
    <JsonPropertyName("name")> Public Property Name As String
    <JsonPropertyName("title")> Public Property Title As String
    <JsonPropertyName("rating")> Public Property Rating As Integer
    <JsonPropertyName("provisional")> Public Property Provisional As Boolean
    <JsonPropertyName("patron")> Public Property Patron As Boolean
    <JsonPropertyName("online")> Public Property Online As Boolean
    <JsonPropertyName("lag")> Public Property Lag As Integer
End Class
Public Class Challenge
    <JsonPropertyName("id")> Public Property Id As String
    <JsonPropertyName("status")> Public Property Status As String
    <JsonPropertyName("rated")> Public Property Rated As Boolean
    <JsonPropertyName("color")> Public Property Color As String
    <JsonPropertyName("challenger")> Public Property Challenger As Player
    <JsonPropertyName("destUser")> Public Property DestUser As Player
    <JsonPropertyName("variant")> Public Property [Variant] As ChessVariant
    <JsonPropertyName("timeControl")> Public Property Timecontrol As TimeControl
    <JsonPropertyName("perf")> Public Property Perf As Perf
    <JsonPropertyName("speed")> Public Property Speed As String
    <JsonPropertyName("direction")> Public Property Direction As String
    Public Overrides Function ToString() As String
        If Direction = "out" Then
            Return "-> " + DestUser.Name + " (" + Timecontrol.Show + ") | Classé : " +
                Rated.ToString() + " | Couleur : " + Color
        Else
            Return "<- " + Challenger.Name + " (" + Timecontrol.Show + ") | Classé : " +
                Rated.ToString() + " | Couleur : " + Color
        End If
    End Function
End Class
Public Class CreatedChallenge
    <JsonPropertyName("challenge")> Public Property Challenge As Challenge
    <JsonPropertyName("socketVersion")> Public Property SocketVersion As Integer
End Class
Public Class GameID
    <JsonPropertyName("id")> Public Property Id As String
End Class
Public Class Clock
    <JsonPropertyName("initial")> Public Property Initial As Integer
    <JsonPropertyName("increment")> Public Property Increment As Integer
End Class

Public Class GameState
    <JsonPropertyName("type")> Public Property Type As String
    <JsonPropertyName("moves")> Public Property Moves As String
    <JsonPropertyName("wtime")> Public Property Wtime As Integer
    <JsonPropertyName("btime")> Public Property Btime As Integer
    <JsonPropertyName("winc")> Public Property Winc As Integer
    <JsonPropertyName("binc")> Public Property Binc As Integer
    <JsonPropertyName("status")> Public Property Status As String
    <JsonPropertyName("winner")> Public Property Winner As String
End Class

' l'API renvoie un objet JSON non predictible
' pour l'instant la classe GameEvent est un
' fourre-tout pour pouvoir recuperer les
' données peu importe l'objet json recu
Public Class GameEvent
    <JsonPropertyName("type")> Public Property Type As String
    <JsonPropertyName("id")> Public Property Id As String
    <JsonPropertyName("rated")> Public Property Rated As Boolean
    <JsonPropertyName("speed")> Public Property Speed As String
    <JsonPropertyName("createdAt")> Public Property CreatedAt As ULong
    <JsonPropertyName("initialFen")> Public Property InitialFen As String
    <JsonPropertyName("variant")> Public Property [Variant] As ChessVariant
    <JsonPropertyName("clock")> Public Property Clock As Clock
    <JsonPropertyName("perf")> Public Property Perf As Perf
    <JsonPropertyName("white")> Public Property White As Player
    <JsonPropertyName("black")> Public Property Black As Player
    <JsonPropertyName("state")> Public Property State As GameState
    <JsonPropertyName("moves")> Public Property Moves As String
    <JsonPropertyName("wtime")> Public Property Wtime As Integer
    <JsonPropertyName("btime")> Public Property Btime As Integer
    <JsonPropertyName("winc")> Public Property Winc As Integer
    <JsonPropertyName("binc")> Public Property Binc As Integer
    <JsonPropertyName("status")> Public Property Status As String
    <JsonPropertyName("winner")> Public Property Winner As String
    <JsonPropertyName("username")> Public Property Username As String
    <JsonPropertyName("text")> Public Property Text As String
    <JsonPropertyName("room")> Public Property Room As String
End Class
Public Class LichessEvent
    <JsonPropertyName("type")> Public Property Type As String
    <JsonPropertyName("challenge")> Public Property Challenge As Challenge
    <JsonPropertyName("game")> Public Property Game As GameID
End Class

' Classe principale de l'API
'
' Contient toutes les fonctions de communication avec l'API lichess

Public Class LichessHttpClient

    Private Shared ReadOnly _baseUrl As String = "https://lichess.dev/api/"
    Private Shared ReadOnly _httpClient As HttpClient = New HttpClient()

    ' Constructeur de classe
    '
    ' Paramètres : aucun

    Public Sub New()

        ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12
        _httpClient.Timeout = Timeout.InfiniteTimeSpan ' a changer en fonction des requetes

    End Sub

    ' Changer le token utiliser pour la requete
    '
    ' Paramètres :
    '
    ' token : la chaine qui contient le token
    '
    ' Valeur de retour : aucune

    Public Sub SetToken(token As String)
        _httpClient.DefaultRequestHeaders.Clear()
        _httpClient.DefaultRequestHeaders.Add("Authorization", "Bearer " + token)
    End Sub

    ' Connexion au stream d'évenements
    '
    ' Paramètres : 
    '
    ' progress : objet de type Progress(Of LichessEvent) utilisé pour récuperer
    ' les données d'évenement du stream. (voir application exemple)
    '
    ' Valeur de retour : 
    '
    ' aucun, cette fonction reste active indéfiniment, il faut
    ' l'arreter manuellement (non implementé)
    '
    ' à refactoriser tester optimiser tout ce qui finit en er

    Public Async Function EventStreamAsync(progress As IProgress(Of LichessEvent)) As Task

        Using response = Await _httpClient.GetAsync(_baseUrl + "stream/event", HttpCompletionOption.ResponseHeadersRead).ConfigureAwait(False)
            Using body = Await response.Content.ReadAsStreamAsync().ConfigureAwait(False)
                Using eventStream = New StreamReader(body)
                    While Not eventStream.EndOfStream
                        Dim res As String = Await eventStream.ReadLineAsync().ConfigureAwait(False)
                        If Not String.IsNullOrWhiteSpace(res) Then
                            MsgBox(res)
                            progress.Report(JsonSerializer.Deserialize(Of LichessEvent)(res))
                        End If
                    End While
                End Using
            End Using
        End Using

    End Function

    ' Rafraichissement des informations du stream d'évenements
    '
    ' Paramètres : aucun
    '
    ' Valeur de retour :
    '
    ' tableau d'objets de type LichessEvent contenant les évenements actifs
    ' utilisé pour rafraichir périodiquement la liste de challenges (voir application exemple)

    Public Async Function RefreshEventsAsync() As Task(Of LichessEvent())

        Dim eventsArray() = New LichessEvent() {}

        Using response = Await _httpClient.GetAsync(_baseUrl + "stream/event", HttpCompletionOption.ResponseHeadersRead).ConfigureAwait(False)
            Using body = Await response.Content.ReadAsStreamAsync().ConfigureAwait(False)
                Using eventStream = New StreamReader(body)
                    Dim res As String = ""
                    Dim i As Integer = 0
                    Do
                        res = Await eventStream.ReadLineAsync().ConfigureAwait(False)
                        If Not String.IsNullOrWhiteSpace(res) Then
                            ReDim Preserve eventsArray(i)
                            eventsArray(i) = JsonSerializer.Deserialize(Of LichessEvent)(res)
                            i += 1
                        End If
                    Loop Until String.IsNullOrWhiteSpace(res)
                End Using
            End Using
        End Using

        Return eventsArray
    End Function

    ' Connexion au stream d'une partie
    '
    ' Paramètres : 
    '
    ' progress : objet de type Progress(Of GameEvent) utilisé pour récuperer
    ' les données d'évenement du stream de la partie. (voir application exemple)
    '
    ' Valeur de retour : 
    '
    ' Aucune, cette fonction reste active indéfiniment, elle se termine quand une
    ' partie est finie ou il faut l'arreter manuellement (non implementé)

    Public Async Function BoardGameStreamAsync(gameId As String, progress As IProgress(Of GameEvent)) As Task

        Using response = Await _httpClient.GetAsync(_baseUrl + "board/game/stream/" + gameId, HttpCompletionOption.ResponseHeadersRead).ConfigureAwait(False)
            Using body = Await response.Content.ReadAsStreamAsync().ConfigureAwait(False)
                Using gameStream = New StreamReader(body)
                    While Not gameStream.EndOfStream
                        Dim res As String = Await gameStream.ReadLineAsync().ConfigureAwait(False)
                        If Not String.IsNullOrWhiteSpace(res) Then
                            progress.Report(JsonSerializer.Deserialize(Of GameEvent)(res))
                        End If
                    End While
                End Using
            End Using
        End Using

    End Function

    ' Envoyer un coup dans une partie
    '
    ' Paramètres : 
    '
    ' gameID : chaine contenant l'ID de la partie
    ' 
    ' move : chaine contenant le coup à jouer
    '
    ' Valeur de retour : 
    '
    ' Objet de type Confirmation
    ' contenant la réponse ok / error

    Public Async Function SendMoveAsync(gameId As String, move As String) As Task(Of Confirmation)

        Dim confirm As Confirmation = Nothing

        Using response = Await _httpClient.PostAsync(_baseUrl + "board/game/" + gameId + "/move" + move, Nothing).ConfigureAwait(False)
            Dim res = Await response.Content.ReadAsStringAsync()
            confirm = JsonSerializer.Deserialize(Of Confirmation)(res)
        End Using

        Return confirm

    End Function

    ' Interrompre une partie
    '
    ' Paramètres : 
    '
    ' gameID : chaine contenant l'ID de la partie
    '
    ' Valeur de retour : 
    '
    ' Objet de type Confirmation
    ' contenant la réponse ok / error

    Public Async Function AbortGameAsync(gameId As String) As Task(Of Confirmation)

        Dim confirm As Confirmation = Nothing

        Using response = Await _httpClient.PostAsync(_baseUrl + "board/game/" + gameId + "/abort", Nothing).ConfigureAwait(False)
            Dim res = Await response.Content.ReadAsStringAsync()
            confirm = JsonSerializer.Deserialize(Of Confirmation)(res)
        End Using

        Return confirm

    End Function

    ' Abandonner une partie (déconseillé :p)
    '
    ' Paramètres : 
    '
    ' gameID : chaine contenant l'ID de la partie
    '
    ' Valeur de retour : 
    '
    ' Objet de type Confirmation
    ' contenant la réponse ok / error

    Public Async Function ResignGameAsync(gameId As String) As Task(Of Confirmation)

        Dim confirm As Confirmation = Nothing

        Using response = Await _httpClient.PostAsync(_baseUrl + "board/game/" + gameId + "/resign", Nothing).ConfigureAwait(False)
            Dim res = Await response.Content.ReadAsStringAsync()
            confirm = JsonSerializer.Deserialize(Of Confirmation)(res)
        End Using

        Return confirm

    End Function

    ' Ecrire dans le chat d'une partie
    '
    ' Paramètres : 
    '
    ' gameID : chaine contenant l'ID de la partie
    '
    ' room : "player" ou "spectator"
    '
    ' text : chaine contenant la ligne de texte à envoyer
    '
    ' Valeur de retour : 
    '
    ' Objet de type Confirmation
    ' contenant la réponse ok / error
    '
    ' Reste a faire : gestion UTF8 (d'ailleurs pour le stream aussi)

    Public Async Function SendChatAsync(gameId As String, room As String, text As String) As Task(Of Confirmation)

        Dim confirm As Confirmation = Nothing
        Dim values As Dictionary(Of String, String) = New Dictionary(Of String, String) From {
            {"room", room},
            {"text", text}
        }

        Using requestContent As New FormUrlEncodedContent(values)
            Using response = Await _httpClient.PostAsync(_baseUrl + "board/game/" + gameId + "/chat", requestContent).ConfigureAwait(False)
                Dim res = Await response.Content.ReadAsStringAsync()
                confirm = JsonSerializer.Deserialize(Of Confirmation)(res)
            End Using
        End Using

        Return confirm

    End Function

    ' Chercher une partie aléatoire
    '
    ' Paramètres :
    '
    ' time : temps initial en minutes
    '
    ' increment : increment en secondes
    '
    ' rated (optionnel) : true pour une partie classée ou false sinon (false par défaut)
    '
    ' color (optionnel) : "random" "white" "black" (random par défaut)
    '
    ' variant (optionnel) : "standard" "chess960" "crazyhouse" "antichess" "atomic" "horde" "kingOfTheHill" "racingKings" "threeCheck" ("standard" par défaut)
    '
    ' ratingRange (optionnel) : plage d'elo personnalisée, deconseillé (ex "1500-1800")
    '
    ' Valeur de retour :
    '
    ' Aucune, cette fonction reste active indéfiniment et se termine quand
    ' un challenge a été trouvé (notification dans le stream d'évenements)
    ' il faut l'arreter manuellement pour arreter de chercher un challenge
    ' (non implementé)

    Public Async Function CreateSeekAsync(time As Integer, increment As Integer,
                                     Optional rated As Boolean = False,
                                     Optional color As String = "random",
                                     Optional [variant] As String = "standard",
                                     Optional ratingRange As String = "") As Task
        Dim values As Dictionary(Of String, String) = New Dictionary(Of String, String) From {
            {"rated", rated.ToString()},
            {"time", time.ToString()},
            {"increment", increment.ToString()},
            {"color", color},
            {"variant", [variant]},
            {"ratingRange", ratingRange}
        }

        Using request = New HttpRequestMessage(HttpMethod.Post, _baseUrl + "board/seek")
            Using requestContent As New FormUrlEncodedContent(values)
                request.Content = requestContent
                Using response = Await _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead).ConfigureAwait(False)
                    Using body = Await response.Content.ReadAsStreamAsync().ConfigureAwait(False)
                        Using seekStream = New StreamReader(body)
                            While Not seekStream.EndOfStream
                                Dim res As String = Await seekStream.ReadLineAsync().ConfigureAwait(False)
                            End While
                        End Using
                    End Using
                End Using
            End Using
        End Using

    End Function

    ' Envoyer un challenge à un joueur
    ' fonctionne pour les challenges à cadence en temps réel
    '
    ' Paramètres :
    '
    ' userName : chaine contenant le nom d'utilisateur du joueur
    ' rated : true pour une partie classée ou false sinon
    ' clockLimit (optionnel) : temps en secondes de la partie (600 par défaut)
    ' clockIncrement (optionnel) : incrément en secondes (0 par défaut)
    ' color (optionnel) : "random" "white" "black" ("random" par défaut)
    ' variant (optionnel) : "standard" "chess960" "crazyhouse" "antichess" "atomic" "horde" "kingOfTheHill" "racingKings" "threeCheck" (todo : une enumeration)
    ' position (optionnel) : Position de départ personnalisé au format FEN
    '
    ' Valeur de retour : 
    '
    ' Objet de type CreatedChallenge contenant les informations du challenge

    Public Async Function SendChallengeAsync(userName As String, rated As Boolean,
                                        Optional clockLimit As Integer = 600,
                                        Optional clockIncrement As Integer = 0,
                                        Optional color As String = "random",
                                        Optional [variant] As String = "standard",
                                        Optional position As String = "rnbqkbnr/pppppppp/8/8/8/8/PPPPPPPP/RNBQKBNR w KQkq - 0 1") As Task(Of CreatedChallenge)

        Dim createdChallenge As CreatedChallenge = Nothing
        Dim values As Dictionary(Of String, String) = New Dictionary(Of String, String) From {
            {"rated", rated.ToString().ToLower()},
            {"clock.limit", clockLimit.ToString()},
            {"clock.increment", clockIncrement.ToString()},
            {"color", color},
            {"variant", [variant]},
            {"position", position}
        }

        Using requestContent As New FormUrlEncodedContent(values)
            Using response = Await _httpClient.PostAsync(_baseUrl + "challenge/" + userName, requestContent).ConfigureAwait(False)
                Dim res = Await response.Content.ReadAsStringAsync()
                If response.StatusCode = HttpStatusCode.OK Then
                    MsgBox(res)
                    createdChallenge = JsonSerializer.Deserialize(Of CreatedChallenge)(res)
                Else
                    MsgBox(res)
                End If

            End Using
        End Using

        Return createdChallenge

    End Function


    ' Envoyer un challenge avec une cadence de type correspondance à un joueur
    ' 
    ' Paramètres :
    '
    ' userName : chaine contenant le nom d'utilisateur du joueur
    ' rated : true pour une partie classée ou false sinon
    ' days (optionnel) : temps en jours de la partie (2 par défaut)
    ' color (optionnel) : "random" "white" "black" ("random" par défaut)
    ' variant (optionnel) : "standard" "chess960" "crazyhouse" "antichess" "atomic" "horde" "kingOfTheHill" "racingKings" "threeCheck" (todo : une enumeration)
    ' position (optionnel) : Position de départ personnalisé au format FEN
    '
    ' Valeur de retour : 
    '
    ' Objet de type CreatedChallenge contenant les informations du challenge

    Public Async Function SendCorrespondenceChallengeAsync(userName As String, rated As Boolean,
                                        Optional days As Integer = 2,
                                        Optional color As String = "random",
                                        Optional [variant] As String = "standard",
                                        Optional position As String = "rnbqkbnr/pppppppp/8/8/8/8/PPPPPPPP/RNBQKBNR w KQkq - 0 1") As Task(Of CreatedChallenge)

        Dim createdChallenge As CreatedChallenge = Nothing
        Dim values As Dictionary(Of String, String) = New Dictionary(Of String, String) From {
            {"rated", rated.ToString().ToLower()},
            {"days", days.ToString()},
            {"color", color},
            {"variant", [variant]},
            {"position", position}
        }

        Using requestContent As New FormUrlEncodedContent(values)
            Using response = Await _httpClient.PostAsync(_baseUrl + "challenge/" + userName, requestContent).ConfigureAwait(False)
                Dim res = Await response.Content.ReadAsStringAsync()
                If response.StatusCode = HttpStatusCode.OK Then
                    MsgBox(res)
                    createdChallenge = JsonSerializer.Deserialize(Of CreatedChallenge)(res)
                Else
                    MsgBox(res)
                End If

            End Using
        End Using

        Return createdChallenge

    End Function

    ' Envoyer un challenge avec une cadence illimitée à un joueur
    ' 
    ' Paramètres :
    '
    ' userName : chaine contenant le nom d'utilisateur du joueur
    ' rated : true pour une partie classée ou false sinon
    ' color (optionnel) : "random" "white" "black" ("random" par défaut)
    ' variant (optionnel) : "standard" "chess960" "crazyhouse" "antichess" "atomic" "horde" "kingOfTheHill" "racingKings" "threeCheck" (todo : une enumeration)
    ' position (optionnel) : Position de départ personnalisé au format FEN
    '
    ' Valeur de retour : 
    '
    ' Objet de type CreatedChallenge contenant les informations du challenge

    Public Async Function SendUnlimitedChallengeAsync(userName As String, rated As Boolean,
                                        Optional color As String = "random",
                                        Optional [variant] As String = "standard",
                                        Optional position As String = "rnbqkbnr/pppppppp/8/8/8/8/PPPPPPPP/RNBQKBNR w KQkq - 0 1") As Task(Of CreatedChallenge)

        Dim createdChallenge As CreatedChallenge = Nothing
        Dim values As Dictionary(Of String, String) = New Dictionary(Of String, String) From {
            {"rated", rated.ToString().ToLower()},
            {"color", color},
            {"variant", [variant]},
            {"position", position}
        }

        Using requestContent As New FormUrlEncodedContent(values)
            Using response = Await _httpClient.PostAsync(_baseUrl + "challenge/" + userName, requestContent).ConfigureAwait(False)
                Dim res = Await response.Content.ReadAsStringAsync()
                If response.StatusCode = HttpStatusCode.OK Then
                    MsgBox(res)
                    createdChallenge = JsonSerializer.Deserialize(Of CreatedChallenge)(res)
                Else
                    MsgBox(res)
                End If

            End Using
        End Using

        Return createdChallenge

    End Function

    ' Accepter un challenge
    '
    ' Paramètres :
    '
    ' challengeId : chaine contenant l'ID du challenge
    '
    ' Valeur de retour :
    '
    ' Objet de type Confirmation
    ' contenant la réponse ok / error

    Public Async Function AcceptChallengeAsync(challengeId As String) As Task(Of Confirmation)

        Dim confirm As Confirmation = Nothing

        Using response = Await _httpClient.PostAsync(_baseUrl + "challenge/" + challengeId + "/accept", Nothing).ConfigureAwait(False)
            Dim res = Await response.Content.ReadAsStringAsync()
            confirm = JsonSerializer.Deserialize(Of Confirmation)(res)
        End Using

        Return confirm

    End Function

    ' Refuser un challenge
    '
    ' Paramètres
    '
    ' challengeId : chaine contenant l'ID du challenge
    '
    ' Valeur de retour :
    '
    ' Objet de type Confirmation
    ' contenant la réponse ok / error

    Public Async Function DeclineChallengeAsync(challengeId As String) As Task(Of Confirmation)

        Dim confirm As Confirmation = Nothing

        Using response = Await _httpClient.PostAsync(_baseUrl + "challenge/" + challengeId + "/decline", Nothing).ConfigureAwait(False)
            Dim res = Await response.Content.ReadAsStringAsync()
            confirm = JsonSerializer.Deserialize(Of Confirmation)(res)
        End Using

        Return confirm

    End Function

    ' Récuperer les informations du compte
    '
    ' Paramètres : aucun
    '
    ' Valeur de retour :
    '
    ' Objet de type Account contenant les informations du compte

    Public Async Function AccountAsync() As Task(Of Account)

        Dim account As Account = Nothing

        Using response = Await _httpClient.GetAsync(_baseUrl + "account").ConfigureAwait(False)
            If response.IsSuccessStatusCode Then
                Dim res = Await response.Content.ReadAsStringAsync()
                account = JsonSerializer.Deserialize(Of Account)(res)
            End If
        End Using

        Return account

    End Function

End Class
