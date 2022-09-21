Imports ClosedXML.Excel

Public Class FormStockChartExtraction

    Dim ds As New DataSet
    Dim dt As DataTable = Nothing
    Dim col As Integer = 0


    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles btnAccessUrl.Click
        webRawData.Navigate("about:blank")

        'Do While WebBrowser1.ReadyState <> WebBrowserReadyState.Complete
        '    Application.DoEvents()
        'Loop

        'webRawData.Navigate("http://stockcharts.com/def/servlet/SC.scan")
        webRawData.Navigate(txtUrl.Text)

        Dim oRequest As System.Net.WebRequest
        Dim oResponse As System.Net.WebResponse
        Dim oReader As System.IO.StreamReader
        Dim sResponse As String

        Try
            oRequest = System.Net.WebRequest.Create(txtUrl.Text)
            oResponse = oRequest.GetResponse
            oReader = New System.IO.StreamReader(oResponse.GetResponseStream)
            sResponse = oReader.ReadToEnd
            txtParsedHTML.Text = sResponse
        Catch ex As Exception
            MsgBox("Could not load page. Check url syntax")
        End Try
    End Sub

    Private Sub btnExtract_Click(sender As System.Object, e As System.EventArgs) Handles btnExtract.Click

        Try
            For x As Integer = 1 To webRawData.Document.GetElementsByTagName("table").Count - 1
                'MsgBox("Tables: " & webRawData.Document.GetElementsByTagName("table").Count & "; Active Table: " & x + 1)
                dt = New DataTable(x)
                'need to create an if statement here to use either TD or TH to get the first table from each page so that it is a little more versatile
                Do While col < webRawData.Document.GetElementsByTagName("table").Item(x).GetElementsByTagName("tr").Item(0).GetElementsByTagName("th").Count
                    'MsgBox("Columns: " & webRawData.Document.GetElementsByTagName("table").Item(x).GetElementsByTagName("tr").Item(0).GetElementsByTagName("th").Count & "; Active Column: " & col + 1)
                    dt.Columns.Add(col)
                    col = col + 1
                Loop
                ds.Tables.Add(dt)
                'MsgBox("Columns Generated for table " & x + 1 & " : " & col)
                col = 0
            Next

            'MsgBox("Finished generating number of columns")

            For x As Integer = 1 To webRawData.Document.GetElementsByTagName("table").Count - 1
                'MsgBox(webRawData.Document.GetElementsByTagName("table").Item(x).InnerText)
                For y As Integer = 1 To webRawData.Document.GetElementsByTagName("table").Item(x).GetElementsByTagName("tr").Count - 1
                    'MsgBox(webRawData.Document.GetElementsByTagName("table").Item(x).GetElementsByTagName("tr").Item(y).InnerText)
                    Dim row As DataRow = dt.NewRow
                    For z As Integer = 0 To webRawData.Document.GetElementsByTagName("table").Item(x).GetElementsByTagName("tr").Item(y).GetElementsByTagName("td").Count - 1
                        'MsgBox(webRawData.Document.GetElementsByTagName("table").Item(x).GetElementsByTagName("tr").Item(y).GetElementsByTagName("td").Item(z).InnerText)
                        row(z) = webRawData.Document.GetElementsByTagName("table").Item(x).GetElementsByTagName("tr").Item(y).GetElementsByTagName("td").Item(z).InnerText
                    Next
                    ds.Tables(0).Rows.Add(row)
                Next
            Next
            grdProcessedData.DataSource = ds.Tables(0)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    '    solved it - I had to add the application.doevents so that it actually ran the command on the browser - using sleep, as it appears, stops any code from running so it was never giving the browser a chance to load.

    'The working code for anyones reference is:

    '    Sub TestBrowse(ByVal url As String)
    '        Dim testbrowse As New WebBrowser
    '        testbrowse.Navigate(url)
    '        Do Until testbrowse.ReadyState = WebBrowserReadyState.Complete
    '            Application.DoEvents()
    '        Loop
    '        MsgBox("Status - " & testbrowse.ReadyState.ToString)
    '    End Sub

    'Seems fine to me. I would, however, put some extra check in the loop i.e. some way to "time out" from the loop if the ReadyState never returns Complete. I'm not sure if that could happen but if it happens, you'll end up to endless loop.

    Private Sub Button1_Click_1(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        'just typed this here to store it somewhere. create a webbrowser array and populate a bunch of invisible webbrowsers
        'then create a button that will bring up a pop up window with the browser in it for the specified index/indicator

        ''Dim browser() As WebBrowser = Nothing
        'Dim browserSequence As Integer = 0

        ''For i = 0 To 20
        ''browser(i).Navigate("")
        ''Next
        Try
            Dim wb As New XLWorkbook()
            wb.Worksheets.Add(dt, dt.TableName.ToString)
            wb.SaveAs("C:\Users\James\Desktop\" + dt.TableName.ToString() + ".xlsx")
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try





        'For x As Integer to webMaster
        'load webpae with all the links to each of the scans on it. load the urls to the scans in an array. use the array to programattically populate invisible
        'web browsers. load all the web browsers, extract the data to invisible grids, export grids to excel.
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click

        formChartSelection.Show()
        'Me.Hide()
    End Sub

    Private Sub btnLoadMaster_Click(sender As System.Object, e As System.EventArgs) Handles btnLoadMaster.Click
        webMaster.Navigate("about:blank")
        webMaster.Navigate(masterLink.Text)
    End Sub

    Private Sub btnLoadAll_Click(sender As System.Object, e As System.EventArgs) Handles btnLoadAll.Click
        FormLoadWebpages.Show()
    End Sub
End Class
