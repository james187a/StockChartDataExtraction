Public Class formChartSelection

    Private Sub formChartSelection_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        '*** Technical Indicators (Bullish) ***
        chkTBuNew52WeekHighs.Checked = My.Settings.vTBuNew52WeekHighs
        chkTBuStrongVolumeGainers.Checked = My.Settings.vTBuStrongVolumeGainers
        chkTBuBullish50200DayMACrossovers.Checked = My.Settings.vTBuBullish50200DayMACrossovers
        chkTBuBullishMACDCrossovers.Checked = My.Settings.vTBuBullishMACDCrossovers
        chkTBuOversoldWithAnImprovingRSI.Checked = My.Settings.vTBuOversoldWithAnImprovingRSI
        chkTBuMovedAboveUpperBollingerBand.Checked = My.Settings.vTBuMovedAboveUpperBollingerBand
        chkTBuMovedAboveUpperPriceChannel.Checked = My.Settings.vTBuMovedAboveUpperPriceChannel
        chkTBuMovedAboveUpperKeltnerChannel.Checked = My.Settings.vTBuMovedAboveUpperKeltnerChannel
        chkTBuImprovingChaikinMoneyFlow.Checked = My.Settings.vTBuImprovingChaikinMoneyFlow

        chkTBuNewCCIBuySignals.Checked = My.Settings.vTBuNewCCIBuySignals
        chkTBuParabolicSARBuySignals.Checked = My.Settings.vTBuParabolicSARBuySignals
        chkTBuStocksInANewUptrendAroon.Checked = My.Settings.vTBuStocksInANewUptrendAroon
        chkTBuStocksInANewUptrendADX.Checked = My.Settings.vTBuStocksInANewUptrendADX
        chkTBuGapUps.Checked = My.Settings.vTBuGapUps
        chkTBuBreakawayGapUps.Checked = My.Settings.vTBuBreakawayGapUps
        chkTBuRunawayGapUps.Checked = My.Settings.vTBuRunawayGapUps
        chkTBuIslandBottoms.Checked = My.Settings.vTBuIslandBottoms

        '*** Technical Indicators (Bearish) ***
        chkTBeNew52WeekLows.Checked = My.Settings.vTBeNew52WeekLows
        chkTBeStrongVolumeDecliners.Checked = My.Settings.vTBeStrongVolumeDecliners
        chkTBeBearish50200DayMACrossovers.Checked = My.Settings.vTBeBearish50200DayMACrossovers
        chkTBeBearishMACDCrossovers.Checked = My.Settings.vTBeBearishMACDCrossovers
        chkTBeOverboughtWithADecliningRSI.Checked = My.Settings.vTBeOverboughtWithADecliningRSI
        chkTBeMovedBelowLowerBollingerBand.Checked = My.Settings.vTBeMovedBelowLowerBollingerBand
        chkTBeMovedBelowLowerPriceChannel.Checked = My.Settings.vTBeMovedBelowLowerPriceChannel
        chkTBeMovedBelowLowerKeltnerChannel.Checked = My.Settings.vTBeMovedBelowLowerKeltnerChannel
        chkTBeDecliningChaikinMoneyFlow.Checked = My.Settings.vTBeDecliningChaikinMoneyFlow

        chkTBeNewCCISellSignals.Checked = My.Settings.vTBeNewCCISellSignals
        chkTBeParabolicSARSellSignals.Checked = My.Settings.vTBeParabolicSARSellSignals
        chkTBeStocksInANewDowntrendAroon.Checked = My.Settings.vTBeStocksInANewDowntrendAroon
        chkTBeStocksInANewDowntrendADX.Checked = My.Settings.vTBeStocksInANewDowntrendADX
        chkTBeGapDowns.Checked = My.Settings.vTBeGapDowns
        chkTBeBreakawayGapDowns.Checked = My.Settings.vTBeBreakawayGapDowns
        chkTBeRunawayGapDowns.Checked = My.Settings.vTBeRunawayGapDowns
        chkTBeIslandTops.Checked = My.Settings.vTBeIslandTops

        '*** Candlestick Patterns ***
        chkCsPBullishEngulfing.Checked = My.Settings.vCsPBullishEngulfing
        chkCsPPiercingLine.Checked = My.Settings.vCsPPiercingLine
        chkCsPMorningStar.Checked = My.Settings.vCsPMorningStar
        chkCsPBullishHarami.Checked = My.Settings.vCsPBullishHarami
        chkCsPThreeWhiteSoldiers.Checked = My.Settings.vCsPThreeWhiteSoldiers

        chkCsPBearishEngulfing.Checked = My.Settings.vCsPBearishEngulfing
        chkCsPDarkCloudCover.Checked = My.Settings.vCsPDarkCloudCover
        chkCsPEveningStar.Checked = My.Settings.vCsPEveningStar
        chkCsPBearishHarami.Checked = My.Settings.vCsPBearishHarami
        chkCsPThreeBlackCrows.Checked = My.Settings.vCsPThreeBlackCrows

        chkCsPRisingThreeMethods.Checked = My.Settings.vCsPRisingThreeMethods
        chkCsPFallingThreeMethods.Checked = My.Settings.vCsPFallingThreeMethods

        chkCsPDragonflyDoji.Checked = My.Settings.vCsPDragonflyDoji
        chkCsPGravestoneDoji.Checked = My.Settings.vCsPGravestoneDoji
        chkCsPHammer.Checked = My.Settings.vCsPHammer
        chkCsPShootingStar.Checked = My.Settings.vCsPShootingStar
        chkCsPFilledBlackCandles.Checked = My.Settings.vCsPFilledBlackCandles
        chkCsPHollowRedCandles.Checked = My.Settings.vCsPHollowRedCandles

        chkCsPElderBarTurnedRed.Checked = My.Settings.vCsPElderBarTurnedRed
        chkCsPElderBarTurnedBlue.Checked = My.Settings.vCsPElderBarTurnedBlue
        chkCsPElderBarTurnedGreen.Checked = My.Settings.vCsPElderBarTurnedGreen

        chkCsPEnteredIchimokuCloud.Checked = My.Settings.vCsPEnteredIchimokuCloud
        chkCsPMovedAboveIchimokuCloud.Checked = My.Settings.vCsPMovedAboveIchimokuCloud
        chkCsPMovedBelowIchimokuCloud.Checked = My.Settings.vCsPMovedBelowIchimokuCloud
        chkCsPIchimokuCloudTurnedGreen.Checked = My.Settings.vCsPIchimokuCloudTurnedGreen
        chkCsPIchimokuCloudTurnedRed.Checked = My.Settings.vCsPIchimokuCloudTurnedRed

        '*** P&F Patterns (Bullish) ***
        chkPFBuPFTripleTopBreakout.Checked = My.Settings.vPFBuPFTripleTopBreakout
        chkPFBuPFSpreadTripleTopBreakout.Checked = My.Settings.vPFBuPFSpreadTripleTopBreakout
        chkPFBuPFAscendingTripleTopBreakout.Checked = My.Settings.vPFBuPFAscendingTripleTopBreakout
        chkPFBuPFQuadrupleTopBreakout.Checked = My.Settings.vPFBuPFQuadrupleTopBreakout
        chkPFBuPFBearishSignalReversal.Checked = My.Settings.vPFBuPFBearishSignalReversal

        chkPFBuPFBearTrap.Checked = My.Settings.vPFBuPFBearTrap
        chkPFBuPFBullishCatapult.Checked = My.Settings.vPFBuPFBullishCatapult
        chkPFBuPFBullishTriangle.Checked = My.Settings.vPFBuPFBullishTriangle
        chkPFBuPFLowPole.Checked = My.Settings.vPFBuPFLowPole

        '*** P&F Patterns (Bearish) ***
        chkPFBePFTripleBottomBreakdown.Checked = My.Settings.vPFBePFTripleBottomBreakdown
        chkPFBePFSpreadTripleBottomBreakdown.Checked = My.Settings.vPFBePFSpreadTripleBottomBreakdown
        chkPFBePFDescendingTripleBottomBreakdown.Checked = My.Settings.vPFBePFDescendingTripleBottomBreakdown
        chkPFBePFQuadrupleBottomBreakdown.Checked = My.Settings.vPFBePFQuadrupleBottomBreakdown
        chkPFBePFBullishSignalReversal.Checked = My.Settings.vPFBePFBullishSignalReversal

        chkPFBePFBullTrap.Checked = My.Settings.vPFBePFBullTrap
        chkPFBePFBearishCatapult.Checked = My.Settings.vPFBePFBearishCatapult
        chkPFBePFBearishTriangle.Checked = My.Settings.vPFBePFBearishTriangle
        chkPFBePFHighPole.Checked = My.Settings.vPFBePFHighPole
        chkPFBePFLongTailDown.Checked = My.Settings.vPFBePFLongTailDown

    End Sub

    Private Sub formChartSelection_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

        'If e.CloseReason = CloseReason.UserClosing Then
        '        e.Cancel = True
        'Me.Hide()
        'End If

    End Sub

