Imports ClosedXML.Excel

Public Class FormLoadWebpages

    Dim ds As New DataSet
    Dim dt As DataTable = Nothing
    Dim col As Integer = 0

    Dim formtest As New Form


    Private Sub FormLoadWebpages_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        '*** Technical Indicators (Bullish)

        If My.Settings.vTBuNew52WeekHighs = True Then
            webTBuNew52WeekHighs.Navigate(lTBuNew52WeekHighs)
            AddHandler webTBuNew52WeekHighs.ProgressChanged, AddressOf lpbTBuNew52WeekHighs
        End If

        If My.Settings.vTBuStrongVolumeGainers = True Then
            webTBuStrongVolumeGainers.Navigate(lTBuStrongVolumeGainers)
            AddHandler webTBuStrongVolumeGainers.ProgressChanged, AddressOf lpbTBuStrongVolumeGainers
        End If

        If My.Settings.vTBuBullish50200DayMACrossovers = True Then
            webTBuBullish50200DayMACrossovers.Navigate(lTBuBullish50200DayMACrossovers)
            AddHandler webTBuBullish50200DayMACrossovers.ProgressChanged, AddressOf lpbTBuBullish50200DayMACrossovers
        End If

        If My.Settings.vTBuBullishMACDCrossovers = True Then
            webTBuBullishMACDCrossovers.Navigate(lTBuBullishMACDCrossovers)
            AddHandler webTBuBullishMACDCrossovers.ProgressChanged, AddressOf lpbTBuBullishMACDCrossovers
        End If

        If My.Settings.vTBuOversoldWithAnImprovingRSI = True Then
            webTBuOversoldWithAnImprovingRSI.Navigate(lTBuOversoldWithAnImprovingRSI)
            AddHandler webTBuOversoldWithAnImprovingRSI.ProgressChanged, AddressOf lpbTBuOversoldWithAnImprovingRSI
        End If

        If My.Settings.vTBuMovedAboveUpperBollingerBand = True Then
            webTBuMovedAboveUpperBollingerBand.Navigate(lTBuMovedAboveUpperBollingerBand)
            AddHandler webTBuMovedAboveUpperBollingerBand.ProgressChanged, AddressOf lpbTBuMovedAboveUpperBollingerBand
        End If

        If My.Settings.vTBuMovedAboveUpperPriceChannel = True Then
            webTBuMovedAboveUpperPriceChannel.Navigate(lTBuMovedAboveUpperPriceChannel)
            AddHandler webTBuMovedAboveUpperPriceChannel.ProgressChanged, AddressOf lpbTBuMovedAboveUpperPriceChannel
        End If

        If My.Settings.vTBuMovedAboveUpperKeltnerChannel = True Then
            webTBuMovedAboveUpperKeltnerChannel.Navigate(lTBuMovedAboveUpperKeltnerChannel)
            AddHandler webTBuMovedAboveUpperKeltnerChannel.ProgressChanged, AddressOf lpbTBuMovedAboveUpperKeltnerChannel
        End If

        If My.Settings.vTBuImprovingChaikinMoneyFlow = True Then
            webTBuImprovingChaikinMoneyFlow.Navigate(lTBuImprovingChaikinMoneyFlow)
            AddHandler webTBuImprovingChaikinMoneyFlow.ProgressChanged, AddressOf lpbTBuImprovingChaikinMoneyFlow
        End If

        If My.Settings.vTBuNewCCIBuySignals = True Then
            webTBuNewCCIBuySignals.Navigate(lTBuNewCCIBuySignals)
            AddHandler webTBuNewCCIBuySignals.ProgressChanged, AddressOf lpbTBuNewCCIBuySignals
        End If

        If My.Settings.vTBuParabolicSARBuySignals = True Then
            webTBuParabolicSARBuySignals.Navigate(lTBuParabolicSARBuySignals)
            AddHandler webTBuParabolicSARBuySignals.ProgressChanged, AddressOf lpbTBuParabolicSARBuySignals
        End If

        If My.Settings.vTBuStocksInANewUptrendAroon = True Then
            webTBuStocksInANewUptrendAroon.Navigate(lTBuStocksInANewUptrendAroon)
            AddHandler webTBuStocksInANewUptrendAroon.ProgressChanged, AddressOf lpbTBuStocksInANewUptrendAroon
        End If

        If My.Settings.vTBuStocksInANewUptrendADX = True Then
            webTBuStocksInANewUptrendADX.Navigate(lTBuStocksInANewUptrendADX)
            AddHandler webTBuStocksInANewUptrendADX.ProgressChanged, AddressOf lpbTBuStocksInANewUptrendADX
        End If

        If My.Settings.vTBuGapUps = True Then
            webTBuGapUps.Navigate(lTBuGapUps)
            AddHandler webTBuGapUps.ProgressChanged, AddressOf lpbTBuGapUps
        End If

        If My.Settings.vTBuBreakawayGapUps = True Then
            webTBuBreakawayGapUps.Navigate(lTBuBreakawayGapUps)
            AddHandler webTBuBreakawayGapUps.ProgressChanged, AddressOf lpbTBuBreakawayGapUps
        End If

        If My.Settings.vTBuRunawayGapUps = True Then
            webTBuRunawayGapUps.Navigate(lTBuRunawayGapUps)
            AddHandler webTBuRunawayGapUps.ProgressChanged, AddressOf lpbTBuRunawayGapUps
        End If

        If My.Settings.vTBuIslandBottoms = True Then
            webTBuIslandBottoms.Navigate(lTBuIslandBottoms)
            AddHandler webTBuIslandBottoms.ProgressChanged, AddressOf lpbTBuIslandBottoms
        End If

        '*** Technical Indicators (Bearish)



        '*** Candlestick Patterns



        '*** P&F Patterns (Bullish)



        '*** P&F Patterns (Bearish)


    End Sub

