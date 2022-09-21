Module ModuleGlobalVariables

#Region "Chart Selection Links"

#Region "Technical Indicators (Bullish) Links"

    Public lTBuNew52WeekHighs As String = "http://stockcharts.com/def/servlet/SC.scan?s=TSAL[t.t_eq_s]![as0,20,tv_gt_40000]![th0_gt_am1,253,th]&report=predefall"
    Public lTBuStrongVolumeGainers As String = "http://stockcharts.com/def/servlet/SC.scan?s=TSAL[t.t_eq_s]![as0,20,tv_gt_40000]![tv0_gt_as1,20,tv*4]![tc0_gt_tc1]&report=predefall"
    Public lTBuBullish50200DayMACrossovers As String = "http://stockcharts.com/def/servlet/SC.scan?s=TSAL[t.t_eq_s]![as0,20,tv_gt_40000]![as0,50,tc_gt_as0,200,tc]![as1,50,tc_le_as1,200,tc]&report=predefall"
    Public lTBuBullishMACDCrossovers As String = "http://stockcharts.com/def/servlet/SC.scan?s=TSAL[t.t_eq_s]![as0,20,tv_gt_40000]![ba0_lt_0]![ba0_ge_bb0]![ba1_lt_bb1]![ba2_lt_bb2]![ba3_lt_bb3]![bc3_lt_bb3*0.25]&report=predefall"
    Public lTBuOversoldWithAnImprovingRSI As String = "http://stockcharts.com/def/servlet/SC.scan?s=TSAL[t.t_eq_s]![as0,20,tv_gt_40000]![bs0_gt_30]![bs1_lt_29]![bs2_lt_28]![bs3_lt_27]&report=predefall"
    Public lTBuMovedAboveUpperBollingerBand As String = "http://stockcharts.com/def/servlet/SC.scan?s=TSAL[t.t_eq_s]![as0,20,tv_gt_40000]![tc1_le_ab1]![tc0_gt_ab0]&report=predefall"
    Public lTBuMovedAboveUpperPriceChannel As String = "http://stockcharts.com/def/servlet/SC.scan?s=TSAL[t.t_eq_s]![as0,20,tv_gt_40000]![al0,20_lt_tc0]![al1,20_gt_tc1]&report=predefall"
    Public lTBuMovedAboveUpperKeltnerChannel As String = "http://stockcharts.com/def/servlet/SC.scan?s=TSAL[t.t_eq_s]![as0,20,tv_gt_40000]![cl0,20_lt_tc0]![cl1,20_gt_tc1]&report=predefall"
    Public lTBuImprovingChaikinMoneyFlow As String = "http://stockcharts.com/def/servlet/SC.scan?s=TSAL[t.t_eq_s]![as0,20,tv_gt_40000]![bt0,20_ge_0.2]![bt1,20_lt_0.2]![bt2,20_lt_0.2]![bt3,20_lt_0.2]![bt4,20_lt_0.2]&report=predefall"

    Public lTBuNewCCIBuySignals As String = "http://stockcharts.com/def/servlet/SC.scan?s=TSAL[t.t_eq_s]![as0,20,tv_gt_40000]![bu0,20_gt_100]![bu1,20_le_100]![bu2,20_lt_100]&report=predefall"
    Public lTBuParabolicSARBuySignals As String = "http://stockcharts.com/def/servlet/SC.scan?s=TSAL[t.t_eq_s]![as0,20,tv_gt_40000]![ap1,0.02,0.2_gt_tc1]![ap0,0.02,0.2_lt_tc0]&report=predefall"
    Public lTBuStocksInANewUptrendAroon As String = "http://stockcharts.com/def/servlet/SC.scan?s=TSAL[t.t_eq_s]![as0,20,tv_gt_40000]![br0_gt_50]![br1_le_50]&report=predefall"
    Public lTBuStocksInANewUptrendADX As String = "http://stockcharts.com/def/servlet/SC.scan?s=TSAL[t.t_eq_s]![as0,20,tv_gt_40000]![bm0,14_gt_20]![bm1,14_le_20]![bm2,14_le_20]![bn0,14_gt_bo0,14]&report=predefall"
    Public lTBuGapUps As String = "http://stockcharts.com/def/servlet/SC.scan?s=TSAL[t.t_eq_s]![as0,20,tv_gt_40000]![tl0_gt_th1*1.026]&report=predefall"
    Public lTBuBreakawayGapUps As String = "http://stockcharts.com/def/servlet/SC.scan?s=TSAL[t.t_eq_s]![as0,20,tv_gt_40000]![an1,5,tl_gt_am1,5,th*0.95]![tl0_gt_th1*1.026]![tl0_ne_th0]&report=predefall"
    Public lTBuRunawayGapUps As String = "http://stockcharts.com/def/servlet/SC.scan?s=TSAL[t.t_eq_s]![as0,20,tv_gt_40000]![tc1_gt_ax1,10,tc]![tl0_gt_th1*1.025]![tl0_ne_th0]&report=predefall"
    Public lTBuIslandBottoms As String = "http://stockcharts.com/def/servlet/SC.scan?s=TSAL[t.t_eq_s]![as0,20,tv_gt_40000]![tc2_lt_ax2,10,tc]![th1_lt_tl2*0.975]![tl1_ne_th1]![tl0_gt_th1*1.025]&report=predefall"