#Region "Chart Selection"

#Region "Technical Indicators (Bullish)" 'doublechecked

    Private Sub chkTBuNew52WeekHighs_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkTBuNew52WeekHighs.CheckedChanged
        My.Settings.vTBuNew52WeekHighs = chkTBuNew52WeekHighs.CheckState()
    End Sub

    Private Sub chkTBuStrongVolumeGainers_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkTBuStrongVolumeGainers.CheckedChanged
        My.Settings.vTBuStrongVolumeGainers = chkTBuStrongVolumeGainers.CheckState()
    End Sub

    Private Sub chkTBuBullish50200DayMACrossovers_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkTBuBullish50200DayMACrossovers.CheckedChanged
        My.Settings.vTBuBullish50200DayMACrossovers = chkTBuBullish50200DayMACrossovers.CheckState()
    End Sub

    Private Sub chkTBuBullishMACDCrossovers_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkTBuBullishMACDCrossovers.CheckedChanged
        My.Settings.vTBuBullishMACDCrossovers = chkTBuBullishMACDCrossovers.CheckState()
    End Sub

    Private Sub chkTBuOversoldWithAnImprovingRSI_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkTBuOversoldWithAnImprovingRSI.CheckedChanged
        My.Settings.vTBuOversoldWithAnImprovingRSI = chkTBuOversoldWithAnImprovingRSI.CheckState()
    End Sub

    Private Sub chkTBuMovedAboveUpperBollingerBand_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkTBuMovedAboveUpperBollingerBand.CheckedChanged
        My.Settings.vTBuMovedAboveUpperBollingerBand = chkTBuMovedAboveUpperBollingerBand.CheckState()
    End Sub

    Private Sub chkTBuMovedAboveUpperPriceChannel_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkTBuMovedAboveUpperPriceChannel.CheckedChanged
        My.Settings.vTBuMovedAboveUpperPriceChannel = chkTBuMovedAboveUpperPriceChannel.CheckState()
    End Sub

    Private Sub chkTBuMovedAboveUpperKeltnerChannel_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkTBuMovedAboveUpperKeltnerChannel.CheckedChanged
        My.Settings.vTBuMovedAboveUpperKeltnerChannel = chkTBuMovedAboveUpperKeltnerChannel.CheckState()
    End Sub

    Private Sub chkTBuImprovingChaikinMoneyFlow_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkTBuImprovingChaikinMoneyFlow.CheckedChanged
        My.Settings.vTBuImprovingChaikinMoneyFlow = chkTBuImprovingChaikinMoneyFlow.CheckState()
    End Sub

    Private Sub chkTBuNewCCIBuySignals_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkTBuNewCCIBuySignals.CheckedChanged
        My.Settings.vTBuNewCCIBuySignals = chkTBuNewCCIBuySignals.CheckState()
    End Sub

    Private Sub chkTBuParabolicSARBuySignals_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkTBuParabolicSARBuySignals.CheckedChanged
        My.Settings.vTBuParabolicSARBuySignals = chkTBuParabolicSARBuySignals.CheckState()
    End Sub

    Private Sub chkTBuStocksInANewUptrendAroon_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkTBuStocksInANewUptrendAroon.CheckedChanged
        My.Settings.vTBuStocksInANewUptrendAroon = chkTBuStocksInANewUptrendAroon.CheckState()
    End Sub

    Private Sub chkTBuStocksInANewUptrendADX_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkTBuStocksInANewUptrendADX.CheckedChanged
        My.Settings.vTBuStocksInANewUptrendADX = chkTBuStocksInANewUptrendADX.CheckState()
    End Sub

    Private Sub chkTBuGapUps_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkTBuGapUps.CheckedChanged
        My.Settings.vTBuGapUps = chkTBuGapUps.CheckState()
    End Sub

    Private Sub chkTBuBreakawayGapUps_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkTBuBreakawayGapUps.CheckedChanged
        My.Settings.vTBuBreakawayGapUps = chkTBuBreakawayGapUps.CheckState()
    End Sub

    Private Sub chkTBuRunawayGapUps_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkTBuRunawayGapUps.CheckedChanged
        My.Settings.vTBuRunawayGapUps = chkTBuRunawayGapUps.CheckState()
    End Sub

    Private Sub chkTBuIslandBottoms_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkTBuIslandBottoms.CheckedChanged
        My.Settings.vTBuIslandBottoms = chkTBuIslandBottoms.CheckState()
    End Sub

