<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.components = New System.ComponentModel.Container()
        Dim AccnoLabel As System.Windows.Forms.Label
        Dim BranchLabel As System.Windows.Forms.Label
        Dim NameLabel As System.Windows.Forms.Label
        Dim AddLabel As System.Windows.Forms.Label
        Dim PhoneLabel As System.Windows.Forms.Label
        Dim AmtLabel As System.Windows.Forms.Label
        Dim DobLabel As System.Windows.Forms.Label
        Dim OccLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Me._MyDatabase_1DataSet = New WindowsApplication1._MyDatabase_1DataSet()
        Me.CustomerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CustomerTableAdapter = New WindowsApplication1._MyDatabase_1DataSetTableAdapters.CustomerTableAdapter()
        Me.TableAdapterManager = New WindowsApplication1._MyDatabase_1DataSetTableAdapters.TableAdapterManager()
        Me.AccnoTextBox = New System.Windows.Forms.TextBox()
        Me.BranchTextBox = New System.Windows.Forms.TextBox()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.AddTextBox = New System.Windows.Forms.TextBox()
        Me.PhoneTextBox = New System.Windows.Forms.TextBox()
        Me.AmtTextBox = New System.Windows.Forms.TextBox()
        Me.DobDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.OccTextBox = New System.Windows.Forms.TextBox()
        Me.BindingNavigator1 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripTextBox1 = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton5 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.BindingNavigator2 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigator3 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel3 = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigator4 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.ToolStripLabel4 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripButton11 = New System.Windows.Forms.ToolStripButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        AccnoLabel = New System.Windows.Forms.Label()
        BranchLabel = New System.Windows.Forms.Label()
        NameLabel = New System.Windows.Forms.Label()
        AddLabel = New System.Windows.Forms.Label()
        PhoneLabel = New System.Windows.Forms.Label()
        AmtLabel = New System.Windows.Forms.Label()
        DobLabel = New System.Windows.Forms.Label()
        OccLabel = New System.Windows.Forms.Label()
        CType(Me._MyDatabase_1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator1.SuspendLayout()
        CType(Me.BindingNavigator2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator2.SuspendLayout()
        CType(Me.BindingNavigator3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator3.SuspendLayout()
        CType(Me.BindingNavigator4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator4.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AccnoLabel
        '
        AccnoLabel.AutoSize = True
        AccnoLabel.Location = New System.Drawing.Point(106, 77)
        AccnoLabel.Name = "AccnoLabel"
        AccnoLabel.Size = New System.Drawing.Size(81, 13)
        AccnoLabel.TabIndex = 1
        AccnoLabel.Text = "ACCOUNT NO:"
        '
        'BranchLabel
        '
        BranchLabel.AutoSize = True
        BranchLabel.Location = New System.Drawing.Point(106, 103)
        BranchLabel.Name = "BranchLabel"
        BranchLabel.Size = New System.Drawing.Size(55, 13)
        BranchLabel.TabIndex = 3
        BranchLabel.Text = "BRANCH:"
        '
        'NameLabel
        '
        NameLabel.AutoSize = True
        NameLabel.Location = New System.Drawing.Point(106, 133)
        NameLabel.Name = "NameLabel"
        NameLabel.Size = New System.Drawing.Size(41, 13)
        NameLabel.TabIndex = 5
        NameLabel.Text = "NAME:"
        '
        'AddLabel
        '
        AddLabel.AutoSize = True
        AddLabel.Location = New System.Drawing.Point(106, 159)
        AddLabel.Name = "AddLabel"
        AddLabel.Size = New System.Drawing.Size(62, 13)
        AddLabel.TabIndex = 7
        AddLabel.Text = "ADDRESS:"
        '
        'PhoneLabel
        '
        PhoneLabel.AutoSize = True
        PhoneLabel.Location = New System.Drawing.Point(106, 185)
        PhoneLabel.Name = "PhoneLabel"
        PhoneLabel.Size = New System.Drawing.Size(48, 13)
        PhoneLabel.TabIndex = 9
        PhoneLabel.Text = "PHONE:"
        '
        'AmtLabel
        '
        AmtLabel.AutoSize = True
        AmtLabel.Location = New System.Drawing.Point(107, 211)
        AmtLabel.Name = "AmtLabel"
        AmtLabel.Size = New System.Drawing.Size(57, 13)
        AmtLabel.TabIndex = 11
        AmtLabel.Text = "AMOUNT:"
        '
        'DobLabel
        '
        DobLabel.AutoSize = True
        DobLabel.Location = New System.Drawing.Point(96, 234)
        DobLabel.Name = "DobLabel"
        DobLabel.Size = New System.Drawing.Size(92, 13)
        DobLabel.TabIndex = 13
        DobLabel.Text = "DATE OF BIRTH:"
        '
        'OccLabel
        '
        OccLabel.AutoSize = True
        OccLabel.Location = New System.Drawing.Point(106, 259)
        OccLabel.Name = "OccLabel"
        OccLabel.Size = New System.Drawing.Size(80, 13)
        OccLabel.TabIndex = 15
        OccLabel.Text = "OCCUPATION:"
        '
        '_MyDatabase_1DataSet
        '
        Me._MyDatabase_1DataSet.DataSetName = "_MyDatabase_1DataSet"
        Me._MyDatabase_1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CustomerBindingSource
        '
        Me.CustomerBindingSource.DataMember = "Customer"
        Me.CustomerBindingSource.DataSource = Me._MyDatabase_1DataSet
        '
        'CustomerTableAdapter
        '
        Me.CustomerTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CustomerTableAdapter = Me.CustomerTableAdapter
        Me.TableAdapterManager.UpdateOrder = WindowsApplication1._MyDatabase_1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'AccnoTextBox
        '
        Me.AccnoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "accno", True))
        Me.AccnoTextBox.Location = New System.Drawing.Point(192, 74)
        Me.AccnoTextBox.Name = "AccnoTextBox"
        Me.AccnoTextBox.Size = New System.Drawing.Size(200, 20)
        Me.AccnoTextBox.TabIndex = 2
        '
        'BranchTextBox
        '
        Me.BranchTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "branch", True))
        Me.BranchTextBox.Location = New System.Drawing.Point(192, 100)
        Me.BranchTextBox.Name = "BranchTextBox"
        Me.BranchTextBox.Size = New System.Drawing.Size(200, 20)
        Me.BranchTextBox.TabIndex = 4
        '
        'NameTextBox
        '
        Me.NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "name", True))
        Me.NameTextBox.Location = New System.Drawing.Point(192, 126)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(200, 20)
        Me.NameTextBox.TabIndex = 6
        '
        'AddTextBox
        '
        Me.AddTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "add", True))
        Me.AddTextBox.Location = New System.Drawing.Point(192, 152)
        Me.AddTextBox.Name = "AddTextBox"
        Me.AddTextBox.Size = New System.Drawing.Size(200, 20)
        Me.AddTextBox.TabIndex = 8
        '
        'PhoneTextBox
        '
        Me.PhoneTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "phone", True))
        Me.PhoneTextBox.Location = New System.Drawing.Point(192, 178)
        Me.PhoneTextBox.Name = "PhoneTextBox"
        Me.PhoneTextBox.Size = New System.Drawing.Size(200, 20)
        Me.PhoneTextBox.TabIndex = 10
        '
        'AmtTextBox
        '
        Me.AmtTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "amt", True))
        Me.AmtTextBox.Location = New System.Drawing.Point(192, 204)
        Me.AmtTextBox.Name = "AmtTextBox"
        Me.AmtTextBox.Size = New System.Drawing.Size(200, 20)
        Me.AmtTextBox.TabIndex = 12
        '
        'DobDateTimePicker
        '
        Me.DobDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.CustomerBindingSource, "dob", True))
        Me.DobDateTimePicker.Location = New System.Drawing.Point(192, 230)
        Me.DobDateTimePicker.Name = "DobDateTimePicker"
        Me.DobDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.DobDateTimePicker.TabIndex = 14
        '
        'OccTextBox
        '
        Me.OccTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "occ", True))
        Me.OccTextBox.Location = New System.Drawing.Point(192, 256)
        Me.OccTextBox.Name = "OccTextBox"
        Me.OccTextBox.Size = New System.Drawing.Size(200, 20)
        Me.OccTextBox.TabIndex = 16
        '
        'BindingNavigator1
        '
        Me.BindingNavigator1.AddNewItem = Nothing
        Me.BindingNavigator1.BindingSource = Me.CustomerBindingSource
        Me.BindingNavigator1.CountItem = Me.ToolStripLabel1
        Me.BindingNavigator1.DeleteItem = Nothing
        Me.BindingNavigator1.Dock = System.Windows.Forms.DockStyle.None
        Me.BindingNavigator1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton4, Me.ToolStripSeparator1, Me.ToolStripTextBox1, Me.ToolStripLabel1, Me.ToolStripSeparator2, Me.ToolStripButton5, Me.ToolStripSeparator3})
        Me.BindingNavigator1.Location = New System.Drawing.Point(209, 288)
        Me.BindingNavigator1.MoveFirstItem = Nothing
        Me.BindingNavigator1.MoveLastItem = Nothing
        Me.BindingNavigator1.MoveNextItem = Me.ToolStripButton5
        Me.BindingNavigator1.MovePreviousItem = Me.ToolStripButton4
        Me.BindingNavigator1.Name = "BindingNavigator1"
        Me.BindingNavigator1.PositionItem = Me.ToolStripTextBox1
        Me.BindingNavigator1.Size = New System.Drawing.Size(163, 25)
        Me.BindingNavigator1.TabIndex = 17
        Me.BindingNavigator1.Text = "BindingNavigator1"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(35, 22)
        Me.ToolStripLabel1.Text = "of {0}"
        Me.ToolStripLabel1.ToolTipText = "Total number of items"
        '
        'ToolStripButton4
        '
        Me.ToolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton4.Image = CType(resources.GetObject("ToolStripButton4.Image"), System.Drawing.Image)
        Me.ToolStripButton4.Name = "ToolStripButton4"
        Me.ToolStripButton4.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton4.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton4.Text = "Move previous"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripTextBox1
        '
        Me.ToolStripTextBox1.AccessibleName = "Position"
        Me.ToolStripTextBox1.AutoSize = False
        Me.ToolStripTextBox1.Name = "ToolStripTextBox1"
        Me.ToolStripTextBox1.Size = New System.Drawing.Size(50, 23)
        Me.ToolStripTextBox1.Text = "0"
        Me.ToolStripTextBox1.ToolTipText = "Current position"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton5
        '
        Me.ToolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton5.Image = CType(resources.GetObject("ToolStripButton5.Image"), System.Drawing.Image)
        Me.ToolStripButton5.Name = "ToolStripButton5"
        Me.ToolStripButton5.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton5.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton5.Text = "Move next"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(96, 326)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 18
        Me.Button1.Text = "Back"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(350, 326)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 19
        Me.Button2.Text = "Records"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'BindingNavigator2
        '
        Me.BindingNavigator2.AddNewItem = Me.ToolStripButton1
        Me.BindingNavigator2.BindingSource = Me.CustomerBindingSource
        Me.BindingNavigator2.CountItem = Nothing
        Me.BindingNavigator2.DeleteItem = Nothing
        Me.BindingNavigator2.Dock = System.Windows.Forms.DockStyle.None
        Me.BindingNavigator2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel2, Me.ToolStripButton1})
        Me.BindingNavigator2.Location = New System.Drawing.Point(23, 288)
        Me.BindingNavigator2.MoveFirstItem = Nothing
        Me.BindingNavigator2.MoveLastItem = Nothing
        Me.BindingNavigator2.MoveNextItem = Nothing
        Me.BindingNavigator2.MovePreviousItem = Nothing
        Me.BindingNavigator2.Name = "BindingNavigator2"
        Me.BindingNavigator2.PositionItem = Nothing
        Me.BindingNavigator2.Size = New System.Drawing.Size(66, 25)
        Me.BindingNavigator2.TabIndex = 20
        Me.BindingNavigator2.Text = "BindingNavigator1"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton1.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton1.Text = "Add new"
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(31, 22)
        Me.ToolStripLabel2.Text = "ADD"
        '
        'BindingNavigator3
        '
        Me.BindingNavigator3.AddNewItem = Nothing
        Me.BindingNavigator3.BindingSource = Me.CustomerBindingSource
        Me.BindingNavigator3.CountItem = Nothing
        Me.BindingNavigator3.DeleteItem = Me.ToolStripButton3
        Me.BindingNavigator3.Dock = System.Windows.Forms.DockStyle.None
        Me.BindingNavigator3.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel3, Me.ToolStripButton3})
        Me.BindingNavigator3.Location = New System.Drawing.Point(113, 288)
        Me.BindingNavigator3.MoveFirstItem = Nothing
        Me.BindingNavigator3.MoveLastItem = Nothing
        Me.BindingNavigator3.MoveNextItem = Nothing
        Me.BindingNavigator3.MovePreviousItem = Nothing
        Me.BindingNavigator3.Name = "BindingNavigator3"
        Me.BindingNavigator3.PositionItem = Nothing
        Me.BindingNavigator3.Size = New System.Drawing.Size(62, 25)
        Me.BindingNavigator3.TabIndex = 21
        Me.BindingNavigator3.Text = "BindingNavigator1"
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton3.Image = CType(resources.GetObject("ToolStripButton3.Image"), System.Drawing.Image)
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton3.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton3.Text = "Delete"
        '
        'ToolStripLabel3
        '
        Me.ToolStripLabel3.Name = "ToolStripLabel3"
        Me.ToolStripLabel3.Size = New System.Drawing.Size(27, 22)
        Me.ToolStripLabel3.Text = "DEL"
        '
        'BindingNavigator4
        '
        Me.BindingNavigator4.AddNewItem = Nothing
        Me.BindingNavigator4.BindingSource = Me.CustomerBindingSource
        Me.BindingNavigator4.CountItem = Nothing
        Me.BindingNavigator4.DeleteItem = Nothing
        Me.BindingNavigator4.Dock = System.Windows.Forms.DockStyle.None
        Me.BindingNavigator4.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel4, Me.ToolStripButton11})
        Me.BindingNavigator4.Location = New System.Drawing.Point(415, 288)
        Me.BindingNavigator4.MoveFirstItem = Nothing
        Me.BindingNavigator4.MoveLastItem = Nothing
        Me.BindingNavigator4.MoveNextItem = Nothing
        Me.BindingNavigator4.MovePreviousItem = Nothing
        Me.BindingNavigator4.Name = "BindingNavigator4"
        Me.BindingNavigator4.PositionItem = Nothing
        Me.BindingNavigator4.Size = New System.Drawing.Size(69, 25)
        Me.BindingNavigator4.TabIndex = 22
        Me.BindingNavigator4.Text = "BindingNavigator1"
        '
        'ToolStripLabel4
        '
        Me.ToolStripLabel4.Name = "ToolStripLabel4"
        Me.ToolStripLabel4.Size = New System.Drawing.Size(34, 22)
        Me.ToolStripLabel4.Text = "SAVE"
        '
        'ToolStripButton11
        '
        Me.ToolStripButton11.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton11.Image = CType(resources.GetObject("ToolStripButton11.Image"), System.Drawing.Image)
        Me.ToolStripButton11.Name = "ToolStripButton11"
        Me.ToolStripButton11.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton11.Text = "Save Data"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(131, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(252, 25)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Enter The Customer Details"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.WindowsApplication1.My.Resources.Resources._1365027927_Users_Group
        Me.PictureBox1.Location = New System.Drawing.Point(25, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 50)
        Me.PictureBox1.TabIndex = 24
        Me.PictureBox1.TabStop = False
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(560, 376)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BindingNavigator4)
        Me.Controls.Add(Me.BindingNavigator3)
        Me.Controls.Add(Me.BindingNavigator2)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.BindingNavigator1)
        Me.Controls.Add(AccnoLabel)
        Me.Controls.Add(Me.AccnoTextBox)
        Me.Controls.Add(BranchLabel)
        Me.Controls.Add(Me.BranchTextBox)
        Me.Controls.Add(NameLabel)
        Me.Controls.Add(Me.NameTextBox)
        Me.Controls.Add(AddLabel)
        Me.Controls.Add(Me.AddTextBox)
        Me.Controls.Add(PhoneLabel)
        Me.Controls.Add(Me.PhoneTextBox)
        Me.Controls.Add(AmtLabel)
        Me.Controls.Add(Me.AmtTextBox)
        Me.Controls.Add(DobLabel)
        Me.Controls.Add(Me.DobDateTimePicker)
        Me.Controls.Add(OccLabel)
        Me.Controls.Add(Me.OccTextBox)
        Me.Name = "Form3"
        Me.Text = "Form3"
        CType(Me._MyDatabase_1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator1.ResumeLayout(False)
        Me.BindingNavigator1.PerformLayout()
        CType(Me.BindingNavigator2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator2.ResumeLayout(False)
        Me.BindingNavigator2.PerformLayout()
        CType(Me.BindingNavigator3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator3.ResumeLayout(False)
        Me.BindingNavigator3.PerformLayout()
        CType(Me.BindingNavigator4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator4.ResumeLayout(False)
        Me.BindingNavigator4.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents _MyDatabase_1DataSet As WindowsApplication1._MyDatabase_1DataSet
    Friend WithEvents CustomerBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CustomerTableAdapter As WindowsApplication1._MyDatabase_1DataSetTableAdapters.CustomerTableAdapter
    Friend WithEvents TableAdapterManager As WindowsApplication1._MyDatabase_1DataSetTableAdapters.TableAdapterManager
    Friend WithEvents AccnoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BranchTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AddTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PhoneTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AmtTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DobDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents OccTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BindingNavigator1 As System.Windows.Forms.BindingNavigator
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripButton4 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripTextBox1 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton5 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents BindingNavigator2 As System.Windows.Forms.BindingNavigator
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripLabel2 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigator3 As System.Windows.Forms.BindingNavigator
    Friend WithEvents ToolStripButton3 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripLabel3 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigator4 As System.Windows.Forms.BindingNavigator
    Friend WithEvents ToolStripLabel4 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripButton11 As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