#End Region

#Region "Technical Indicators (Bearish) Links"

    Public lTBeNew52WeekLows As String = "http://stockcharts.com/def/servlet/SC.scan?s=TSAL[t.t_eq_s]![as0,20,tv_gt_40000]![tl0_lt_an1,253,tl]&report=predefall"
    Public lTBeStrongVolumeDecliners As String = "http://stockcharts.com/def/servlet/SC.scan?s=TSAL[t.t_eq_s]![as0,20,tv_gt_40000]![tv0_gt_as1,20,tv*4]![tc0_lt_tc1]&report=predefall"
    Public lTBeBearish50200DayMACrossovers As String = "http://stockcharts.com/def/servlet/SC.scan?s=TSAL[t.t_eq_s]![as0,20,tv_gt_40000]![as0,50,tc_lt_as0,200,tc]![as1,50,tc_ge_as1,200,tc]&report=predefall"
    Public lTBeBearishMACDCrossovers As String = "http://stockcharts.com/def/servlet/SC.scan?s=TSAL[t.t_eq_s]![as0,20,tv_gt_40000]![ba0_gt_0]![ba0_le_bb0]![ba1_gt_bb1]![ba2_gt_bb2]![ba3_gt_bb3]![bc3_gt_bb3*0.25]&report=predefall"
    Public lTBeOverboughtWithADecliningRSI As String = "http://stockcharts.com/def/servlet/SC.scan?s=TSAL[t.t_eq_s]![as0,20,tv_gt_40000]![bs0_lt_70]![bs1_gt_71]![bs2_gt_72]![bs3_gt_73]&report=predefall"
    Public lTBeMovedBelowLowerBollingerBand As String = "http://stockcharts.com/def/servlet/SC.scan?s=TSAL[t.t_eq_s]![as0,20,tv_gt_40000]![tc1_ge_ac1]![tc0_lt_ac0]&report=predefall"
    Public lTBeMovedBelowLowerPriceChannel As String = "http://stockcharts.com/def/servlet/SC.scan?s=TSAL[t.t_eq_s]![as0,20,tv_gt_40000]![aq0,20_gt_tc0]![aq1,20_lt_tc1]&report=predefall"
    Public lTBeMovedBelowLowerKeltnerChannel As String = "http://stockcharts.com/def/servlet/SC.scan?s=TSAL[t.t_eq_s]![as0,20,tv_gt_40000]![cm0,20_gt_tc0]![cm1,20_lt_tc1]&report=predefall"
    Public lTBeDecliningChaikinMoneyFlow As String = "http://stockcharts.com/def/servlet/SC.scan?s=TSAL[t.t_eq_s]![as0,20,tv_gt_40000]![bt0,20_lt_-0.2]![bt1,20_gt_-0.2]![bt2,20_gt_-0.2]![bt3,20_gt_-0.2]![bt4,20_gt_-0.2]&report=predefall"

    Public lTBeNewCCISellSignals As String = "http://stockcharts.com/def/servlet/SC.scan?s=TSAL[t.t_eq_s]![as0,20,tv_gt_40000]![bu0,20_lt_-100]![bu1,20_ge_-100]![bu2,20_gt_-100]&report=predefall"
    Public lTBeParabolicSARSellSignals As String = "http://stockcharts.com/def/servlet/SC.scan?s=TSAL[t.t_eq_s]![as0,20,tv_gt_40000]![ap1,0.02,0.2_lt_tc1]![ap0,0.02,0.2_gt_tc0]&report=predefall"
    Public lTBeStocksInANewDowntrendAroon As String = "http://stockcharts.com/def/servlet/SC.scan?s=TSAL[t.t_eq_s]![as0,20,tv_gt_40000]![br0_lt_-50]![br1_ge_-50]&report=predefall"
    Public lTBeStocksInANewDowntrendADX As String = "http://stockcharts.com/def/servlet/SC.scan?s=TSAL[t.t_eq_s]![as0,20,tv_gt_40000]![bm0,14_gt_20]![bm1,14_le_20]![bm2,14_le_20]![bn0,14_lt_bo0,14]&report=predefall"
    Public lTBeGapDowns As String = "http://stockcharts.com/def/servlet/SC.scan?s=TSAL[t.t_eq_s]![as0,20,tv_gt_40000]![th0_lt_tl1*0.974]&report=predefall"
    Public lTBeBreakawayGapDowns As String = "http://stockcharts.com/def/servlet/SC.scan?s=TSAL[t.t_eq_s]![as0,20,tv_gt_40000]![an1,5,tl_gt_am1,5,th*0.95]![th0_lt_tl1*0.974]![tl0_ne_th0]&report=predefall"
    Public lTBeRunawayGapDowns As String = "http://stockcharts.com/def/servlet/SC.scan?s=TSAL[t.t_eq_s]![as0,20,tv_gt_40000]![tc1_lt_ax1,10,tc]![th0_lt_tl1*0.975]![tl0_ne_th0]&report=predefall"
    Public lTBeIslandTops As String = "http://stockcharts.com/def/servlet/SC.scan?s=TSAL[t.t_eq_s]![as0,20,tv_gt_40000]![tc2_gt_ax2,10,tc]![tl1_gt_th2*1.025]![tl1_ne_th1]![th0_lt_tl1*0.975]&report=predefall"