#End Region

#Region "Technical Indicators (Bearish)" 'doublechecked

    Private Sub chkTBeNew52WeekLows_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkTBeNew52WeekLows.CheckedChanged
        My.Settings.vTBeNew52WeekLows = chkTBeNew52WeekLows.CheckState()
    End Sub

    Private Sub chkTBeStrongVolumeDecliners_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkTBeStrongVolumeDecliners.CheckedChanged
        My.Settings.vTBeStrongVolumeDecliners = chkTBeStrongVolumeDecliners.CheckState()
    End Sub

    Private Sub chkTBeBearish50200DayMACrossovers_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkTBeBearish50200DayMACrossovers.CheckedChanged
        My.Settings.vTBeBearish50200DayMACrossovers = chkTBeBearish50200DayMACrossovers.CheckState()
    End Sub

    Private Sub chkTBeBearishMACDCrossovers_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkTBeBearishMACDCrossovers.CheckedChanged
        My.Settings.vTBeBearishMACDCrossovers = chkTBeBearishMACDCrossovers.CheckState()
    End Sub

    Private Sub chkTBeOverboughtWithADecliningRSI_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkTBeOverboughtWithADecliningRSI.CheckedChanged
        My.Settings.vTBeOverboughtWithADecliningRSI = chkTBeOverboughtWithADecliningRSI.CheckState()
    End Sub

    Private Sub chkTBeMovedBelowLowerBollingerBand_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkTBeMovedBelowLowerBollingerBand.CheckedChanged
        My.Settings.vTBeMovedBelowLowerBollingerBand = chkTBeMovedBelowLowerBollingerBand.CheckState()
    End Sub

    Private Sub chkTBeMovedBelowLowerPriceChannel_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkTBeMovedBelowLowerPriceChannel.CheckedChanged
        My.Settings.vTBeMovedBelowLowerPriceChannel = chkTBeMovedBelowLowerPriceChannel.CheckState()
    End Sub

    Private Sub chkTBeMovedBelowLowerKeltnerChannel_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkTBeMovedBelowLowerKeltnerChannel.CheckedChanged
        My.Settings.vTBeMovedBelowLowerKeltnerChannel = chkTBeMovedBelowLowerKeltnerChannel.CheckState()
    End Sub

    Private Sub chkTBeDecliningChaikinMoneyFlow_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkTBeDecliningChaikinMoneyFlow.CheckedChanged
        My.Settings.vTBeDecliningChaikinMoneyFlow = chkTBeDecliningChaikinMoneyFlow.CheckState()
    End Sub

    Private Sub chkTBeNewCCISellSignals_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkTBeNewCCISellSignals.CheckedChanged
        My.Settings.vTBeNewCCISellSignals = chkTBeNewCCISellSignals.CheckState()
    End Sub

    Private Sub chkTBeParabolicSARSellSignals_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkTBeParabolicSARSellSignals.CheckedChanged
        My.Settings.vTBeParabolicSARSellSignals = chkTBeParabolicSARSellSignals.CheckState()
    End Sub

    Private Sub chkTBeStocksInANewDowntrendAroon_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkTBeStocksInANewDowntrendAroon.CheckedChanged
        My.Settings.vTBeStocksInANewDowntrendAroon = chkTBeStocksInANewDowntrendAroon.CheckState()
    End Sub

    Private Sub chkTBeStocksInANewDowntrendADX_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkTBeStocksInANewDowntrendADX.CheckedChanged
        My.Settings.vTBeStocksInANewDowntrendADX = chkTBeStocksInANewDowntrendADX.CheckState()
    End Sub

    Private Sub chkTBeGapDowns_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkTBeGapDowns.CheckedChanged
        My.Settings.vTBeGapDowns = chkTBeGapDowns.CheckState()
    End Sub

    Private Sub chkTBeBreakawayGapDowns_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkTBeBreakawayGapDowns.CheckedChanged
        My.Settings.vTBeBreakawayGapDowns = chkTBeBreakawayGapDowns.CheckState()
    End Sub

    Private Sub chkTBeRunawayGapDowns_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkTBeRunawayGapDowns.CheckedChanged
        My.Settings.vTBeRunawayGapDowns = chkTBeRunawayGapDowns.CheckState()
    End Sub

    Private Sub chkTBeIslandTops_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkTBeIslandTops.CheckedChanged
        My.Settings.vTBeIslandTops = chkTBeIslandTops.CheckState()
    End Sub

