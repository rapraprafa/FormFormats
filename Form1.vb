Imports System.Text.RegularExpressions
Imports Newtonsoft.Json

Public Class Form1
    Dim PATH As String = "C:/Users/Rafamus/Raforms"

    Class formInput
        Public name As String
        Public age As Int32
        Public address As String
    End Class

    Private Sub TextAge_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextAge.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextAge_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextAge.TextChanged
        Dim digitsOnly As Regex = New Regex("[^\d]")
        TextAge.Text = digitsOnly.Replace(TextAge.Text, "")
    End Sub

    Private Sub SaveTxt_Click(sender As Object, e As EventArgs) Handles SaveTxt.Click
        If isBlank() Then
            My.Computer.FileSystem.WriteAllText(PATH & ".txt", "", True)
            Dim objWriter As New System.IO.StreamWriter(PATH & ".txt")

            objWriter.WriteLine("Name:" & ControlChars.Tab & TextName.Text)
            objWriter.WriteLine("Age:" & ControlChars.Tab & TextAge.Text)
            objWriter.WriteLine("Address:" & ControlChars.Tab & TextAddress.Text)

            objWriter.Close()

            Status.Text = "Successfully saved as TXT format."
        Else
            Status.Text = "Please fill up all inputs."
        End If
    End Sub

    Private Sub SaveXml_Click(sender As Object, e As EventArgs) Handles SaveXml.Click
        If isBlank() Then
            Dim xmlDeclaration As New XDeclaration("1.0", "UTF-8", "yes")
            Dim doc As XDocument =
                New XDocument(xmlDeclaration,
                              New XElement("Form",
                                           New XElement("name", "" & TextName.Text),
                                           New XElement("age", "" & TextAge.Text),
                                           New XElement("address", "" & TextAddress.Text)
                                          )
                              )

            doc.Save(PATH & ".xml")

            Status.Text = "Successfully saved as XML format."
        Else
            Status.Text = "Please fill up all inputs."
        End If
    End Sub

    Private Sub SaveJson_Click(sender As Object, e As EventArgs) Handles SaveJson.Click
        If isBlank() Then
            Dim inp As formInput = New formInput()
            inp.name = TextName.Text
            inp.age = Convert.ToInt32(TextAge.Text)
            inp.address = TextAddress.Text

            My.Computer.FileSystem.WriteAllText(PATH & "JSON.txt", JsonConvert.SerializeObject(inp, Newtonsoft.Json.Formatting.Indented), False)

            Status.Text = "Successfully saved as JSON format."
        Else
            Status.Text = "Please fill up all inputs."
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Status.Text = "Hi!"
    End Sub

    Function isBlank() As Boolean
        If TextName.Text = "" Or TextAge.Text = "" Or TextAddress.Text = "" Then
            isBlank = False
        Else
            isBlank = True
        End If
    End Function
End Class
