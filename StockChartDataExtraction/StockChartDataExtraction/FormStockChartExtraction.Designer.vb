<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormStockChartExtraction
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
        Me.txtUrl = New System.Windows.Forms.TextBox()
        Me.btnAccessUrl = New System.Windows.Forms.Button()
        Me.grdProcessedData = New System.Windows.Forms.DataGridView()
        Me.webRawData = New System.Windows.Forms.WebBrowser()
        Me.txtParsedHTML = New System.Windows.Forms.RichTextBox()
        Me.btnExtract = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.masterLink = New System.Windows.Forms.TextBox()
        Me.webMaster = New System.Windows.Forms.WebBrowser()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnLoadMaster = New System.Windows.Forms.Button()
        Me.btnLoadAll = New System.Windows.Forms.Button()
        CType(Me.grdProcessedData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtUrl
        '
        Me.txtUrl.Location = New System.Drawing.Point(813, 21)
        Me.txtUrl.Name = "txtUrl"
        Me.txtUrl.Size = New System.Drawing.Size(248, 20)
        Me.txtUrl.TabIndex = 0
        Me.txtUrl.Text = "http://stockcharts.com/def/servlet/SC.scan?s=TSAL[t.t_eq_s]![as0,20,tv_gt_40000]!" & _
    "[tv0_gt_as1,20,tv*4]![tc0_gt_tc1]&report=predefall"
        '
        'btnAccessUrl
        '
        Me.btnAccessUrl.Location = New System.Drawing.Point(1067, 19)
        Me.btnAccessUrl.Name = "btnAccessUrl"
        Me.btnAccessUrl.Size = New System.Drawing.Size(75, 23)
        Me.btnAccessUrl.TabIndex = 1
        Me.btnAccessUrl.Text = "1# Load"
        Me.btnAccessUrl.UseVisualStyleBackColor = True
        '
        'grdProcessedData
        '
        Me.grdProcessedData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdProcessedData.Location = New System.Drawing.Point(12, 12)
        Me.grdProcessedData.Name = "grdProcessedData"
        Me.grdProcessedData.Size = New System.Drawing.Size(775, 424)
        Me.grdProcessedData.TabIndex = 2
        '
        'webRawData
        '
        Me.webRawData.Location = New System.Drawing.Point(813, 47)
        Me.webRawData.MinimumSize = New System.Drawing.Size(20, 20)
        Me.webRawData.Name = "webRawData"
        Me.webRawData.Size = New System.Drawing.Size(329, 250)
        Me.webRawData.TabIndex = 3
        Me.webRawData.Url = New System.Uri("", System.UriKind.Relative)
        '
        'txtParsedHTML
        '
        Me.txtParsedHTML.Location = New System.Drawing.Point(813, 316)
        Me.txtParsedHTML.Name = "txtParsedHTML"
        Me.txtParsedHTML.Size = New System.Drawing.Size(329, 247)
        Me.txtParsedHTML.TabIndex = 4
        Me.txtParsedHTML.Text = ""
        '
        'btnExtract
        '
        Me.btnExtract.Location = New System.Drawing.Point(813, 570)
        Me.btnExtract.Name = "btnExtract"
        Me.btnExtract.Size = New System.Drawing.Size(75, 23)
        Me.btnExtract.TabIndex = 6
        Me.btnExtract.Text = "2# Extract"
        Me.btnExtract.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(212, 491)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "3# Export"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'masterLink
        '
        Me.masterLink.Location = New System.Drawing.Point(458, 485)
        Me.masterLink.Name = "masterLink"
        Me.masterLink.Size = New System.Drawing.Size(248, 20)
        Me.masterLink.TabIndex = 8
        Me.masterLink.Text = "http://stockcharts.com/def/servlet/SC.scan"
        '
        'webMaster
        '
        Me.webMaster.Location = New System.Drawing.Point(458, 512)
        Me.webMaster.MinimumSize = New System.Drawing.Size(20, 20)
        Me.webMaster.Name = "webMaster"
        Me.webMaster.Size = New System.Drawing.Size(329, 250)
        Me.webMaster.TabIndex = 9
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(42, 490)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 39)
        Me.Button2.TabIndex = 10
        Me.Button2.Text = "#2.5 Select Charts"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'btnLoadMaster
        '
        Me.btnLoadMaster.Location = New System.Drawing.Point(712, 483)
        Me.btnLoadMaster.Name = "btnLoadMaster"
        Me.btnLoadMaster.Size = New System.Drawing.Size(75, 23)
        Me.btnLoadMaster.TabIndex = 11
        Me.btnLoadMaster.Text = "Load"
        Me.btnLoadMaster.UseVisualStyleBackColor = True
        '
        'btnLoadAll
        '
        Me.btnLoadAll.Location = New System.Drawing.Point(122, 593)
        Me.btnLoadAll.Name = "btnLoadAll"
        Me.btnLoadAll.Size = New System.Drawing.Size(75, 23)
        Me.btnLoadAll.TabIndex = 12
        Me.btnLoadAll.Text = "Load All"
        Me.btnLoadAll.UseVisualStyleBackColor = True
        '
        'FormStockChartExtraction
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1172, 801)
        Me.Controls.Add(Me.btnLoadAll)
        Me.Controls.Add(Me.btnLoadMaster)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.webMaster)
        Me.Controls.Add(Me.masterLink)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnExtract)
        Me.Controls.Add(Me.txtParsedHTML)
        Me.Controls.Add(Me.webRawData)
        Me.Controls.Add(Me.grdProcessedData)
        Me.Controls.Add(Me.btnAccessUrl)
        Me.Controls.Add(Me.txtUrl)
        Me.Name = "FormStockChartExtraction"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Stock Chart Extraction"
        CType(Me.grdProcessedData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtUrl As System.Windows.Forms.TextBox
    Friend WithEvents btnAccessUrl As System.Windows.Forms.Button
    Friend WithEvents grdProcessedData As System.Windows.Forms.DataGridView
    Friend WithEvents webRawData As System.Windows.Forms.WebBrowser
    Friend WithEvents txtParsedHTML As System.Windows.Forms.RichTextBox
    Friend WithEvents btnExtract As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents masterLink As System.Windows.Forms.TextBox
    Friend WithEvents webMaster As System.Windows.Forms.WebBrowser
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents btnLoadMaster As System.Windows.Forms.Button
    Friend WithEvents btnLoadAll As System.Windows.Forms.Button

End Class