#End Region

#Region "Candlestick Patterns" 'doublechecked

    Private Sub chkCsPBullishEngulfing_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkCsPBullishEngulfing.CheckedChanged
        My.Settings.vCsPBullishEngulfing = chkCsPBullishEngulfing.CheckState()
    End Sub

    Private Sub chkCsPPiercingLine_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkCsPPiercingLine.CheckedChanged
        My.Settings.vCsPPiercingLine = chkCsPPiercingLine.CheckState()
    End Sub

    Private Sub chkCsPMorningStar_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkCsPMorningStar.CheckedChanged
        My.Settings.vCsPMorningStar = chkCsPMorningStar.CheckState()
    End Sub

    Private Sub chkCsPBullishHarami_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkCsPBullishHarami.CheckedChanged
        My.Settings.vCsPBullishHarami = chkCsPBullishHarami.CheckState()
    End Sub

    Private Sub chkCsPThreeWhiteSoldiers_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkCsPThreeWhiteSoldiers.CheckedChanged
        My.Settings.vCsPThreeWhiteSoldiers = chkCsPThreeWhiteSoldiers.CheckState()
    End Sub

    Private Sub chkCsPBearishEngulfing_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkCsPBearishEngulfing.CheckedChanged
        My.Settings.vCsPBearishEngulfing = chkCsPBearishEngulfing.CheckState()
    End Sub

    Private Sub chkCsPDarkCloudCover_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkCsPDarkCloudCover.CheckedChanged
        My.Settings.vCsPDarkCloudCover = chkCsPDarkCloudCover.CheckState()
    End Sub

    Private Sub chkCsPEveningStar_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkCsPEveningStar.CheckedChanged
        My.Settings.vCsPEveningStar = chkCsPEveningStar.CheckState()
    End Sub

    Private Sub chkCsPBearishHarami_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkCsPBearishHarami.CheckedChanged
        My.Settings.vCsPBearishHarami = chkCsPBearishHarami.CheckState()
    End Sub

    Private Sub chkCsPThreeBlackCrows_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkCsPThreeBlackCrows.CheckedChanged
        My.Settings.vCsPThreeBlackCrows = chkCsPThreeBlackCrows.CheckState()
    End Sub

    Private Sub chkCsPRisingThreeMethods_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkCsPRisingThreeMethods.CheckedChanged
        My.Settings.vCsPRisingThreeMethods = chkCsPRisingThreeMethods.CheckState()
    End Sub

    Private Sub chkCsPFallingThreeMethods_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkCsPFallingThreeMethods.CheckedChanged
        My.Settings.vCsPFallingThreeMethods = chkCsPFallingThreeMethods.CheckState()
    End Sub

    Private Sub chkCsPDragonflyDoji_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkCsPDragonflyDoji.CheckedChanged
        My.Settings.vCsPDragonflyDoji = chkCsPDragonflyDoji.CheckState()
    End Sub

    Private Sub chkCsPGravestoneDoji_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkCsPGravestoneDoji.CheckedChanged
        My.Settings.vCsPGravestoneDoji = chkCsPGravestoneDoji.CheckState()
    End Sub

    Private Sub chkCsPHammer_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkCsPHammer.CheckedChanged
        My.Settings.vCsPHammer = chkCsPHammer.CheckState()
    End Sub

    Private Sub chkCsPShootingStar_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkCsPShootingStar.CheckedChanged
        My.Settings.vCsPShootingStar = chkCsPShootingStar.CheckState()
    End Sub

    Private Sub chkCsPFilledBlackCandles_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkCsPFilledBlackCandles.CheckedChanged
        My.Settings.vCsPFilledBlackCandles = chkCsPFilledBlackCandles.CheckState()
    End Sub

    Private Sub chkCsPHollowRedCandles_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkCsPHollowRedCandles.CheckedChanged
        My.Settings.vCsPHollowRedCandles = chkCsPHollowRedCandles.CheckState()
    End Sub

    Private Sub chkCsPElderBarTurnedRed_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkCsPElderBarTurnedRed.CheckedChanged
        My.Settings.vCsPElderBarTurnedRed = chkCsPElderBarTurnedRed.CheckState()
    End Sub

    Private Sub chkCsPElderBarTurnedBlue_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkCsPElderBarTurnedBlue.CheckedChanged
        My.Settings.vCsPElderBarTurnedBlue = chkCsPElderBarTurnedBlue.CheckState()
    End Sub

    Private Sub chkCsPElderBarTurnedGreen_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkCsPElderBarTurnedGreen.CheckedChanged
        My.Settings.vCsPElderBarTurnedGreen = chkCsPElderBarTurnedGreen.CheckState()
    End Sub

    Private Sub chkCsPEnteredIchimokuCloud_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkCsPEnteredIchimokuCloud.CheckedChanged
        My.Settings.vCsPEnteredIchimokuCloud = chkCsPEnteredIchimokuCloud.CheckState()
    End Sub

    Private Sub chkCsPMovedAboveIchimokuCloud_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkCsPMovedAboveIchimokuCloud.CheckedChanged
        My.Settings.vCsPMovedAboveIchimokuCloud = chkCsPMovedAboveIchimokuCloud.CheckState()
    End Sub

    Private Sub chkCsPMovedBelowIchimokuCloud_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkCsPMovedBelowIchimokuCloud.CheckedChanged
        My.Settings.vCsPMovedBelowIchimokuCloud = chkCsPMovedBelowIchimokuCloud.CheckState()
    End Sub

    Private Sub chkCsPIchimokuCloudTurnedGreen_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkCsPIchimokuCloudTurnedGreen.CheckedChanged
        My.Settings.vCsPIchimokuCloudTurnedGreen = chkCsPIchimokuCloudTurnedGreen.CheckState()
    End Sub

    Private Sub chkCsPIchimokuCloudTurnedRed_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkCsPIchimokuCloudTurnedRed.CheckedChanged
        My.Settings.vCsPIchimokuCloudTurnedRed = chkCsPIchimokuCloudTurnedRed.CheckState()
    End Sub

