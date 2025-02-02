'Put campaign types details
=IF(G2="Spotbuys","FCT","")&IF(G2="MARKETING","Marketing","")&IF(G2="MIRCHIMURGA","Programming","")&IF(G2="AFFILIATED","FCT","")&IF(G2="CONCERT-PROP","Concerts","")&IF(G2="MIRCHITOP20","TV","")&IF(G2="CONCERT-FCT","Concerts","")&IF(G2="SPONSORSHIP","FCT","")&IF(G2="NONFCT","FCT","")&IF(G2="ACTIVATION","MA","")&IF(G2="BARTER","MA","")&IF(G2="MASPLPROD","MA","")&IF(G2="CONCERT-BARTER","Concerts","")&IF(G2="AMPLIFICATION","FCT","")&IF(G2="TEEKHTHURSDAY","MA","")&IF(G2="MMD-FCT","MMS-FCT","")&IF(G2="TIMECHECK","MA","")&IF(G2="MAE-FCT","MA","")&IF(G2="MAE-BARTER","MA","")&IF(G2="MMA-FCT","TV","")&IF(G2="MMA-BARTER","TV","")&IF(G2="HATTRICK","MA","")&IF(G2="PATTNAPAATTU","MA","")&IF(G2="MMA","TV","")&IF(G2="MMD-MA","MMS-MA","")&IF(G2="TRAFFICBEAT","MA","")&IF(G2="MOBILEREVENUE","MA","")&IF(G2="DIGITALREVENUE","MA","")&IF(G2="FLIGHTUPDATE","MA","")&IF(G2="TEENGAANE","Programming","")&IF(G2="ROADBLOCK","FCT","")&IF(G2="INHOUSE","MA","")

'Put cluster heads details
=IF(A2="AMRITSAR - Amritsar","Bhanu","")&IF(A2="CHANDIGARH - Bhanu","NE","")&IF(A2="2KANPUR - 2 Kanpur","Pankaj","")&IF(A2="2LUCKNOW - 2 Lucknow","Pankaj","")&IF(A2="GUWAHATI - Guwahati","Bithin","")&IF(A2="JALLANDHAR - Jallandhar","Bhanu","")&IF(A2="KANPUR - Kanpur","Pankaj","")&IF(A2="KOLKATA - Kolkata","Bithin","")&IF(A2="LUCKNOW - Lucknow","Pankaj","")&IF(A2="PATIALA - Patiala","Bhanu","")&IF(A2="PATNA - Patna","Pankaj","")&IF(A2="SHILLONG - Shillong","Bithin","")&IF(A2="SHIMLA - Shimla","Bhanu","")&IF(A2="VARANASI - Varanasi","Pankaj","")&IF(A2="JAMMU - Jammu","Bhanu","")&IF(A2="Ludhiana","Bhanu","")

'Put Regions to sheet
=IF(A2="AMRITSAR - Amritsar","NE","")&IF(A2="CHANDIGARH - Chandigarh","NE","")&IF(A2="DELHI - Delhi","NE","")&IF(A2="2JAIPUR - 2 Jaipur","NE","")&IF(A2="2KANPUR - 2 Kanpur","NE","")&IF(A2="2LUCKNOW - 2 Lucknow","NE","")&IF(A2="GUWAHATI - Guwahati","NE","")&IF(A2="JAIPUR - Jaipur","NE","")&IF(A2="JALLANDHAR - Jallandhar","NE","")&IF(A2="JODHPUR - Jodhpur","NE","")&IF(A2="KANPUR - Kanpur","NE","")&IF(A2="KOLKATA - Kolkata","NE","")&IF(A2="LUCKNOW - Lucknow","NE","")&IF(A2="PATIALA - Patiala","NE","")&IF(A2="PATNA - Patna","NE","")&IF(A2="SHILLONG - Shillong","NE","")&IF(A2="SHIMLA - Shimla","NE","")&IF(A2="VARANASI - Varanasi","NE","")&IF(A2="JAMMU - Jammu","NE","")

