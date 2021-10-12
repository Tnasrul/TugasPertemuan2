@Code
    Layout = "~/_SiteLayout.vbhtml"
    PageData("Title") = "About"

    Dim statusboolean As Boolean = True
    Dim statusangka As Integer = 0
    Dim statustext As String = "C"
End Code

<style>
    table, th, td {
        border: 1px solid black;
        padding: 5px;
    }
    </style>

<hgroup class="title">
    <h1>@PageData("Title").</h1>
    <h2>Your app description page.</h2>
</hgroup>

<article>
    <!--Fungsi IF-->
    @code
        Dim kalimat1 As String
        @If statusboolean Then
            kalimat1 = "ini status aktif"
        Else
            kalimat1 = "ini status non aktif"
        End If
        @kalimat1
    End Code
    <br> <br>
    @code
        Dim kalimat2 As String
        @If statusangka < 5 Then
            kalimat2 = "angka kurang dari 5"
        ElseIf statusangka > 5 Then
            kalimat2 = "angka lebih dari 5"
        Else kalimat2 = "angkasama dengan 5"
        End If
        @kalimat2
    End Code
    <br><br>

    @code

        @If statustext.Equals("A") Or statustext.Equals("a") Then
            @: ini status A
        ElseIf statustext.Equals("B") Or statustext.Equals("b") Then
            @<text> ini status B </text>
        Else
            Dim kalimat3 As String = "<b> ini status lainnya</b>"
            @Html.Raw(kalimat3)
        End If
        End code

    <!--Fungsi Loop-->
<table border="1">
    <tr>
        <th>kolom1</th>
        <th>kolom2</th>
        <th>kolom3</th>
    </tr>
    @code
        Dim i As Integer
        For i = 1 To 5 Step 1
            @Html.Raw("<tr>")
            @Html.Raw("<td> baris " + i.ToString + " Kolom A</td>")
            @Html.Raw("<td> baris " + i.ToString + " Kolom B</td>")
            @Html.Raw("<td> baris " + i.ToString + " Kolom C</td>")
            @Html.Raw("</tr>")
        Next

    End Code
</table>

    <ul>
        @code
            Dim j As Integer
            For j = 9 To 1 Step -1
                @:<li>
                    @j
                @:</li>
            Next
        End Code
    </ul>
    @code
        Dim angka As Integer = 13
        Dim pangkat As Integer = 3
        Dim hasil As Integer = 1
        Dim k As Integer
        For k = 1 To pangkat
            hasil = hasil * angka
        Next
        @:hasil
        @angka
        @:pangkat
        @pangkat
        @<text> = </text>
        @hasil
    End Code
</article>

<aside>
    <h3>Aside Title</h3>
    <p>
        Use this area To provide additional information.
    </p>
    <ul>
        <li><a href = "~/" > Home</a></li>
        <li><a href = "~/About" > About</a></li>
        <li><a href = "~/Contact" > Contact</a></li>
    </ul>
</aside>