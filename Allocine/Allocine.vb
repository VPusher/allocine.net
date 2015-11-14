Imports System.Net

Public Class Allocine

    Dim MovieList As List(Of Movie) = New List(Of Movie)

    Private Function Get_request(ByVal url As String, ByVal PgBar As ToolStripProgressBar, Optional ByVal cookies As String = "", Optional ByVal proxy As String = Nothing, Optional ByVal proxyport As Integer = Nothing, Optional ByVal timeout As Integer = 30000, Optional ByVal login As String = "", Optional ByVal pass As String = "") As String
        Dim reader As IO.StreamReader 'on crée un objet streamreader 
        Try
            Dim hwebrequest As System.Net.HttpWebRequest = System.Net.HttpWebRequest.Create(url) 'on crée la requete web 
            hwebrequest.Timeout = timeout
            PgBar.Value = 10
            If proxy <> "" Then
                Dim hproxy As WebProxy
                hproxy = New WebProxy(proxy, proxyport)
                WebRequest.DefaultWebProxy = hproxy
            End If
            If login <> "" Then
                Dim hcredential As New System.Net.NetworkCredential(login, pass)
                hwebrequest.Credentials = hcredential
            End If
            If cookies <> "" Then
                hwebrequest.CookieContainer = New CookieContainer
                hwebrequest.CookieContainer.SetCookies(New Uri(url.Substring(0, url.IndexOf("/", 8))), cookies)
            End If
            PgBar.Value = 15
            Dim hwebresponse As System.Net.HttpWebResponse = hwebrequest.GetResponse 'on crée un objet de reponse a notre requete 
            PgBar.Value = 25
            reader = New IO.StreamReader(hwebresponse.GetResponseStream) 'on redefini notre streamreader avec la reponse à la requete en argument 
            PgBar.Value = 35
            Dim res As String = ""
            res = reader.ReadToEnd() 'on renvoie l'ensemble du resultat 
            PgBar.Value = 40
            reader.Close() 'on ferme l'objet 
            hwebresponse.Close()
            PgBar.Value = 45
            Return res
        Catch ex As Exception
            Return ex.ToString
        End Try
    End Function
    '
    Private Sub BtSend_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtSend.Click

        Me.StatusLabel.Text = "Recherche des films en cours..."
        Me.StatusProgressBar.Visible = True
        Me.StatusProgressBar.Value = 0

        Try
            Dim res As String = Get_request("http://api.allocine.fr/rest/v3/search?partner=YW5kcm9pZC12M3M&profile=medium&q=" + Me.TxtUrl.Text.ToString, Me.StatusProgressBar)

            Me.StatusProgressBar.Value = 50

            Dim xml As XDocument = XDocument.Parse(res)
            Dim ns As System.Xml.Linq.XNamespace = "http://www.allocine.net/v6/ns/"
            TxtResponse.Text = xml.ToString

            Me.StatusProgressBar.Value = 75

            Me.ListBox.Items.Clear()

            Me.StatusProgressBar.Value = 80

            For Each el As XElement In xml.Descendants(ns + "movie")
                Me.ListBox.Items.Add(New Movie(el.@code, el.Descendants(ns + "originalTitle").Value, el.Descendants(ns + "productionYear").Value))
            Next
        Catch ex As Exception
            ex.ToString()
            Me.TxtResponse.AppendText(ex.ToString)
        End Try

        Me.StatusProgressBar.Value = 100
        Me.StatusProgressBar.Visible = False
        Me.StatusLabel.Text = "OK"
    End Sub

    Private Sub ListBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox.SelectedIndexChanged
        Me.StatusLabel.Text = "Recherche du film en cours..."
        Me.StatusProgressBar.Visible = True
        Me.StatusProgressBar.Value = 0

        Dim res As String = Get_request("http://api.allocine.fr/rest/v3/movie?partner=YW5kcm9pZC12M3M&code=" + CType(Me.ListBox.SelectedItem, Movie).Code, Me.StatusProgressBar)
        Me.StatusProgressBar.Value = 50
        Dim xml As XDocument = XDocument.Parse(res)
        Dim ns As System.Xml.Linq.XNamespace = "http://www.allocine.net/v6/ns/"
        TxtResponse.Text = xml.ToString
        Me.StatusProgressBar.Value = 60

        Try
            LblDate.Text = xml.Descendants(ns + "productionYear").Value
            TxtTitre.Text = xml.Descendants(ns + "title").Value
            TxtActeurs.Text = xml.Descendants(ns + "actors").Value
            LblRealisateur.Text = xml.Descendants(ns + "directors").Value
            TxtSynopsis.Text = xml.Descendants(ns + "synopsis").Value
            LabelWebLink.Links.Add(0, 20)
            LabelWebLink.Links(0).LinkData = xml.Descendants(ns + "link").Value
            Dim i As Integer = 0
            For Each el As XElement In xml.Descendants(ns + "genreList").Descendants
                If i = 0 Then LblGenre1.Text = el.Value
                If i = 1 Then LblGenre2.Text = el.Value
                i += 1
            Next

            Me.StatusProgressBar.Value = 70

            Dim Wc As New System.Net.WebClient()

            Me.StatusProgressBar.Value = 75

            Dim St As System.IO.Stream = Wc.OpenRead(xml.Descendants(ns + "poster").@href)

            Me.StatusProgressBar.Value = 80

            Dim Im As System.Drawing.Image = System.Drawing.Image.FromStream(St)

            Me.StatusProgressBar.Value = 90

            Picture.Image = Im.GetThumbnailImage(Picture.Height / Im.Height * Im.Width, Picture.Height, Nothing, Nothing)

            Me.StatusProgressBar.Value = 95

            St.Dispose()
            Wc.Dispose()

            setMark(xml.Descendants(ns + "userRating").Value)

        Catch ex As Exception
            ex.ToString()
            Me.TxtResponse.AppendText(ex.ToString)
        End Try

        Me.StatusProgressBar.Value = 100
        Me.StatusProgressBar.Visible = False
        Me.StatusLabel.Text = "OK"
    End Sub

    Private Sub setMark(ByVal mark As String)

        Select Case mark(0)
            Case "0"
                Me.PictureStar1.Image = Image.FromFile("./star_off.gif")
                Me.PictureStar2.Image = Image.FromFile("./star_off.gif")
                Me.PictureStar3.Image = Image.FromFile("./star_off.gif")
                Me.PictureStar4.Image = Image.FromFile("./star_off.gif")
                Me.PictureStar5.Image = Image.FromFile("./star_off.gif")
            Case "1"
                Me.PictureStar1.Image = Image.FromFile("./star_on.png")
                Me.PictureStar2.Image = Image.FromFile("./star_off.gif")
                Me.PictureStar3.Image = Image.FromFile("./star_off.gif")
                Me.PictureStar4.Image = Image.FromFile("./star_off.gif")
                Me.PictureStar5.Image = Image.FromFile("./star_off.gif")
            Case "2"
                Me.PictureStar1.Image = Image.FromFile("./star_on.png")
                Me.PictureStar2.Image = Image.FromFile("./star_on.png")
                Me.PictureStar3.Image = Image.FromFile("./star_off.gif")
                Me.PictureStar4.Image = Image.FromFile("./star_off.gif")
                Me.PictureStar5.Image = Image.FromFile("./star_off.gif")
            Case "3"
                Me.PictureStar1.Image = Image.FromFile("./star_on.png")
                Me.PictureStar2.Image = Image.FromFile("./star_on.png")
                Me.PictureStar3.Image = Image.FromFile("./star_on.png")
                Me.PictureStar4.Image = Image.FromFile("./star_off.gif")
                Me.PictureStar5.Image = Image.FromFile("./star_off.gif")
            Case "4"
                Me.PictureStar1.Image = Image.FromFile("./star_on.png")
                Me.PictureStar2.Image = Image.FromFile("./star_on.png")
                Me.PictureStar3.Image = Image.FromFile("./star_on.png")
                Me.PictureStar4.Image = Image.FromFile("./star_on.png")
                Me.PictureStar5.Image = Image.FromFile("./star_off.gif")
            Case "5"
                Me.PictureStar1.Image = Image.FromFile("./star_on.png")
                Me.PictureStar2.Image = Image.FromFile("./star_on.png")
                Me.PictureStar3.Image = Image.FromFile("./star_on.png")
                Me.PictureStar4.Image = Image.FromFile("./star_on.png")
                Me.PictureStar5.Image = Image.FromFile("./star_on.png")
        End Select
    End Sub
End Class
