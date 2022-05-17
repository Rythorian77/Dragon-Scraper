<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.UrlHost = New System.Windows.Forms.TextBox()
        Me.Seeker = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Png = New System.Windows.Forms.CheckBox()
        Me.Tif = New System.Windows.Forms.CheckBox()
        Me.Gif = New System.Windows.Forms.CheckBox()
        Me.Jpg = New System.Windows.Forms.CheckBox()
        Me.Bmp = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Clear = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UrlHost
        '
        Me.UrlHost.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.UrlHost.Font = New System.Drawing.Font("MS Reference Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UrlHost.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.UrlHost.Location = New System.Drawing.Point(207, 174)
        Me.UrlHost.Multiline = True
        Me.UrlHost.Name = "UrlHost"
        Me.UrlHost.Size = New System.Drawing.Size(672, 36)
        Me.UrlHost.TabIndex = 0
        '
        'Seeker
        '
        Me.Seeker.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Seeker.Font = New System.Drawing.Font("MS Reference Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Seeker.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.Seeker.Location = New System.Drawing.Point(910, 166)
        Me.Seeker.Name = "Seeker"
        Me.Seeker.Size = New System.Drawing.Size(181, 48)
        Me.Seeker.TabIndex = 1
        Me.Seeker.Text = "Get Em'"
        Me.Seeker.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("MS Reference Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.Label1.Location = New System.Drawing.Point(169, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(783, 35)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Please Insert The Web Address To Acquire Images"
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(-2, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(144, 139)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Location = New System.Drawing.Point(959, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(144, 139)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 4
        Me.PictureBox2.TabStop = False
        '
        'Png
        '
        Me.Png.AutoSize = True
        Me.Png.Font = New System.Drawing.Font("MS Reference Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Png.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Png.Location = New System.Drawing.Point(322, 109)
        Me.Png.Name = "Png"
        Me.Png.Size = New System.Drawing.Size(84, 30)
        Me.Png.TabIndex = 5
        Me.Png.Text = "PNG"
        Me.Png.UseVisualStyleBackColor = True
        '
        'Tif
        '
        Me.Tif.AutoSize = True
        Me.Tif.Font = New System.Drawing.Font("MS Reference Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tif.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Tif.Location = New System.Drawing.Point(412, 109)
        Me.Tif.Name = "Tif"
        Me.Tif.Size = New System.Drawing.Size(73, 30)
        Me.Tif.TabIndex = 6
        Me.Tif.Text = "TIF"
        Me.Tif.UseVisualStyleBackColor = True
        '
        'Gif
        '
        Me.Gif.AutoSize = True
        Me.Gif.Font = New System.Drawing.Font("MS Reference Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Gif.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Gif.Location = New System.Drawing.Point(491, 109)
        Me.Gif.Name = "Gif"
        Me.Gif.Size = New System.Drawing.Size(77, 30)
        Me.Gif.TabIndex = 7
        Me.Gif.Text = "GIF"
        Me.Gif.UseVisualStyleBackColor = True
        '
        'Jpg
        '
        Me.Jpg.AutoSize = True
        Me.Jpg.Font = New System.Drawing.Font("MS Reference Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Jpg.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Jpg.Location = New System.Drawing.Point(574, 109)
        Me.Jpg.Name = "Jpg"
        Me.Jpg.Size = New System.Drawing.Size(78, 30)
        Me.Jpg.TabIndex = 8
        Me.Jpg.Text = "JPG"
        Me.Jpg.UseVisualStyleBackColor = True
        '
        'Bmp
        '
        Me.Bmp.AutoSize = True
        Me.Bmp.Font = New System.Drawing.Font("MS Reference Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bmp.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Bmp.Location = New System.Drawing.Point(658, 109)
        Me.Bmp.Name = "Bmp"
        Me.Bmp.Size = New System.Drawing.Size(84, 30)
        Me.Bmp.TabIndex = 9
        Me.Bmp.Text = "BMP"
        Me.Bmp.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("MS Reference Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.Label2.Location = New System.Drawing.Point(308, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(443, 28)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Select as many formats as you wish"
        '
        'Clear
        '
        Me.Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Clear.Font = New System.Drawing.Font("MS Reference Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Clear.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.Clear.Location = New System.Drawing.Point(12, 168)
        Me.Clear.Name = "Clear"
        Me.Clear.Size = New System.Drawing.Size(181, 48)
        Me.Clear.TabIndex = 11
        Me.Clear.Text = "Clear Settings"
        Me.Clear.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.TextBox1.Font = New System.Drawing.Font("MS Reference Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.TextBox1.Location = New System.Drawing.Point(12, 335)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox1.Size = New System.Drawing.Size(1079, 333)
        Me.TextBox1.TabIndex = 12
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("MS Reference Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.Label3.Location = New System.Drawing.Point(279, 290)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(538, 28)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "HTML Code Display From Your Web Address"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("MS Reference Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.Label4.Location = New System.Drawing.Point(48, 237)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(1007, 28)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Images and an HTML file will be saved to the desktop in a folder called: Collecti" &
    "on"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(1103, 680)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Clear)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Bmp)
        Me.Controls.Add(Me.Jpg)
        Me.Controls.Add(Me.Gif)
        Me.Controls.Add(Me.Tif)
        Me.Controls.Add(Me.Png)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Seeker)
        Me.Controls.Add(Me.UrlHost)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Dragon Image Scraper"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents UrlHost As TextBox
    Friend WithEvents Seeker As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Png As CheckBox
    Friend WithEvents Tif As CheckBox
    Friend WithEvents Gif As CheckBox
    Friend WithEvents Jpg As CheckBox
    Friend WithEvents Bmp As CheckBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Clear As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