#Region "Technical Indicators (Bullish) Progress Bar Handlers"

    Private Sub lpbTBuNew52WeekHighs(ByVal sender As Object, ByVal e As System.Windows.Forms.WebBrowserProgressChangedEventArgs)
        Try
            prgTBuNew52WeekHighs.Maximum = e.MaximumProgress
            prgTBuNew52WeekHighs.Value = e.CurrentProgress

            If prgTBuNew52WeekHighs.Value = prgTBuNew52WeekHighs.Maximum Then
                RemoveHandler webTBuNew52WeekHighs.ProgressChanged, AddressOf lpbTBuNew52WeekHighs
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub lpbTBuStrongVolumeGainers(ByVal sender As Object, ByVal e As System.Windows.Forms.WebBrowserProgressChangedEventArgs)
        Try
            prgTBuStrongVolumeGainers.Maximum = e.MaximumProgress
            prgTBuStrongVolumeGainers.Value = e.CurrentProgress

            If prgTBuStrongVolumeGainers.Value = prgTBuStrongVolumeGainers.Maximum Then
                RemoveHandler webTBuStrongVolumeGainers.ProgressChanged, AddressOf lpbTBuStrongVolumeGainers
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub lpbTBuBullish50200DayMACrossovers(ByVal sender As Object, ByVal e As System.Windows.Forms.WebBrowserProgressChangedEventArgs)
        Try
            prgTBuBullish50200DayMACrossovers.Maximum = e.MaximumProgress
            prgTBuBullish50200DayMACrossovers.Value = e.CurrentProgress

            If prgTBuBullish50200DayMACrossovers.Value = prgTBuBullish50200DayMACrossovers.Maximum Then
                RemoveHandler webTBuBullish50200DayMACrossovers.ProgressChanged, AddressOf lpbTBuBullish50200DayMACrossovers
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub lpbTBuBullishMACDCrossovers(ByVal sender As Object, ByVal e As System.Windows.Forms.WebBrowserProgressChangedEventArgs)
        Try
            prgTBuBullishMACDCrossovers.Maximum = e.MaximumProgress
            prgTBuBullishMACDCrossovers.Value = e.CurrentProgress

            If prgTBuBullishMACDCrossovers.Value = prgTBuBullishMACDCrossovers.Maximum Then
                RemoveHandler webTBuBullishMACDCrossovers.ProgressChanged, AddressOf lpbTBuBullishMACDCrossovers
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub lpbTBuOversoldWithAnImprovingRSI(ByVal sender As Object, ByVal e As System.Windows.Forms.WebBrowserProgressChangedEventArgs)
        Try
            prgTBuOversoldWithAnImprovingRSI.Maximum = e.MaximumProgress
            prgTBuOversoldWithAnImprovingRSI.Value = e.CurrentProgress

            If prgTBuOversoldWithAnImprovingRSI.Value = prgTBuOversoldWithAnImprovingRSI.Maximum Then
                RemoveHandler webTBuOversoldWithAnImprovingRSI.ProgressChanged, AddressOf lpbTBuOversoldWithAnImprovingRSI
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub lpbTBuMovedAboveUpperBollingerBand(ByVal sender As Object, ByVal e As System.Windows.Forms.WebBrowserProgressChangedEventArgs)
        Try
            prgTBuMovedAboveUpperBollingerBand.Maximum = e.MaximumProgress
            prgTBuMovedAboveUpperBollingerBand.Value = e.CurrentProgress

            If prgTBuMovedAboveUpperBollingerBand.Value = prgTBuMovedAboveUpperBollingerBand.Maximum Then
                RemoveHandler webTBuMovedAboveUpperBollingerBand.ProgressChanged, AddressOf lpbTBuMovedAboveUpperBollingerBand
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub lpbTBuMovedAboveUpperPriceChannel(ByVal sender As Object, ByVal e As System.Windows.Forms.WebBrowserProgressChangedEventArgs)
        Try
            prgTBuMovedAboveUpperPriceChannel.Maximum = e.MaximumProgress
            prgTBuMovedAboveUpperPriceChannel.Value = e.CurrentProgress

            If prgTBuMovedAboveUpperPriceChannel.Value = prgTBuMovedAboveUpperPriceChannel.Maximum Then
                RemoveHandler webTBuMovedAboveUpperPriceChannel.ProgressChanged, AddressOf lpbTBuMovedAboveUpperPriceChannel
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub lpbTBuMovedAboveUpperKeltnerChannel(ByVal sender As Object, ByVal e As System.Windows.Forms.WebBrowserProgressChangedEventArgs)
        Try
            prgTBuMovedAboveUpperKeltnerChannel.Maximum = e.MaximumProgress
            prgTBuMovedAboveUpperKeltnerChannel.Value = e.CurrentProgress

            If prgTBuMovedAboveUpperKeltnerChannel.Value = prgTBuMovedAboveUpperKeltnerChannel.Maximum Then
                RemoveHandler webTBuMovedAboveUpperKeltnerChannel.ProgressChanged, AddressOf lpbTBuMovedAboveUpperKeltnerChannel
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub lpbTBuImprovingChaikinMoneyFlow(ByVal sender As Object, ByVal e As System.Windows.Forms.WebBrowserProgressChangedEventArgs)
        Try
            prgTBuImprovingChaikinMoneyFlow.Maximum = e.MaximumProgress
            prgTBuImprovingChaikinMoneyFlow.Value = e.CurrentProgress

            If prgTBuImprovingChaikinMoneyFlow.Value = prgTBuImprovingChaikinMoneyFlow.Maximum Then
                RemoveHandler webTBuImprovingChaikinMoneyFlow.ProgressChanged, AddressOf lpbTBuImprovingChaikinMoneyFlow
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub lpbTBuNewCCIBuySignals(ByVal sender As Object, ByVal e As System.Windows.Forms.WebBrowserProgressChangedEventArgs)
        Try
            prgTBuNewCCIBuySignals.Maximum = e.MaximumProgress
            prgTBuNewCCIBuySignals.Value = e.CurrentProgress

            If prgTBuNewCCIBuySignals.Value = prgTBuNewCCIBuySignals.Maximum Then
                RemoveHandler webTBuNewCCIBuySignals.ProgressChanged, AddressOf lpbTBuNewCCIBuySignals
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub lpbTBuParabolicSARBuySignals(ByVal sender As Object, ByVal e As System.Windows.Forms.WebBrowserProgressChangedEventArgs)
        Try
            prgTBuParabolicSARBuySignals.Maximum = e.MaximumProgress
            prgTBuParabolicSARBuySignals.Value = e.CurrentProgress

            If prgTBuParabolicSARBuySignals.Value = prgTBuParabolicSARBuySignals.Maximum Then
                RemoveHandler webTBuParabolicSARBuySignals.ProgressChanged, AddressOf lpbTBuParabolicSARBuySignals
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub lpbTBuStocksInANewUptrendAroon(ByVal sender As Object, ByVal e As System.Windows.Forms.WebBrowserProgressChangedEventArgs)
        Try
            prgTBuStocksInANewUptrendAroon.Maximum = e.MaximumProgress
            prgTBuStocksInANewUptrendAroon.Value = e.CurrentProgress

            If prgTBuStocksInANewUptrendAroon.Value = prgTBuStocksInANewUptrendAroon.Maximum Then
                RemoveHandler webTBuStocksInANewUptrendAroon.ProgressChanged, AddressOf lpbTBuStocksInANewUptrendAroon
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub lpbTBuStocksInANewUptrendADX(ByVal sender As Object, ByVal e As System.Windows.Forms.WebBrowserProgressChangedEventArgs)
        Try
            prgTBuStocksInANewUptrendADX.Maximum = e.MaximumProgress
            prgTBuStocksInANewUptrendADX.Value = e.CurrentProgress

            If prgTBuStocksInANewUptrendADX.Value = prgTBuStocksInANewUptrendADX.Maximum Then
                RemoveHandler webTBuStocksInANewUptrendADX.ProgressChanged, AddressOf lpbTBuStocksInANewUptrendADX
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub lpbTBuGapUps(ByVal sender As Object, ByVal e As System.Windows.Forms.WebBrowserProgressChangedEventArgs)
        Try
            prgTBuGapUps.Maximum = e.MaximumProgress
            prgTBuGapUps.Value = e.CurrentProgress

            If prgTBuGapUps.Value = prgTBuGapUps.Maximum Then
                RemoveHandler webTBuGapUps.ProgressChanged, AddressOf lpbTBuGapUps
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub lpbTBuBreakawayGapUps(ByVal sender As Object, ByVal e As System.Windows.Forms.WebBrowserProgressChangedEventArgs)
        Try
            prgTBuBreakawayGapUps.Maximum = e.MaximumProgress
            prgTBuBreakawayGapUps.Value = e.CurrentProgress

            If prgTBuBreakawayGapUps.Value = prgTBuBreakawayGapUps.Maximum Then
                RemoveHandler webTBuBreakawayGapUps.ProgressChanged, AddressOf lpbTBuBreakawayGapUps
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub lpbTBuRunawayGapUps(ByVal sender As Object, ByVal e As System.Windows.Forms.WebBrowserProgressChangedEventArgs)
        Try
            prgTBuRunawayGapUps.Maximum = e.MaximumProgress
            prgTBuRunawayGapUps.Value = e.CurrentProgress

            If prgTBuRunawayGapUps.Value = prgTBuRunawayGapUps.Maximum Then
                RemoveHandler webTBuRunawayGapUps.ProgressChanged, AddressOf lpbTBuRunawayGapUps
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub lpbTBuIslandBottoms(ByVal sender As Object, ByVal e As System.Windows.Forms.WebBrowserProgressChangedEventArgs)
        Try
            prgTBuIslandBottoms.Maximum = e.MaximumProgress
            prgTBuIslandBottoms.Value = e.CurrentProgress

            If prgTBuIslandBottoms.Value = prgTBuIslandBottoms.Maximum Then
                RemoveHandler webTBuIslandBottoms.ProgressChanged, AddressOf lpbTBuIslandBottoms
            End If
        Catch ex As Exception
        End Try
    End Sub