#End Region

#Region "P&F Patterns (Bullish)" 'doublechecked

    Private Sub chkPFBuPFTripleTopBreakout_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkPFBuPFTripleTopBreakout.CheckedChanged
        My.Settings.vPFBuPFTripleTopBreakout = chkPFBuPFTripleTopBreakout.CheckState()
    End Sub

    Private Sub chkPFBuPFSpreadTripleTopBreakout_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkPFBuPFSpreadTripleTopBreakout.CheckedChanged
        My.Settings.vPFBuPFSpreadTripleTopBreakout = chkPFBuPFSpreadTripleTopBreakout.CheckState()
    End Sub

    Private Sub chkPFBuPFAscendingTripleTopBreakout_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkPFBuPFAscendingTripleTopBreakout.CheckedChanged
        My.Settings.vPFBuPFAscendingTripleTopBreakout = chkPFBuPFAscendingTripleTopBreakout.CheckState()
    End Sub

    Private Sub chkPFBuPFQuadrupleTopBreakout_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkPFBuPFQuadrupleTopBreakout.CheckedChanged
        My.Settings.vPFBuPFQuadrupleTopBreakout = chkPFBuPFQuadrupleTopBreakout.CheckState()
    End Sub

    Private Sub chkPFBuPFBearishSignalReversal_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkPFBuPFBearishSignalReversal.CheckedChanged
        My.Settings.vPFBuPFBearishSignalReversal = chkPFBuPFBearishSignalReversal.CheckState()
    End Sub

    Private Sub chkPFBuPFBearTrap_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkPFBuPFBearTrap.CheckedChanged
        My.Settings.vPFBuPFBearTrap = chkPFBuPFBearTrap.CheckState()
    End Sub

    Private Sub chkPFBuPFBullishCatapult_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkPFBuPFBullishCatapult.CheckedChanged
        My.Settings.vPFBuPFBullishCatapult = chkPFBuPFBullishCatapult.CheckState()
    End Sub

    Private Sub chkPFBuPFBullishTriangle_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkPFBuPFBullishTriangle.CheckedChanged
        My.Settings.vPFBuPFBullishTriangle = chkPFBuPFBullishTriangle.CheckState()
    End Sub

    Private Sub chkPFBuPFLowPole_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkPFBuPFLowPole.CheckedChanged
        My.Settings.vPFBuPFLowPole = chkPFBuPFLowPole.CheckState()
    End Sub