#End Region

#Region "Candlestick Patterns Links"

    Public lCsPBullishEngulfing As String = "http://stockcharts.com/def/servlet/SC.scan?s=TSAL[t.t_eq_s]![as0,20,tv_gt_40000]![wa_eq_1]&report=predefall"
    Public lCsPPiercingLine As String = "http://stockcharts.com/def/servlet/SC.scan?s=TSAL[t.t_eq_s]![as0,20,tv_gt_40000]![wd_eq_1]&report=predefall"
    Public lCsPMorningStar As String = "http://stockcharts.com/def/servlet/SC.scan?s=TSAL[t.t_eq_s]![as0,20,tv_gt_40000]![wh_eq_1]&report=predefall"
    Public lCsPBullishHarami As String = "http://stockcharts.com/def/servlet/SC.scan?s=TSAL[t.t_eq_s]![as0,20,tv_gt_40000]![wf_eq_1]&report=predefall"
    Public lCsPThreeWhiteSoldiers As String = "http://stockcharts.com/def/servlet/SC.scan?s=TSAL[t.t_eq_s]![as0,20,tv_gt_40000]![wn_eq_1]&report=predefall"

    Public lCsPBearishEngulfing As String = "http://stockcharts.com/def/servlet/SC.scan?s=TSAL[t.t_eq_s]![as0,20,tv_gt_40000]![wb_eq_1]&report=predefall"
    Public lCsPDarkCloudCover As String = "http://stockcharts.com/def/servlet/SC.scan?s=TSAL[t.t_eq_s]![as0,20,tv_gt_40000]![wc_eq_1]&report=predefall"
    Public lCsPEveningStar As String = "http://stockcharts.com/def/servlet/SC.scan?s=TSAL[t.t_eq_s]![as0,20,tv_gt_40000]![wi_eq_1]&report=predefall"
    Public lCsPBearishHarami As String = "http://stockcharts.com/def/servlet/SC.scan?s=TSAL[t.t_eq_s]![as0,20,tv_gt_40000]![wg_eq_1]&report=predefall"
    Public lCsPThreeBlackCrows As String = "http://stockcharts.com/def/servlet/SC.scan?s=TSAL[t.t_eq_s]![as0,20,tv_gt_40000]![wo_eq_1]&report=predefall"

    Public lCsPRisingThreeMethods As String = "http://stockcharts.com/def/servlet/SC.scan?s=TSAL[t.t_eq_s]![as0,20,tv_gt_40000]![wj_eq_1]&report=predefall"
    Public lCsPFallingThreeMethods As String = "http://stockcharts.com/def/servlet/SC.scan?s=TSAL[t.t_eq_s]![as0,20,tv_gt_40000]![wk_eq_1]&report=predefall"

    Public lCsPDragonflyDoji As String = "http://stockcharts.com/def/servlet/SC.scan?s=TSAL[t.t_eq_s]![as0,20,tv_gt_40000]![wm_eq_1]&report=predefall"
    Public lCsPGravestoneDoji As String = "http://stockcharts.com/def/servlet/SC.scan?s=TSAL[t.t_eq_s]![as0,20,tv_gt_40000]![wl_eq_1]&report=predefall"
    Public lCsPHammer As String = "http://stockcharts.com/def/servlet/SC.scan?s=TSAL[t.t_eq_s]![as0,20,tv_gt_40000]![wp_eq_1]&report=predefall"
    Public lCsPShootingStar As String = "http://stockcharts.com/def/servlet/SC.scan?s=TSAL[t.t_eq_s]![as0,20,tv_gt_40000]![wq_eq_1]&report=predefall"
    Public lCsPFilledBlackCandles As String = "http://stockcharts.com/def/servlet/SC.scan?s=TSAL[t.t_eq_s]![as0,20,tv_gt_40000]![wr_eq_1]&report=predefall"
    Public lCsPHollowRedCandles As String = "http://stockcharts.com/def/servlet/SC.scan?s=TSAL[t.t_eq_s]![as0,20,tv_gt_40000]![ws_eq_1]&report=predefall"

    Public lCsPElderBarTurnedRed As String = "http://stockcharts.com/def/servlet/SC.scan?s=TSAL[t.t_eq_s]![as0,20,tv_gt_40000]![wu_eq_1]![wu1_eq_0]&report=predefall"
    Public lCsPElderBarTurnedBlue As String = "http://stockcharts.com/def/servlet/SC.scan?s=TSAL[t.t_eq_s]![as0,20,tv_gt_40000]![wv_eq_1]![wv1_eq_0]&report=predefall"
    Public lCsPElderBarTurnedGreen As String = "http://stockcharts.com/def/servlet/SC.scan?s=TSAL[t.t_eq_s]![as0,20,tv_gt_40000]![ww_eq_1]![ww1_eq_0]&report=predefall"

    Public lCsPEnteredIchimokuCloud As String = "http://stockcharts.com/def/servlet/SC.scan?s=TSAL[t.t_eq_s]![as0,20,tv_gt_40000]![wx_eq_1]![wx1_eq_0]&report=predefall"
    Public lCsPMovedAboveIchimokuCloud As String = "http://stockcharts.com/def/servlet/SC.scan?s=TSAL[t.t_eq_s]![as0,20,tv_gt_40000]![wy_eq_1]![wy1_eq_0]&report=predefall"
    Public lCsPMovedBelowIchimokuCloud As String = "http://stockcharts.com/def/servlet/SC.scan?s=TSAL[t.t_eq_s]![as0,20,tv_gt_40000]![wz_eq_1]![wz1_eq_0]&report=predefall"
    Public lCsPIchimokuCloudTurnedGreen As String = "http://stockcharts.com/def/servlet/SC.scan?s=TSAL[t.t_eq_s]![as0,20,tv_gt_40000]![zk_eq_1]![zk1_eq_0]&report=predefall"
    Public lCsPIchimokuCloudTurnedRed As String = "http://stockcharts.com/def/servlet/SC.scan?s=TSAL[t.t_eq_s]![as0,20,tv_gt_40000]![zl_eq_1]![zl1_eq_0]&report=predefall"

