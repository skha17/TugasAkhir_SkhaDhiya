<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Panel1 = New Panel()
        Label1 = New Label()
        lblNama = New Label()
        lblNoHP = New Label()
        txtNama = New TextBox()
        txtNoHP = New TextBox()
        lblTujuan = New Label()
        cmbTujuan = New ComboBox()
        lblHarga = New Label()
        txtHarga = New TextBox()
        lblJumlah = New Label()
        txtJumlah = New TextBox()
        lblTotalHarga = New Label()
        txtTotalHarga = New TextBox()
        btnPesan = New Button()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(btnPesan)
        Panel1.Controls.Add(txtTotalHarga)
        Panel1.Controls.Add(lblTotalHarga)
        Panel1.Controls.Add(txtJumlah)
        Panel1.Controls.Add(lblJumlah)
        Panel1.Controls.Add(txtHarga)
        Panel1.Controls.Add(lblHarga)
        Panel1.Controls.Add(cmbTujuan)
        Panel1.Controls.Add(lblTujuan)
        Panel1.Controls.Add(txtNoHP)
        Panel1.Controls.Add(txtNama)
        Panel1.Controls.Add(lblNoHP)
        Panel1.Controls.Add(lblNama)
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(38, 177)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(497, 530)
        Panel1.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Black", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(103, 15)
        Label1.Name = "Label1"
        Label1.Size = New Size(315, 30)
        Label1.TabIndex = 0
        Label1.Text = "Pemesanan Tiket Pariwisata"
        ' 
        ' lblNama
        ' 
        lblNama.AutoSize = True
        lblNama.Location = New Point(44, 92)
        lblNama.Name = "lblNama"
        lblNama.Size = New Size(59, 25)
        lblNama.TabIndex = 1
        lblNama.Text = "Nama"
        ' 
        ' lblNoHP
        ' 
        lblNoHP.AutoSize = True
        lblNoHP.Location = New Point(41, 145)
        lblNoHP.Name = "lblNoHP"
        lblNoHP.Size = New Size(135, 25)
        lblNoHP.TabIndex = 2
        lblNoHP.Text = "No Handphone"
        ' 
        ' txtNama
        ' 
        txtNama.Location = New Point(182, 89)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(287, 31)
        txtNama.TabIndex = 3
        ' 
        ' txtNoHP
        ' 
        txtNoHP.Location = New Point(182, 142)
        txtNoHP.Name = "txtNoHP"
        txtNoHP.Size = New Size(287, 31)
        txtNoHP.TabIndex = 4
        ' 
        ' lblTujuan
        ' 
        lblTujuan.AutoSize = True
        lblTujuan.Location = New Point(44, 207)
        lblTujuan.Name = "lblTujuan"
        lblTujuan.Size = New Size(64, 25)
        lblTujuan.TabIndex = 5
        lblTujuan.Text = "Tujuan"
        ' 
        ' cmbTujuan
        ' 
        cmbTujuan.FormattingEnabled = True
        cmbTujuan.Location = New Point(182, 199)
        cmbTujuan.Name = "cmbTujuan"
        cmbTujuan.Size = New Size(287, 33)
        cmbTujuan.TabIndex = 6
        ' 
        ' lblHarga
        ' 
        lblHarga.AutoSize = True
        lblHarga.Location = New Point(41, 260)
        lblHarga.Name = "lblHarga"
        lblHarga.Size = New Size(102, 25)
        lblHarga.TabIndex = 7
        lblHarga.Text = "Harga Tiket"
        ' 
        ' txtHarga
        ' 
        txtHarga.Location = New Point(182, 257)
        txtHarga.Name = "txtHarga"
        txtHarga.Size = New Size(287, 31)
        txtHarga.TabIndex = 8
        ' 
        ' lblJumlah
        ' 
        lblJumlah.AutoSize = True
        lblJumlah.Location = New Point(41, 317)
        lblJumlah.Name = "lblJumlah"
        lblJumlah.Size = New Size(67, 25)
        lblJumlah.TabIndex = 9
        lblJumlah.Text = "Jumlah"
        ' 
        ' txtJumlah
        ' 
        txtJumlah.Location = New Point(182, 317)
        txtJumlah.Name = "txtJumlah"
        txtJumlah.Size = New Size(287, 31)
        txtJumlah.TabIndex = 10
        ' 
        ' lblTotalHarga
        ' 
        lblTotalHarga.AutoSize = True
        lblTotalHarga.Location = New Point(41, 377)
        lblTotalHarga.Name = "lblTotalHarga"
        lblTotalHarga.Size = New Size(102, 25)
        lblTotalHarga.TabIndex = 11
        lblTotalHarga.Text = "Total Harga"
        ' 
        ' txtTotalHarga
        ' 
        txtTotalHarga.Location = New Point(182, 377)
        txtTotalHarga.Name = "txtTotalHarga"
        txtTotalHarga.Size = New Size(287, 31)
        txtTotalHarga.TabIndex = 12
        ' 
        ' btnPesan
        ' 
        btnPesan.Location = New Point(278, 445)
        btnPesan.Name = "btnPesan"
        btnPesan.Size = New Size(112, 34)
        btnPesan.TabIndex = 13
        btnPesan.Text = "Pesan"
        btnPesan.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.free_photo_of_jalur_indah_di_pegunungan_trentino_alto_adige
        ClientSize = New Size(581, 747)
        Controls.Add(Panel1)
        Name = "Form1"
        Text = "Form1"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtNoHP As TextBox
    Friend WithEvents txtNama As TextBox
    Friend WithEvents lblNoHP As Label
    Friend WithEvents lblNama As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblHarga As Label
    Friend WithEvents cmbTujuan As ComboBox
    Friend WithEvents lblTujuan As Label
    Friend WithEvents btnPesan As Button
    Friend WithEvents txtTotalHarga As TextBox
    Friend WithEvents lblTotalHarga As Label
    Friend WithEvents txtJumlah As TextBox
    Friend WithEvents lblJumlah As Label
    Friend WithEvents txtHarga As TextBox

End Class