#End Region

#Region "P&F Patterns (Bearish)" 'doublechecked

    Private Sub chkPFBePFTripleBottomBreakdown_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkPFBePFTripleBottomBreakdown.CheckedChanged
        My.Settings.vPFBePFTripleBottomBreakdown = chkPFBePFTripleBottomBreakdown.CheckState()
    End Sub

    Private Sub chkPFBePFSpreadTripleBottomBreakdown_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkPFBePFSpreadTripleBottomBreakdown.CheckedChanged
        My.Settings.vPFBePFSpreadTripleBottomBreakdown = chkPFBePFSpreadTripleBottomBreakdown.CheckState()
    End Sub

    Private Sub chkPFBePFDescendingTripleBottomBreakdown_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkPFBePFDescendingTripleBottomBreakdown.CheckedChanged
        My.Settings.vPFBePFDescendingTripleBottomBreakdown = chkPFBePFDescendingTripleBottomBreakdown.CheckState()
    End Sub

    Private Sub chkPFBePFQuadrupleBottomBreakdown_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkPFBePFQuadrupleBottomBreakdown.CheckedChanged
        My.Settings.vPFBePFQuadrupleBottomBreakdown = chkPFBePFQuadrupleBottomBreakdown.CheckState()
    End Sub

    Private Sub chkPFBePFBullishSignalReversal_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkPFBePFBullishSignalReversal.CheckedChanged
        My.Settings.vPFBePFBullishSignalReversal = chkPFBePFBullishSignalReversal.CheckState()
    End Sub

    Private Sub chkPFBePFBullTrap_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkPFBePFBullTrap.CheckedChanged
        My.Settings.vPFBePFBullTrap = chkPFBePFBullTrap.CheckState()
    End Sub

    Private Sub chkPFBePFBearishCatapult_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkPFBePFBearishCatapult.CheckedChanged
        My.Settings.vPFBePFBearishCatapult = chkPFBePFBearishCatapult.CheckState()
    End Sub

    Private Sub chkPFBePFBearishTriangle_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkPFBePFBearishTriangle.CheckedChanged
        My.Settings.vPFBePFBearishTriangle = chkPFBePFBearishTriangle.CheckState()
    End Sub

    Private Sub chkPFBePFHighPole_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkPFBePFHighPole.CheckedChanged
        My.Settings.vPFBePFHighPole = chkPFBePFHighPole.CheckState()
    End Sub

    Private Sub chkPFBePFLongTailDown_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkPFBePFLongTailDown.CheckedChanged
        My.Settings.vPFBePFLongTailDown = chkPFBePFLongTailDown.CheckState()
    End Sub

#End Region

#End Region

End Class