#End Region

#Region "P&F Patterns (Bullish) Links"

    Public lPFBuPFTripleTopBreakout As String = "http://stockcharts.com/def/servlet/SC.scan?s=TSAL[t.t_eq_s]![as0,20,tv_gt_40000]![ym_eq_1]&report=predefall"
    Public lPFBuPFSpreadTripleTopBreakout As String = "http://stockcharts.com/def/servlet/SC.scan?s=TSAL[t.t_eq_s]![as0,20,tv_gt_40000]![yh_eq_1]&report=predefall"
    Public lPFBuPFAscendingTripleTopBreakout As String = "http://stockcharts.com/def/servlet/SC.scan?s=TSAL[t.t_eq_s]![as0,20,tv_gt_40000]![yk_eq_1]&report=predefall"
    Public lPFBuPFQuadrupleTopBreakout As String = "http://stockcharts.com/def/servlet/SC.scan?s=TSAL[t.t_eq_s]![as0,20,tv_gt_40000]![yj_eq_1]&report=predefall"
    Public lPFBuPFBearishSignalReversal As String = "http://stockcharts.com/def/servlet/SC.scan?s=TSAL[t.t_eq_s]![as0,20,tv_gt_40000]![yd_eq_1]&report=predefall"

    Public lPFBuPFBearTrap As String = "http://stockcharts.com/def/servlet/SC.scan?s=TSAL[t.t_eq_s]![as0,20,tv_gt_40000]![yl_eq_1]&report=predefall"
    Public lPFBuPFBullishCatapult As String = "http://stockcharts.com/def/servlet/SC.scan?s=TSAL[t.t_eq_s]![as0,20,tv_gt_40000]![ya_eq_1]&report=predefall"
    Public lPFBuPFBullishTriangle As String = "http://stockcharts.com/def/servlet/SC.scan?s=TSAL[t.t_eq_s]![as0,20,tv_gt_40000]![ye_eq_1]&report=predefall"
    Public lPFBuPFLowPole As String = "http://stockcharts.com/def/servlet/SC.scan?s=TSAL[t.t_eq_s]![as0,20,tv_gt_40000]![yx_eq_1]&report=predefall"