#End Region

#Region "Technical Indicators (Bullish) Display Browser Buttons"

    Private Sub btnTBuNew52WeekHighs_Click(sender As System.Object, e As System.EventArgs) Handles btnTBuNew52WeekHighs.Click, Button9.Click, Button8.Click, Button7.Click, Button6.Click, Button5.Click, Button4.Click, Button3.Click, Button2.Click, Button16.Click, Button15.Click, Button14.Click, Button13.Click, Button12.Click, Button11.Click, Button10.Click, Button1.Click
        formtest.Controls.Add(webTBuNew52WeekHighs)
        formtest.Size = New Size(600, 600)
        webTBuNew52WeekHighs.Dock = DockStyle.Fill
        webTBuNew52WeekHighs.BringToFront()
        formtest.Show()
        AddHandler formtest.FormClosing, AddressOf formtest_FormClosing
    End Sub

#End Region

#Region "Technical Indicators (Bullish) Close Browser Windows"

    Private Sub formtest_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs)
        Try
            e.Cancel = True
            formtest.Hide()
            RemoveHandler formtest.FormClosing, AddressOf formtest_FormClosing
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

#End Region

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles btnExportToExcel.Click
        Try
            For x As Integer = 1 To webTBuNew52WeekHighs.Document.GetElementsByTagName("table").Count - 1
                dt = New DataTable(x)
                Do While col < webTBuNew52WeekHighs.Document.GetElementsByTagName("table").Item(x).GetElementsByTagName("tr").Item(0).GetElementsByTagName("th").Count
                    dt.Columns.Add(col)
                    col = col + 1
                Loop
                ds.Tables.Add(dt)
                col = 0
            Next

            For x As Integer = 1 To webTBuNew52WeekHighs.Document.GetElementsByTagName("table").Count - 1
                For y As Integer = 1 To webTBuNew52WeekHighs.Document.GetElementsByTagName("table").Item(x).GetElementsByTagName("tr").Count - 1
                    Dim row As DataRow = dt.NewRow
                    For z As Integer = 0 To webTBuNew52WeekHighs.Document.GetElementsByTagName("table").Item(x).GetElementsByTagName("tr").Item(y).GetElementsByTagName("td").Count - 1
                        row(z) = webTBuNew52WeekHighs.Document.GetElementsByTagName("table").Item(x).GetElementsByTagName("tr").Item(y).GetElementsByTagName("td").Item(z).InnerText
                    Next
                    ds.Tables(0).Rows.Add(row)
                Next
            Next
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        Try
            Dim wb As New XLWorkbook()
            wb.Worksheets.Add(dt, dt.TableName.ToString)
            wb.SaveAs("C:\Users\James\Desktop\Stock Charts.xlsx")
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub

End Class