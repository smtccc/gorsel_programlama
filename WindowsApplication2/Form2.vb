Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        DataGridView1.ColumnCount = 9
        DataGridView1.ColumnHeadersVisible = True

        DataGridView1.Columns(0).Name = "MESLEK"
        DataGridView1.Columns(1).Name = "ÜYELİK TARİHİ"
        DataGridView1.Columns(2).Name = "TC KİMLİK NO"
        DataGridView1.Columns(3).Name = "ADI"
        DataGridView1.Columns(4).Name = "SOYADI"
        DataGridView1.Columns(5).Name = "DOGUM TARİHİ"
        DataGridView1.Columns(6).Name = "CİNSİYET"
        DataGridView1.Columns(7).Name = "AİDAT"

    End Sub
    Private Sub DataGridView1_CellFormatting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles DataGridView1.CellFormatting



    End Sub


    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub


    Public Sub ekle()
        DataGridView1.Rows.Add(TextBox1.Text.ToString(), DateTimePicker1.Text.ToString(), TextBox4.Text.ToString(), TextBox5.Text.ToString(), TextBox6.Text.ToString(), TextBox7.Text.ToString(), DateTimePicker1.Text.ToString(), ComboBox1.Text.ToString(), TextBox4.Text.ToString())
    End Sub


    Public Sub sil()
        Dim i As Integer
        Dim s As String

        s = DataGridView1.SelectedRows.ToString()
        s = ToString(i)
        DataGridView1.Rows.RemoveAt(i)

    End Sub


    Public Sub düzenle()
        Dim index As Integer
        Dim kaydıdüzenle As DataGridViewRow
        kaydıdüzenle = DataGridView1.Rows(index)
        kaydıdüzenle.Cells(0).Value = TextBox1.Text
        kaydıdüzenle.Cells(1).Value = DateTimePicker1.Text
        kaydıdüzenle.Cells(2).Value = TextBox5.Text
        kaydıdüzenle.Cells(3).Value = TextBox6.Text
        kaydıdüzenle.Cells(4).Value = TextBox7.Text
        kaydıdüzenle.Cells(5).Value = DateTimePicker1.Text
        kaydıdüzenle.Cells(6).Value = ComboBox1.Text
        kaydıdüzenle.Cells(7).Value = TextBox4.Text

    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim index As Integer
        index = e.RowIndex
        Dim seçilikayıt As DataGridViewRow
        seçilikayıt = DataGridView1.Rows(index)
        TextBox1.Text = seçilikayıt.Cells(0).Value.ToString()
        DateTimePicker1.Text = seçilikayıt.Cells(1).Value.ToString()
        TextBox5.Text = seçilikayıt.Cells(2).Value.ToString()
        TextBox6.Text = seçilikayıt.Cells(3).Value.ToString()
        TextBox7.Text = seçilikayıt.Cells(4).Value.ToString()
        DateTimePicker2.Text = seçilikayıt.Cells(5).Value.ToString()
        ComboBox1.Text = seçilikayıt.Cells(6).Value.ToString()
        TextBox4.Text = seçilikayıt.Cells(7).Value.ToString()



    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub EKLEBUTTON_Click(sender As Object, e As EventArgs) Handles EKLEBUTTON.Click
        ekle()
    End Sub

    Private Sub SİLButton_Click(sender As Object, e As EventArgs) Handles SİLButton.Click
        sil()

    End Sub

    Private Sub DÜZENLEButton_Click(sender As Object, e As EventArgs) Handles DÜZENLEButton.Click
        düzenle()

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub
End Class