#End Region

#Region "P&F Patterns (Bearish) Links"

    Public lPFBePFTripleBottomBreakdown As String = "http://stockcharts.com/def/servlet/SC.scan?s=TSAL[t.t_eq_s]![as0,20,tv_gt_40000]![yq_eq_1]&report=predefall"
    Public lPFBePFSpreadTripleBottomBreakdown As String = "http://stockcharts.com/def/servlet/SC.scan?s=TSAL[t.t_eq_s]![as0,20,tv_gt_40000]![yi_eq_1]&report=predefall"
    Public lPFBePFDescendingTripleBottomBreakdown As String = "http://stockcharts.com/def/servlet/SC.scan?s=TSAL[t.t_eq_s]![as0,20,tv_gt_40000]![yo_eq_1]&report=predefall"
    Public lPFBePFQuadrupleBottomBreakdown As String = "http://stockcharts.com/def/servlet/SC.scan?s=TSAL[t.t_eq_s]![as0,20,tv_gt_40000]![yn_eq_1]&report=predefall"
    Public lPFBePFBullishSignalReversal As String = "http://stockcharts.com/def/servlet/SC.scan?s=TSAL[t.t_eq_s]![as0,20,tv_gt_40000]![yc_eq_1]&report=predefall"

    Public lPFBePFBullTrap As String = "http://stockcharts.com/def/servlet/SC.scan?s=TSAL[t.t_eq_s]![as0,20,tv_gt_40000]![yp_eq_1]&report=predefall"
    Public lPFBePFBearishCatapult As String = "http://stockcharts.com/def/servlet/SC.scan?s=TSAL[t.t_eq_s]![as0,20,tv_gt_40000]![yb_eq_1]&report=predefall"
    Public lPFBePFBearishTriangle As String = "http://stockcharts.com/def/servlet/SC.scan?s=TSAL[t.t_eq_s]![as0,20,tv_gt_40000]![yf_eq_1]&report=predefall"
    Public lPFBePFHighPole As String = "http://stockcharts.com/def/servlet/SC.scan?s=TSAL[t.t_eq_s]![as0,20,tv_gt_40000]![yw_eq_1]&report=predefall"
    Public lPFBePFLongTailDown As String = "http://stockcharts.com/def/servlet/SC.scan?s=TSAL[t.t_eq_s]![as0,20,tv_gt_40000]![yg_eq_1]&report=predefall"

