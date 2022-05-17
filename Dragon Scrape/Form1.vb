Imports System.IO
Imports System.Net
Imports System.Text.RegularExpressions

Public Class Form1

    Private ReadOnly htmlsource As String = My.Computer.FileSystem.SpecialDirectories.Desktop & "\Collection\source.txt"
    Private ReadOnly portfolio As String = My.Computer.FileSystem.SpecialDirectories.Desktop & "\Collection\images"

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load



        'This will create a desktop folder if one doesn't exist
        If Not Directory.Exists($"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\Collection") Then
            Directory.CreateDirectory($"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\Collection")
        End If

        PictureBox1.Load(AppDomain.CurrentDomain.BaseDirectory & "../../Images/face.jpg")
        PictureBox2.Load(AppDomain.CurrentDomain.BaseDirectory & "../../Images/face.jpg")
    End Sub


    Function GetImagesFromURL(URL As String)
        Dim i As Integer = -1
        Dim Picturez(3000) As Image
        Dim cl As HttpWebRequest
        cl = WebRequest.Create(URL)
        Dim receive As HttpWebResponse = cl.GetResponse
        Dim WStream As Stream = receive.GetResponseStream

        ' Create reader object
        Dim Basin As New IO.StreamReader(WStream)
        Dim items As String = Basin.ReadToEnd
        'Why use this expression??? >>> "src\=\""[\u0000-\uFFFF]*?\.(gif|png|jpg|tif|bmp)\""" 
        'It searches for a string like src="AnyCharForMinimumLength.gif or png or jpg or tif or bmp"
        For Each Rythorian As Match In Regex.Matches(items, "src\=\""[\u0000-\uFFFF]*?\.(gif|png|jpg|tif|bmp)\""") 'for each match"

            Dim Kreznok As String = Rythorian.Value
            Kreznok = Kreznok.TrimStart("s", "r", "c", "=", """").TrimEnd("""") ' it clears the url from src=" and "

            Try
                Try
                    'if is a full url then create a new web request
                    cl = WebRequest.Create(Kreznok) 'if this fails then this is not a complete url
                Catch ex As Exception
                    ' if is not the full url then combine the given URL with the image path and get rid of any \\ if they exists ( www.mysite.com//image.gif to www.mysite.com/image.gif)
                    cl = WebRequest.Create((URL & "/" & Kreznok).Replace("//", "/"))

                End Try

                receive = cl.GetResponse
                WStream = receive.GetResponseStream

                i += 1
                'write the image into an array(list) of images
                Picturez(i) = Image.FromStream(WStream)
            Catch ex As Exception

            End Try

        Next

        Return Picturez

    End Function

    Private Sub Seeker_Click(sender As Object,
                             e As EventArgs) Handles Seeker.Click

        Dim i As Integer = 0
        For Each img As Image In GetImagesFromURL(UrlHost.Text.ToString) '"https://moviestowatch.tv/movie"
            Try
                If img IsNot Nothing Then

                    If Png.Checked Then
                        img.Save(filename:=$"{portfolio}{i}.png")
                        i += 1
                    ElseIf Gif.Checked Then
                        img.Save(filename:=$"{portfolio}{i}.gif")
                        i += 1
                    ElseIf Jpg.Checked Then
                        img.Save(filename:=$"{portfolio}{i}.jpg")
                        i += 1
                    ElseIf Bmp.Checked Then
                        img.Save(filename:=$"{portfolio}{i}.bmp")
                        i += 1
                    ElseIf Tif.Checked Then
                        img.Save(filename:=$"{portfolio}{i}.tif")
                        i += 1
                    End If

                End If
            Catch ex As Exception
                'when it's done it gives an error telling us that there is no image in the next img, so we stop
                Exit For
            End Try

        Next


        Dim request As WebRequest = WebRequest.Create(UrlHost.Text)

        Using response As WebResponse = request.GetResponse()
            Using reader As New StreamReader(response.GetResponseStream())
                Dim html As String = reader.ReadToEnd()
                File.WriteAllText(htmlsource, html)
            End Using
        End Using

        Try
            Dim array = File.ReadAllLines(htmlsource)
            For i1 = 0 To array.Length - 1
                Dim sz As String = array(i1)
                TextBox1.AppendText(sz + vbNewLine)

            Next

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try
    End Sub

    Private Sub Form1_FormClosing(sender As Object,
                                  e As FormClosingEventArgs) Handles Me.FormClosing

        Dispose()
        GC.Collect()
        GC.WaitForPendingFinalizers()
    End Sub

    Private Sub Png_CheckedChanged(sender As Object,
                                   e As EventArgs) Handles Png.CheckedChanged

    End Sub

    Private Sub Tif_CheckedChanged(sender As Object,
                                   e As EventArgs) Handles Tif.CheckedChanged

    End Sub

    Private Sub Gif_CheckedChanged(sender As Object,
                                   e As EventArgs) Handles Gif.CheckedChanged

    End Sub

    Private Sub Jpg_CheckedChanged(sender As Object,
                                   e As EventArgs) Handles Jpg.CheckedChanged

    End Sub

    Private Sub Bmp_CheckedChanged(sender As Object,
                                   e As EventArgs) Handles Bmp.CheckedChanged

    End Sub

    Private Sub Clear_Click(sender As Object,
                            e As EventArgs) Handles Clear.Click

        Png.CheckState = CheckState.Unchecked
        Tif.CheckState = CheckState.Unchecked
        Gif.CheckState = CheckState.Unchecked
        Bmp.CheckState = CheckState.Unchecked
        Jpg.CheckState = CheckState.Unchecked

    End Sub
End Class