'Main function to data cleaning and formatting
Sub Compiled()
    Rows("1:3").Select
    Selection.Delete Shift:=xlUp
    Rows("2:2").Select
    Selection.Delete Shift:=xlUp
    Columns("A:A").Select
    Selection.Insert Shift:=xlToRight
    Cells.Select
    Selection.AutoFilter
    Range("D1").Select
    ActiveSheet.Range("$A$1:$Q$5210").AutoFilter Field:=4, Criteria1:="="
    Range("B1").Select
    ActiveSheet.Range("$A$1:$Q$5210").AutoFilter Field:=2, Criteria1:="<>"
    Range("A2").Select
    ActiveCell.FormulaR1C1 = "=RC[1]"
    Range("B2").Select
    Selection.End(xlDown).Select
    Range("A5188").Select
    Range(Selection, Selection.End(xlUp)).Select
    Selection.FillDown
    Selection.End(xlUp).Select
    Selection.End(xlUp).Select
    ActiveCell.FormulaR1C1 = "Station"
    Range("B1").Select
    Range("B2").Select
    Selection.End(xlDown).Select
    Range("A5188").Select
    Range(Selection, Selection.End(xlUp)).Select
    Range("B5188").Select
    Selection.End(xlDown).Select
    Range("A65536").Select
    Range(Selection, Selection.End(xlUp)).Select
    Selection.FillDown
    Selection.End(xlUp).Select
    Selection.End(xlUp).Select
    Range("B1").Select
    Selection.AutoFilter
    Columns("A:A").Select
    Range("A3").Activate
    Selection.SpecialCells(xlCellTypeBlanks).Select
    Selection.FormulaR1C1 = "=R[-1]C"
    Range("A1").Select
    Range(Selection, Selection.End(xlDown)).Select
    Range("A2").Select
    Selection.End(xlDown).Select
    Selection.End(xlUp).Select
    Selection.End(xlUp).Select
    Range("I1").Select
    With Selection
        .HorizontalAlignment = xlLeft
        .VerticalAlignment = xlCenter
        .WrapText = False
        .Orientation = 0
        .AddIndent = False
        .IndentLevel = 0
        .ShrinkToFit = False
        .ReadingOrder = xlContext
        .MergeCells = False
    End With
    ActiveCell.FormulaR1C1 = "Typeds"
    With ActiveCell.Characters(Start:=1, Length:=6).Font
        .Name = "Arial"
        .FontStyle = "Regular"
        .Size = 7.9
        .Strikethrough = False
        .Superscript = False
        .Subscript = False
        .OutlineFont = False
        .Shadow = False
        .Underline = xlUnderlineStyleNone
        .ColorIndex = 1
        .TintAndShade = 0
        .ThemeFont = xlThemeFontNone
    End With
    Range("I1").Select
    ActiveCell.FormulaR1C1 = "Types"
    With ActiveCell.Characters(Start:=1, Length:=5).Font
        .Name = "Arial"
        .FontStyle = "Regular"
        .Size = 7.9
        .Strikethrough = False
        .Superscript = False
        .Subscript = False
        .OutlineFont = False
        .Shadow = False
        .Underline = xlUnderlineStyleNone
        .ColorIndex = 1
        .TintAndShade = 0
        .ThemeFont = xlThemeFontNone
    End With
    Columns("E:E").Select
    Selection.Delete Shift:=xlToLeft
    Columns("N:N").Select
    Selection.Delete Shift:=xlToLeft
    Columns("L:L").Select
    Selection.Delete Shift:=xlToLeft
    Range("H1").Select
    Selection.AutoFilter
    Range("G1").Select
    Selection.End(xlToLeft).Select
    Selection.End(xlToLeft).Select
    Range("A2").Select
    Range(Selection, Selection.End(xlDown)).Select
    Selection.Copy
    Selection.PasteSpecial Paste:=xlPasteValues, Operation:=xlNone, SkipBlanks _
        :=False, Transpose:=False
    Range("A1").Select
    Selection.End(xlUp).Select
    Range("C1").Select
    ActiveSheet.Range("$A:$N").AutoFilter Field:=3, Criteria1:="="
    Rows("2:2").Select
    Range("B2").Activate
    Range(Selection, Selection.End(xlDown)).Select
    Range(Selection, Selection.End(xlDown)).Select
    Range(Selection, Selection.End(xlDown)).Select
    Range(Selection, Selection.End(xlDown)).Select
    Rows("2:5210").Select
    Range("B2").Activate
    Range(Selection, Selection.End(xlDown)).Select
    Application.CutCopyMode = False
    Selection.Delete Shift:=xlUp
    Range("B1").Select
    Selection.AutoFilter
    Range("E1").Select
    Selection.AutoFilter
    Range("F1").Select
    ActiveSheet.Range("$A$1:$N$5102").AutoFilter Field:=6, Criteria1:=Array( _
        "AFFILIATED", "AMPLI/BARTER/PRE/FCT", "AMPLIFICATION", "ROADBLOCK", "SPOTBUYS"), _
        Operator:=xlFilterValues
    Range("H3").Select
    With Selection
        .HorizontalAlignment = xlGeneral
        .VerticalAlignment = xlCenter
        .WrapText = False
        .Orientation = 0
        .AddIndent = False
        .ShrinkToFit = False
        .ReadingOrder = xlContext
        .MergeCells = False
    End With
    ActiveCell.FormulaR1C1 = "FCT"
    With ActiveCell.Characters(Start:=1, Length:=3).Font
        .Name = "Arial"
        .FontStyle = "Regular"
        .Size = 7.9
        .Strikethrough = False
        .Superscript = False
        .Subscript = False
        .OutlineFont = False
        .Shadow = False
        .Underline = xlUnderlineStyleNone
        .ColorIndex = 1
        .TintAndShade = 0
        .ThemeFont = xlThemeFontNone
    End With
    Range("G3").Select
    Selection.End(xlDown).Select
    Range("H5102").Select
    Range(Selection, Selection.End(xlUp)).Select
    Selection.FillDown
    Selection.End(xlUp).Select
    Selection.End(xlUp).Select
    Range("H1").Select
    Selection.End(xlDown).Select
    Range("H5103").Select
    Selection.End(xlDown).Select
    Range(Selection, Selection.End(xlUp)).Select
    Selection.FillDown
    Selection.End(xlUp).Select
    Range("F1").Select
    Selection.End(xlDown).Select
    Range("G65536").Select
    Selection.End(xlUp).Select
    Range("H5103").Select
    Range(Selection, Selection.End(xlDown)).Select
    Selection.ClearContents
    Range("H5102").Select
    Selection.End(xlUp).Select
    Selection.End(xlUp).Select
    Range("F1").Select
    ActiveSheet.Range("$A$1:$N$5102").AutoFilter Field:=6
    Range("H1").Select
    ActiveSheet.Range("$A$1:$N$5102").AutoFilter Field:=8, Criteria1:="="
    Range("F1").Select
    ActiveSheet.Range("$A$1:$N$5102").AutoFilter Field:=6, Criteria1:=Array( _
        "CONCER-BARTER-FCT", "CONCERT-BARTER", "CONCERT-FCT", "CONCERT-PROP", _
        "CONCERT-TICKETS"), Operator:=xlFilterValues
    Range("H59").Select
    With Selection
        .HorizontalAlignment = xlGeneral
        .VerticalAlignment = xlCenter
        .WrapText = False
        .Orientation = 0
        .AddIndent = False
        .ShrinkToFit = False
        .ReadingOrder = xlContext
        .MergeCells = False
    End With
    ActiveCell.FormulaR1C1 = "Concerts"
    With ActiveCell.Characters(Start:=1, Length:=8).Font
        .Name = "Arial"
        .FontStyle = "Regular"
        .Size = 7.9
        .Strikethrough = False
        .Superscript = False
        .Subscript = False
        .OutlineFont = False
        .Shadow = False
        .Underline = xlUnderlineStyleNone
        .ColorIndex = 1
        .TintAndShade = 0
        .ThemeFont = xlThemeFontNone
    End With
    Range("G59").Select
    Selection.End(xlDown).Select
    Range("H4971").Select
    Range(Selection, Selection.End(xlUp)).Select
    Selection.FillDown
    Selection.End(xlUp).Select
    Selection.End(xlUp).Select
    Range("F1").Select
    ActiveSheet.Range("$A$1:$N$5102").AutoFilter Field:=6, Criteria1:=Array( _
        "MIRCHITOP20", "MMA", "MMA-BARTER", "MMA-BARTERFCT", "MMA-FCT"), Operator:= _
        xlFilterValues
    Range("H656").Select
    With Selection
        .HorizontalAlignment = xlGeneral
        .VerticalAlignment = xlCenter
        .WrapText = False
        .Orientation = 0
        .AddIndent = False
        .ShrinkToFit = False
        .ReadingOrder = xlContext
        .MergeCells = False
    End With
    ActiveCell.FormulaR1C1 = "TV"
    With ActiveCell.Characters(Start:=1, Length:=2).Font
        .Name = "Arial"
        .FontStyle = "Regular"
        .Size = 7.9
        .Strikethrough = False
        .Superscript = False
        .Subscript = False
        .OutlineFont = False
        .Shadow = False
        .Underline = xlUnderlineStyleNone
        .ColorIndex = 1
        .TintAndShade = 0
        .ThemeFont = xlThemeFontNone
    End With
    Range("G657").Select
    Selection.End(xlDown).Select
    Range("H3984").Select
    Range(Selection, Selection.End(xlUp)).Select
    Selection.FillDown
    Selection.End(xlUp).Select
    Range("F1").Select
    ActiveSheet.Range("$A$1:$N$5102").AutoFilter Field:=6, Criteria1:="NONFCT"
    Range("H40").Select
    With Selection
        .HorizontalAlignment = xlGeneral
        .VerticalAlignment = xlCenter
        .WrapText = False
        .Orientation = 0
        .AddIndent = False
        .ShrinkToFit = False
        .ReadingOrder = xlContext
        .MergeCells = False
    End With
    ActiveCell.FormulaR1C1 = "FCT"
    With ActiveCell.Characters(Start:=1, Length:=3).Font
        .Name = "Arial"
        .FontStyle = "Regular"
        .Size = 7.9
        .Strikethrough = False
        .Superscript = False
        .Subscript = False
        .OutlineFont = False
        .Shadow = False
        .Underline = xlUnderlineStyleNone
        .ColorIndex = 1
        .TintAndShade = 0
        .ThemeFont = xlThemeFontNone
    End With
    Range("G41").Select
    Selection.End(xlDown).Select
    Range("H4985").Select
    Range(Selection, Selection.End(xlUp)).Select
    Selection.FillDown
    Selection.End(xlUp).Select
    Range("F1").Select
    ActiveSheet.Range("$A$1:$N$5102").AutoFilter Field:=6, Criteria1:="=MMD-MA" _
        , Operator:=xlOr, Criteria2:="=MMD-MA-PRINT"
    Range("H468").Select
    With Selection
        .HorizontalAlignment = xlGeneral
        .VerticalAlignment = xlCenter
        .WrapText = False
        .Orientation = 0
        .AddIndent = False
        .ShrinkToFit = False
        .ReadingOrder = xlContext
        .MergeCells = False
    End With
    ActiveCell.FormulaR1C1 = "MMS-MA"
    With ActiveCell.Characters(Start:=1, Length:=6).Font
        .Name = "Arial"
        .FontStyle = "Regular"
        .Size = 7.9
        .Strikethrough = False
        .Superscript = False
        .Subscript = False
        .OutlineFont = False
        .Shadow = False
        .Underline = xlUnderlineStyleNone
        .ColorIndex = 1
        .TintAndShade = 0
        .ThemeFont = xlThemeFontNone
    End With
    Range("G468").Select
    Selection.End(xlDown).Select
    Range("H3274").Select
    Range(Selection, Selection.End(xlUp)).Select
    Selection.FillDown
    Selection.End(xlUp).Select
    Range("F1").Select
    ActiveSheet.Range("$A$1:$N$5102").AutoFilter Field:=6, Criteria1:= _
        "=MMD-FCT", Operator:=xlOr, Criteria2:="=MMD-FCT-PRINT"
    Range("H167").Select
    With Selection
        .HorizontalAlignment = xlGeneral
        .VerticalAlignment = xlCenter
        .WrapText = False
        .Orientation = 0
        .AddIndent = False
        .ShrinkToFit = False
        .ReadingOrder = xlContext
        .MergeCells = False
    End With
    ActiveCell.FormulaR1C1 = "MMS-FCT"
    With ActiveCell.Characters(Start:=1, Length:=7).Font
        .Name = "Arial"
        .FontStyle = "Regular"
        .Size = 7.9
        .Strikethrough = False
        .Superscript = False
        .Subscript = False
        .OutlineFont = False
        .Shadow = False
        .Underline = xlUnderlineStyleNone
        .ColorIndex = 1
        .TintAndShade = 0
        .ThemeFont = xlThemeFontNone
    End With
    Range("G168").Select
    Selection.End(xlDown).Select
    Range("H5075").Select
    Range(Selection, Selection.End(xlUp)).Select
    Selection.FillDown
    Selection.End(xlUp).Select
    Range("F1").Select
    ActiveSheet.Range("$A$1:$N$5102").AutoFilter Field:=6, Criteria1:= _
        "MARKETING"
    Range("H2").Select
    With Selection
        .HorizontalAlignment = xlGeneral
        .VerticalAlignment = xlCenter
        .WrapText = False
        .Orientation = 0
        .AddIndent = False
        .ShrinkToFit = False
        .ReadingOrder = xlContext
        .MergeCells = False
    End With
    ActiveCell.FormulaR1C1 = "Marketing"
    With ActiveCell.Characters(Start:=1, Length:=9).Font
        .Name = "Arial"
        .FontStyle = "Regular"
        .Size = 7.9
        .Strikethrough = False
        .Superscript = False
        .Subscript = False
        .OutlineFont = False
        .Shadow = False
        .Underline = xlUnderlineStyleNone
        .ColorIndex = 1
        .TintAndShade = 0
        .ThemeFont = xlThemeFontNone
    End With
    Range("G2").Select
    Selection.End(xlDown).Select
    Range("H4828").Select
    Range(Selection, Selection.End(xlUp)).Select
    Selection.FillDown
    Selection.End(xlUp).Select
    Range("F1").Select
    ActiveSheet.Range("$A$1:$N$5102").AutoFilter Field:=6
    Range("H10").Select
    With Selection
        .HorizontalAlignment = xlGeneral
        .VerticalAlignment = xlCenter
        .WrapText = False
        .Orientation = 0
        .AddIndent = False
        .ShrinkToFit = False
        .ReadingOrder = xlContext
        .MergeCells = False
    End With
    ActiveCell.FormulaR1C1 = "Marketing"
    With ActiveCell.Characters(Start:=1, Length:=9).Font
        .Name = "Arial"
        .FontStyle = "Regular"
        .Size = 7.9
        .Strikethrough = False
        .Superscript = False
        .Subscript = False
        .OutlineFont = False
        .Shadow = False
        .Underline = xlUnderlineStyleNone
        .ColorIndex = 1
        .TintAndShade = 0
        .ThemeFont = xlThemeFontNone
    End With
    Range("H10").Select
    ActiveCell.FormulaR1C1 = "MA"
    Range("G10").Select
    Selection.End(xlDown).Select
    Range("H5061").Select
    Range(Selection, Selection.End(xlUp)).Select
    Selection.FillDown
    Selection.End(xlUp).Select
    Selection.End(xlUp).Select
    Selection.AutoFilter
    Selection.End(xlToLeft).Select
    Selection.End(xlToLeft).Select
End Sub