#End Region

#End Region

#Region "Webbrowser Controls"

#Region "Technical Indicators (Bullish) Webbrowsers"

    Public webTBuNew52WeekHighs As New WebBrowser
    Public webTBuStrongVolumeGainers As New WebBrowser
    Public webTBuBullish50200DayMACrossovers As New WebBrowser
    Public webTBuBullishMACDCrossovers As New WebBrowser
    Public webTBuOversoldWithAnImprovingRSI As New WebBrowser
    Public webTBuMovedAboveUpperBollingerBand As New WebBrowser
    Public webTBuMovedAboveUpperPriceChannel As New WebBrowser
    Public webTBuMovedAboveUpperKeltnerChannel As New WebBrowser
    Public webTBuImprovingChaikinMoneyFlow As New WebBrowser

    Public webTBuNewCCIBuySignals As New WebBrowser
    Public webTBuParabolicSARBuySignals As New WebBrowser
    Public webTBuStocksInANewUptrendAroon As New WebBrowser
    Public webTBuStocksInANewUptrendADX As New WebBrowser
    Public webTBuGapUps As New WebBrowser
    Public webTBuBreakawayGapUps As New WebBrowser
    Public webTBuRunawayGapUps As New WebBrowser
    Public webTBuIslandBottoms As New WebBrowser

#End Region

