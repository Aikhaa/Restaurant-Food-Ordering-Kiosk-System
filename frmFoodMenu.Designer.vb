<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmFoodMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFoodMenu))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblFood = New System.Windows.Forms.Label()
        Me.btnAddToCart = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnDessert = New System.Windows.Forms.Button()
        Me.pnlMenu = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnDrinks = New System.Windows.Forms.Button()
        Me.btnFood = New System.Windows.Forms.Button()
        Me.btnTYK = New System.Windows.Forms.Button()
        Me.btnKPP = New System.Windows.Forms.Button()
        Me.btnCC = New System.Windows.Forms.Button()
        Me.btnST = New System.Windows.Forms.Button()
        Me.btnPSR = New System.Windows.Forms.Button()
        Me.btnSPT = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.SteelBlue
        Me.Panel1.Controls.Add(Me.lblFood)
        Me.Panel1.Controls.Add(Me.btnAddToCart)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(800, 79)
        Me.Panel1.TabIndex = 0
        '
        'lblFood
        '
        Me.lblFood.AutoSize = True
        Me.lblFood.Font = New System.Drawing.Font("Times New Roman", 39.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFood.Location = New System.Drawing.Point(311, 11)
        Me.lblFood.Name = "lblFood"
        Me.lblFood.Size = New System.Drawing.Size(172, 61)
        Me.lblFood.TabIndex = 1
        Me.lblFood.Text = "FOOD"
        '
        'btnAddToCart
        '
        Me.btnAddToCart.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAddToCart.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnAddToCart.BackColor = System.Drawing.Color.SteelBlue
        Me.btnAddToCart.BackgroundImage = CType(resources.GetObject("btnAddToCart.BackgroundImage"), System.Drawing.Image)
        Me.btnAddToCart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnAddToCart.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddToCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddToCart.Location = New System.Drawing.Point(714, 12)
        Me.btnAddToCart.Margin = New System.Windows.Forms.Padding(0)
        Me.btnAddToCart.MaximumSize = New System.Drawing.Size(70, 60)
        Me.btnAddToCart.Name = "btnAddToCart"
        Me.btnAddToCart.Size = New System.Drawing.Size(70, 60)
        Me.btnAddToCart.TabIndex = 1
        Me.btnAddToCart.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.btnAddToCart.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.ErrorImage = CType(resources.GetObject("PictureBox1.ErrorImage"), System.Drawing.Image)
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.InitialImage = CType(resources.GetObject("PictureBox1.InitialImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(1)
        Me.PictureBox1.MaximumSize = New System.Drawing.Size(259, 280)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(184, 78)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'btnDessert
        '
        Me.btnDessert.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.btnDessert.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDessert.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDessert.Font = New System.Drawing.Font("Times New Roman", 12.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDessert.Location = New System.Drawing.Point(14, 195)
        Me.btnDessert.Margin = New System.Windows.Forms.Padding(1)
        Me.btnDessert.Name = "btnDessert"
        Me.btnDessert.Size = New System.Drawing.Size(93, 46)
        Me.btnDessert.TabIndex = 2
        Me.btnDessert.Text = "DESSERT"
        Me.btnDessert.UseVisualStyleBackColor = False
        '
        'pnlMenu
        '
        Me.pnlMenu.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.pnlMenu.Controls.Add(Me.Label1)
        Me.pnlMenu.Controls.Add(Me.btnDrinks)
        Me.pnlMenu.Controls.Add(Me.btnDessert)
        Me.pnlMenu.Location = New System.Drawing.Point(45, 134)
        Me.pnlMenu.Name = "pnlMenu"
        Me.pnlMenu.Size = New System.Drawing.Size(121, 256)
        Me.pnlMenu.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(17, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 28)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "MENU"
        '
        'btnDrinks
        '
        Me.btnDrinks.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.btnDrinks.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDrinks.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDrinks.Font = New System.Drawing.Font("Times New Roman", 12.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDrinks.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnDrinks.Location = New System.Drawing.Point(14, 134)
        Me.btnDrinks.Margin = New System.Windows.Forms.Padding(1)
        Me.btnDrinks.Name = "btnDrinks"
        Me.btnDrinks.Size = New System.Drawing.Size(93, 46)
        Me.btnDrinks.TabIndex = 3
        Me.btnDrinks.Text = "DRINKS"
        Me.btnDrinks.UseVisualStyleBackColor = False
        '
        'btnFood
        '
        Me.btnFood.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.btnFood.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFood.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFood.Font = New System.Drawing.Font("Times New Roman", 12.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFood.Location = New System.Drawing.Point(58, 208)
        Me.btnFood.Margin = New System.Windows.Forms.Padding(1)
        Me.btnFood.Name = "btnFood"
        Me.btnFood.Size = New System.Drawing.Size(93, 46)
        Me.btnFood.TabIndex = 4
        Me.btnFood.Text = "FOOD"
        Me.btnFood.UseVisualStyleBackColor = False
        '
        'btnTYK
        '
        Me.btnTYK.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnTYK.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnTYK.BackColor = System.Drawing.Color.Beige
        Me.btnTYK.BackgroundImage = CType(resources.GetObject("btnTYK.BackgroundImage"), System.Drawing.Image)
        Me.btnTYK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnTYK.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnTYK.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnTYK.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTYK.Location = New System.Drawing.Point(291, 134)
        Me.btnTYK.Margin = New System.Windows.Forms.Padding(0)
        Me.btnTYK.MaximumSize = New System.Drawing.Size(1000, 1000)
        Me.btnTYK.Name = "btnTYK"
        Me.btnTYK.Size = New System.Drawing.Size(101, 120)
        Me.btnTYK.TabIndex = 2
        Me.btnTYK.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.btnTYK.UseVisualStyleBackColor = False
        '
        'btnKPP
        '
        Me.btnKPP.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnKPP.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnKPP.BackColor = System.Drawing.Color.Beige
        Me.btnKPP.BackgroundImage = CType(resources.GetObject("btnKPP.BackgroundImage"), System.Drawing.Image)
        Me.btnKPP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnKPP.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnKPP.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnKPP.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnKPP.Location = New System.Drawing.Point(427, 134)
        Me.btnKPP.Margin = New System.Windows.Forms.Padding(0)
        Me.btnKPP.MaximumSize = New System.Drawing.Size(1000, 1000)
        Me.btnKPP.Name = "btnKPP"
        Me.btnKPP.Size = New System.Drawing.Size(101, 120)
        Me.btnKPP.TabIndex = 5
        Me.btnKPP.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.btnKPP.UseVisualStyleBackColor = False
        '
        'btnCC
        '
        Me.btnCC.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCC.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnCC.BackColor = System.Drawing.Color.Beige
        Me.btnCC.BackgroundImage = CType(resources.GetObject("btnCC.BackgroundImage"), System.Drawing.Image)
        Me.btnCC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnCC.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCC.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnCC.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCC.Location = New System.Drawing.Point(566, 134)
        Me.btnCC.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCC.MaximumSize = New System.Drawing.Size(1000, 1000)
        Me.btnCC.Name = "btnCC"
        Me.btnCC.Size = New System.Drawing.Size(101, 120)
        Me.btnCC.TabIndex = 6
        Me.btnCC.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.btnCC.UseVisualStyleBackColor = False
        '
        'btnST
        '
        Me.btnST.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnST.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnST.BackColor = System.Drawing.Color.Beige
        Me.btnST.BackgroundImage = CType(resources.GetObject("btnST.BackgroundImage"), System.Drawing.Image)
        Me.btnST.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnST.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnST.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnST.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnST.Location = New System.Drawing.Point(427, 270)
        Me.btnST.Margin = New System.Windows.Forms.Padding(0)
        Me.btnST.MaximumSize = New System.Drawing.Size(1000, 1000)
        Me.btnST.Name = "btnST"
        Me.btnST.Size = New System.Drawing.Size(101, 120)
        Me.btnST.TabIndex = 7
        Me.btnST.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.btnST.UseVisualStyleBackColor = False
        '
        'btnPSR
        '
        Me.btnPSR.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPSR.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnPSR.BackColor = System.Drawing.Color.Beige
        Me.btnPSR.BackgroundImage = CType(resources.GetObject("btnPSR.BackgroundImage"), System.Drawing.Image)
        Me.btnPSR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnPSR.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPSR.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnPSR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPSR.Location = New System.Drawing.Point(566, 270)
        Me.btnPSR.Margin = New System.Windows.Forms.Padding(0)
        Me.btnPSR.MaximumSize = New System.Drawing.Size(1000, 1000)
        Me.btnPSR.Name = "btnPSR"
        Me.btnPSR.Size = New System.Drawing.Size(101, 120)
        Me.btnPSR.TabIndex = 8
        Me.btnPSR.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.btnPSR.UseVisualStyleBackColor = False
        '
        'btnSPT
        '
        Me.btnSPT.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSPT.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnSPT.BackColor = System.Drawing.Color.Beige
        Me.btnSPT.BackgroundImage = CType(resources.GetObject("btnSPT.BackgroundImage"), System.Drawing.Image)
        Me.btnSPT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnSPT.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSPT.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnSPT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSPT.Location = New System.Drawing.Point(291, 270)
        Me.btnSPT.Margin = New System.Windows.Forms.Padding(0)
        Me.btnSPT.MaximumSize = New System.Drawing.Size(1000, 1000)
        Me.btnSPT.Name = "btnSPT"
        Me.btnSPT.Size = New System.Drawing.Size(101, 120)
        Me.btnSPT.TabIndex = 9
        Me.btnSPT.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.btnSPT.UseVisualStyleBackColor = False
        '
        'frmFoodMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Beige
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnSPT)
        Me.Controls.Add(Me.btnPSR)
        Me.Controls.Add(Me.btnST)
        Me.Controls.Add(Me.btnCC)
        Me.Controls.Add(Me.btnKPP)
        Me.Controls.Add(Me.btnTYK)
        Me.Controls.Add(Me.btnFood)
        Me.Controls.Add(Me.pnlMenu)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmFoodMenu"
        Me.Text = "ZenThai"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlMenu.ResumeLayout(False)
        Me.pnlMenu.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnAddToCart As Button
    Friend WithEvents lblFood As Label
    Friend WithEvents btnDessert As Button
    Friend WithEvents pnlMenu As Panel
    Friend WithEvents btnDrinks As Button
    Friend WithEvents btnFood As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btnTYK As Button
    Friend WithEvents btnKPP As Button
    Friend WithEvents btnCC As Button
    Friend WithEvents btnST As Button
    Friend WithEvents btnPSR As Button
    Friend WithEvents btnSPT As Button
End Class
