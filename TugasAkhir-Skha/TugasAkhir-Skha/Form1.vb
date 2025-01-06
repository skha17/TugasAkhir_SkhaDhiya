Public Class Form1
    ' Array untuk menyimpan daftar tujuan dan harga tiket
    Dim tujuan() As String = {"Bali", "Yogyakarta", "Bandung"}
    Dim hargaTiket() As Integer = {500000, 300000, 200000}

    ' Event handler untuk tombol Pesan
    Private Sub btnPesan_Click(sender As Object, e As EventArgs) Handles btnPesan.Click
        ' Mendeklarasikan variabel untuk menyimpan data input
        Dim nama As String = txtNama.Text
        Dim noHP As String = txtNoHP.Text
        Dim tujuanPilihan As String = cmbTujuan.SelectedItem.ToString()
        Dim harga As Integer = 0
        Dim jumlah As Integer = Convert.ToInt32(txtJumlah.Text)
        Dim totalHarga As Integer = 0
        Dim pesan As String = btnPesan.Text

        ' Menggunakan perulangan untuk mencari harga tiket berdasarkan tujuan
        For i As Integer = 0 To tujuan.Length - 1
            If tujuanPilihan = tujuan(i) Then
                harga = hargaTiket(i)
                totalHarga = harga * jumlah
                Exit For
            End If
        Next

        ' Menampilkan total harga
        txtTotalHarga.Text = totalHarga.ToString()

        ' Menampilkan informasi pemesanan melalui MessageBox
        MessageBox.Show("Pemesanan berhasil dilakukan!" & vbCrLf &
                        "Nama: " & nama & vbCrLf &
                        "No HP: " & noHP & vbCrLf &
                        "Tujuan: " & tujuanPilihan & vbCrLf &
                        "Jumlah Tiket: " & jumlah & vbCrLf &
                        "Total Harga: " & totalHarga.ToString() & vbCrLf &
                        "Pesan: " & pesan)
    End Sub

    ' Event handler untuk ComboBox Tujuan (untuk menampilkan daftar tujuan)
    Private Sub cmbTujuan_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbTujuan.SelectedIndexChanged
        ' Harga tiket akan otomatis diperbarui setelah tujuan dipilih
        Dim harga As Integer = 0
        For i As Integer = 0 To tujuan.Length - 1
            If cmbTujuan.SelectedItem.ToString() = tujuan(i) Then
                harga = hargaTiket(i)
                txtHarga.Text = harga.ToString()
                Exit For
            End If
        Next
    End Sub

    ' Form Load untuk set default pada beberapa kontrol
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Menambahkan pilihan tujuan pada ComboBox menggunakan perulangan
        For Each item In tujuan
            cmbTujuan.Items.Add(item)
        Next

        ' Set default pilihan tujuan
        cmbTujuan.SelectedIndex = 0  ' Default ke Bali
    End Sub
End Class