#Region "Technical Indicators (Bearish) Webbrowsers"

    Public webTBeNew52WeekLows As New WebBrowser
    Public webTBeStrongVolumeDecliners As New WebBrowser
    Public webTBeBearish50200DayMACrossovers As New WebBrowser
    Public webTBeBearishMACDCrossovers As New WebBrowser
    Public webTBeOverboughtWithADecliningRSI As New WebBrowser
    Public webTBeMovedBelowLowerBollingerBand As New WebBrowser
    Public webTBeMovedBelowLowerPriceChannel As New WebBrowser
    Public webTBeMovedBelowLowerKeltnerChannel As New WebBrowser
    Public webTBeDecliningChaikinMoneyFlow As New WebBrowser

    Public webTBeNewCCISellSignals As New WebBrowser
    Public webTBeParabolicSARSellSignals As New WebBrowser
    Public webTBeStocksInANewDowntrendAroon As New WebBrowser
    Public webTBeStocksInANewDowntrendADX As New WebBrowser
    Public webTBeGapDowns As New WebBrowser
    Public webTBeBreakawayGapDowns As New WebBrowser
    Public webTBeRunawayGapDowns As New WebBrowser
    Public webTBeIslandTops As New WebBrowser

#End Region

#Region "Candlestick Patterns Webbrowsers"

    Public webCsPBullishEngulfing As New WebBrowser
    Public webCsPPiercingLine As New WebBrowser
    Public webCsPMorningStar As New WebBrowser
    Public webCsPBullishHarami As New WebBrowser
    Public webCsPThreeWhiteSoldiers As New WebBrowser

    Public webCsPBearishEngulfing As New WebBrowser
    Public webCsPDarkCloudCover As New WebBrowser
    Public webCsPEveningStar As New WebBrowser
    Public webCsPBearishHarami As New WebBrowser
    Public webCsPThreeBlackCrows As New WebBrowser

    Public webCsPRisingThreeMethods As New WebBrowser
    Public webCsPFallingThreeMethods As New WebBrowser

    Public webCsPDragonflyDoji As New WebBrowser
    Public webCsPGravestoneDoji As New WebBrowser
    Public webCsPHammer As New WebBrowser
    Public webCsPShootingStar As New WebBrowser
    Public webCsPFilledBlackCandles As New WebBrowser
    Public webCsPHollowRedCandles As New WebBrowser

    Public webCsPElderBarTurnedRed As New WebBrowser
    Public webCsPElderBarTurnedBlue As New WebBrowser
    Public webCsPElderBarTurnedGreen As New WebBrowser

    Public webCsPEnteredIchimokuCloud As New WebBrowser
    Public webCsPMovedAboveIchimokuCloud As New WebBrowser
    Public webCsPMovedBelowIchimokuCloud As New WebBrowser
    Public webCsPIchimokuCloudTurnedGreen As New WebBrowser
    Public webCsPIchimokuCloudTurnedRed As New WebBrowser

#End Region

#Region "P&F Patterns (Bullish) Webbrowsers"

    Public webPFBuPFTripleTopBreakout As New WebBrowser
    Public webPFBuPFSpreadTripleTopBreakout As New WebBrowser
    Public webPFBuPFAscendingTripleTopBreakout As New WebBrowser
    Public webPFBuPFQuadrupleTopBreakout As New WebBrowser
    Public webPFBuPFBearishSignalReversal As New WebBrowser

    Public webPFBuPFBearTrap As New WebBrowser
    Public webPFBuPFBullishCatapult As New WebBrowser
    Public webPFBuPFBullishTriangle As New WebBrowser
    Public webPFBuPFLowPole As New WebBrowser

#End Region

#Region "P&F Patterns (Bearish) Webbrowsers"

    Public webPFBePFTripleBottomBreakdown As New WebBrowser
    Public webPFBePFSpreadTripleBottomBreakdown As New WebBrowser
    Public webPFBePFDescendingTripleBottomBreakdown As New WebBrowser
    Public webPFBePFQuadrupleBottomBreakdown As New WebBrowser
    Public webPFBePFBullishSignalReversal As New WebBrowser

    Public webPFBePFBullTrap As New WebBrowser
    Public webPFBePFBearishCatapult As New WebBrowser
    Public webPFBePFBearishTriangle As New WebBrowser
    Public webPFBePFHighPole As New WebBrowser
    Public webPFBePFLongTailDown As New WebBrowser

#End Region

#End Region

End Module
