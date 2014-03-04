using DocumentFormat.OpenXml.Packaging;
using Ap = DocumentFormat.OpenXml.ExtendedProperties;
using Vt = DocumentFormat.OpenXml.VariantTypes;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Wordprocessing;
using M = DocumentFormat.OpenXml.Math;
using Ovml = DocumentFormat.OpenXml.Vml.Office;
using V = DocumentFormat.OpenXml.Vml;
using A = DocumentFormat.OpenXml.Drawing;

namespace Diagnostics_FP.GeneratedXML
{
    public class GeneratedClass
    {
        // Creates a WordprocessingDocument.
        public void CreatePackage(string filePath)
        {
            using (WordprocessingDocument package = WordprocessingDocument.Create(filePath, WordprocessingDocumentType.Document))
            {
                CreateParts(package);
            }
        }

        // Adds child parts and generates content of the specified part.
        private void CreateParts(WordprocessingDocument document)
        {
            ExtendedFilePropertiesPart extendedFilePropertiesPart1 = document.AddNewPart<ExtendedFilePropertiesPart>("rId3");
            GenerateExtendedFilePropertiesPart1Content(extendedFilePropertiesPart1);

            MainDocumentPart mainDocumentPart1 = document.AddMainDocumentPart();
            GenerateMainDocumentPart1Content(mainDocumentPart1);

            FooterPart footerPart1 = mainDocumentPart1.AddNewPart<FooterPart>("rId8");
            GenerateFooterPart1Content(footerPart1);

            DocumentSettingsPart documentSettingsPart1 = mainDocumentPart1.AddNewPart<DocumentSettingsPart>("rId3");
            GenerateDocumentSettingsPart1Content(documentSettingsPart1);

            HeaderPart headerPart1 = mainDocumentPart1.AddNewPart<HeaderPart>("rId7");
            GenerateHeaderPart1Content(headerPart1);

            StylesWithEffectsPart stylesWithEffectsPart1 = mainDocumentPart1.AddNewPart<StylesWithEffectsPart>("rId2");
            GenerateStylesWithEffectsPart1Content(stylesWithEffectsPart1);

            StyleDefinitionsPart styleDefinitionsPart1 = mainDocumentPart1.AddNewPart<StyleDefinitionsPart>("rId1");
            GenerateStyleDefinitionsPart1Content(styleDefinitionsPart1);

            EndnotesPart endnotesPart1 = mainDocumentPart1.AddNewPart<EndnotesPart>("rId6");
            GenerateEndnotesPart1Content(endnotesPart1);

            FootnotesPart footnotesPart1 = mainDocumentPart1.AddNewPart<FootnotesPart>("rId5");
            GenerateFootnotesPart1Content(footnotesPart1);

            ThemePart themePart1 = mainDocumentPart1.AddNewPart<ThemePart>("rId10");
            GenerateThemePart1Content(themePart1);

            WebSettingsPart webSettingsPart1 = mainDocumentPart1.AddNewPart<WebSettingsPart>("rId4");
            GenerateWebSettingsPart1Content(webSettingsPart1);

            FontTablePart fontTablePart1 = mainDocumentPart1.AddNewPart<FontTablePart>("rId9");
            GenerateFontTablePart1Content(fontTablePart1);

            SetPackageProperties(document);
        }

        // Generates content of extendedFilePropertiesPart1.
        private void GenerateExtendedFilePropertiesPart1Content(ExtendedFilePropertiesPart extendedFilePropertiesPart1)
        {
            Ap.Properties properties1 = new Ap.Properties();
            properties1.AddNamespaceDeclaration("vt", "http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes");
            Ap.Template template1 = new Ap.Template();
            template1.Text = "Normal.dotm";
            Ap.TotalTime totalTime1 = new Ap.TotalTime();
            totalTime1.Text = "0";
            Ap.Pages pages1 = new Ap.Pages();
            pages1.Text = "1";
            Ap.Words words1 = new Ap.Words();
            words1.Text = "94";
            Ap.Characters characters1 = new Ap.Characters();
            characters1.Text = "538";
            Ap.Application application1 = new Ap.Application();
            application1.Text = "Microsoft Office Word";
            Ap.DocumentSecurity documentSecurity1 = new Ap.DocumentSecurity();
            documentSecurity1.Text = "0";
            Ap.Lines lines1 = new Ap.Lines();
            lines1.Text = "4";
            Ap.Paragraphs paragraphs1 = new Ap.Paragraphs();
            paragraphs1.Text = "1";
            Ap.ScaleCrop scaleCrop1 = new Ap.ScaleCrop();
            scaleCrop1.Text = "false";

            Ap.HeadingPairs headingPairs1 = new Ap.HeadingPairs();

            Vt.VTVector vTVector1 = new Vt.VTVector() { BaseType = Vt.VectorBaseValues.Variant, Size = (UInt32Value)2U };

            Vt.Variant variant1 = new Vt.Variant();
            Vt.VTLPSTR vTLPSTR1 = new Vt.VTLPSTR();
            vTLPSTR1.Text = "Название";

            variant1.Append(vTLPSTR1);

            Vt.Variant variant2 = new Vt.Variant();
            Vt.VTInt32 vTInt321 = new Vt.VTInt32();
            vTInt321.Text = "1";

            variant2.Append(vTInt321);

            vTVector1.Append(variant1);
            vTVector1.Append(variant2);

            headingPairs1.Append(vTVector1);

            Ap.TitlesOfParts titlesOfParts1 = new Ap.TitlesOfParts();

            Vt.VTVector vTVector2 = new Vt.VTVector() { BaseType = Vt.VectorBaseValues.Lpstr, Size = (UInt32Value)1U };
            Vt.VTLPSTR vTLPSTR2 = new Vt.VTLPSTR();
            vTLPSTR2.Text = "";

            vTVector2.Append(vTLPSTR2);

            titlesOfParts1.Append(vTVector2);
            Ap.Company company1 = new Ap.Company();
            company1.Text = "";
            Ap.LinksUpToDate linksUpToDate1 = new Ap.LinksUpToDate();
            linksUpToDate1.Text = "false";
            Ap.CharactersWithSpaces charactersWithSpaces1 = new Ap.CharactersWithSpaces();
            charactersWithSpaces1.Text = "631";
            Ap.SharedDocument sharedDocument1 = new Ap.SharedDocument();
            sharedDocument1.Text = "false";
            Ap.HyperlinksChanged hyperlinksChanged1 = new Ap.HyperlinksChanged();
            hyperlinksChanged1.Text = "false";
            Ap.ApplicationVersion applicationVersion1 = new Ap.ApplicationVersion();
            applicationVersion1.Text = "14.0000";

            properties1.Append(template1);
            properties1.Append(totalTime1);
            properties1.Append(pages1);
            properties1.Append(words1);
            properties1.Append(characters1);
            properties1.Append(application1);
            properties1.Append(documentSecurity1);
            properties1.Append(lines1);
            properties1.Append(paragraphs1);
            properties1.Append(scaleCrop1);
            properties1.Append(headingPairs1);
            properties1.Append(titlesOfParts1);
            properties1.Append(company1);
            properties1.Append(linksUpToDate1);
            properties1.Append(charactersWithSpaces1);
            properties1.Append(sharedDocument1);
            properties1.Append(hyperlinksChanged1);
            properties1.Append(applicationVersion1);

            extendedFilePropertiesPart1.Properties = properties1;
        }

        // Generates content of mainDocumentPart1.
        private void GenerateMainDocumentPart1Content(MainDocumentPart mainDocumentPart1)
        {
            Document document1 = new Document() { MCAttributes = new MarkupCompatibilityAttributes() { Ignorable = "w14 wp14" } };
            document1.AddNamespaceDeclaration("wpc", "http://schemas.microsoft.com/office/word/2010/wordprocessingCanvas");
            document1.AddNamespaceDeclaration("mc", "http://schemas.openxmlformats.org/markup-compatibility/2006");
            document1.AddNamespaceDeclaration("o", "urn:schemas-microsoft-com:office:office");
            document1.AddNamespaceDeclaration("r", "http://schemas.openxmlformats.org/officeDocument/2006/relationships");
            document1.AddNamespaceDeclaration("m", "http://schemas.openxmlformats.org/officeDocument/2006/math");
            document1.AddNamespaceDeclaration("v", "urn:schemas-microsoft-com:vml");
            document1.AddNamespaceDeclaration("wp14", "http://schemas.microsoft.com/office/word/2010/wordprocessingDrawing");
            document1.AddNamespaceDeclaration("wp", "http://schemas.openxmlformats.org/drawingml/2006/wordprocessingDrawing");
            document1.AddNamespaceDeclaration("w10", "urn:schemas-microsoft-com:office:word");
            document1.AddNamespaceDeclaration("w", "http://schemas.openxmlformats.org/wordprocessingml/2006/main");
            document1.AddNamespaceDeclaration("w14", "http://schemas.microsoft.com/office/word/2010/wordml");
            document1.AddNamespaceDeclaration("wpg", "http://schemas.microsoft.com/office/word/2010/wordprocessingGroup");
            document1.AddNamespaceDeclaration("wpi", "http://schemas.microsoft.com/office/word/2010/wordprocessingInk");
            document1.AddNamespaceDeclaration("wne", "http://schemas.microsoft.com/office/word/2006/wordml");
            document1.AddNamespaceDeclaration("wps", "http://schemas.microsoft.com/office/word/2010/wordprocessingShape");

            Body body1 = new Body();

            Paragraph paragraph1 = new Paragraph() { RsidParagraphAddition = "00900A10", RsidParagraphProperties = "00900A10", RsidRunAdditionDefault = "00900A10" };

            ParagraphProperties paragraphProperties1 = new ParagraphProperties();
            WidowControl widowControl1 = new WidowControl() { Val = false };
            AutoSpaceDE autoSpaceDE1 = new AutoSpaceDE() { Val = false };
            AutoSpaceDN autoSpaceDN1 = new AutoSpaceDN() { Val = false };
            AdjustRightIndent adjustRightIndent1 = new AdjustRightIndent() { Val = false };
            SpacingBetweenLines spacingBetweenLines1 = new SpacingBetweenLines() { After = "0", Line = "240", LineRule = LineSpacingRuleValues.Auto };

            ParagraphMarkRunProperties paragraphMarkRunProperties1 = new ParagraphMarkRunProperties();
            RunFonts runFonts1 = new RunFonts() { Ascii = "New Roman", HighAnsi = "New Roman", EastAsia = "New Roman", ComplexScript = "Times New Roman" };
            FontSize fontSize1 = new FontSize() { Val = "24" };
            FontSizeComplexScript fontSizeComplexScript1 = new FontSizeComplexScript() { Val = "24" };

            paragraphMarkRunProperties1.Append(runFonts1);
            paragraphMarkRunProperties1.Append(fontSize1);
            paragraphMarkRunProperties1.Append(fontSizeComplexScript1);

            paragraphProperties1.Append(widowControl1);
            paragraphProperties1.Append(autoSpaceDE1);
            paragraphProperties1.Append(autoSpaceDN1);
            paragraphProperties1.Append(adjustRightIndent1);
            paragraphProperties1.Append(spacingBetweenLines1);
            paragraphProperties1.Append(paragraphMarkRunProperties1);

            paragraph1.Append(paragraphProperties1);

            Paragraph paragraph2 = new Paragraph() { RsidParagraphAddition = "00900A10", RsidParagraphProperties = "00900A10", RsidRunAdditionDefault = "00900A10" };

            ParagraphProperties paragraphProperties2 = new ParagraphProperties();
            WidowControl widowControl2 = new WidowControl() { Val = false };
            AutoSpaceDE autoSpaceDE2 = new AutoSpaceDE() { Val = false };
            AutoSpaceDN autoSpaceDN2 = new AutoSpaceDN() { Val = false };
            AdjustRightIndent adjustRightIndent2 = new AdjustRightIndent() { Val = false };
            SpacingBetweenLines spacingBetweenLines2 = new SpacingBetweenLines() { After = "0", Line = "240", LineRule = LineSpacingRuleValues.Auto };

            ParagraphMarkRunProperties paragraphMarkRunProperties2 = new ParagraphMarkRunProperties();
            RunFonts runFonts2 = new RunFonts() { Ascii = "New Roman", HighAnsi = "New Roman", EastAsia = "New Roman", ComplexScript = "Times New Roman" };
            FontSize fontSize2 = new FontSize() { Val = "24" };
            FontSizeComplexScript fontSizeComplexScript2 = new FontSizeComplexScript() { Val = "24" };

            paragraphMarkRunProperties2.Append(runFonts2);
            paragraphMarkRunProperties2.Append(fontSize2);
            paragraphMarkRunProperties2.Append(fontSizeComplexScript2);

            paragraphProperties2.Append(widowControl2);
            paragraphProperties2.Append(autoSpaceDE2);
            paragraphProperties2.Append(autoSpaceDN2);
            paragraphProperties2.Append(adjustRightIndent2);
            paragraphProperties2.Append(spacingBetweenLines2);
            paragraphProperties2.Append(paragraphMarkRunProperties2);

            paragraph2.Append(paragraphProperties2);

            Paragraph paragraph3 = new Paragraph() { RsidParagraphAddition = "00900A10", RsidParagraphProperties = "00900A10", RsidRunAdditionDefault = "00900A10" };

            ParagraphProperties paragraphProperties3 = new ParagraphProperties();
            WidowControl widowControl3 = new WidowControl() { Val = false };
            AutoSpaceDE autoSpaceDE3 = new AutoSpaceDE() { Val = false };
            AutoSpaceDN autoSpaceDN3 = new AutoSpaceDN() { Val = false };
            AdjustRightIndent adjustRightIndent3 = new AdjustRightIndent() { Val = false };
            SpacingBetweenLines spacingBetweenLines3 = new SpacingBetweenLines() { After = "0", Line = "240", LineRule = LineSpacingRuleValues.Auto };
            Justification justification1 = new Justification() { Val = JustificationValues.Center };

            ParagraphMarkRunProperties paragraphMarkRunProperties3 = new ParagraphMarkRunProperties();
            RunFonts runFonts3 = new RunFonts() { Ascii = "Verdana", HighAnsi = "Verdana", EastAsia = "New Roman", ComplexScript = "Verdana" };
            FontSize fontSize3 = new FontSize() { Val = "20" };
            FontSizeComplexScript fontSizeComplexScript3 = new FontSizeComplexScript() { Val = "20" };

            paragraphMarkRunProperties3.Append(runFonts3);
            paragraphMarkRunProperties3.Append(fontSize3);
            paragraphMarkRunProperties3.Append(fontSizeComplexScript3);

            paragraphProperties3.Append(widowControl3);
            paragraphProperties3.Append(autoSpaceDE3);
            paragraphProperties3.Append(autoSpaceDN3);
            paragraphProperties3.Append(adjustRightIndent3);
            paragraphProperties3.Append(spacingBetweenLines3);
            paragraphProperties3.Append(justification1);
            paragraphProperties3.Append(paragraphMarkRunProperties3);

            Run run1 = new Run();

            RunProperties runProperties1 = new RunProperties();
            RunFonts runFonts4 = new RunFonts() { Ascii = "Verdana", HighAnsi = "Verdana", EastAsia = "New Roman", ComplexScript = "Verdana" };
            FontSize fontSize4 = new FontSize() { Val = "20" };
            FontSizeComplexScript fontSizeComplexScript4 = new FontSizeComplexScript() { Val = "20" };

            runProperties1.Append(runFonts4);
            runProperties1.Append(fontSize4);
            runProperties1.Append(fontSizeComplexScript4);
            Text text1 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text1.Text = " ";

            run1.Append(runProperties1);
            run1.Append(text1);

            Run run2 = new Run() { RsidRunAddition = "00D60978" };

            RunProperties runProperties2 = new RunProperties();
            RunFonts runFonts5 = new RunFonts() { Ascii = "Verdana", HighAnsi = "Verdana", EastAsia = "New Roman", ComplexScript = "Verdana" };
            Bold bold1 = new Bold();
            BoldComplexScript boldComplexScript1 = new BoldComplexScript();
            FontSize fontSize5 = new FontSize() { Val = "20" };
            FontSizeComplexScript fontSizeComplexScript5 = new FontSizeComplexScript() { Val = "20" };

            runProperties2.Append(runFonts5);
            runProperties2.Append(bold1);
            runProperties2.Append(boldComplexScript1);
            runProperties2.Append(fontSize5);
            runProperties2.Append(fontSizeComplexScript5);
            Text text2 = new Text();
            text2.Text = "МИКРОБИОЛОГИЧЕСКОЕ ИССЛЕДОВАНИЕ";

            run2.Append(runProperties2);
            run2.Append(text2);

            Run run3 = new Run();

            RunProperties runProperties3 = new RunProperties();
            RunFonts runFonts6 = new RunFonts() { Ascii = "Verdana", HighAnsi = "Verdana", EastAsia = "New Roman", ComplexScript = "Verdana" };
            Bold bold2 = new Bold();
            BoldComplexScript boldComplexScript2 = new BoldComplexScript();
            FontSize fontSize6 = new FontSize() { Val = "20" };
            FontSizeComplexScript fontSizeComplexScript6 = new FontSizeComplexScript() { Val = "20" };

            runProperties3.Append(runFonts6);
            runProperties3.Append(bold2);
            runProperties3.Append(boldComplexScript2);
            runProperties3.Append(fontSize6);
            runProperties3.Append(fontSizeComplexScript6);
            Text text3 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text3.Text = " № 0000";

            run3.Append(runProperties3);
            run3.Append(text3);

            Run run4 = new Run() { RsidRunAddition = "00D60978" };

            RunProperties runProperties4 = new RunProperties();
            RunFonts runFonts7 = new RunFonts() { Ascii = "Verdana", HighAnsi = "Verdana", EastAsia = "New Roman", ComplexScript = "Verdana" };
            Bold bold3 = new Bold();
            BoldComplexScript boldComplexScript3 = new BoldComplexScript();
            FontSize fontSize7 = new FontSize() { Val = "20" };
            FontSizeComplexScript fontSizeComplexScript7 = new FontSizeComplexScript() { Val = "20" };

            runProperties4.Append(runFonts7);
            runProperties4.Append(bold3);
            runProperties4.Append(boldComplexScript3);
            runProperties4.Append(fontSize7);
            runProperties4.Append(fontSizeComplexScript7);
            Text text4 = new Text();
            text4.Text = "01";

            run4.Append(runProperties4);
            run4.Append(text4);

            paragraph3.Append(paragraphProperties3);
            paragraph3.Append(run1);
            paragraph3.Append(run2);
            paragraph3.Append(run3);
            paragraph3.Append(run4);

            Paragraph paragraph4 = new Paragraph() { RsidParagraphAddition = "00900A10", RsidParagraphProperties = "00900A10", RsidRunAdditionDefault = "00900A10" };

            ParagraphProperties paragraphProperties4 = new ParagraphProperties();
            WidowControl widowControl4 = new WidowControl() { Val = false };
            AutoSpaceDE autoSpaceDE4 = new AutoSpaceDE() { Val = false };
            AutoSpaceDN autoSpaceDN4 = new AutoSpaceDN() { Val = false };
            AdjustRightIndent adjustRightIndent4 = new AdjustRightIndent() { Val = false };
            SpacingBetweenLines spacingBetweenLines4 = new SpacingBetweenLines() { After = "0", Line = "240", LineRule = LineSpacingRuleValues.Auto };
            Justification justification2 = new Justification() { Val = JustificationValues.Center };

            ParagraphMarkRunProperties paragraphMarkRunProperties4 = new ParagraphMarkRunProperties();
            RunFonts runFonts8 = new RunFonts() { Ascii = "Verdana", HighAnsi = "Verdana", EastAsia = "New Roman", ComplexScript = "Verdana" };
            FontSize fontSize8 = new FontSize() { Val = "20" };
            FontSizeComplexScript fontSizeComplexScript8 = new FontSizeComplexScript() { Val = "20" };

            paragraphMarkRunProperties4.Append(runFonts8);
            paragraphMarkRunProperties4.Append(fontSize8);
            paragraphMarkRunProperties4.Append(fontSizeComplexScript8);

            paragraphProperties4.Append(widowControl4);
            paragraphProperties4.Append(autoSpaceDE4);
            paragraphProperties4.Append(autoSpaceDN4);
            paragraphProperties4.Append(adjustRightIndent4);
            paragraphProperties4.Append(spacingBetweenLines4);
            paragraphProperties4.Append(justification2);
            paragraphProperties4.Append(paragraphMarkRunProperties4);

            paragraph4.Append(paragraphProperties4);

            Table table1 = new Table();

            TableProperties tableProperties1 = new TableProperties();
            TableStyle tableStyle1 = new TableStyle() { Val = "a3" };
            TableWidth tableWidth1 = new TableWidth() { Width = "0", Type = TableWidthUnitValues.Auto };

            TableBorders tableBorders1 = new TableBorders();
            TopBorder topBorder1 = new TopBorder() { Val = BorderValues.None, Color = "auto", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            LeftBorder leftBorder1 = new LeftBorder() { Val = BorderValues.None, Color = "auto", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            BottomBorder bottomBorder1 = new BottomBorder() { Val = BorderValues.None, Color = "auto", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            RightBorder rightBorder1 = new RightBorder() { Val = BorderValues.None, Color = "auto", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            InsideHorizontalBorder insideHorizontalBorder1 = new InsideHorizontalBorder() { Val = BorderValues.None, Color = "auto", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            InsideVerticalBorder insideVerticalBorder1 = new InsideVerticalBorder() { Val = BorderValues.None, Color = "auto", Size = (UInt32Value)0U, Space = (UInt32Value)0U };

            tableBorders1.Append(topBorder1);
            tableBorders1.Append(leftBorder1);
            tableBorders1.Append(bottomBorder1);
            tableBorders1.Append(rightBorder1);
            tableBorders1.Append(insideHorizontalBorder1);
            tableBorders1.Append(insideVerticalBorder1);
            TableLayout tableLayout1 = new TableLayout() { Type = TableLayoutValues.Fixed };
            TableLook tableLook1 = new TableLook() { Val = "0000", FirstRow = false, LastRow = false, FirstColumn = false, LastColumn = false, NoHorizontalBand = false, NoVerticalBand = false };

            tableProperties1.Append(tableStyle1);
            tableProperties1.Append(tableWidth1);
            tableProperties1.Append(tableBorders1);
            tableProperties1.Append(tableLayout1);
            tableProperties1.Append(tableLook1);

            TableGrid tableGrid1 = new TableGrid();
            GridColumn gridColumn1 = new GridColumn() { Width = "3500" };
            GridColumn gridColumn2 = new GridColumn() { Width = "5500" };

            tableGrid1.Append(gridColumn1);
            tableGrid1.Append(gridColumn2);

            TableRow tableRow1 = new TableRow() { RsidTableRowAddition = "00900A10", RsidTableRowProperties = "00D60978" };

            TableRowProperties tableRowProperties1 = new TableRowProperties();
            TableRowHeight tableRowHeight1 = new TableRowHeight() { Val = (UInt32Value)262U };

            tableRowProperties1.Append(tableRowHeight1);

            TableCell tableCell1 = new TableCell();

            TableCellProperties tableCellProperties1 = new TableCellProperties();
            TableCellWidth tableCellWidth1 = new TableCellWidth() { Width = "3500", Type = TableWidthUnitValues.Dxa };

            tableCellProperties1.Append(tableCellWidth1);

            Paragraph paragraph5 = new Paragraph() { RsidParagraphAddition = "00900A10", RsidParagraphProperties = "00B819CE", RsidRunAdditionDefault = "00900A10" };

            ParagraphProperties paragraphProperties5 = new ParagraphProperties();
            WidowControl widowControl5 = new WidowControl() { Val = false };
            AutoSpaceDE autoSpaceDE5 = new AutoSpaceDE() { Val = false };
            AutoSpaceDN autoSpaceDN5 = new AutoSpaceDN() { Val = false };
            AdjustRightIndent adjustRightIndent5 = new AdjustRightIndent() { Val = false };

            ParagraphMarkRunProperties paragraphMarkRunProperties5 = new ParagraphMarkRunProperties();
            RunFonts runFonts9 = new RunFonts() { Ascii = "Verdana", HighAnsi = "Verdana", EastAsia = "New Roman", ComplexScript = "Verdana" };
            FontSize fontSize9 = new FontSize() { Val = "20" };
            FontSizeComplexScript fontSizeComplexScript9 = new FontSizeComplexScript() { Val = "20" };

            paragraphMarkRunProperties5.Append(runFonts9);
            paragraphMarkRunProperties5.Append(fontSize9);
            paragraphMarkRunProperties5.Append(fontSizeComplexScript9);

            paragraphProperties5.Append(widowControl5);
            paragraphProperties5.Append(autoSpaceDE5);
            paragraphProperties5.Append(autoSpaceDN5);
            paragraphProperties5.Append(adjustRightIndent5);
            paragraphProperties5.Append(paragraphMarkRunProperties5);

            Run run5 = new Run();

            RunProperties runProperties5 = new RunProperties();
            RunFonts runFonts10 = new RunFonts() { Ascii = "Verdana", HighAnsi = "Verdana", EastAsia = "New Roman", ComplexScript = "Verdana" };
            Bold bold4 = new Bold();
            BoldComplexScript boldComplexScript4 = new BoldComplexScript();
            FontSize fontSize10 = new FontSize() { Val = "20" };
            FontSizeComplexScript fontSizeComplexScript10 = new FontSizeComplexScript() { Val = "20" };

            runProperties5.Append(runFonts10);
            runProperties5.Append(bold4);
            runProperties5.Append(boldComplexScript4);
            runProperties5.Append(fontSize10);
            runProperties5.Append(fontSizeComplexScript10);
            Text text5 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text5.Text = "Лечебное учреждение: ";

            run5.Append(runProperties5);
            run5.Append(text5);

            paragraph5.Append(paragraphProperties5);
            paragraph5.Append(run5);

            tableCell1.Append(tableCellProperties1);
            tableCell1.Append(paragraph5);

            TableCell tableCell2 = new TableCell();

            TableCellProperties tableCellProperties2 = new TableCellProperties();
            TableCellWidth tableCellWidth2 = new TableCellWidth() { Width = "5500", Type = TableWidthUnitValues.Dxa };

            tableCellProperties2.Append(tableCellWidth2);

            Paragraph paragraph6 = new Paragraph() { RsidParagraphAddition = "00900A10", RsidParagraphProperties = "00B819CE", RsidRunAdditionDefault = "00900A10" };

            ParagraphProperties paragraphProperties6 = new ParagraphProperties();
            WidowControl widowControl6 = new WidowControl() { Val = false };
            AutoSpaceDE autoSpaceDE6 = new AutoSpaceDE() { Val = false };
            AutoSpaceDN autoSpaceDN6 = new AutoSpaceDN() { Val = false };
            AdjustRightIndent adjustRightIndent6 = new AdjustRightIndent() { Val = false };

            ParagraphMarkRunProperties paragraphMarkRunProperties6 = new ParagraphMarkRunProperties();
            RunFonts runFonts11 = new RunFonts() { Ascii = "Verdana", HighAnsi = "Verdana", EastAsia = "New Roman", ComplexScript = "Verdana" };
            FontSize fontSize11 = new FontSize() { Val = "20" };
            FontSizeComplexScript fontSizeComplexScript11 = new FontSizeComplexScript() { Val = "20" };

            paragraphMarkRunProperties6.Append(runFonts11);
            paragraphMarkRunProperties6.Append(fontSize11);
            paragraphMarkRunProperties6.Append(fontSizeComplexScript11);

            paragraphProperties6.Append(widowControl6);
            paragraphProperties6.Append(autoSpaceDE6);
            paragraphProperties6.Append(autoSpaceDN6);
            paragraphProperties6.Append(adjustRightIndent6);
            paragraphProperties6.Append(paragraphMarkRunProperties6);

            Run run6 = new Run();

            RunProperties runProperties6 = new RunProperties();
            RunFonts runFonts12 = new RunFonts() { Ascii = "Verdana", HighAnsi = "Verdana", EastAsia = "New Roman", ComplexScript = "Verdana" };
            FontSize fontSize12 = new FontSize() { Val = "20" };
            FontSizeComplexScript fontSizeComplexScript12 = new FontSizeComplexScript() { Val = "20" };

            runProperties6.Append(runFonts12);
            runProperties6.Append(fontSize12);
            runProperties6.Append(fontSizeComplexScript12);
            Text text6 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text6.Text = "НИИАХ (О) ";

            run6.Append(runProperties6);
            run6.Append(text6);

            paragraph6.Append(paragraphProperties6);
            paragraph6.Append(run6);

            tableCell2.Append(tableCellProperties2);
            tableCell2.Append(paragraph6);

            tableRow1.Append(tableRowProperties1);
            tableRow1.Append(tableCell1);
            tableRow1.Append(tableCell2);

            TableRow tableRow2 = new TableRow() { RsidTableRowAddition = "00900A10", RsidTableRowProperties = "00D60978" };

            TableRowProperties tableRowProperties2 = new TableRowProperties();
            TableRowHeight tableRowHeight2 = new TableRowHeight() { Val = (UInt32Value)262U };

            tableRowProperties2.Append(tableRowHeight2);

            TableCell tableCell3 = new TableCell();

            TableCellProperties tableCellProperties3 = new TableCellProperties();
            TableCellWidth tableCellWidth3 = new TableCellWidth() { Width = "3500", Type = TableWidthUnitValues.Dxa };

            tableCellProperties3.Append(tableCellWidth3);

            Paragraph paragraph7 = new Paragraph() { RsidParagraphAddition = "00900A10", RsidParagraphProperties = "00B819CE", RsidRunAdditionDefault = "00900A10" };

            ParagraphProperties paragraphProperties7 = new ParagraphProperties();
            WidowControl widowControl7 = new WidowControl() { Val = false };
            AutoSpaceDE autoSpaceDE7 = new AutoSpaceDE() { Val = false };
            AutoSpaceDN autoSpaceDN7 = new AutoSpaceDN() { Val = false };
            AdjustRightIndent adjustRightIndent7 = new AdjustRightIndent() { Val = false };

            ParagraphMarkRunProperties paragraphMarkRunProperties7 = new ParagraphMarkRunProperties();
            RunFonts runFonts13 = new RunFonts() { Ascii = "Verdana", HighAnsi = "Verdana", EastAsia = "New Roman", ComplexScript = "Verdana" };
            FontSize fontSize13 = new FontSize() { Val = "20" };
            FontSizeComplexScript fontSizeComplexScript13 = new FontSizeComplexScript() { Val = "20" };

            paragraphMarkRunProperties7.Append(runFonts13);
            paragraphMarkRunProperties7.Append(fontSize13);
            paragraphMarkRunProperties7.Append(fontSizeComplexScript13);

            paragraphProperties7.Append(widowControl7);
            paragraphProperties7.Append(autoSpaceDE7);
            paragraphProperties7.Append(autoSpaceDN7);
            paragraphProperties7.Append(adjustRightIndent7);
            paragraphProperties7.Append(paragraphMarkRunProperties7);

            Run run7 = new Run();

            RunProperties runProperties7 = new RunProperties();
            RunFonts runFonts14 = new RunFonts() { Ascii = "Verdana", HighAnsi = "Verdana", EastAsia = "New Roman", ComplexScript = "Verdana" };
            Bold bold5 = new Bold();
            BoldComplexScript boldComplexScript5 = new BoldComplexScript();
            FontSize fontSize14 = new FontSize() { Val = "20" };
            FontSizeComplexScript fontSizeComplexScript14 = new FontSizeComplexScript() { Val = "20" };

            runProperties7.Append(runFonts14);
            runProperties7.Append(bold5);
            runProperties7.Append(boldComplexScript5);
            runProperties7.Append(fontSize14);
            runProperties7.Append(fontSizeComplexScript14);
            Text text7 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text7.Text = "Врач: ";

            run7.Append(runProperties7);
            run7.Append(text7);

            paragraph7.Append(paragraphProperties7);
            paragraph7.Append(run7);

            tableCell3.Append(tableCellProperties3);
            tableCell3.Append(paragraph7);

            TableCell tableCell4 = new TableCell();

            TableCellProperties tableCellProperties4 = new TableCellProperties();
            TableCellWidth tableCellWidth4 = new TableCellWidth() { Width = "5500", Type = TableWidthUnitValues.Dxa };

            tableCellProperties4.Append(tableCellWidth4);

            Paragraph paragraph8 = new Paragraph() { RsidParagraphAddition = "00900A10", RsidParagraphProperties = "00B819CE", RsidRunAdditionDefault = "00900A10" };

            ParagraphProperties paragraphProperties8 = new ParagraphProperties();
            WidowControl widowControl8 = new WidowControl() { Val = false };
            AutoSpaceDE autoSpaceDE8 = new AutoSpaceDE() { Val = false };
            AutoSpaceDN autoSpaceDN8 = new AutoSpaceDN() { Val = false };
            AdjustRightIndent adjustRightIndent8 = new AdjustRightIndent() { Val = false };

            ParagraphMarkRunProperties paragraphMarkRunProperties8 = new ParagraphMarkRunProperties();
            RunFonts runFonts15 = new RunFonts() { Ascii = "Verdana", HighAnsi = "Verdana", EastAsia = "New Roman", ComplexScript = "Verdana" };
            FontSize fontSize15 = new FontSize() { Val = "20" };
            FontSizeComplexScript fontSizeComplexScript15 = new FontSizeComplexScript() { Val = "20" };

            paragraphMarkRunProperties8.Append(runFonts15);
            paragraphMarkRunProperties8.Append(fontSize15);
            paragraphMarkRunProperties8.Append(fontSizeComplexScript15);

            paragraphProperties8.Append(widowControl8);
            paragraphProperties8.Append(autoSpaceDE8);
            paragraphProperties8.Append(autoSpaceDN8);
            paragraphProperties8.Append(adjustRightIndent8);
            paragraphProperties8.Append(paragraphMarkRunProperties8);
            ProofError proofError1 = new ProofError() { Type = ProofingErrorValues.SpellStart };

            Run run8 = new Run();

            RunProperties runProperties8 = new RunProperties();
            RunFonts runFonts16 = new RunFonts() { Ascii = "Verdana", HighAnsi = "Verdana", EastAsia = "New Roman", ComplexScript = "Verdana" };
            FontSize fontSize16 = new FontSize() { Val = "20" };
            FontSizeComplexScript fontSizeComplexScript16 = new FontSizeComplexScript() { Val = "20" };

            runProperties8.Append(runFonts16);
            runProperties8.Append(fontSize16);
            runProperties8.Append(fontSizeComplexScript16);
            Text text8 = new Text();
            text8.Text = "Сехин";

            run8.Append(runProperties8);
            run8.Append(text8);
            ProofError proofError2 = new ProofError() { Type = ProofingErrorValues.SpellEnd };

            Run run9 = new Run();

            RunProperties runProperties9 = new RunProperties();
            RunFonts runFonts17 = new RunFonts() { Ascii = "Verdana", HighAnsi = "Verdana", EastAsia = "New Roman", ComplexScript = "Verdana" };
            FontSize fontSize17 = new FontSize() { Val = "20" };
            FontSizeComplexScript fontSizeComplexScript17 = new FontSizeComplexScript() { Val = "20" };

            runProperties9.Append(runFonts17);
            runProperties9.Append(fontSize17);
            runProperties9.Append(fontSizeComplexScript17);
            Text text9 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text9.Text = " С. В. ";

            run9.Append(runProperties9);
            run9.Append(text9);

            paragraph8.Append(paragraphProperties8);
            paragraph8.Append(proofError1);
            paragraph8.Append(run8);
            paragraph8.Append(proofError2);
            paragraph8.Append(run9);

            tableCell4.Append(tableCellProperties4);
            tableCell4.Append(paragraph8);
            BookmarkStart bookmarkStart1 = new BookmarkStart() { Name = "_GoBack", Id = "0" };
            BookmarkEnd bookmarkEnd1 = new BookmarkEnd() { Id = "0" };

            tableRow2.Append(tableRowProperties2);
            tableRow2.Append(tableCell3);
            tableRow2.Append(tableCell4);
            tableRow2.Append(bookmarkStart1);
            tableRow2.Append(bookmarkEnd1);

            TableRow tableRow3 = new TableRow() { RsidTableRowAddition = "00900A10", RsidTableRowProperties = "00D60978" };

            TableRowProperties tableRowProperties3 = new TableRowProperties();
            TableRowHeight tableRowHeight3 = new TableRowHeight() { Val = (UInt32Value)262U };

            tableRowProperties3.Append(tableRowHeight3);

            TableCell tableCell5 = new TableCell();

            TableCellProperties tableCellProperties5 = new TableCellProperties();
            TableCellWidth tableCellWidth5 = new TableCellWidth() { Width = "3500", Type = TableWidthUnitValues.Dxa };

            tableCellProperties5.Append(tableCellWidth5);

            Paragraph paragraph9 = new Paragraph() { RsidParagraphAddition = "00900A10", RsidParagraphProperties = "00B819CE", RsidRunAdditionDefault = "00900A10" };

            ParagraphProperties paragraphProperties9 = new ParagraphProperties();
            WidowControl widowControl9 = new WidowControl() { Val = false };
            AutoSpaceDE autoSpaceDE9 = new AutoSpaceDE() { Val = false };
            AutoSpaceDN autoSpaceDN9 = new AutoSpaceDN() { Val = false };
            AdjustRightIndent adjustRightIndent9 = new AdjustRightIndent() { Val = false };

            ParagraphMarkRunProperties paragraphMarkRunProperties9 = new ParagraphMarkRunProperties();
            RunFonts runFonts18 = new RunFonts() { Ascii = "Verdana", HighAnsi = "Verdana", EastAsia = "New Roman", ComplexScript = "Verdana" };
            FontSize fontSize18 = new FontSize() { Val = "20" };
            FontSizeComplexScript fontSizeComplexScript18 = new FontSizeComplexScript() { Val = "20" };

            paragraphMarkRunProperties9.Append(runFonts18);
            paragraphMarkRunProperties9.Append(fontSize18);
            paragraphMarkRunProperties9.Append(fontSizeComplexScript18);

            paragraphProperties9.Append(widowControl9);
            paragraphProperties9.Append(autoSpaceDE9);
            paragraphProperties9.Append(autoSpaceDN9);
            paragraphProperties9.Append(adjustRightIndent9);
            paragraphProperties9.Append(paragraphMarkRunProperties9);

            Run run10 = new Run();

            RunProperties runProperties10 = new RunProperties();
            RunFonts runFonts19 = new RunFonts() { Ascii = "Verdana", HighAnsi = "Verdana", EastAsia = "New Roman", ComplexScript = "Verdana" };
            Bold bold6 = new Bold();
            BoldComplexScript boldComplexScript6 = new BoldComplexScript();
            FontSize fontSize19 = new FontSize() { Val = "20" };
            FontSizeComplexScript fontSizeComplexScript19 = new FontSizeComplexScript() { Val = "20" };

            runProperties10.Append(runFonts19);
            runProperties10.Append(bold6);
            runProperties10.Append(boldComplexScript6);
            runProperties10.Append(fontSize19);
            runProperties10.Append(fontSizeComplexScript19);
            Text text10 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text10.Text = "Пациент: ";

            run10.Append(runProperties10);
            run10.Append(text10);

            paragraph9.Append(paragraphProperties9);
            paragraph9.Append(run10);

            tableCell5.Append(tableCellProperties5);
            tableCell5.Append(paragraph9);

            TableCell tableCell6 = new TableCell();

            TableCellProperties tableCellProperties6 = new TableCellProperties();
            TableCellWidth tableCellWidth6 = new TableCellWidth() { Width = "5500", Type = TableWidthUnitValues.Dxa };

            tableCellProperties6.Append(tableCellWidth6);

            Paragraph paragraph10 = new Paragraph() { RsidParagraphAddition = "00900A10", RsidParagraphProperties = "00B819CE", RsidRunAdditionDefault = "00900A10" };

            ParagraphProperties paragraphProperties10 = new ParagraphProperties();
            WidowControl widowControl10 = new WidowControl() { Val = false };
            AutoSpaceDE autoSpaceDE10 = new AutoSpaceDE() { Val = false };
            AutoSpaceDN autoSpaceDN10 = new AutoSpaceDN() { Val = false };
            AdjustRightIndent adjustRightIndent10 = new AdjustRightIndent() { Val = false };

            ParagraphMarkRunProperties paragraphMarkRunProperties10 = new ParagraphMarkRunProperties();
            RunFonts runFonts20 = new RunFonts() { Ascii = "Verdana", HighAnsi = "Verdana", EastAsia = "New Roman", ComplexScript = "Verdana" };
            FontSize fontSize20 = new FontSize() { Val = "20" };
            FontSizeComplexScript fontSizeComplexScript20 = new FontSizeComplexScript() { Val = "20" };

            paragraphMarkRunProperties10.Append(runFonts20);
            paragraphMarkRunProperties10.Append(fontSize20);
            paragraphMarkRunProperties10.Append(fontSizeComplexScript20);

            paragraphProperties10.Append(widowControl10);
            paragraphProperties10.Append(autoSpaceDE10);
            paragraphProperties10.Append(autoSpaceDN10);
            paragraphProperties10.Append(adjustRightIndent10);
            paragraphProperties10.Append(paragraphMarkRunProperties10);

            Run run11 = new Run();

            RunProperties runProperties11 = new RunProperties();
            RunFonts runFonts21 = new RunFonts() { Ascii = "Verdana", HighAnsi = "Verdana", EastAsia = "New Roman", ComplexScript = "Verdana" };
            FontSize fontSize21 = new FontSize() { Val = "20" };
            FontSizeComplexScript fontSizeComplexScript21 = new FontSizeComplexScript() { Val = "20" };

            runProperties11.Append(runFonts21);
            runProperties11.Append(fontSize21);
            runProperties11.Append(fontSizeComplexScript21);
            Text text11 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text11.Text = "Ковалева А.В. ";

            run11.Append(runProperties11);
            run11.Append(text11);

            paragraph10.Append(paragraphProperties10);
            paragraph10.Append(run11);

            tableCell6.Append(tableCellProperties6);
            tableCell6.Append(paragraph10);

            tableRow3.Append(tableRowProperties3);
            tableRow3.Append(tableCell5);
            tableRow3.Append(tableCell6);

            TableRow tableRow4 = new TableRow() { RsidTableRowAddition = "00900A10", RsidTableRowProperties = "00D60978" };

            TableRowProperties tableRowProperties4 = new TableRowProperties();
            TableRowHeight tableRowHeight4 = new TableRowHeight() { Val = (UInt32Value)262U };

            tableRowProperties4.Append(tableRowHeight4);

            TableCell tableCell7 = new TableCell();

            TableCellProperties tableCellProperties7 = new TableCellProperties();
            TableCellWidth tableCellWidth7 = new TableCellWidth() { Width = "3500", Type = TableWidthUnitValues.Dxa };

            tableCellProperties7.Append(tableCellWidth7);

            Paragraph paragraph11 = new Paragraph() { RsidParagraphAddition = "00900A10", RsidParagraphProperties = "00B819CE", RsidRunAdditionDefault = "00900A10" };

            ParagraphProperties paragraphProperties11 = new ParagraphProperties();
            WidowControl widowControl11 = new WidowControl() { Val = false };
            AutoSpaceDE autoSpaceDE11 = new AutoSpaceDE() { Val = false };
            AutoSpaceDN autoSpaceDN11 = new AutoSpaceDN() { Val = false };
            AdjustRightIndent adjustRightIndent11 = new AdjustRightIndent() { Val = false };

            ParagraphMarkRunProperties paragraphMarkRunProperties11 = new ParagraphMarkRunProperties();
            RunFonts runFonts22 = new RunFonts() { Ascii = "Verdana", HighAnsi = "Verdana", EastAsia = "New Roman", ComplexScript = "Verdana" };
            FontSize fontSize22 = new FontSize() { Val = "20" };
            FontSizeComplexScript fontSizeComplexScript22 = new FontSizeComplexScript() { Val = "20" };

            paragraphMarkRunProperties11.Append(runFonts22);
            paragraphMarkRunProperties11.Append(fontSize22);
            paragraphMarkRunProperties11.Append(fontSizeComplexScript22);

            paragraphProperties11.Append(widowControl11);
            paragraphProperties11.Append(autoSpaceDE11);
            paragraphProperties11.Append(autoSpaceDN11);
            paragraphProperties11.Append(adjustRightIndent11);
            paragraphProperties11.Append(paragraphMarkRunProperties11);

            Run run12 = new Run();

            RunProperties runProperties12 = new RunProperties();
            RunFonts runFonts23 = new RunFonts() { Ascii = "Verdana", HighAnsi = "Verdana", EastAsia = "New Roman", ComplexScript = "Verdana" };
            Bold bold7 = new Bold();
            BoldComplexScript boldComplexScript7 = new BoldComplexScript();
            FontSize fontSize23 = new FontSize() { Val = "20" };
            FontSizeComplexScript fontSizeComplexScript23 = new FontSizeComplexScript() { Val = "20" };

            runProperties12.Append(runFonts23);
            runProperties12.Append(bold7);
            runProperties12.Append(boldComplexScript7);
            runProperties12.Append(fontSize23);
            runProperties12.Append(fontSizeComplexScript23);
            Text text12 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text12.Text = "Дата рождения: ";

            run12.Append(runProperties12);
            run12.Append(text12);

            paragraph11.Append(paragraphProperties11);
            paragraph11.Append(run12);

            tableCell7.Append(tableCellProperties7);
            tableCell7.Append(paragraph11);

            TableCell tableCell8 = new TableCell();

            TableCellProperties tableCellProperties8 = new TableCellProperties();
            TableCellWidth tableCellWidth8 = new TableCellWidth() { Width = "5500", Type = TableWidthUnitValues.Dxa };

            tableCellProperties8.Append(tableCellWidth8);

            Paragraph paragraph12 = new Paragraph() { RsidParagraphAddition = "00900A10", RsidParagraphProperties = "00B819CE", RsidRunAdditionDefault = "00900A10" };

            ParagraphProperties paragraphProperties12 = new ParagraphProperties();
            WidowControl widowControl12 = new WidowControl() { Val = false };
            AutoSpaceDE autoSpaceDE12 = new AutoSpaceDE() { Val = false };
            AutoSpaceDN autoSpaceDN12 = new AutoSpaceDN() { Val = false };
            AdjustRightIndent adjustRightIndent12 = new AdjustRightIndent() { Val = false };

            ParagraphMarkRunProperties paragraphMarkRunProperties12 = new ParagraphMarkRunProperties();
            RunFonts runFonts24 = new RunFonts() { Ascii = "Verdana", HighAnsi = "Verdana", EastAsia = "New Roman", ComplexScript = "Verdana" };
            FontSize fontSize24 = new FontSize() { Val = "20" };
            FontSizeComplexScript fontSizeComplexScript24 = new FontSizeComplexScript() { Val = "20" };

            paragraphMarkRunProperties12.Append(runFonts24);
            paragraphMarkRunProperties12.Append(fontSize24);
            paragraphMarkRunProperties12.Append(fontSizeComplexScript24);

            paragraphProperties12.Append(widowControl12);
            paragraphProperties12.Append(autoSpaceDE12);
            paragraphProperties12.Append(autoSpaceDN12);
            paragraphProperties12.Append(adjustRightIndent12);
            paragraphProperties12.Append(paragraphMarkRunProperties12);

            Run run13 = new Run();

            RunProperties runProperties13 = new RunProperties();
            RunFonts runFonts25 = new RunFonts() { Ascii = "Verdana", HighAnsi = "Verdana", EastAsia = "New Roman", ComplexScript = "Verdana" };
            FontSize fontSize25 = new FontSize() { Val = "20" };
            FontSizeComplexScript fontSizeComplexScript25 = new FontSizeComplexScript() { Val = "20" };

            runProperties13.Append(runFonts25);
            runProperties13.Append(fontSize25);
            runProperties13.Append(fontSizeComplexScript25);
            Text text13 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text13.Text = "14.01.1982 ";

            run13.Append(runProperties13);
            run13.Append(text13);

            paragraph12.Append(paragraphProperties12);
            paragraph12.Append(run13);

            tableCell8.Append(tableCellProperties8);
            tableCell8.Append(paragraph12);

            tableRow4.Append(tableRowProperties4);
            tableRow4.Append(tableCell7);
            tableRow4.Append(tableCell8);

            TableRow tableRow5 = new TableRow() { RsidTableRowAddition = "00900A10", RsidTableRowProperties = "00D60978" };

            TableRowProperties tableRowProperties5 = new TableRowProperties();
            TableRowHeight tableRowHeight5 = new TableRowHeight() { Val = (UInt32Value)262U };

            tableRowProperties5.Append(tableRowHeight5);

            TableCell tableCell9 = new TableCell();

            TableCellProperties tableCellProperties9 = new TableCellProperties();
            TableCellWidth tableCellWidth9 = new TableCellWidth() { Width = "3500", Type = TableWidthUnitValues.Dxa };

            tableCellProperties9.Append(tableCellWidth9);

            Paragraph paragraph13 = new Paragraph() { RsidParagraphAddition = "00900A10", RsidParagraphProperties = "00B819CE", RsidRunAdditionDefault = "00900A10" };

            ParagraphProperties paragraphProperties13 = new ParagraphProperties();
            WidowControl widowControl13 = new WidowControl() { Val = false };
            AutoSpaceDE autoSpaceDE13 = new AutoSpaceDE() { Val = false };
            AutoSpaceDN autoSpaceDN13 = new AutoSpaceDN() { Val = false };
            AdjustRightIndent adjustRightIndent13 = new AdjustRightIndent() { Val = false };

            ParagraphMarkRunProperties paragraphMarkRunProperties13 = new ParagraphMarkRunProperties();
            RunFonts runFonts26 = new RunFonts() { Ascii = "Verdana", HighAnsi = "Verdana", EastAsia = "New Roman", ComplexScript = "Verdana" };
            FontSize fontSize26 = new FontSize() { Val = "20" };
            FontSizeComplexScript fontSizeComplexScript26 = new FontSizeComplexScript() { Val = "20" };

            paragraphMarkRunProperties13.Append(runFonts26);
            paragraphMarkRunProperties13.Append(fontSize26);
            paragraphMarkRunProperties13.Append(fontSizeComplexScript26);

            paragraphProperties13.Append(widowControl13);
            paragraphProperties13.Append(autoSpaceDE13);
            paragraphProperties13.Append(autoSpaceDN13);
            paragraphProperties13.Append(adjustRightIndent13);
            paragraphProperties13.Append(paragraphMarkRunProperties13);

            Run run14 = new Run();

            RunProperties runProperties14 = new RunProperties();
            RunFonts runFonts27 = new RunFonts() { Ascii = "Verdana", HighAnsi = "Verdana", EastAsia = "New Roman", ComplexScript = "Verdana" };
            Bold bold8 = new Bold();
            BoldComplexScript boldComplexScript8 = new BoldComplexScript();
            FontSize fontSize27 = new FontSize() { Val = "20" };
            FontSizeComplexScript fontSizeComplexScript27 = new FontSizeComplexScript() { Val = "20" };

            runProperties14.Append(runFonts27);
            runProperties14.Append(bold8);
            runProperties14.Append(boldComplexScript8);
            runProperties14.Append(fontSize27);
            runProperties14.Append(fontSizeComplexScript27);
            Text text14 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text14.Text = "Клинический материал: ";

            run14.Append(runProperties14);
            run14.Append(text14);

            paragraph13.Append(paragraphProperties13);
            paragraph13.Append(run14);

            tableCell9.Append(tableCellProperties9);
            tableCell9.Append(paragraph13);

            TableCell tableCell10 = new TableCell();

            TableCellProperties tableCellProperties10 = new TableCellProperties();
            TableCellWidth tableCellWidth10 = new TableCellWidth() { Width = "5500", Type = TableWidthUnitValues.Dxa };

            tableCellProperties10.Append(tableCellWidth10);

            Paragraph paragraph14 = new Paragraph() { RsidParagraphAddition = "00900A10", RsidParagraphProperties = "00B819CE", RsidRunAdditionDefault = "00900A10" };

            ParagraphProperties paragraphProperties14 = new ParagraphProperties();
            WidowControl widowControl14 = new WidowControl() { Val = false };
            AutoSpaceDE autoSpaceDE14 = new AutoSpaceDE() { Val = false };
            AutoSpaceDN autoSpaceDN14 = new AutoSpaceDN() { Val = false };
            AdjustRightIndent adjustRightIndent14 = new AdjustRightIndent() { Val = false };

            ParagraphMarkRunProperties paragraphMarkRunProperties14 = new ParagraphMarkRunProperties();
            RunFonts runFonts28 = new RunFonts() { Ascii = "Verdana", HighAnsi = "Verdana", EastAsia = "New Roman", ComplexScript = "Verdana" };
            FontSize fontSize28 = new FontSize() { Val = "20" };
            FontSizeComplexScript fontSizeComplexScript28 = new FontSizeComplexScript() { Val = "20" };

            paragraphMarkRunProperties14.Append(runFonts28);
            paragraphMarkRunProperties14.Append(fontSize28);
            paragraphMarkRunProperties14.Append(fontSizeComplexScript28);

            paragraphProperties14.Append(widowControl14);
            paragraphProperties14.Append(autoSpaceDE14);
            paragraphProperties14.Append(autoSpaceDN14);
            paragraphProperties14.Append(adjustRightIndent14);
            paragraphProperties14.Append(paragraphMarkRunProperties14);

            Run run15 = new Run();

            RunProperties runProperties15 = new RunProperties();
            RunFonts runFonts29 = new RunFonts() { Ascii = "Verdana", HighAnsi = "Verdana", EastAsia = "New Roman", ComplexScript = "Verdana" };
            FontSize fontSize29 = new FontSize() { Val = "20" };
            FontSizeComplexScript fontSizeComplexScript29 = new FontSizeComplexScript() { Val = "20" };

            runProperties15.Append(runFonts29);
            runProperties15.Append(fontSize29);
            runProperties15.Append(fontSizeComplexScript29);
            Text text15 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text15.Text = "Цельная кровь ";

            run15.Append(runProperties15);
            run15.Append(text15);

            paragraph14.Append(paragraphProperties14);
            paragraph14.Append(run15);

            tableCell10.Append(tableCellProperties10);
            tableCell10.Append(paragraph14);

            tableRow5.Append(tableRowProperties5);
            tableRow5.Append(tableCell9);
            tableRow5.Append(tableCell10);

            TableRow tableRow6 = new TableRow() { RsidTableRowAddition = "00900A10", RsidTableRowProperties = "00D60978" };

            TableRowProperties tableRowProperties6 = new TableRowProperties();
            TableRowHeight tableRowHeight6 = new TableRowHeight() { Val = (UInt32Value)262U };

            tableRowProperties6.Append(tableRowHeight6);

            TableCell tableCell11 = new TableCell();

            TableCellProperties tableCellProperties11 = new TableCellProperties();
            TableCellWidth tableCellWidth11 = new TableCellWidth() { Width = "3500", Type = TableWidthUnitValues.Dxa };

            tableCellProperties11.Append(tableCellWidth11);

            Paragraph paragraph15 = new Paragraph() { RsidParagraphAddition = "00900A10", RsidParagraphProperties = "00B819CE", RsidRunAdditionDefault = "00900A10" };

            ParagraphProperties paragraphProperties15 = new ParagraphProperties();
            WidowControl widowControl15 = new WidowControl() { Val = false };
            AutoSpaceDE autoSpaceDE15 = new AutoSpaceDE() { Val = false };
            AutoSpaceDN autoSpaceDN15 = new AutoSpaceDN() { Val = false };
            AdjustRightIndent adjustRightIndent15 = new AdjustRightIndent() { Val = false };

            ParagraphMarkRunProperties paragraphMarkRunProperties15 = new ParagraphMarkRunProperties();
            RunFonts runFonts30 = new RunFonts() { Ascii = "Verdana", HighAnsi = "Verdana", EastAsia = "New Roman", ComplexScript = "Verdana" };
            FontSize fontSize30 = new FontSize() { Val = "20" };
            FontSizeComplexScript fontSizeComplexScript30 = new FontSizeComplexScript() { Val = "20" };

            paragraphMarkRunProperties15.Append(runFonts30);
            paragraphMarkRunProperties15.Append(fontSize30);
            paragraphMarkRunProperties15.Append(fontSizeComplexScript30);

            paragraphProperties15.Append(widowControl15);
            paragraphProperties15.Append(autoSpaceDE15);
            paragraphProperties15.Append(autoSpaceDN15);
            paragraphProperties15.Append(adjustRightIndent15);
            paragraphProperties15.Append(paragraphMarkRunProperties15);

            Run run16 = new Run();

            RunProperties runProperties16 = new RunProperties();
            RunFonts runFonts31 = new RunFonts() { Ascii = "Verdana", HighAnsi = "Verdana", EastAsia = "New Roman", ComplexScript = "Verdana" };
            Bold bold9 = new Bold();
            BoldComplexScript boldComplexScript9 = new BoldComplexScript();
            FontSize fontSize31 = new FontSize() { Val = "20" };
            FontSizeComplexScript fontSizeComplexScript31 = new FontSizeComplexScript() { Val = "20" };

            runProperties16.Append(runFonts31);
            runProperties16.Append(bold9);
            runProperties16.Append(boldComplexScript9);
            runProperties16.Append(fontSize31);
            runProperties16.Append(fontSizeComplexScript31);
            Text text16 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text16.Text = "Дата получения материала: ";

            run16.Append(runProperties16);
            run16.Append(text16);

            paragraph15.Append(paragraphProperties15);
            paragraph15.Append(run16);

            tableCell11.Append(tableCellProperties11);
            tableCell11.Append(paragraph15);

            TableCell tableCell12 = new TableCell();

            TableCellProperties tableCellProperties12 = new TableCellProperties();
            TableCellWidth tableCellWidth12 = new TableCellWidth() { Width = "5500", Type = TableWidthUnitValues.Dxa };

            tableCellProperties12.Append(tableCellWidth12);

            Paragraph paragraph16 = new Paragraph() { RsidParagraphAddition = "00900A10", RsidParagraphProperties = "00B819CE", RsidRunAdditionDefault = "00900A10" };

            ParagraphProperties paragraphProperties16 = new ParagraphProperties();
            WidowControl widowControl16 = new WidowControl() { Val = false };
            AutoSpaceDE autoSpaceDE16 = new AutoSpaceDE() { Val = false };
            AutoSpaceDN autoSpaceDN16 = new AutoSpaceDN() { Val = false };
            AdjustRightIndent adjustRightIndent16 = new AdjustRightIndent() { Val = false };

            ParagraphMarkRunProperties paragraphMarkRunProperties16 = new ParagraphMarkRunProperties();
            RunFonts runFonts32 = new RunFonts() { Ascii = "Verdana", HighAnsi = "Verdana", EastAsia = "New Roman", ComplexScript = "Verdana" };
            FontSize fontSize32 = new FontSize() { Val = "20" };
            FontSizeComplexScript fontSizeComplexScript32 = new FontSizeComplexScript() { Val = "20" };

            paragraphMarkRunProperties16.Append(runFonts32);
            paragraphMarkRunProperties16.Append(fontSize32);
            paragraphMarkRunProperties16.Append(fontSizeComplexScript32);

            paragraphProperties16.Append(widowControl16);
            paragraphProperties16.Append(autoSpaceDE16);
            paragraphProperties16.Append(autoSpaceDN16);
            paragraphProperties16.Append(adjustRightIndent16);
            paragraphProperties16.Append(paragraphMarkRunProperties16);

            Run run17 = new Run();

            RunProperties runProperties17 = new RunProperties();
            RunFonts runFonts33 = new RunFonts() { Ascii = "Verdana", HighAnsi = "Verdana", EastAsia = "New Roman", ComplexScript = "Verdana" };
            FontSize fontSize33 = new FontSize() { Val = "20" };
            FontSizeComplexScript fontSizeComplexScript33 = new FontSizeComplexScript() { Val = "20" };

            runProperties17.Append(runFonts33);
            runProperties17.Append(fontSize33);
            runProperties17.Append(fontSizeComplexScript33);
            Text text17 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text17.Text = "21.12.2012 9:47:00 ";

            run17.Append(runProperties17);
            run17.Append(text17);

            paragraph16.Append(paragraphProperties16);
            paragraph16.Append(run17);

            tableCell12.Append(tableCellProperties12);
            tableCell12.Append(paragraph16);

            tableRow6.Append(tableRowProperties6);
            tableRow6.Append(tableCell11);
            tableRow6.Append(tableCell12);

            TableRow tableRow7 = new TableRow() { RsidTableRowAddition = "00900A10", RsidTableRowProperties = "00D60978" };

            TableRowProperties tableRowProperties7 = new TableRowProperties();
            TableRowHeight tableRowHeight7 = new TableRowHeight() { Val = (UInt32Value)262U };

            tableRowProperties7.Append(tableRowHeight7);

            TableCell tableCell13 = new TableCell();

            TableCellProperties tableCellProperties13 = new TableCellProperties();
            TableCellWidth tableCellWidth13 = new TableCellWidth() { Width = "3500", Type = TableWidthUnitValues.Dxa };

            tableCellProperties13.Append(tableCellWidth13);

            Paragraph paragraph17 = new Paragraph() { RsidParagraphAddition = "00900A10", RsidParagraphProperties = "00B819CE", RsidRunAdditionDefault = "00D60978" };

            ParagraphProperties paragraphProperties17 = new ParagraphProperties();
            WidowControl widowControl17 = new WidowControl() { Val = false };
            AutoSpaceDE autoSpaceDE17 = new AutoSpaceDE() { Val = false };
            AutoSpaceDN autoSpaceDN17 = new AutoSpaceDN() { Val = false };
            AdjustRightIndent adjustRightIndent17 = new AdjustRightIndent() { Val = false };

            ParagraphMarkRunProperties paragraphMarkRunProperties17 = new ParagraphMarkRunProperties();
            RunFonts runFonts34 = new RunFonts() { Ascii = "Verdana", HighAnsi = "Verdana", EastAsia = "New Roman", ComplexScript = "Verdana" };
            FontSize fontSize34 = new FontSize() { Val = "20" };
            FontSizeComplexScript fontSizeComplexScript34 = new FontSizeComplexScript() { Val = "20" };

            paragraphMarkRunProperties17.Append(runFonts34);
            paragraphMarkRunProperties17.Append(fontSize34);
            paragraphMarkRunProperties17.Append(fontSizeComplexScript34);

            paragraphProperties17.Append(widowControl17);
            paragraphProperties17.Append(autoSpaceDE17);
            paragraphProperties17.Append(autoSpaceDN17);
            paragraphProperties17.Append(adjustRightIndent17);
            paragraphProperties17.Append(paragraphMarkRunProperties17);

            Run run18 = new Run();

            RunProperties runProperties18 = new RunProperties();
            RunFonts runFonts35 = new RunFonts() { Ascii = "Verdana", HighAnsi = "Verdana", EastAsia = "New Roman", ComplexScript = "Verdana" };
            Bold bold10 = new Bold();
            BoldComplexScript boldComplexScript10 = new BoldComplexScript();
            FontSize fontSize35 = new FontSize() { Val = "20" };
            FontSizeComplexScript fontSizeComplexScript35 = new FontSizeComplexScript() { Val = "20" };

            runProperties18.Append(runFonts35);
            runProperties18.Append(bold10);
            runProperties18.Append(boldComplexScript10);
            runProperties18.Append(fontSize35);
            runProperties18.Append(fontSizeComplexScript35);
            Text text18 = new Text();
            text18.Text = "Дата забора";

            run18.Append(runProperties18);
            run18.Append(text18);

            Run run19 = new Run();

            RunProperties runProperties19 = new RunProperties();
            RunFonts runFonts36 = new RunFonts() { Ascii = "Verdana", HighAnsi = "Verdana", EastAsia = "New Roman", ComplexScript = "Verdana" };
            Bold bold11 = new Bold();
            BoldComplexScript boldComplexScript11 = new BoldComplexScript();
            FontSize fontSize36 = new FontSize() { Val = "20" };
            FontSizeComplexScript fontSizeComplexScript36 = new FontSizeComplexScript() { Val = "20" };

            runProperties19.Append(runFonts36);
            runProperties19.Append(bold11);
            runProperties19.Append(boldComplexScript11);
            runProperties19.Append(fontSize36);
            runProperties19.Append(fontSizeComplexScript36);
            Text text19 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text19.Text = " материала:";

            run19.Append(runProperties19);
            run19.Append(text19);

            paragraph17.Append(paragraphProperties17);
            paragraph17.Append(run18);
            paragraph17.Append(run19);

            tableCell13.Append(tableCellProperties13);
            tableCell13.Append(paragraph17);

            TableCell tableCell14 = new TableCell();

            TableCellProperties tableCellProperties14 = new TableCellProperties();
            TableCellWidth tableCellWidth14 = new TableCellWidth() { Width = "5500", Type = TableWidthUnitValues.Dxa };

            tableCellProperties14.Append(tableCellWidth14);

            Paragraph paragraph18 = new Paragraph() { RsidParagraphAddition = "00900A10", RsidParagraphProperties = "00B819CE", RsidRunAdditionDefault = "00D60978" };

            ParagraphProperties paragraphProperties18 = new ParagraphProperties();
            WidowControl widowControl18 = new WidowControl() { Val = false };
            AutoSpaceDE autoSpaceDE18 = new AutoSpaceDE() { Val = false };
            AutoSpaceDN autoSpaceDN18 = new AutoSpaceDN() { Val = false };
            AdjustRightIndent adjustRightIndent18 = new AdjustRightIndent() { Val = false };

            ParagraphMarkRunProperties paragraphMarkRunProperties18 = new ParagraphMarkRunProperties();
            RunFonts runFonts37 = new RunFonts() { Ascii = "Verdana", HighAnsi = "Verdana", EastAsia = "New Roman", ComplexScript = "Verdana" };
            FontSize fontSize37 = new FontSize() { Val = "20" };
            FontSizeComplexScript fontSizeComplexScript37 = new FontSizeComplexScript() { Val = "20" };

            paragraphMarkRunProperties18.Append(runFonts37);
            paragraphMarkRunProperties18.Append(fontSize37);
            paragraphMarkRunProperties18.Append(fontSizeComplexScript37);

            paragraphProperties18.Append(widowControl18);
            paragraphProperties18.Append(autoSpaceDE18);
            paragraphProperties18.Append(autoSpaceDN18);
            paragraphProperties18.Append(adjustRightIndent18);
            paragraphProperties18.Append(paragraphMarkRunProperties18);

            Run run20 = new Run();

            RunProperties runProperties20 = new RunProperties();
            RunFonts runFonts38 = new RunFonts() { Ascii = "Verdana", HighAnsi = "Verdana", EastAsia = "New Roman", ComplexScript = "Verdana" };
            FontSize fontSize38 = new FontSize() { Val = "20" };
            FontSizeComplexScript fontSizeComplexScript38 = new FontSizeComplexScript() { Val = "20" };

            runProperties20.Append(runFonts38);
            runProperties20.Append(fontSize38);
            runProperties20.Append(fontSizeComplexScript38);
            Text text20 = new Text();
            text20.Text = "21.12.2012 9:47:00";

            run20.Append(runProperties20);
            run20.Append(text20);

            paragraph18.Append(paragraphProperties18);
            paragraph18.Append(run20);

            tableCell14.Append(tableCellProperties14);
            tableCell14.Append(paragraph18);

            tableRow7.Append(tableRowProperties7);
            tableRow7.Append(tableCell13);
            tableRow7.Append(tableCell14);

            table1.Append(tableProperties1);
            table1.Append(tableGrid1);
            table1.Append(tableRow1);
            table1.Append(tableRow2);
            table1.Append(tableRow3);
            table1.Append(tableRow4);
            table1.Append(tableRow5);
            table1.Append(tableRow6);
            table1.Append(tableRow7);

            Paragraph paragraph19 = new Paragraph() { RsidParagraphAddition = "00900A10", RsidParagraphProperties = "00900A10", RsidRunAdditionDefault = "00900A10" };

            ParagraphProperties paragraphProperties19 = new ParagraphProperties();
            WidowControl widowControl19 = new WidowControl() { Val = false };
            AutoSpaceDE autoSpaceDE19 = new AutoSpaceDE() { Val = false };
            AutoSpaceDN autoSpaceDN19 = new AutoSpaceDN() { Val = false };
            AdjustRightIndent adjustRightIndent19 = new AdjustRightIndent() { Val = false };
            SpacingBetweenLines spacingBetweenLines5 = new SpacingBetweenLines() { After = "0", Line = "240", LineRule = LineSpacingRuleValues.Auto };
            Justification justification3 = new Justification() { Val = JustificationValues.Center };

            ParagraphMarkRunProperties paragraphMarkRunProperties19 = new ParagraphMarkRunProperties();
            RunFonts runFonts39 = new RunFonts() { Ascii = "Verdana", HighAnsi = "Verdana", EastAsia = "New Roman", ComplexScript = "Verdana" };
            FontSize fontSize39 = new FontSize() { Val = "20" };
            FontSizeComplexScript fontSizeComplexScript39 = new FontSizeComplexScript() { Val = "20" };

            paragraphMarkRunProperties19.Append(runFonts39);
            paragraphMarkRunProperties19.Append(fontSize39);
            paragraphMarkRunProperties19.Append(fontSizeComplexScript39);

            paragraphProperties19.Append(widowControl19);
            paragraphProperties19.Append(autoSpaceDE19);
            paragraphProperties19.Append(autoSpaceDN19);
            paragraphProperties19.Append(adjustRightIndent19);
            paragraphProperties19.Append(spacingBetweenLines5);
            paragraphProperties19.Append(justification3);
            paragraphProperties19.Append(paragraphMarkRunProperties19);

            paragraph19.Append(paragraphProperties19);

            Paragraph paragraph20 = new Paragraph() { RsidParagraphAddition = "00900A10", RsidParagraphProperties = "00900A10", RsidRunAdditionDefault = "00900A10" };

            ParagraphProperties paragraphProperties20 = new ParagraphProperties();
            WidowControl widowControl20 = new WidowControl() { Val = false };
            AutoSpaceDE autoSpaceDE20 = new AutoSpaceDE() { Val = false };
            AutoSpaceDN autoSpaceDN20 = new AutoSpaceDN() { Val = false };
            AdjustRightIndent adjustRightIndent20 = new AdjustRightIndent() { Val = false };
            SpacingBetweenLines spacingBetweenLines6 = new SpacingBetweenLines() { After = "0", Line = "240", LineRule = LineSpacingRuleValues.Auto };
            Justification justification4 = new Justification() { Val = JustificationValues.Center };

            ParagraphMarkRunProperties paragraphMarkRunProperties20 = new ParagraphMarkRunProperties();
            RunFonts runFonts40 = new RunFonts() { Ascii = "Verdana", HighAnsi = "Verdana", EastAsia = "New Roman", ComplexScript = "Verdana" };
            FontSize fontSize40 = new FontSize() { Val = "20" };
            FontSizeComplexScript fontSizeComplexScript40 = new FontSizeComplexScript() { Val = "20" };

            paragraphMarkRunProperties20.Append(runFonts40);
            paragraphMarkRunProperties20.Append(fontSize40);
            paragraphMarkRunProperties20.Append(fontSizeComplexScript40);

            paragraphProperties20.Append(widowControl20);
            paragraphProperties20.Append(autoSpaceDE20);
            paragraphProperties20.Append(autoSpaceDN20);
            paragraphProperties20.Append(adjustRightIndent20);
            paragraphProperties20.Append(spacingBetweenLines6);
            paragraphProperties20.Append(justification4);
            paragraphProperties20.Append(paragraphMarkRunProperties20);

            paragraph20.Append(paragraphProperties20);

            Paragraph paragraph21 = new Paragraph() { RsidParagraphAddition = "00900A10", RsidParagraphProperties = "00900A10", RsidRunAdditionDefault = "00900A10" };

            ParagraphProperties paragraphProperties21 = new ParagraphProperties();
            WidowControl widowControl21 = new WidowControl() { Val = false };
            AutoSpaceDE autoSpaceDE21 = new AutoSpaceDE() { Val = false };
            AutoSpaceDN autoSpaceDN21 = new AutoSpaceDN() { Val = false };
            AdjustRightIndent adjustRightIndent21 = new AdjustRightIndent() { Val = false };
            SpacingBetweenLines spacingBetweenLines7 = new SpacingBetweenLines() { After = "0", Line = "240", LineRule = LineSpacingRuleValues.Auto };

            ParagraphMarkRunProperties paragraphMarkRunProperties21 = new ParagraphMarkRunProperties();
            RunFonts runFonts41 = new RunFonts() { Ascii = "Verdana", HighAnsi = "Verdana", EastAsia = "New Roman", ComplexScript = "Verdana" };
            FontSize fontSize41 = new FontSize() { Val = "16" };
            FontSizeComplexScript fontSizeComplexScript41 = new FontSizeComplexScript() { Val = "16" };

            paragraphMarkRunProperties21.Append(runFonts41);
            paragraphMarkRunProperties21.Append(fontSize41);
            paragraphMarkRunProperties21.Append(fontSizeComplexScript41);

            paragraphProperties21.Append(widowControl21);
            paragraphProperties21.Append(autoSpaceDE21);
            paragraphProperties21.Append(autoSpaceDN21);
            paragraphProperties21.Append(adjustRightIndent21);
            paragraphProperties21.Append(spacingBetweenLines7);
            paragraphProperties21.Append(paragraphMarkRunProperties21);

            Run run21 = new Run();

            RunProperties runProperties21 = new RunProperties();
            RunFonts runFonts42 = new RunFonts() { Ascii = "Verdana", HighAnsi = "Verdana", EastAsia = "New Roman", ComplexScript = "Verdana" };
            FontSize fontSize42 = new FontSize() { Val = "16" };
            FontSizeComplexScript fontSizeComplexScript42 = new FontSizeComplexScript() { Val = "16" };

            runProperties21.Append(runFonts42);
            runProperties21.Append(fontSize42);
            runProperties21.Append(fontSizeComplexScript42);
            Text text21 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text21.Text = " ";

            run21.Append(runProperties21);
            run21.Append(text21);

            Run run22 = new Run();

            RunProperties runProperties22 = new RunProperties();
            RunFonts runFonts43 = new RunFonts() { Ascii = "Verdana", HighAnsi = "Verdana", EastAsia = "New Roman", ComplexScript = "Verdana" };
            Bold bold12 = new Bold();
            BoldComplexScript boldComplexScript12 = new BoldComplexScript();
            FontSize fontSize43 = new FontSize() { Val = "16" };
            FontSizeComplexScript fontSizeComplexScript43 = new FontSizeComplexScript() { Val = "16" };

            runProperties22.Append(runFonts43);
            runProperties22.Append(bold12);
            runProperties22.Append(boldComplexScript12);
            runProperties22.Append(fontSize43);
            runProperties22.Append(fontSizeComplexScript43);
            Text text22 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text22.Text = "Список заказанных анализов ";

            run22.Append(runProperties22);
            run22.Append(text22);

            paragraph21.Append(paragraphProperties21);
            paragraph21.Append(run21);
            paragraph21.Append(run22);

            Paragraph paragraph22 = new Paragraph() { RsidParagraphAddition = "00900A10", RsidParagraphProperties = "00900A10", RsidRunAdditionDefault = "00900A10" };

            ParagraphProperties paragraphProperties22 = new ParagraphProperties();
            WidowControl widowControl22 = new WidowControl() { Val = false };
            AutoSpaceDE autoSpaceDE22 = new AutoSpaceDE() { Val = false };
            AutoSpaceDN autoSpaceDN22 = new AutoSpaceDN() { Val = false };
            AdjustRightIndent adjustRightIndent22 = new AdjustRightIndent() { Val = false };
            SpacingBetweenLines spacingBetweenLines8 = new SpacingBetweenLines() { After = "0", Line = "240", LineRule = LineSpacingRuleValues.Auto };

            ParagraphMarkRunProperties paragraphMarkRunProperties22 = new ParagraphMarkRunProperties();
            RunFonts runFonts44 = new RunFonts() { Ascii = "Verdana", HighAnsi = "Verdana", EastAsia = "New Roman", ComplexScript = "Verdana" };
            FontSize fontSize44 = new FontSize() { Val = "16" };
            FontSizeComplexScript fontSizeComplexScript44 = new FontSizeComplexScript() { Val = "16" };

            paragraphMarkRunProperties22.Append(runFonts44);
            paragraphMarkRunProperties22.Append(fontSize44);
            paragraphMarkRunProperties22.Append(fontSizeComplexScript44);

            paragraphProperties22.Append(widowControl22);
            paragraphProperties22.Append(autoSpaceDE22);
            paragraphProperties22.Append(autoSpaceDN22);
            paragraphProperties22.Append(adjustRightIndent22);
            paragraphProperties22.Append(spacingBetweenLines8);
            paragraphProperties22.Append(paragraphMarkRunProperties22);

            paragraph22.Append(paragraphProperties22);

            Table table2 = new Table();

            TableProperties tableProperties2 = new TableProperties();
            TableWidth tableWidth2 = new TableWidth() { Width = "0", Type = TableWidthUnitValues.Auto };
            TableIndentation tableIndentation1 = new TableIndentation() { Width = 30, Type = TableWidthUnitValues.Dxa };

            TableCellMarginDefault tableCellMarginDefault1 = new TableCellMarginDefault();
            TableCellLeftMargin tableCellLeftMargin1 = new TableCellLeftMargin() { Width = 30, Type = TableWidthValues.Dxa };
            TableCellRightMargin tableCellRightMargin1 = new TableCellRightMargin() { Width = 30, Type = TableWidthValues.Dxa };

            tableCellMarginDefault1.Append(tableCellLeftMargin1);
            tableCellMarginDefault1.Append(tableCellRightMargin1);
            TableLook tableLook2 = new TableLook() { Val = "0000", FirstRow = false, LastRow = false, FirstColumn = false, LastColumn = false, NoHorizontalBand = false, NoVerticalBand = false };

            tableProperties2.Append(tableWidth2);
            tableProperties2.Append(tableIndentation1);
            tableProperties2.Append(tableCellMarginDefault1);
            tableProperties2.Append(tableLook2);

            TableGrid tableGrid2 = new TableGrid();
            GridColumn gridColumn3 = new GridColumn() { Width = "500" };
            GridColumn gridColumn4 = new GridColumn() { Width = "1000" };
            GridColumn gridColumn5 = new GridColumn() { Width = "5500" };
            GridColumn gridColumn6 = new GridColumn() { Width = "1500" };

            tableGrid2.Append(gridColumn3);
            tableGrid2.Append(gridColumn4);
            tableGrid2.Append(gridColumn5);
            tableGrid2.Append(gridColumn6);

            TableRow tableRow8 = new TableRow() { RsidTableRowAddition = "00900A10", RsidTableRowProperties = "00B819CE" };

            TableRowProperties tableRowProperties8 = new TableRowProperties();
            TableRowHeight tableRowHeight8 = new TableRowHeight() { Val = (UInt32Value)262U };
            TableHeader tableHeader1 = new TableHeader();

            tableRowProperties8.Append(tableRowHeight8);
            tableRowProperties8.Append(tableHeader1);

            TableCell tableCell15 = new TableCell();

            TableCellProperties tableCellProperties15 = new TableCellProperties();
            TableCellWidth tableCellWidth15 = new TableCellWidth() { Width = "500", Type = TableWidthUnitValues.Dxa };

            TableCellBorders tableCellBorders1 = new TableCellBorders();
            TopBorder topBorder2 = new TopBorder() { Val = BorderValues.Nil };
            LeftBorder leftBorder2 = new LeftBorder() { Val = BorderValues.Nil };
            BottomBorder bottomBorder2 = new BottomBorder() { Val = BorderValues.Nil };
            RightBorder rightBorder2 = new RightBorder() { Val = BorderValues.Nil };

            tableCellBorders1.Append(topBorder2);
            tableCellBorders1.Append(leftBorder2);
            tableCellBorders1.Append(bottomBorder2);
            tableCellBorders1.Append(rightBorder2);

            tableCellProperties15.Append(tableCellWidth15);
            tableCellProperties15.Append(tableCellBorders1);

            Paragraph paragraph23 = new Paragraph() { RsidParagraphAddition = "00900A10", RsidParagraphProperties = "00B819CE", RsidRunAdditionDefault = "00900A10" };

            ParagraphProperties paragraphProperties23 = new ParagraphProperties();
            WidowControl widowControl23 = new WidowControl() { Val = false };
            AutoSpaceDE autoSpaceDE23 = new AutoSpaceDE() { Val = false };
            AutoSpaceDN autoSpaceDN23 = new AutoSpaceDN() { Val = false };
            AdjustRightIndent adjustRightIndent23 = new AdjustRightIndent() { Val = false };
            SpacingBetweenLines spacingBetweenLines9 = new SpacingBetweenLines() { After = "0", Line = "240", LineRule = LineSpacingRuleValues.Auto };

            ParagraphMarkRunProperties paragraphMarkRunProperties23 = new ParagraphMarkRunProperties();
            RunFonts runFonts45 = new RunFonts() { Ascii = "Verdana", HighAnsi = "Verdana", EastAsia = "New Roman", ComplexScript = "Verdana" };
            FontSize fontSize45 = new FontSize() { Val = "16" };
            FontSizeComplexScript fontSizeComplexScript45 = new FontSizeComplexScript() { Val = "16" };

            paragraphMarkRunProperties23.Append(runFonts45);
            paragraphMarkRunProperties23.Append(fontSize45);
            paragraphMarkRunProperties23.Append(fontSizeComplexScript45);

            paragraphProperties23.Append(widowControl23);
            paragraphProperties23.Append(autoSpaceDE23);
            paragraphProperties23.Append(autoSpaceDN23);
            paragraphProperties23.Append(adjustRightIndent23);
            paragraphProperties23.Append(spacingBetweenLines9);
            paragraphProperties23.Append(paragraphMarkRunProperties23);

            Run run23 = new Run();

            RunProperties runProperties23 = new RunProperties();
            RunFonts runFonts46 = new RunFonts() { Ascii = "Verdana", HighAnsi = "Verdana", EastAsia = "New Roman", ComplexScript = "Verdana" };
            Bold bold13 = new Bold();
            BoldComplexScript boldComplexScript13 = new BoldComplexScript();
            Italic italic1 = new Italic();
            ItalicComplexScript italicComplexScript1 = new ItalicComplexScript();
            FontSize fontSize46 = new FontSize() { Val = "16" };
            FontSizeComplexScript fontSizeComplexScript46 = new FontSizeComplexScript() { Val = "16" };
            Underline underline1 = new Underline() { Val = UnderlineValues.Single };

            runProperties23.Append(runFonts46);
            runProperties23.Append(bold13);
            runProperties23.Append(boldComplexScript13);
            runProperties23.Append(italic1);
            runProperties23.Append(italicComplexScript1);
            runProperties23.Append(fontSize46);
            runProperties23.Append(fontSizeComplexScript46);
            runProperties23.Append(underline1);
            Text text23 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text23.Text = "№ ";

            run23.Append(runProperties23);
            run23.Append(text23);

            paragraph23.Append(paragraphProperties23);
            paragraph23.Append(run23);

            tableCell15.Append(tableCellProperties15);
            tableCell15.Append(paragraph23);

            TableCell tableCell16 = new TableCell();

            TableCellProperties tableCellProperties16 = new TableCellProperties();
            TableCellWidth tableCellWidth16 = new TableCellWidth() { Width = "1000", Type = TableWidthUnitValues.Dxa };

            TableCellBorders tableCellBorders2 = new TableCellBorders();
            TopBorder topBorder3 = new TopBorder() { Val = BorderValues.Nil };
            LeftBorder leftBorder3 = new LeftBorder() { Val = BorderValues.Nil };
            BottomBorder bottomBorder3 = new BottomBorder() { Val = BorderValues.Nil };
            RightBorder rightBorder3 = new RightBorder() { Val = BorderValues.Nil };

            tableCellBorders2.Append(topBorder3);
            tableCellBorders2.Append(leftBorder3);
            tableCellBorders2.Append(bottomBorder3);
            tableCellBorders2.Append(rightBorder3);

            tableCellProperties16.Append(tableCellWidth16);
            tableCellProperties16.Append(tableCellBorders2);

            Paragraph paragraph24 = new Paragraph() { RsidParagraphAddition = "00900A10", RsidParagraphProperties = "00B819CE", RsidRunAdditionDefault = "00900A10" };

            ParagraphProperties paragraphProperties24 = new ParagraphProperties();
            WidowControl widowControl24 = new WidowControl() { Val = false };
            AutoSpaceDE autoSpaceDE24 = new AutoSpaceDE() { Val = false };
            AutoSpaceDN autoSpaceDN24 = new AutoSpaceDN() { Val = false };
            AdjustRightIndent adjustRightIndent24 = new AdjustRightIndent() { Val = false };
            SpacingBetweenLines spacingBetweenLines10 = new SpacingBetweenLines() { After = "0", Line = "240", LineRule = LineSpacingRuleValues.Auto };
            Justification justification5 = new Justification() { Val = JustificationValues.Center };

            ParagraphMarkRunProperties paragraphMarkRunProperties24 = new ParagraphMarkRunProperties();
            RunFonts runFonts47 = new RunFonts() { Ascii = "Verdana", HighAnsi = "Verdana", EastAsia = "New Roman", ComplexScript = "Verdana" };
            FontSize fontSize47 = new FontSize() { Val = "16" };
            FontSizeComplexScript fontSizeComplexScript47 = new FontSizeComplexScript() { Val = "16" };

            paragraphMarkRunProperties24.Append(runFonts47);
            paragraphMarkRunProperties24.Append(fontSize47);
            paragraphMarkRunProperties24.Append(fontSizeComplexScript47);

            paragraphProperties24.Append(widowControl24);
            paragraphProperties24.Append(autoSpaceDE24);
            paragraphProperties24.Append(autoSpaceDN24);
            paragraphProperties24.Append(adjustRightIndent24);
            paragraphProperties24.Append(spacingBetweenLines10);
            paragraphProperties24.Append(justification5);
            paragraphProperties24.Append(paragraphMarkRunProperties24);

            Run run24 = new Run();

            RunProperties runProperties24 = new RunProperties();
            RunFonts runFonts48 = new RunFonts() { Ascii = "Verdana", HighAnsi = "Verdana", EastAsia = "New Roman", ComplexScript = "Verdana" };
            Bold bold14 = new Bold();
            BoldComplexScript boldComplexScript14 = new BoldComplexScript();
            Italic italic2 = new Italic();
            ItalicComplexScript italicComplexScript2 = new ItalicComplexScript();
            FontSize fontSize48 = new FontSize() { Val = "16" };
            FontSizeComplexScript fontSizeComplexScript48 = new FontSizeComplexScript() { Val = "16" };
            Underline underline2 = new Underline() { Val = UnderlineValues.Single };

            runProperties24.Append(runFonts48);
            runProperties24.Append(bold14);
            runProperties24.Append(boldComplexScript14);
            runProperties24.Append(italic2);
            runProperties24.Append(italicComplexScript2);
            runProperties24.Append(fontSize48);
            runProperties24.Append(fontSizeComplexScript48);
            runProperties24.Append(underline2);
            Text text24 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text24.Text = "Код ";

            run24.Append(runProperties24);
            run24.Append(text24);

            paragraph24.Append(paragraphProperties24);
            paragraph24.Append(run24);

            tableCell16.Append(tableCellProperties16);
            tableCell16.Append(paragraph24);

            TableCell tableCell17 = new TableCell();

            TableCellProperties tableCellProperties17 = new TableCellProperties();
            TableCellWidth tableCellWidth17 = new TableCellWidth() { Width = "5500", Type = TableWidthUnitValues.Dxa };

            TableCellBorders tableCellBorders3 = new TableCellBorders();
            TopBorder topBorder4 = new TopBorder() { Val = BorderValues.Nil };
            LeftBorder leftBorder4 = new LeftBorder() { Val = BorderValues.Nil };
            BottomBorder bottomBorder4 = new BottomBorder() { Val = BorderValues.Nil };
            RightBorder rightBorder4 = new RightBorder() { Val = BorderValues.Nil };

            tableCellBorders3.Append(topBorder4);
            tableCellBorders3.Append(leftBorder4);
            tableCellBorders3.Append(bottomBorder4);
            tableCellBorders3.Append(rightBorder4);

            tableCellProperties17.Append(tableCellWidth17);
            tableCellProperties17.Append(tableCellBorders3);

            Paragraph paragraph25 = new Paragraph() { RsidParagraphAddition = "00900A10", RsidParagraphProperties = "00B819CE", RsidRunAdditionDefault = "00900A10" };

            ParagraphProperties paragraphProperties25 = new ParagraphProperties();
            WidowControl widowControl25 = new WidowControl() { Val = false };
            AutoSpaceDE autoSpaceDE25 = new AutoSpaceDE() { Val = false };
            AutoSpaceDN autoSpaceDN25 = new AutoSpaceDN() { Val = false };
            AdjustRightIndent adjustRightIndent25 = new AdjustRightIndent() { Val = false };
            SpacingBetweenLines spacingBetweenLines11 = new SpacingBetweenLines() { After = "0", Line = "240", LineRule = LineSpacingRuleValues.Auto };

            ParagraphMarkRunProperties paragraphMarkRunProperties25 = new ParagraphMarkRunProperties();
            RunFonts runFonts49 = new RunFonts() { Ascii = "Verdana", HighAnsi = "Verdana", EastAsia = "New Roman", ComplexScript = "Verdana" };
            FontSize fontSize49 = new FontSize() { Val = "16" };
            FontSizeComplexScript fontSizeComplexScript49 = new FontSizeComplexScript() { Val = "16" };

            paragraphMarkRunProperties25.Append(runFonts49);
            paragraphMarkRunProperties25.Append(fontSize49);
            paragraphMarkRunProperties25.Append(fontSizeComplexScript49);

            paragraphProperties25.Append(widowControl25);
            paragraphProperties25.Append(autoSpaceDE25);
            paragraphProperties25.Append(autoSpaceDN25);
            paragraphProperties25.Append(adjustRightIndent25);
            paragraphProperties25.Append(spacingBetweenLines11);
            paragraphProperties25.Append(paragraphMarkRunProperties25);

            Run run25 = new Run();

            RunProperties runProperties25 = new RunProperties();
            RunFonts runFonts50 = new RunFonts() { Ascii = "Verdana", HighAnsi = "Verdana", EastAsia = "New Roman", ComplexScript = "Verdana" };
            Bold bold15 = new Bold();
            BoldComplexScript boldComplexScript15 = new BoldComplexScript();
            Italic italic3 = new Italic();
            ItalicComplexScript italicComplexScript3 = new ItalicComplexScript();
            FontSize fontSize50 = new FontSize() { Val = "16" };
            FontSizeComplexScript fontSizeComplexScript50 = new FontSizeComplexScript() { Val = "16" };
            Underline underline3 = new Underline() { Val = UnderlineValues.Single };

            runProperties25.Append(runFonts50);
            runProperties25.Append(bold15);
            runProperties25.Append(boldComplexScript15);
            runProperties25.Append(italic3);
            runProperties25.Append(italicComplexScript3);
            runProperties25.Append(fontSize50);
            runProperties25.Append(fontSizeComplexScript50);
            runProperties25.Append(underline3);
            Text text25 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text25.Text = "Тип анализа ";

            run25.Append(runProperties25);
            run25.Append(text25);

            paragraph25.Append(paragraphProperties25);
            paragraph25.Append(run25);

            tableCell17.Append(tableCellProperties17);
            tableCell17.Append(paragraph25);

            TableCell tableCell18 = new TableCell();

            TableCellProperties tableCellProperties18 = new TableCellProperties();
            TableCellWidth tableCellWidth18 = new TableCellWidth() { Width = "1500", Type = TableWidthUnitValues.Dxa };

            TableCellBorders tableCellBorders4 = new TableCellBorders();
            TopBorder topBorder5 = new TopBorder() { Val = BorderValues.Nil };
            LeftBorder leftBorder5 = new LeftBorder() { Val = BorderValues.Nil };
            BottomBorder bottomBorder5 = new BottomBorder() { Val = BorderValues.Nil };
            RightBorder rightBorder5 = new RightBorder() { Val = BorderValues.Nil };

            tableCellBorders4.Append(topBorder5);
            tableCellBorders4.Append(leftBorder5);
            tableCellBorders4.Append(bottomBorder5);
            tableCellBorders4.Append(rightBorder5);

            tableCellProperties18.Append(tableCellWidth18);
            tableCellProperties18.Append(tableCellBorders4);

            Paragraph paragraph26 = new Paragraph() { RsidParagraphAddition = "00900A10", RsidParagraphProperties = "00B819CE", RsidRunAdditionDefault = "00900A10" };

            ParagraphProperties paragraphProperties26 = new ParagraphProperties();
            WidowControl widowControl26 = new WidowControl() { Val = false };
            AutoSpaceDE autoSpaceDE26 = new AutoSpaceDE() { Val = false };
            AutoSpaceDN autoSpaceDN26 = new AutoSpaceDN() { Val = false };
            AdjustRightIndent adjustRightIndent26 = new AdjustRightIndent() { Val = false };
            SpacingBetweenLines spacingBetweenLines12 = new SpacingBetweenLines() { After = "0", Line = "240", LineRule = LineSpacingRuleValues.Auto };

            ParagraphMarkRunProperties paragraphMarkRunProperties26 = new ParagraphMarkRunProperties();
            RunFonts runFonts51 = new RunFonts() { Ascii = "Verdana", HighAnsi = "Verdana", EastAsia = "New Roman", ComplexScript = "Verdana" };
            FontSize fontSize51 = new FontSize() { Val = "16" };
            FontSizeComplexScript fontSizeComplexScript51 = new FontSizeComplexScript() { Val = "16" };

            paragraphMarkRunProperties26.Append(runFonts51);
            paragraphMarkRunProperties26.Append(fontSize51);
            paragraphMarkRunProperties26.Append(fontSizeComplexScript51);

            paragraphProperties26.Append(widowControl26);
            paragraphProperties26.Append(autoSpaceDE26);
            paragraphProperties26.Append(autoSpaceDN26);
            paragraphProperties26.Append(adjustRightIndent26);
            paragraphProperties26.Append(spacingBetweenLines12);
            paragraphProperties26.Append(paragraphMarkRunProperties26);

            Run run26 = new Run();

            RunProperties runProperties26 = new RunProperties();
            RunFonts runFonts52 = new RunFonts() { Ascii = "Verdana", HighAnsi = "Verdana", EastAsia = "New Roman", ComplexScript = "Verdana" };
            Bold bold16 = new Bold();
            BoldComplexScript boldComplexScript16 = new BoldComplexScript();
            Italic italic4 = new Italic();
            ItalicComplexScript italicComplexScript4 = new ItalicComplexScript();
            FontSize fontSize52 = new FontSize() { Val = "16" };
            FontSizeComplexScript fontSizeComplexScript52 = new FontSizeComplexScript() { Val = "16" };
            Underline underline4 = new Underline() { Val = UnderlineValues.Single };

            runProperties26.Append(runFonts52);
            runProperties26.Append(bold16);
            runProperties26.Append(boldComplexScript16);
            runProperties26.Append(italic4);
            runProperties26.Append(italicComplexScript4);
            runProperties26.Append(fontSize52);
            runProperties26.Append(fontSizeComplexScript52);
            runProperties26.Append(underline4);
            Text text26 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text26.Text = "Стоимость ";

            run26.Append(runProperties26);
            run26.Append(text26);

            paragraph26.Append(paragraphProperties26);
            paragraph26.Append(run26);

            tableCell18.Append(tableCellProperties18);
            tableCell18.Append(paragraph26);

            tableRow8.Append(tableRowProperties8);
            tableRow8.Append(tableCell15);
            tableRow8.Append(tableCell16);
            tableRow8.Append(tableCell17);
            tableRow8.Append(tableCell18);

            TableRow tableRow9 = new TableRow() { RsidTableRowAddition = "00900A10", RsidTableRowProperties = "00B819CE" };

            TableRowProperties tableRowProperties9 = new TableRowProperties();
            TableRowHeight tableRowHeight9 = new TableRowHeight() { Val = (UInt32Value)262U };

            tableRowProperties9.Append(tableRowHeight9);

            TableCell tableCell19 = new TableCell();

            TableCellProperties tableCellProperties19 = new TableCellProperties();
            TableCellWidth tableCellWidth19 = new TableCellWidth() { Width = "500", Type = TableWidthUnitValues.Dxa };

            TableCellBorders tableCellBorders5 = new TableCellBorders();
            TopBorder topBorder6 = new TopBorder() { Val = BorderValues.Nil };
            LeftBorder leftBorder6 = new LeftBorder() { Val = BorderValues.Nil };
            BottomBorder bottomBorder6 = new BottomBorder() { Val = BorderValues.Nil };
            RightBorder rightBorder6 = new RightBorder() { Val = BorderValues.Nil };

            tableCellBorders5.Append(topBorder6);
            tableCellBorders5.Append(leftBorder6);
            tableCellBorders5.Append(bottomBorder6);
            tableCellBorders5.Append(rightBorder6);

            tableCellProperties19.Append(tableCellWidth19);
            tableCellProperties19.Append(tableCellBorders5);

            Paragraph paragraph27 = new Paragraph() { RsidParagraphAddition = "00900A10", RsidParagraphProperties = "00B819CE", RsidRunAdditionDefault = "00900A10" };

            ParagraphProperties paragraphProperties27 = new ParagraphProperties();
            WidowControl widowControl27 = new WidowControl() { Val = false };
            AutoSpaceDE autoSpaceDE27 = new AutoSpaceDE() { Val = false };
            AutoSpaceDN autoSpaceDN27 = new AutoSpaceDN() { Val = false };
            AdjustRightIndent adjustRightIndent27 = new AdjustRightIndent() { Val = false };
            SpacingBetweenLines spacingBetweenLines13 = new SpacingBetweenLines() { After = "0", Line = "240", LineRule = LineSpacingRuleValues.Auto };

            ParagraphMarkRunProperties paragraphMarkRunProperties27 = new ParagraphMarkRunProperties();
            RunFonts runFonts53 = new RunFonts() { Ascii = "Verdana", HighAnsi = "Verdana", EastAsia = "New Roman", ComplexScript = "Verdana" };
            FontSize fontSize53 = new FontSize() { Val = "16" };
            FontSizeComplexScript fontSizeComplexScript53 = new FontSizeComplexScript() { Val = "16" };

            paragraphMarkRunProperties27.Append(runFonts53);
            paragraphMarkRunProperties27.Append(fontSize53);
            paragraphMarkRunProperties27.Append(fontSizeComplexScript53);

            paragraphProperties27.Append(widowControl27);
            paragraphProperties27.Append(autoSpaceDE27);
            paragraphProperties27.Append(autoSpaceDN27);
            paragraphProperties27.Append(adjustRightIndent27);
            paragraphProperties27.Append(spacingBetweenLines13);
            paragraphProperties27.Append(paragraphMarkRunProperties27);

            Run run27 = new Run();

            RunProperties runProperties27 = new RunProperties();
            RunFonts runFonts54 = new RunFonts() { Ascii = "Verdana", HighAnsi = "Verdana", EastAsia = "New Roman", ComplexScript = "Verdana" };
            FontSize fontSize54 = new FontSize() { Val = "16" };
            FontSizeComplexScript fontSizeComplexScript54 = new FontSizeComplexScript() { Val = "16" };

            runProperties27.Append(runFonts54);
            runProperties27.Append(fontSize54);
            runProperties27.Append(fontSizeComplexScript54);
            Text text27 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text27.Text = "1     ";

            run27.Append(runProperties27);
            run27.Append(text27);

            paragraph27.Append(paragraphProperties27);
            paragraph27.Append(run27);

            tableCell19.Append(tableCellProperties19);
            tableCell19.Append(paragraph27);

            TableCell tableCell20 = new TableCell();

            TableCellProperties tableCellProperties20 = new TableCellProperties();
            TableCellWidth tableCellWidth20 = new TableCellWidth() { Width = "1000", Type = TableWidthUnitValues.Dxa };

            TableCellBorders tableCellBorders6 = new TableCellBorders();
            TopBorder topBorder7 = new TopBorder() { Val = BorderValues.Nil };
            LeftBorder leftBorder7 = new LeftBorder() { Val = BorderValues.Nil };
            BottomBorder bottomBorder7 = new BottomBorder() { Val = BorderValues.Nil };
            RightBorder rightBorder7 = new RightBorder() { Val = BorderValues.Nil };

            tableCellBorders6.Append(topBorder7);
            tableCellBorders6.Append(leftBorder7);
            tableCellBorders6.Append(bottomBorder7);
            tableCellBorders6.Append(rightBorder7);

            tableCellProperties20.Append(tableCellWidth20);
            tableCellProperties20.Append(tableCellBorders6);

            Paragraph paragraph28 = new Paragraph() { RsidParagraphAddition = "00900A10", RsidParagraphProperties = "00B819CE", RsidRunAdditionDefault = "00900A10" };

            ParagraphProperties paragraphProperties28 = new ParagraphProperties();
            WidowControl widowControl28 = new WidowControl() { Val = false };
            AutoSpaceDE autoSpaceDE28 = new AutoSpaceDE() { Val = false };
            AutoSpaceDN autoSpaceDN28 = new AutoSpaceDN() { Val = false };
            AdjustRightIndent adjustRightIndent28 = new AdjustRightIndent() { Val = false };
            SpacingBetweenLines spacingBetweenLines14 = new SpacingBetweenLines() { After = "0", Line = "240", LineRule = LineSpacingRuleValues.Auto };
            Justification justification6 = new Justification() { Val = JustificationValues.Center };

            ParagraphMarkRunProperties paragraphMarkRunProperties28 = new ParagraphMarkRunProperties();
            RunFonts runFonts55 = new RunFonts() { Ascii = "Verdana", HighAnsi = "Verdana", EastAsia = "New Roman", ComplexScript = "Verdana" };
            FontSize fontSize55 = new FontSize() { Val = "16" };
            FontSizeComplexScript fontSizeComplexScript55 = new FontSizeComplexScript() { Val = "16" };

            paragraphMarkRunProperties28.Append(runFonts55);
            paragraphMarkRunProperties28.Append(fontSize55);
            paragraphMarkRunProperties28.Append(fontSizeComplexScript55);

            paragraphProperties28.Append(widowControl28);
            paragraphProperties28.Append(autoSpaceDE28);
            paragraphProperties28.Append(autoSpaceDN28);
            paragraphProperties28.Append(adjustRightIndent28);
            paragraphProperties28.Append(spacingBetweenLines14);
            paragraphProperties28.Append(justification6);
            paragraphProperties28.Append(paragraphMarkRunProperties28);

            Run run28 = new Run();

            RunProperties runProperties28 = new RunProperties();
            RunFonts runFonts56 = new RunFonts() { Ascii = "Verdana", HighAnsi = "Verdana", EastAsia = "New Roman", ComplexScript = "Verdana" };
            FontSize fontSize56 = new FontSize() { Val = "16" };
            FontSizeComplexScript fontSizeComplexScript56 = new FontSizeComplexScript() { Val = "16" };

            runProperties28.Append(runFonts56);
            runProperties28.Append(fontSize56);
            runProperties28.Append(fontSizeComplexScript56);
            Text text28 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text28.Text = "500002     ";

            run28.Append(runProperties28);
            run28.Append(text28);

            paragraph28.Append(paragraphProperties28);
            paragraph28.Append(run28);

            tableCell20.Append(tableCellProperties20);
            tableCell20.Append(paragraph28);

            TableCell tableCell21 = new TableCell();

            TableCellProperties tableCellProperties21 = new TableCellProperties();
            TableCellWidth tableCellWidth21 = new TableCellWidth() { Width = "5500", Type = TableWidthUnitValues.Dxa };

            TableCellBorders tableCellBorders7 = new TableCellBorders();
            TopBorder topBorder8 = new TopBorder() { Val = BorderValues.Nil };
            LeftBorder leftBorder8 = new LeftBorder() { Val = BorderValues.Nil };
            BottomBorder bottomBorder8 = new BottomBorder() { Val = BorderValues.Nil };
            RightBorder rightBorder8 = new RightBorder() { Val = BorderValues.Nil };

            tableCellBorders7.Append(topBorder8);
            tableCellBorders7.Append(leftBorder8);
            tableCellBorders7.Append(bottomBorder8);
            tableCellBorders7.Append(rightBorder8);

            tableCellProperties21.Append(tableCellWidth21);
            tableCellProperties21.Append(tableCellBorders7);

            Paragraph paragraph29 = new Paragraph() { RsidParagraphAddition = "00900A10", RsidParagraphProperties = "00B819CE", RsidRunAdditionDefault = "00900A10" };

            ParagraphProperties paragraphProperties29 = new ParagraphProperties();
            WidowControl widowControl29 = new WidowControl() { Val = false };
            AutoSpaceDE autoSpaceDE29 = new AutoSpaceDE() { Val = false };
            AutoSpaceDN autoSpaceDN29 = new AutoSpaceDN() { Val = false };
            AdjustRightIndent adjustRightIndent29 = new AdjustRightIndent() { Val = false };
            SpacingBetweenLines spacingBetweenLines15 = new SpacingBetweenLines() { After = "0", Line = "240", LineRule = LineSpacingRuleValues.Auto };

            ParagraphMarkRunProperties paragraphMarkRunProperties29 = new ParagraphMarkRunProperties();
            RunFonts runFonts57 = new RunFonts() { Ascii = "Verdana", HighAnsi = "Verdana", EastAsia = "New Roman", ComplexScript = "Verdana" };
            FontSize fontSize57 = new FontSize() { Val = "16" };
            FontSizeComplexScript fontSizeComplexScript57 = new FontSizeComplexScript() { Val = "16" };

            paragraphMarkRunProperties29.Append(runFonts57);
            paragraphMarkRunProperties29.Append(fontSize57);
            paragraphMarkRunProperties29.Append(fontSizeComplexScript57);

            paragraphProperties29.Append(widowControl29);
            paragraphProperties29.Append(autoSpaceDE29);
            paragraphProperties29.Append(autoSpaceDN29);
            paragraphProperties29.Append(adjustRightIndent29);
            paragraphProperties29.Append(spacingBetweenLines15);
            paragraphProperties29.Append(paragraphMarkRunProperties29);

            Run run29 = new Run();

            RunProperties runProperties29 = new RunProperties();
            RunFonts runFonts58 = new RunFonts() { Ascii = "Verdana", HighAnsi = "Verdana", EastAsia = "New Roman", ComplexScript = "Verdana" };
            FontSize fontSize58 = new FontSize() { Val = "16" };
            FontSizeComplexScript fontSizeComplexScript58 = new FontSizeComplexScript() { Val = "16" };

            runProperties29.Append(runFonts58);
            runProperties29.Append(fontSize58);
            runProperties29.Append(fontSizeComplexScript58);
            Text text29 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text29.Text = "ОАК с лейкоцитарной формулой (17 показателей) ";

            run29.Append(runProperties29);
            run29.Append(text29);

            paragraph29.Append(paragraphProperties29);
            paragraph29.Append(run29);

            tableCell21.Append(tableCellProperties21);
            tableCell21.Append(paragraph29);

            TableCell tableCell22 = new TableCell();

            TableCellProperties tableCellProperties22 = new TableCellProperties();
            TableCellWidth tableCellWidth22 = new TableCellWidth() { Width = "1500", Type = TableWidthUnitValues.Dxa };

            TableCellBorders tableCellBorders8 = new TableCellBorders();
            TopBorder topBorder9 = new TopBorder() { Val = BorderValues.Nil };
            LeftBorder leftBorder9 = new LeftBorder() { Val = BorderValues.Nil };
            BottomBorder bottomBorder9 = new BottomBorder() { Val = BorderValues.Nil };
            RightBorder rightBorder9 = new RightBorder() { Val = BorderValues.Nil };

            tableCellBorders8.Append(topBorder9);
            tableCellBorders8.Append(leftBorder9);
            tableCellBorders8.Append(bottomBorder9);
            tableCellBorders8.Append(rightBorder9);

            tableCellProperties22.Append(tableCellWidth22);
            tableCellProperties22.Append(tableCellBorders8);

            Paragraph paragraph30 = new Paragraph() { RsidParagraphAddition = "00900A10", RsidParagraphProperties = "00B819CE", RsidRunAdditionDefault = "00900A10" };

            ParagraphProperties paragraphProperties30 = new ParagraphProperties();
            WidowControl widowControl30 = new WidowControl() { Val = false };
            AutoSpaceDE autoSpaceDE30 = new AutoSpaceDE() { Val = false };
            AutoSpaceDN autoSpaceDN30 = new AutoSpaceDN() { Val = false };
            AdjustRightIndent adjustRightIndent30 = new AdjustRightIndent() { Val = false };
            SpacingBetweenLines spacingBetweenLines16 = new SpacingBetweenLines() { After = "0", Line = "240", LineRule = LineSpacingRuleValues.Auto };

            ParagraphMarkRunProperties paragraphMarkRunProperties30 = new ParagraphMarkRunProperties();
            RunFonts runFonts59 = new RunFonts() { Ascii = "Verdana", HighAnsi = "Verdana", EastAsia = "New Roman", ComplexScript = "Verdana" };
            FontSize fontSize59 = new FontSize() { Val = "16" };
            FontSizeComplexScript fontSizeComplexScript59 = new FontSizeComplexScript() { Val = "16" };

            paragraphMarkRunProperties30.Append(runFonts59);
            paragraphMarkRunProperties30.Append(fontSize59);
            paragraphMarkRunProperties30.Append(fontSizeComplexScript59);

            paragraphProperties30.Append(widowControl30);
            paragraphProperties30.Append(autoSpaceDE30);
            paragraphProperties30.Append(autoSpaceDN30);
            paragraphProperties30.Append(adjustRightIndent30);
            paragraphProperties30.Append(spacingBetweenLines16);
            paragraphProperties30.Append(paragraphMarkRunProperties30);

            Run run30 = new Run();

            RunProperties runProperties30 = new RunProperties();
            RunFonts runFonts60 = new RunFonts() { Ascii = "Verdana", HighAnsi = "Verdana", EastAsia = "New Roman", ComplexScript = "Verdana" };
            FontSize fontSize60 = new FontSize() { Val = "16" };
            FontSizeComplexScript fontSizeComplexScript60 = new FontSizeComplexScript() { Val = "16" };

            runProperties30.Append(runFonts60);
            runProperties30.Append(fontSize60);
            runProperties30.Append(fontSizeComplexScript60);
            Text text30 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text30.Text = "290,00 руб. ";

            run30.Append(runProperties30);
            run30.Append(text30);

            paragraph30.Append(paragraphProperties30);
            paragraph30.Append(run30);

            tableCell22.Append(tableCellProperties22);
            tableCell22.Append(paragraph30);

            tableRow9.Append(tableRowProperties9);
            tableRow9.Append(tableCell19);
            tableRow9.Append(tableCell20);
            tableRow9.Append(tableCell21);
            tableRow9.Append(tableCell22);

            table2.Append(tableProperties2);
            table2.Append(tableGrid2);
            table2.Append(tableRow8);
            table2.Append(tableRow9);

            Paragraph paragraph31 = new Paragraph() { RsidParagraphAddition = "00900A10", RsidParagraphProperties = "00900A10", RsidRunAdditionDefault = "00900A10" };

            ParagraphProperties paragraphProperties31 = new ParagraphProperties();
            WidowControl widowControl31 = new WidowControl() { Val = false };
            AutoSpaceDE autoSpaceDE31 = new AutoSpaceDE() { Val = false };
            AutoSpaceDN autoSpaceDN31 = new AutoSpaceDN() { Val = false };
            AdjustRightIndent adjustRightIndent31 = new AdjustRightIndent() { Val = false };
            SpacingBetweenLines spacingBetweenLines17 = new SpacingBetweenLines() { After = "0", Line = "240", LineRule = LineSpacingRuleValues.Auto };

            ParagraphMarkRunProperties paragraphMarkRunProperties31 = new ParagraphMarkRunProperties();
            RunFonts runFonts61 = new RunFonts() { Ascii = "Verdana", HighAnsi = "Verdana", EastAsia = "New Roman", ComplexScript = "Verdana" };
            FontSize fontSize61 = new FontSize() { Val = "16" };
            FontSizeComplexScript fontSizeComplexScript61 = new FontSizeComplexScript() { Val = "16" };

            paragraphMarkRunProperties31.Append(runFonts61);
            paragraphMarkRunProperties31.Append(fontSize61);
            paragraphMarkRunProperties31.Append(fontSizeComplexScript61);

            paragraphProperties31.Append(widowControl31);
            paragraphProperties31.Append(autoSpaceDE31);
            paragraphProperties31.Append(autoSpaceDN31);
            paragraphProperties31.Append(adjustRightIndent31);
            paragraphProperties31.Append(spacingBetweenLines17);
            paragraphProperties31.Append(paragraphMarkRunProperties31);

            paragraph31.Append(paragraphProperties31);

            Paragraph paragraph32 = new Paragraph() { RsidParagraphAddition = "00900A10", RsidParagraphProperties = "00900A10", RsidRunAdditionDefault = "00900A10" };

            ParagraphProperties paragraphProperties32 = new ParagraphProperties();
            WidowControl widowControl32 = new WidowControl() { Val = false };
            AutoSpaceDE autoSpaceDE32 = new AutoSpaceDE() { Val = false };
            AutoSpaceDN autoSpaceDN32 = new AutoSpaceDN() { Val = false };
            AdjustRightIndent adjustRightIndent32 = new AdjustRightIndent() { Val = false };
            SpacingBetweenLines spacingBetweenLines18 = new SpacingBetweenLines() { After = "0", Line = "240", LineRule = LineSpacingRuleValues.Auto };

            ParagraphMarkRunProperties paragraphMarkRunProperties32 = new ParagraphMarkRunProperties();
            RunFonts runFonts62 = new RunFonts() { Ascii = "Verdana", HighAnsi = "Verdana", EastAsia = "New Roman", ComplexScript = "Verdana" };
            FontSize fontSize62 = new FontSize() { Val = "16" };
            FontSizeComplexScript fontSizeComplexScript62 = new FontSizeComplexScript() { Val = "16" };

            paragraphMarkRunProperties32.Append(runFonts62);
            paragraphMarkRunProperties32.Append(fontSize62);
            paragraphMarkRunProperties32.Append(fontSizeComplexScript62);

            paragraphProperties32.Append(widowControl32);
            paragraphProperties32.Append(autoSpaceDE32);
            paragraphProperties32.Append(autoSpaceDN32);
            paragraphProperties32.Append(adjustRightIndent32);
            paragraphProperties32.Append(spacingBetweenLines18);
            paragraphProperties32.Append(paragraphMarkRunProperties32);

            paragraph32.Append(paragraphProperties32);

            Paragraph paragraph33 = new Paragraph() { RsidParagraphAddition = "00900A10", RsidParagraphProperties = "00900A10", RsidRunAdditionDefault = "00900A10" };

            ParagraphProperties paragraphProperties33 = new ParagraphProperties();
            WidowControl widowControl33 = new WidowControl() { Val = false };
            AutoSpaceDE autoSpaceDE33 = new AutoSpaceDE() { Val = false };
            AutoSpaceDN autoSpaceDN33 = new AutoSpaceDN() { Val = false };
            AdjustRightIndent adjustRightIndent33 = new AdjustRightIndent() { Val = false };
            SpacingBetweenLines spacingBetweenLines19 = new SpacingBetweenLines() { After = "0", Line = "240", LineRule = LineSpacingRuleValues.Auto };

            ParagraphMarkRunProperties paragraphMarkRunProperties33 = new ParagraphMarkRunProperties();
            RunFonts runFonts63 = new RunFonts() { Ascii = "Verdana", HighAnsi = "Verdana", EastAsia = "New Roman", ComplexScript = "Verdana" };
            FontSize fontSize63 = new FontSize() { Val = "16" };
            FontSizeComplexScript fontSizeComplexScript63 = new FontSizeComplexScript() { Val = "16" };

            paragraphMarkRunProperties33.Append(runFonts63);
            paragraphMarkRunProperties33.Append(fontSize63);
            paragraphMarkRunProperties33.Append(fontSizeComplexScript63);

            paragraphProperties33.Append(widowControl33);
            paragraphProperties33.Append(autoSpaceDE33);
            paragraphProperties33.Append(autoSpaceDN33);
            paragraphProperties33.Append(adjustRightIndent33);
            paragraphProperties33.Append(spacingBetweenLines19);
            paragraphProperties33.Append(paragraphMarkRunProperties33);

            Run run31 = new Run();

            RunProperties runProperties31 = new RunProperties();
            RunFonts runFonts64 = new RunFonts() { Ascii = "Verdana", HighAnsi = "Verdana", EastAsia = "New Roman", ComplexScript = "Verdana" };
            FontSize fontSize64 = new FontSize() { Val = "16" };
            FontSizeComplexScript fontSizeComplexScript64 = new FontSizeComplexScript() { Val = "16" };

            runProperties31.Append(runFonts64);
            runProperties31.Append(fontSize64);
            runProperties31.Append(fontSizeComplexScript64);
            Text text31 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text31.Text = " ";

            run31.Append(runProperties31);
            run31.Append(text31);

            Run run32 = new Run();

            RunProperties runProperties32 = new RunProperties();
            RunFonts runFonts65 = new RunFonts() { Ascii = "Verdana", HighAnsi = "Verdana", EastAsia = "New Roman", ComplexScript = "Verdana" };
            Bold bold17 = new Bold();
            BoldComplexScript boldComplexScript17 = new BoldComplexScript();
            FontSize fontSize65 = new FontSize() { Val = "16" };
            FontSizeComplexScript fontSizeComplexScript65 = new FontSizeComplexScript() { Val = "16" };

            runProperties32.Append(runFonts65);
            runProperties32.Append(bold17);
            runProperties32.Append(boldComplexScript17);
            runProperties32.Append(fontSize65);
            runProperties32.Append(fontSizeComplexScript65);
            Text text32 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text32.Text = "Дополнительные услуги ";

            run32.Append(runProperties32);
            run32.Append(text32);

            paragraph33.Append(paragraphProperties33);
            paragraph33.Append(run31);
            paragraph33.Append(run32);

            Paragraph paragraph34 = new Paragraph() { RsidParagraphAddition = "00900A10", RsidParagraphProperties = "00900A10", RsidRunAdditionDefault = "00900A10" };

            ParagraphProperties paragraphProperties34 = new ParagraphProperties();
            WidowControl widowControl34 = new WidowControl() { Val = false };
            AutoSpaceDE autoSpaceDE34 = new AutoSpaceDE() { Val = false };
            AutoSpaceDN autoSpaceDN34 = new AutoSpaceDN() { Val = false };
            AdjustRightIndent adjustRightIndent34 = new AdjustRightIndent() { Val = false };
            SpacingBetweenLines spacingBetweenLines20 = new SpacingBetweenLines() { After = "0", Line = "240", LineRule = LineSpacingRuleValues.Auto };

            ParagraphMarkRunProperties paragraphMarkRunProperties34 = new ParagraphMarkRunProperties();
            RunFonts runFonts66 = new RunFonts() { Ascii = "Verdana", HighAnsi = "Verdana", EastAsia = "New Roman", ComplexScript = "Verdana" };
            FontSize fontSize66 = new FontSize() { Val = "16" };
            FontSizeComplexScript fontSizeComplexScript66 = new FontSizeComplexScript() { Val = "16" };

            paragraphMarkRunProperties34.Append(runFonts66);
            paragraphMarkRunProperties34.Append(fontSize66);
            paragraphMarkRunProperties34.Append(fontSizeComplexScript66);

            paragraphProperties34.Append(widowControl34);
            paragraphProperties34.Append(autoSpaceDE34);
            paragraphProperties34.Append(autoSpaceDN34);
            paragraphProperties34.Append(adjustRightIndent34);
            paragraphProperties34.Append(spacingBetweenLines20);
            paragraphProperties34.Append(paragraphMarkRunProperties34);

            paragraph34.Append(paragraphProperties34);

            Table table3 = new Table();

            TableProperties tableProperties3 = new TableProperties();
            TableWidth tableWidth3 = new TableWidth() { Width = "0", Type = TableWidthUnitValues.Auto };
            TableIndentation tableIndentation2 = new TableIndentation() { Width = 30, Type = TableWidthUnitValues.Dxa };
            TableLayout tableLayout2 = new TableLayout() { Type = TableLayoutValues.Fixed };

            TableCellMarginDefault tableCellMarginDefault2 = new TableCellMarginDefault();
            TableCellLeftMargin tableCellLeftMargin2 = new TableCellLeftMargin() { Width = 30, Type = TableWidthValues.Dxa };
            TableCellRightMargin tableCellRightMargin2 = new TableCellRightMargin() { Width = 30, Type = TableWidthValues.Dxa };

            tableCellMarginDefault2.Append(tableCellLeftMargin2);
            tableCellMarginDefault2.Append(tableCellRightMargin2);
            TableLook tableLook3 = new TableLook() { Val = "0000", FirstRow = false, LastRow = false, FirstColumn = false, LastColumn = false, NoHorizontalBand = false, NoVerticalBand = false };

            tableProperties3.Append(tableWidth3);
            tableProperties3.Append(tableIndentation2);
            tableProperties3.Append(tableLayout2);
            tableProperties3.Append(tableCellMarginDefault2);
            tableProperties3.Append(tableLook3);

            TableGrid tableGrid3 = new TableGrid();
            GridColumn gridColumn7 = new GridColumn() { Width = "500" };
            GridColumn gridColumn8 = new GridColumn() { Width = "1000" };
            GridColumn gridColumn9 = new GridColumn() { Width = "5500" };
            GridColumn gridColumn10 = new GridColumn() { Width = "1500" };

            tableGrid3.Append(gridColumn7);
            tableGrid3.Append(gridColumn8);
            tableGrid3.Append(gridColumn9);
            tableGrid3.Append(gridColumn10);

            TableRow tableRow10 = new TableRow() { RsidTableRowAddition = "00900A10", RsidTableRowProperties = "00B819CE" };

            TableRowProperties tableRowProperties10 = new TableRowProperties();
            TableRowHeight tableRowHeight10 = new TableRowHeight() { Val = (UInt32Value)262U };

            tableRowProperties10.Append(tableRowHeight10);

            TableCell tableCell23 = new TableCell();

            TableCellProperties tableCellProperties23 = new TableCellProperties();
            TableCellWidth tableCellWidth23 = new TableCellWidth() { Width = "500", Type = TableWidthUnitValues.Dxa };

            TableCellBorders tableCellBorders9 = new TableCellBorders();
            TopBorder topBorder10 = new TopBorder() { Val = BorderValues.Nil };
            LeftBorder leftBorder10 = new LeftBorder() { Val = BorderValues.Nil };
            BottomBorder bottomBorder10 = new BottomBorder() { Val = BorderValues.Nil };
            RightBorder rightBorder10 = new RightBorder() { Val = BorderValues.Nil };

            tableCellBorders9.Append(topBorder10);
            tableCellBorders9.Append(leftBorder10);
            tableCellBorders9.Append(bottomBorder10);
            tableCellBorders9.Append(rightBorder10);

            tableCellProperties23.Append(tableCellWidth23);
            tableCellProperties23.Append(tableCellBorders9);

            Paragraph paragraph35 = new Paragraph() { RsidParagraphAddition = "00900A10", RsidParagraphProperties = "00B819CE", RsidRunAdditionDefault = "00900A10" };

            ParagraphProperties paragraphProperties35 = new ParagraphProperties();
            WidowControl widowControl35 = new WidowControl() { Val = false };
            AutoSpaceDE autoSpaceDE35 = new AutoSpaceDE() { Val = false };
            AutoSpaceDN autoSpaceDN35 = new AutoSpaceDN() { Val = false };
            AdjustRightIndent adjustRightIndent35 = new AdjustRightIndent() { Val = false };
            SpacingBetweenLines spacingBetweenLines21 = new SpacingBetweenLines() { After = "0", Line = "240", LineRule = LineSpacingRuleValues.Auto };

            ParagraphMarkRunProperties paragraphMarkRunProperties35 = new ParagraphMarkRunProperties();
            RunFonts runFonts67 = new RunFonts() { Ascii = "Verdana", HighAnsi = "Verdana", EastAsia = "New Roman", ComplexScript = "Verdana" };
            FontSize fontSize67 = new FontSize() { Val = "16" };
            FontSizeComplexScript fontSizeComplexScript67 = new FontSizeComplexScript() { Val = "16" };

            paragraphMarkRunProperties35.Append(runFonts67);
            paragraphMarkRunProperties35.Append(fontSize67);
            paragraphMarkRunProperties35.Append(fontSizeComplexScript67);

            paragraphProperties35.Append(widowControl35);
            paragraphProperties35.Append(autoSpaceDE35);
            paragraphProperties35.Append(autoSpaceDN35);
            paragraphProperties35.Append(adjustRightIndent35);
            paragraphProperties35.Append(spacingBetweenLines21);
            paragraphProperties35.Append(paragraphMarkRunProperties35);

            Run run33 = new Run();

            RunProperties runProperties33 = new RunProperties();
            RunFonts runFonts68 = new RunFonts() { Ascii = "Verdana", HighAnsi = "Verdana", EastAsia = "New Roman", ComplexScript = "Verdana" };
            FontSize fontSize68 = new FontSize() { Val = "16" };
            FontSizeComplexScript fontSizeComplexScript68 = new FontSizeComplexScript() { Val = "16" };

            runProperties33.Append(runFonts68);
            runProperties33.Append(fontSize68);
            runProperties33.Append(fontSizeComplexScript68);
            Text text33 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text33.Text = "1     ";

            run33.Append(runProperties33);
            run33.Append(text33);

            paragraph35.Append(paragraphProperties35);
            paragraph35.Append(run33);

            tableCell23.Append(tableCellProperties23);
            tableCell23.Append(paragraph35);

            TableCell tableCell24 = new TableCell();

            TableCellProperties tableCellProperties24 = new TableCellProperties();
            TableCellWidth tableCellWidth24 = new TableCellWidth() { Width = "1000", Type = TableWidthUnitValues.Dxa };

            TableCellBorders tableCellBorders10 = new TableCellBorders();
            TopBorder topBorder11 = new TopBorder() { Val = BorderValues.Nil };
            LeftBorder leftBorder11 = new LeftBorder() { Val = BorderValues.Nil };
            BottomBorder bottomBorder11 = new BottomBorder() { Val = BorderValues.Nil };
            RightBorder rightBorder11 = new RightBorder() { Val = BorderValues.Nil };

            tableCellBorders10.Append(topBorder11);
            tableCellBorders10.Append(leftBorder11);
            tableCellBorders10.Append(bottomBorder11);
            tableCellBorders10.Append(rightBorder11);

            tableCellProperties24.Append(tableCellWidth24);
            tableCellProperties24.Append(tableCellBorders10);

            Paragraph paragraph36 = new Paragraph() { RsidParagraphAddition = "00900A10", RsidParagraphProperties = "00B819CE", RsidRunAdditionDefault = "00900A10" };

            ParagraphProperties paragraphProperties36 = new ParagraphProperties();
            WidowControl widowControl36 = new WidowControl() { Val = false };
            AutoSpaceDE autoSpaceDE36 = new AutoSpaceDE() { Val = false };
            AutoSpaceDN autoSpaceDN36 = new AutoSpaceDN() { Val = false };
            AdjustRightIndent adjustRightIndent36 = new AdjustRightIndent() { Val = false };
            SpacingBetweenLines spacingBetweenLines22 = new SpacingBetweenLines() { After = "0", Line = "240", LineRule = LineSpacingRuleValues.Auto };
            Justification justification7 = new Justification() { Val = JustificationValues.Center };

            ParagraphMarkRunProperties paragraphMarkRunProperties36 = new ParagraphMarkRunProperties();
            RunFonts runFonts69 = new RunFonts() { Ascii = "Verdana", HighAnsi = "Verdana", EastAsia = "New Roman", ComplexScript = "Verdana" };
            FontSize fontSize69 = new FontSize() { Val = "16" };
            FontSizeComplexScript fontSizeComplexScript69 = new FontSizeComplexScript() { Val = "16" };

            paragraphMarkRunProperties36.Append(runFonts69);
            paragraphMarkRunProperties36.Append(fontSize69);
            paragraphMarkRunProperties36.Append(fontSizeComplexScript69);

            paragraphProperties36.Append(widowControl36);
            paragraphProperties36.Append(autoSpaceDE36);
            paragraphProperties36.Append(autoSpaceDN36);
            paragraphProperties36.Append(adjustRightIndent36);
            paragraphProperties36.Append(spacingBetweenLines22);
            paragraphProperties36.Append(justification7);
            paragraphProperties36.Append(paragraphMarkRunProperties36);

            Run run34 = new Run();

            RunProperties runProperties34 = new RunProperties();
            RunFonts runFonts70 = new RunFonts() { Ascii = "Verdana", HighAnsi = "Verdana", EastAsia = "New Roman", ComplexScript = "Verdana" };
            FontSize fontSize70 = new FontSize() { Val = "16" };
            FontSizeComplexScript fontSizeComplexScript70 = new FontSizeComplexScript() { Val = "16" };

            runProperties34.Append(runFonts70);
            runProperties34.Append(fontSize70);
            runProperties34.Append(fontSizeComplexScript70);
            Text text34 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text34.Text = "- ";

            run34.Append(runProperties34);
            run34.Append(text34);

            paragraph36.Append(paragraphProperties36);
            paragraph36.Append(run34);

            tableCell24.Append(tableCellProperties24);
            tableCell24.Append(paragraph36);

            TableCell tableCell25 = new TableCell();

            TableCellProperties tableCellProperties25 = new TableCellProperties();
            TableCellWidth tableCellWidth25 = new TableCellWidth() { Width = "5500", Type = TableWidthUnitValues.Dxa };

            TableCellBorders tableCellBorders11 = new TableCellBorders();
            TopBorder topBorder12 = new TopBorder() { Val = BorderValues.Nil };
            LeftBorder leftBorder12 = new LeftBorder() { Val = BorderValues.Nil };
            BottomBorder bottomBorder12 = new BottomBorder() { Val = BorderValues.Nil };
            RightBorder rightBorder12 = new RightBorder() { Val = BorderValues.Nil };

            tableCellBorders11.Append(topBorder12);
            tableCellBorders11.Append(leftBorder12);
            tableCellBorders11.Append(bottomBorder12);
            tableCellBorders11.Append(rightBorder12);

            tableCellProperties25.Append(tableCellWidth25);
            tableCellProperties25.Append(tableCellBorders11);

            Paragraph paragraph37 = new Paragraph() { RsidParagraphAddition = "00900A10", RsidParagraphProperties = "00B819CE", RsidRunAdditionDefault = "00900A10" };

            ParagraphProperties paragraphProperties37 = new ParagraphProperties();
            WidowControl widowControl37 = new WidowControl() { Val = false };
            AutoSpaceDE autoSpaceDE37 = new AutoSpaceDE() { Val = false };
            AutoSpaceDN autoSpaceDN37 = new AutoSpaceDN() { Val = false };
            AdjustRightIndent adjustRightIndent37 = new AdjustRightIndent() { Val = false };
            SpacingBetweenLines spacingBetweenLines23 = new SpacingBetweenLines() { After = "0", Line = "240", LineRule = LineSpacingRuleValues.Auto };

            ParagraphMarkRunProperties paragraphMarkRunProperties37 = new ParagraphMarkRunProperties();
            RunFonts runFonts71 = new RunFonts() { Ascii = "Verdana", HighAnsi = "Verdana", EastAsia = "New Roman", ComplexScript = "Verdana" };
            FontSize fontSize71 = new FontSize() { Val = "16" };
            FontSizeComplexScript fontSizeComplexScript71 = new FontSizeComplexScript() { Val = "16" };

            paragraphMarkRunProperties37.Append(runFonts71);
            paragraphMarkRunProperties37.Append(fontSize71);
            paragraphMarkRunProperties37.Append(fontSizeComplexScript71);

            paragraphProperties37.Append(widowControl37);
            paragraphProperties37.Append(autoSpaceDE37);
            paragraphProperties37.Append(autoSpaceDN37);
            paragraphProperties37.Append(adjustRightIndent37);
            paragraphProperties37.Append(spacingBetweenLines23);
            paragraphProperties37.Append(paragraphMarkRunProperties37);

            Run run35 = new Run();

            RunProperties runProperties35 = new RunProperties();
            RunFonts runFonts72 = new RunFonts() { Ascii = "Verdana", HighAnsi = "Verdana", EastAsia = "New Roman", ComplexScript = "Verdana" };
            FontSize fontSize72 = new FontSize() { Val = "16" };
            FontSizeComplexScript fontSizeComplexScript72 = new FontSizeComplexScript() { Val = "16" };

            runProperties35.Append(runFonts72);
            runProperties35.Append(fontSize72);
            runProperties35.Append(fontSizeComplexScript72);
            Text text35 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text35.Text = "Взятие крови из вены     ";

            run35.Append(runProperties35);
            run35.Append(text35);

            paragraph37.Append(paragraphProperties37);
            paragraph37.Append(run35);

            tableCell25.Append(tableCellProperties25);
            tableCell25.Append(paragraph37);

            TableCell tableCell26 = new TableCell();

            TableCellProperties tableCellProperties26 = new TableCellProperties();
            TableCellWidth tableCellWidth26 = new TableCellWidth() { Width = "1500", Type = TableWidthUnitValues.Dxa };

            TableCellBorders tableCellBorders12 = new TableCellBorders();
            TopBorder topBorder13 = new TopBorder() { Val = BorderValues.Nil };
            LeftBorder leftBorder13 = new LeftBorder() { Val = BorderValues.Nil };
            BottomBorder bottomBorder13 = new BottomBorder() { Val = BorderValues.Nil };
            RightBorder rightBorder13 = new RightBorder() { Val = BorderValues.Nil };

            tableCellBorders12.Append(topBorder13);
            tableCellBorders12.Append(leftBorder13);
            tableCellBorders12.Append(bottomBorder13);
            tableCellBorders12.Append(rightBorder13);

            tableCellProperties26.Append(tableCellWidth26);
            tableCellProperties26.Append(tableCellBorders12);

            Paragraph paragraph38 = new Paragraph() { RsidParagraphAddition = "00900A10", RsidParagraphProperties = "00B819CE", RsidRunAdditionDefault = "00900A10" };

            ParagraphProperties paragraphProperties38 = new ParagraphProperties();
            WidowControl widowControl38 = new WidowControl() { Val = false };
            AutoSpaceDE autoSpaceDE38 = new AutoSpaceDE() { Val = false };
            AutoSpaceDN autoSpaceDN38 = new AutoSpaceDN() { Val = false };
            AdjustRightIndent adjustRightIndent38 = new AdjustRightIndent() { Val = false };
            SpacingBetweenLines spacingBetweenLines24 = new SpacingBetweenLines() { After = "0", Line = "240", LineRule = LineSpacingRuleValues.Auto };

            ParagraphMarkRunProperties paragraphMarkRunProperties38 = new ParagraphMarkRunProperties();
            RunFonts runFonts73 = new RunFonts() { Ascii = "Verdana", HighAnsi = "Verdana", EastAsia = "New Roman", ComplexScript = "Verdana" };
            FontSize fontSize73 = new FontSize() { Val = "16" };
            FontSizeComplexScript fontSizeComplexScript73 = new FontSizeComplexScript() { Val = "16" };

            paragraphMarkRunProperties38.Append(runFonts73);
            paragraphMarkRunProperties38.Append(fontSize73);
            paragraphMarkRunProperties38.Append(fontSizeComplexScript73);

            paragraphProperties38.Append(widowControl38);
            paragraphProperties38.Append(autoSpaceDE38);
            paragraphProperties38.Append(autoSpaceDN38);
            paragraphProperties38.Append(adjustRightIndent38);
            paragraphProperties38.Append(spacingBetweenLines24);
            paragraphProperties38.Append(paragraphMarkRunProperties38);

            Run run36 = new Run();

            RunProperties runProperties36 = new RunProperties();
            RunFonts runFonts74 = new RunFonts() { Ascii = "Verdana", HighAnsi = "Verdana", EastAsia = "New Roman", ComplexScript = "Verdana" };
            FontSize fontSize74 = new FontSize() { Val = "16" };
            FontSizeComplexScript fontSizeComplexScript74 = new FontSizeComplexScript() { Val = "16" };

            runProperties36.Append(runFonts74);
            runProperties36.Append(fontSize74);
            runProperties36.Append(fontSizeComplexScript74);
            Text text36 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text36.Text = "100,00 руб. ";

            run36.Append(runProperties36);
            run36.Append(text36);

            paragraph38.Append(paragraphProperties38);
            paragraph38.Append(run36);

            tableCell26.Append(tableCellProperties26);
            tableCell26.Append(paragraph38);

            tableRow10.Append(tableRowProperties10);
            tableRow10.Append(tableCell23);
            tableRow10.Append(tableCell24);
            tableRow10.Append(tableCell25);
            tableRow10.Append(tableCell26);

            table3.Append(tableProperties3);
            table3.Append(tableGrid3);
            table3.Append(tableRow10);

            Paragraph paragraph39 = new Paragraph() { RsidParagraphAddition = "00900A10", RsidParagraphProperties = "00900A10", RsidRunAdditionDefault = "00900A10" };

            ParagraphProperties paragraphProperties39 = new ParagraphProperties();
            WidowControl widowControl39 = new WidowControl() { Val = false };
            AutoSpaceDE autoSpaceDE39 = new AutoSpaceDE() { Val = false };
            AutoSpaceDN autoSpaceDN39 = new AutoSpaceDN() { Val = false };
            AdjustRightIndent adjustRightIndent39 = new AdjustRightIndent() { Val = false };
            SpacingBetweenLines spacingBetweenLines25 = new SpacingBetweenLines() { After = "0", Line = "240", LineRule = LineSpacingRuleValues.Auto };

            ParagraphMarkRunProperties paragraphMarkRunProperties39 = new ParagraphMarkRunProperties();
            RunFonts runFonts75 = new RunFonts() { Ascii = "Verdana", HighAnsi = "Verdana", EastAsia = "New Roman", ComplexScript = "Verdana" };
            FontSize fontSize75 = new FontSize() { Val = "16" };
            FontSizeComplexScript fontSizeComplexScript75 = new FontSizeComplexScript() { Val = "16" };

            paragraphMarkRunProperties39.Append(runFonts75);
            paragraphMarkRunProperties39.Append(fontSize75);
            paragraphMarkRunProperties39.Append(fontSizeComplexScript75);

            paragraphProperties39.Append(widowControl39);
            paragraphProperties39.Append(autoSpaceDE39);
            paragraphProperties39.Append(autoSpaceDN39);
            paragraphProperties39.Append(adjustRightIndent39);
            paragraphProperties39.Append(spacingBetweenLines25);
            paragraphProperties39.Append(paragraphMarkRunProperties39);

            paragraph39.Append(paragraphProperties39);

            Paragraph paragraph40 = new Paragraph() { RsidParagraphAddition = "00900A10", RsidParagraphProperties = "00900A10", RsidRunAdditionDefault = "00900A10" };

            ParagraphProperties paragraphProperties40 = new ParagraphProperties();
            WidowControl widowControl40 = new WidowControl() { Val = false };
            AutoSpaceDE autoSpaceDE40 = new AutoSpaceDE() { Val = false };
            AutoSpaceDN autoSpaceDN40 = new AutoSpaceDN() { Val = false };
            AdjustRightIndent adjustRightIndent40 = new AdjustRightIndent() { Val = false };
            SpacingBetweenLines spacingBetweenLines26 = new SpacingBetweenLines() { After = "0", Line = "240", LineRule = LineSpacingRuleValues.Auto };

            ParagraphMarkRunProperties paragraphMarkRunProperties40 = new ParagraphMarkRunProperties();
            RunFonts runFonts76 = new RunFonts() { Ascii = "Verdana", HighAnsi = "Verdana", EastAsia = "New Roman", ComplexScript = "Verdana" };
            FontSize fontSize76 = new FontSize() { Val = "16" };
            FontSizeComplexScript fontSizeComplexScript76 = new FontSizeComplexScript() { Val = "16" };

            paragraphMarkRunProperties40.Append(runFonts76);
            paragraphMarkRunProperties40.Append(fontSize76);
            paragraphMarkRunProperties40.Append(fontSizeComplexScript76);

            paragraphProperties40.Append(widowControl40);
            paragraphProperties40.Append(autoSpaceDE40);
            paragraphProperties40.Append(autoSpaceDN40);
            paragraphProperties40.Append(adjustRightIndent40);
            paragraphProperties40.Append(spacingBetweenLines26);
            paragraphProperties40.Append(paragraphMarkRunProperties40);

            paragraph40.Append(paragraphProperties40);

            Paragraph paragraph41 = new Paragraph() { RsidParagraphAddition = "00900A10", RsidParagraphProperties = "00900A10", RsidRunAdditionDefault = "00900A10" };

            ParagraphProperties paragraphProperties41 = new ParagraphProperties();
            WidowControl widowControl41 = new WidowControl() { Val = false };
            AutoSpaceDE autoSpaceDE41 = new AutoSpaceDE() { Val = false };
            AutoSpaceDN autoSpaceDN41 = new AutoSpaceDN() { Val = false };
            AdjustRightIndent adjustRightIndent41 = new AdjustRightIndent() { Val = false };
            SpacingBetweenLines spacingBetweenLines27 = new SpacingBetweenLines() { After = "0", Line = "240", LineRule = LineSpacingRuleValues.Auto };

            ParagraphMarkRunProperties paragraphMarkRunProperties41 = new ParagraphMarkRunProperties();
            RunFonts runFonts77 = new RunFonts() { Ascii = "Verdana", HighAnsi = "Verdana", EastAsia = "New Roman", ComplexScript = "Verdana" };
            FontSize fontSize77 = new FontSize() { Val = "18" };
            FontSizeComplexScript fontSizeComplexScript77 = new FontSizeComplexScript() { Val = "18" };

            paragraphMarkRunProperties41.Append(runFonts77);
            paragraphMarkRunProperties41.Append(fontSize77);
            paragraphMarkRunProperties41.Append(fontSizeComplexScript77);

            paragraphProperties41.Append(widowControl41);
            paragraphProperties41.Append(autoSpaceDE41);
            paragraphProperties41.Append(autoSpaceDN41);
            paragraphProperties41.Append(adjustRightIndent41);
            paragraphProperties41.Append(spacingBetweenLines27);
            paragraphProperties41.Append(paragraphMarkRunProperties41);

            Run run37 = new Run();

            RunProperties runProperties37 = new RunProperties();
            RunFonts runFonts78 = new RunFonts() { Ascii = "Verdana", HighAnsi = "Verdana", EastAsia = "New Roman", ComplexScript = "Verdana" };
            FontSize fontSize78 = new FontSize() { Val = "18" };
            FontSizeComplexScript fontSizeComplexScript78 = new FontSizeComplexScript() { Val = "18" };

            runProperties37.Append(runFonts78);
            runProperties37.Append(fontSize78);
            runProperties37.Append(fontSizeComplexScript78);
            Text text37 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text37.Text = " ";

            run37.Append(runProperties37);
            run37.Append(text37);

            Run run38 = new Run();

            RunProperties runProperties38 = new RunProperties();
            RunFonts runFonts79 = new RunFonts() { Ascii = "Verdana", HighAnsi = "Verdana", EastAsia = "New Roman", ComplexScript = "Verdana" };
            Bold bold18 = new Bold();
            BoldComplexScript boldComplexScript18 = new BoldComplexScript();
            FontSize fontSize79 = new FontSize() { Val = "18" };
            FontSizeComplexScript fontSizeComplexScript79 = new FontSizeComplexScript() { Val = "18" };

            runProperties38.Append(runFonts79);
            runProperties38.Append(bold18);
            runProperties38.Append(boldComplexScript18);
            runProperties38.Append(fontSize79);
            runProperties38.Append(fontSizeComplexScript79);
            Text text38 = new Text();
            text38.Text = "Итого на общую сумму:  390 руб.";

            run38.Append(runProperties38);
            run38.Append(text38);

            paragraph41.Append(paragraphProperties41);
            paragraph41.Append(run37);
            paragraph41.Append(run38);

            Paragraph paragraph42 = new Paragraph() { RsidParagraphAddition = "00900A10", RsidParagraphProperties = "00900A10", RsidRunAdditionDefault = "00900A10" };

            ParagraphProperties paragraphProperties42 = new ParagraphProperties();
            WidowControl widowControl42 = new WidowControl() { Val = false };
            AutoSpaceDE autoSpaceDE42 = new AutoSpaceDE() { Val = false };
            AutoSpaceDN autoSpaceDN42 = new AutoSpaceDN() { Val = false };
            AdjustRightIndent adjustRightIndent42 = new AdjustRightIndent() { Val = false };
            SpacingBetweenLines spacingBetweenLines28 = new SpacingBetweenLines() { After = "0", Line = "240", LineRule = LineSpacingRuleValues.Auto };

            ParagraphMarkRunProperties paragraphMarkRunProperties42 = new ParagraphMarkRunProperties();
            RunFonts runFonts80 = new RunFonts() { Ascii = "Verdana", HighAnsi = "Verdana", EastAsia = "New Roman", ComplexScript = "Verdana" };
            FontSize fontSize80 = new FontSize() { Val = "18" };
            FontSizeComplexScript fontSizeComplexScript80 = new FontSizeComplexScript() { Val = "18" };

            paragraphMarkRunProperties42.Append(runFonts80);
            paragraphMarkRunProperties42.Append(fontSize80);
            paragraphMarkRunProperties42.Append(fontSizeComplexScript80);

            paragraphProperties42.Append(widowControl42);
            paragraphProperties42.Append(autoSpaceDE42);
            paragraphProperties42.Append(autoSpaceDN42);
            paragraphProperties42.Append(adjustRightIndent42);
            paragraphProperties42.Append(spacingBetweenLines28);
            paragraphProperties42.Append(paragraphMarkRunProperties42);

            paragraph42.Append(paragraphProperties42);

            Paragraph paragraph43 = new Paragraph() { RsidParagraphAddition = "00900A10", RsidParagraphProperties = "00900A10", RsidRunAdditionDefault = "00900A10" };

            ParagraphProperties paragraphProperties43 = new ParagraphProperties();
            WidowControl widowControl43 = new WidowControl() { Val = false };
            AutoSpaceDE autoSpaceDE43 = new AutoSpaceDE() { Val = false };
            AutoSpaceDN autoSpaceDN43 = new AutoSpaceDN() { Val = false };
            AdjustRightIndent adjustRightIndent43 = new AdjustRightIndent() { Val = false };
            SpacingBetweenLines spacingBetweenLines29 = new SpacingBetweenLines() { After = "0", Line = "240", LineRule = LineSpacingRuleValues.Auto };

            ParagraphMarkRunProperties paragraphMarkRunProperties43 = new ParagraphMarkRunProperties();
            RunFonts runFonts81 = new RunFonts() { Ascii = "Verdana", HighAnsi = "Verdana", EastAsia = "New Roman", ComplexScript = "Verdana" };
            FontSize fontSize81 = new FontSize() { Val = "18" };
            FontSizeComplexScript fontSizeComplexScript81 = new FontSizeComplexScript() { Val = "18" };

            paragraphMarkRunProperties43.Append(runFonts81);
            paragraphMarkRunProperties43.Append(fontSize81);
            paragraphMarkRunProperties43.Append(fontSizeComplexScript81);

            paragraphProperties43.Append(widowControl43);
            paragraphProperties43.Append(autoSpaceDE43);
            paragraphProperties43.Append(autoSpaceDN43);
            paragraphProperties43.Append(adjustRightIndent43);
            paragraphProperties43.Append(spacingBetweenLines29);
            paragraphProperties43.Append(paragraphMarkRunProperties43);

            paragraph43.Append(paragraphProperties43);

            Paragraph paragraph44 = new Paragraph() { RsidParagraphAddition = "00900A10", RsidParagraphProperties = "00900A10", RsidRunAdditionDefault = "00900A10" };

            ParagraphProperties paragraphProperties44 = new ParagraphProperties();
            WidowControl widowControl44 = new WidowControl() { Val = false };
            AutoSpaceDE autoSpaceDE44 = new AutoSpaceDE() { Val = false };
            AutoSpaceDN autoSpaceDN44 = new AutoSpaceDN() { Val = false };
            AdjustRightIndent adjustRightIndent44 = new AdjustRightIndent() { Val = false };
            SpacingBetweenLines spacingBetweenLines30 = new SpacingBetweenLines() { After = "0", Line = "240", LineRule = LineSpacingRuleValues.Auto };

            ParagraphMarkRunProperties paragraphMarkRunProperties44 = new ParagraphMarkRunProperties();
            RunFonts runFonts82 = new RunFonts() { Ascii = "Verdana", HighAnsi = "Verdana", EastAsia = "New Roman", ComplexScript = "Verdana" };
            FontSize fontSize82 = new FontSize() { Val = "18" };
            FontSizeComplexScript fontSizeComplexScript82 = new FontSizeComplexScript() { Val = "18" };

            paragraphMarkRunProperties44.Append(runFonts82);
            paragraphMarkRunProperties44.Append(fontSize82);
            paragraphMarkRunProperties44.Append(fontSizeComplexScript82);

            paragraphProperties44.Append(widowControl44);
            paragraphProperties44.Append(autoSpaceDE44);
            paragraphProperties44.Append(autoSpaceDN44);
            paragraphProperties44.Append(adjustRightIndent44);
            paragraphProperties44.Append(spacingBetweenLines30);
            paragraphProperties44.Append(paragraphMarkRunProperties44);

            paragraph44.Append(paragraphProperties44);

            Table table4 = new Table();

            TableProperties tableProperties4 = new TableProperties();
            TableWidth tableWidth4 = new TableWidth() { Width = "0", Type = TableWidthUnitValues.Auto };
            TableIndentation tableIndentation3 = new TableIndentation() { Width = 30, Type = TableWidthUnitValues.Dxa };
            TableLayout tableLayout3 = new TableLayout() { Type = TableLayoutValues.Fixed };

            TableCellMarginDefault tableCellMarginDefault3 = new TableCellMarginDefault();
            TableCellLeftMargin tableCellLeftMargin3 = new TableCellLeftMargin() { Width = 30, Type = TableWidthValues.Dxa };
            TableCellRightMargin tableCellRightMargin3 = new TableCellRightMargin() { Width = 30, Type = TableWidthValues.Dxa };

            tableCellMarginDefault3.Append(tableCellLeftMargin3);
            tableCellMarginDefault3.Append(tableCellRightMargin3);
            TableLook tableLook4 = new TableLook() { Val = "0000", FirstRow = false, LastRow = false, FirstColumn = false, LastColumn = false, NoHorizontalBand = false, NoVerticalBand = false };

            tableProperties4.Append(tableWidth4);
            tableProperties4.Append(tableIndentation3);
            tableProperties4.Append(tableLayout3);
            tableProperties4.Append(tableCellMarginDefault3);
            tableProperties4.Append(tableLook4);

            TableGrid tableGrid4 = new TableGrid();
            GridColumn gridColumn11 = new GridColumn() { Width = "2000" };
            GridColumn gridColumn12 = new GridColumn() { Width = "2000" };
            GridColumn gridColumn13 = new GridColumn() { Width = "2500" };
            GridColumn gridColumn14 = new GridColumn() { Width = "3000" };

            tableGrid4.Append(gridColumn11);
            tableGrid4.Append(gridColumn12);
            tableGrid4.Append(gridColumn13);
            tableGrid4.Append(gridColumn14);

            TableRow tableRow11 = new TableRow() { RsidTableRowAddition = "00900A10", RsidTableRowProperties = "00B819CE" };

            TableRowProperties tableRowProperties11 = new TableRowProperties();
            TableRowHeight tableRowHeight11 = new TableRowHeight() { Val = (UInt32Value)262U };
            TableHeader tableHeader2 = new TableHeader();

            tableRowProperties11.Append(tableRowHeight11);
            tableRowProperties11.Append(tableHeader2);

            TableCell tableCell27 = new TableCell();

            TableCellProperties tableCellProperties27 = new TableCellProperties();
            TableCellWidth tableCellWidth27 = new TableCellWidth() { Width = "2000", Type = TableWidthUnitValues.Dxa };

            TableCellBorders tableCellBorders13 = new TableCellBorders();
            TopBorder topBorder14 = new TopBorder() { Val = BorderValues.Nil };
            LeftBorder leftBorder14 = new LeftBorder() { Val = BorderValues.Nil };
            BottomBorder bottomBorder14 = new BottomBorder() { Val = BorderValues.Nil };
            RightBorder rightBorder14 = new RightBorder() { Val = BorderValues.Nil };

            tableCellBorders13.Append(topBorder14);
            tableCellBorders13.Append(leftBorder14);
            tableCellBorders13.Append(bottomBorder14);
            tableCellBorders13.Append(rightBorder14);

            tableCellProperties27.Append(tableCellWidth27);
            tableCellProperties27.Append(tableCellBorders13);

            Paragraph paragraph45 = new Paragraph() { RsidParagraphAddition = "00900A10", RsidParagraphProperties = "00B819CE", RsidRunAdditionDefault = "00900A10" };

            ParagraphProperties paragraphProperties45 = new ParagraphProperties();
            WidowControl widowControl45 = new WidowControl() { Val = false };
            AutoSpaceDE autoSpaceDE45 = new AutoSpaceDE() { Val = false };
            AutoSpaceDN autoSpaceDN45 = new AutoSpaceDN() { Val = false };
            AdjustRightIndent adjustRightIndent45 = new AdjustRightIndent() { Val = false };
            SpacingBetweenLines spacingBetweenLines31 = new SpacingBetweenLines() { After = "0", Line = "240", LineRule = LineSpacingRuleValues.Auto };

            ParagraphMarkRunProperties paragraphMarkRunProperties45 = new ParagraphMarkRunProperties();
            RunFonts runFonts83 = new RunFonts() { Ascii = "Verdana", HighAnsi = "Verdana", EastAsia = "New Roman", ComplexScript = "Verdana" };
            FontSize fontSize83 = new FontSize() { Val = "16" };
            FontSizeComplexScript fontSizeComplexScript83 = new FontSizeComplexScript() { Val = "16" };

            paragraphMarkRunProperties45.Append(runFonts83);
            paragraphMarkRunProperties45.Append(fontSize83);
            paragraphMarkRunProperties45.Append(fontSizeComplexScript83);

            paragraphProperties45.Append(widowControl45);
            paragraphProperties45.Append(autoSpaceDE45);
            paragraphProperties45.Append(autoSpaceDN45);
            paragraphProperties45.Append(adjustRightIndent45);
            paragraphProperties45.Append(spacingBetweenLines31);
            paragraphProperties45.Append(paragraphMarkRunProperties45);

            Run run39 = new Run();

            RunProperties runProperties39 = new RunProperties();
            RunFonts runFonts84 = new RunFonts() { Ascii = "Verdana", HighAnsi = "Verdana", EastAsia = "New Roman", ComplexScript = "Verdana" };
            FontSize fontSize84 = new FontSize() { Val = "16" };
            FontSizeComplexScript fontSizeComplexScript84 = new FontSizeComplexScript() { Val = "16" };

            runProperties39.Append(runFonts84);
            runProperties39.Append(fontSize84);
            runProperties39.Append(fontSizeComplexScript84);
            Text text39 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text39.Text = "Подпись пациента:  ";

            run39.Append(runProperties39);
            run39.Append(text39);

            paragraph45.Append(paragraphProperties45);
            paragraph45.Append(run39);

            tableCell27.Append(tableCellProperties27);
            tableCell27.Append(paragraph45);

            TableCell tableCell28 = new TableCell();

            TableCellProperties tableCellProperties28 = new TableCellProperties();
            TableCellWidth tableCellWidth28 = new TableCellWidth() { Width = "2000", Type = TableWidthUnitValues.Dxa };

            TableCellBorders tableCellBorders14 = new TableCellBorders();
            TopBorder topBorder15 = new TopBorder() { Val = BorderValues.Nil };
            LeftBorder leftBorder15 = new LeftBorder() { Val = BorderValues.Nil };
            BottomBorder bottomBorder15 = new BottomBorder() { Val = BorderValues.Nil };
            RightBorder rightBorder15 = new RightBorder() { Val = BorderValues.Nil };

            tableCellBorders14.Append(topBorder15);
            tableCellBorders14.Append(leftBorder15);
            tableCellBorders14.Append(bottomBorder15);
            tableCellBorders14.Append(rightBorder15);

            tableCellProperties28.Append(tableCellWidth28);
            tableCellProperties28.Append(tableCellBorders14);

            Paragraph paragraph46 = new Paragraph() { RsidParagraphAddition = "00900A10", RsidParagraphProperties = "00B819CE", RsidRunAdditionDefault = "00900A10" };

            ParagraphProperties paragraphProperties46 = new ParagraphProperties();
            WidowControl widowControl46 = new WidowControl() { Val = false };
            AutoSpaceDE autoSpaceDE46 = new AutoSpaceDE() { Val = false };
            AutoSpaceDN autoSpaceDN46 = new AutoSpaceDN() { Val = false };
            AdjustRightIndent adjustRightIndent46 = new AdjustRightIndent() { Val = false };
            SpacingBetweenLines spacingBetweenLines32 = new SpacingBetweenLines() { After = "0", Line = "240", LineRule = LineSpacingRuleValues.Auto };
            Justification justification8 = new Justification() { Val = JustificationValues.Center };

            ParagraphMarkRunProperties paragraphMarkRunProperties46 = new ParagraphMarkRunProperties();
            RunFonts runFonts85 = new RunFonts() { Ascii = "Verdana", HighAnsi = "Verdana", EastAsia = "New Roman", ComplexScript = "Verdana" };
            FontSize fontSize85 = new FontSize() { Val = "16" };
            FontSizeComplexScript fontSizeComplexScript85 = new FontSizeComplexScript() { Val = "16" };

            paragraphMarkRunProperties46.Append(runFonts85);
            paragraphMarkRunProperties46.Append(fontSize85);
            paragraphMarkRunProperties46.Append(fontSizeComplexScript85);

            paragraphProperties46.Append(widowControl46);
            paragraphProperties46.Append(autoSpaceDE46);
            paragraphProperties46.Append(autoSpaceDN46);
            paragraphProperties46.Append(adjustRightIndent46);
            paragraphProperties46.Append(spacingBetweenLines32);
            paragraphProperties46.Append(justification8);
            paragraphProperties46.Append(paragraphMarkRunProperties46);

            Run run40 = new Run();

            RunProperties runProperties40 = new RunProperties();
            RunFonts runFonts86 = new RunFonts() { Ascii = "Verdana", HighAnsi = "Verdana", EastAsia = "New Roman", ComplexScript = "Verdana" };
            FontSize fontSize86 = new FontSize() { Val = "16" };
            FontSizeComplexScript fontSizeComplexScript86 = new FontSizeComplexScript() { Val = "16" };

            runProperties40.Append(runFonts86);
            runProperties40.Append(fontSize86);
            runProperties40.Append(fontSizeComplexScript86);
            Text text40 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text40.Text = "___________________ ";

            run40.Append(runProperties40);
            run40.Append(text40);

            paragraph46.Append(paragraphProperties46);
            paragraph46.Append(run40);

            tableCell28.Append(tableCellProperties28);
            tableCell28.Append(paragraph46);

            TableCell tableCell29 = new TableCell();

            TableCellProperties tableCellProperties29 = new TableCellProperties();
            TableCellWidth tableCellWidth29 = new TableCellWidth() { Width = "2500", Type = TableWidthUnitValues.Dxa };

            TableCellBorders tableCellBorders15 = new TableCellBorders();
            TopBorder topBorder16 = new TopBorder() { Val = BorderValues.Nil };
            LeftBorder leftBorder16 = new LeftBorder() { Val = BorderValues.Nil };
            BottomBorder bottomBorder16 = new BottomBorder() { Val = BorderValues.Nil };
            RightBorder rightBorder16 = new RightBorder() { Val = BorderValues.Nil };

            tableCellBorders15.Append(topBorder16);
            tableCellBorders15.Append(leftBorder16);
            tableCellBorders15.Append(bottomBorder16);
            tableCellBorders15.Append(rightBorder16);

            tableCellProperties29.Append(tableCellWidth29);
            tableCellProperties29.Append(tableCellBorders15);

            Paragraph paragraph47 = new Paragraph() { RsidParagraphAddition = "00900A10", RsidParagraphProperties = "00B819CE", RsidRunAdditionDefault = "00900A10" };

            ParagraphProperties paragraphProperties47 = new ParagraphProperties();
            WidowControl widowControl47 = new WidowControl() { Val = false };
            AutoSpaceDE autoSpaceDE47 = new AutoSpaceDE() { Val = false };
            AutoSpaceDN autoSpaceDN47 = new AutoSpaceDN() { Val = false };
            AdjustRightIndent adjustRightIndent47 = new AdjustRightIndent() { Val = false };
            SpacingBetweenLines spacingBetweenLines33 = new SpacingBetweenLines() { After = "0", Line = "240", LineRule = LineSpacingRuleValues.Auto };
            Justification justification9 = new Justification() { Val = JustificationValues.Center };

            ParagraphMarkRunProperties paragraphMarkRunProperties47 = new ParagraphMarkRunProperties();
            RunFonts runFonts87 = new RunFonts() { Ascii = "Verdana", HighAnsi = "Verdana", EastAsia = "New Roman", ComplexScript = "Verdana" };
            FontSize fontSize87 = new FontSize() { Val = "16" };
            FontSizeComplexScript fontSizeComplexScript87 = new FontSizeComplexScript() { Val = "16" };

            paragraphMarkRunProperties47.Append(runFonts87);
            paragraphMarkRunProperties47.Append(fontSize87);
            paragraphMarkRunProperties47.Append(fontSizeComplexScript87);

            paragraphProperties47.Append(widowControl47);
            paragraphProperties47.Append(autoSpaceDE47);
            paragraphProperties47.Append(autoSpaceDN47);
            paragraphProperties47.Append(adjustRightIndent47);
            paragraphProperties47.Append(spacingBetweenLines33);
            paragraphProperties47.Append(justification9);
            paragraphProperties47.Append(paragraphMarkRunProperties47);

            Run run41 = new Run();

            RunProperties runProperties41 = new RunProperties();
            RunFonts runFonts88 = new RunFonts() { Ascii = "Verdana", HighAnsi = "Verdana", EastAsia = "New Roman", ComplexScript = "Verdana" };
            FontSize fontSize88 = new FontSize() { Val = "16" };
            FontSizeComplexScript fontSizeComplexScript88 = new FontSizeComplexScript() { Val = "16" };

            runProperties41.Append(runFonts88);
            runProperties41.Append(fontSize88);
            runProperties41.Append(fontSizeComplexScript88);
            Text text41 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text41.Text = "(Ковалева А.В.) ";

            run41.Append(runProperties41);
            run41.Append(text41);

            paragraph47.Append(paragraphProperties47);
            paragraph47.Append(run41);

            tableCell29.Append(tableCellProperties29);
            tableCell29.Append(paragraph47);

            TableCell tableCell30 = new TableCell();

            TableCellProperties tableCellProperties30 = new TableCellProperties();
            TableCellWidth tableCellWidth30 = new TableCellWidth() { Width = "3000", Type = TableWidthUnitValues.Dxa };

            TableCellBorders tableCellBorders16 = new TableCellBorders();
            TopBorder topBorder17 = new TopBorder() { Val = BorderValues.Nil };
            LeftBorder leftBorder17 = new LeftBorder() { Val = BorderValues.Nil };
            BottomBorder bottomBorder17 = new BottomBorder() { Val = BorderValues.Nil };
            RightBorder rightBorder17 = new RightBorder() { Val = BorderValues.Nil };

            tableCellBorders16.Append(topBorder17);
            tableCellBorders16.Append(leftBorder17);
            tableCellBorders16.Append(bottomBorder17);
            tableCellBorders16.Append(rightBorder17);

            tableCellProperties30.Append(tableCellWidth30);
            tableCellProperties30.Append(tableCellBorders16);

            Paragraph paragraph48 = new Paragraph() { RsidParagraphAddition = "00900A10", RsidParagraphProperties = "00B819CE", RsidRunAdditionDefault = "00900A10" };

            ParagraphProperties paragraphProperties48 = new ParagraphProperties();
            WidowControl widowControl48 = new WidowControl() { Val = false };
            AutoSpaceDE autoSpaceDE48 = new AutoSpaceDE() { Val = false };
            AutoSpaceDN autoSpaceDN48 = new AutoSpaceDN() { Val = false };
            AdjustRightIndent adjustRightIndent48 = new AdjustRightIndent() { Val = false };
            SpacingBetweenLines spacingBetweenLines34 = new SpacingBetweenLines() { After = "0", Line = "240", LineRule = LineSpacingRuleValues.Auto };

            ParagraphMarkRunProperties paragraphMarkRunProperties48 = new ParagraphMarkRunProperties();
            RunFonts runFonts89 = new RunFonts() { Ascii = "Verdana", HighAnsi = "Verdana", EastAsia = "New Roman", ComplexScript = "Verdana" };
            FontSize fontSize89 = new FontSize() { Val = "16" };
            FontSizeComplexScript fontSizeComplexScript89 = new FontSizeComplexScript() { Val = "16" };

            paragraphMarkRunProperties48.Append(runFonts89);
            paragraphMarkRunProperties48.Append(fontSize89);
            paragraphMarkRunProperties48.Append(fontSizeComplexScript89);

            paragraphProperties48.Append(widowControl48);
            paragraphProperties48.Append(autoSpaceDE48);
            paragraphProperties48.Append(autoSpaceDN48);
            paragraphProperties48.Append(adjustRightIndent48);
            paragraphProperties48.Append(spacingBetweenLines34);
            paragraphProperties48.Append(paragraphMarkRunProperties48);

            Run run42 = new Run();

            RunProperties runProperties42 = new RunProperties();
            RunFonts runFonts90 = new RunFonts() { Ascii = "Verdana", HighAnsi = "Verdana", EastAsia = "New Roman", ComplexScript = "Verdana" };
            FontSize fontSize90 = new FontSize() { Val = "16" };
            FontSizeComplexScript fontSizeComplexScript90 = new FontSizeComplexScript() { Val = "16" };

            runProperties42.Append(runFonts90);
            runProperties42.Append(fontSize90);
            runProperties42.Append(fontSizeComplexScript90);
            Text text42 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text42.Text = "Дата: 21.12.2012 9:49:52 ";

            run42.Append(runProperties42);
            run42.Append(text42);

            paragraph48.Append(paragraphProperties48);
            paragraph48.Append(run42);

            tableCell30.Append(tableCellProperties30);
            tableCell30.Append(paragraph48);

            tableRow11.Append(tableRowProperties11);
            tableRow11.Append(tableCell27);
            tableRow11.Append(tableCell28);
            tableRow11.Append(tableCell29);
            tableRow11.Append(tableCell30);

            table4.Append(tableProperties4);
            table4.Append(tableGrid4);
            table4.Append(tableRow11);
            Paragraph paragraph49 = new Paragraph() { RsidParagraphAddition = "00900A10", RsidParagraphProperties = "00900A10", RsidRunAdditionDefault = "00900A10" };
            Paragraph paragraph50 = new Paragraph() { RsidParagraphMarkRevision = "00900A10", RsidParagraphAddition = "00945FC6", RsidParagraphProperties = "00900A10", RsidRunAdditionDefault = "00945FC6" };

            SectionProperties sectionProperties1 = new SectionProperties() { RsidRPr = "00900A10", RsidR = "00945FC6" };
            HeaderReference headerReference1 = new HeaderReference() { Type = HeaderFooterValues.Default, Id = "rId7" };
            FooterReference footerReference1 = new FooterReference() { Type = HeaderFooterValues.Default, Id = "rId8" };
            PageSize pageSize1 = new PageSize() { Width = (UInt32Value)12240U, Height = (UInt32Value)15840U };
            PageMargin pageMargin1 = new PageMargin() { Top = 1134, Right = (UInt32Value)850U, Bottom = 1134, Left = (UInt32Value)1701U, Header = (UInt32Value)720U, Footer = (UInt32Value)720U, Gutter = (UInt32Value)0U };
            Columns columns1 = new Columns() { Space = "720" };
            NoEndnote noEndnote1 = new NoEndnote();

            sectionProperties1.Append(headerReference1);
            sectionProperties1.Append(footerReference1);
            sectionProperties1.Append(pageSize1);
            sectionProperties1.Append(pageMargin1);
            sectionProperties1.Append(columns1);
            sectionProperties1.Append(noEndnote1);

            body1.Append(paragraph1);
            body1.Append(paragraph2);
            body1.Append(paragraph3);
            body1.Append(paragraph4);
            body1.Append(table1);
            body1.Append(paragraph19);
            body1.Append(paragraph20);
            body1.Append(paragraph21);
            body1.Append(paragraph22);
            body1.Append(table2);
            body1.Append(paragraph31);
            body1.Append(paragraph32);
            body1.Append(paragraph33);
            body1.Append(paragraph34);
            body1.Append(table3);
            body1.Append(paragraph39);
            body1.Append(paragraph40);
            body1.Append(paragraph41);
            body1.Append(paragraph42);
            body1.Append(paragraph43);
            body1.Append(paragraph44);
            body1.Append(table4);
            body1.Append(paragraph49);
            body1.Append(paragraph50);
            body1.Append(sectionProperties1);

            document1.Append(body1);

            mainDocumentPart1.Document = document1;
        }

        // Generates content of footerPart1.
        private void GenerateFooterPart1Content(FooterPart footerPart1)
        {
            Footer footer1 = new Footer() { MCAttributes = new MarkupCompatibilityAttributes() { Ignorable = "w14 wp14" } };
            footer1.AddNamespaceDeclaration("wpc", "http://schemas.microsoft.com/office/word/2010/wordprocessingCanvas");
            footer1.AddNamespaceDeclaration("mc", "http://schemas.openxmlformats.org/markup-compatibility/2006");
            footer1.AddNamespaceDeclaration("o", "urn:schemas-microsoft-com:office:office");
            footer1.AddNamespaceDeclaration("r", "http://schemas.openxmlformats.org/officeDocument/2006/relationships");
            footer1.AddNamespaceDeclaration("m", "http://schemas.openxmlformats.org/officeDocument/2006/math");
            footer1.AddNamespaceDeclaration("v", "urn:schemas-microsoft-com:vml");
            footer1.AddNamespaceDeclaration("wp14", "http://schemas.microsoft.com/office/word/2010/wordprocessingDrawing");
            footer1.AddNamespaceDeclaration("wp", "http://schemas.openxmlformats.org/drawingml/2006/wordprocessingDrawing");
            footer1.AddNamespaceDeclaration("w10", "urn:schemas-microsoft-com:office:word");
            footer1.AddNamespaceDeclaration("w", "http://schemas.openxmlformats.org/wordprocessingml/2006/main");
            footer1.AddNamespaceDeclaration("w14", "http://schemas.microsoft.com/office/word/2010/wordml");
            footer1.AddNamespaceDeclaration("wpg", "http://schemas.microsoft.com/office/word/2010/wordprocessingGroup");
            footer1.AddNamespaceDeclaration("wpi", "http://schemas.microsoft.com/office/word/2010/wordprocessingInk");
            footer1.AddNamespaceDeclaration("wne", "http://schemas.microsoft.com/office/word/2006/wordml");
            footer1.AddNamespaceDeclaration("wps", "http://schemas.microsoft.com/office/word/2010/wordprocessingShape");

            Paragraph paragraph51 = new Paragraph() { RsidParagraphAddition = "004F7F90", RsidRunAdditionDefault = "00900A10" };

            ParagraphProperties paragraphProperties49 = new ParagraphProperties();
            WidowControl widowControl49 = new WidowControl() { Val = false };

            ParagraphBorders paragraphBorders1 = new ParagraphBorders();
            TopBorder topBorder18 = new TopBorder() { Val = BorderValues.Single, Color = "auto", Size = (UInt32Value)4U, Space = (UInt32Value)5U };

            paragraphBorders1.Append(topBorder18);
            AutoSpaceDE autoSpaceDE49 = new AutoSpaceDE() { Val = false };
            AutoSpaceDN autoSpaceDN49 = new AutoSpaceDN() { Val = false };
            AdjustRightIndent adjustRightIndent49 = new AdjustRightIndent() { Val = false };
            SpacingBetweenLines spacingBetweenLines35 = new SpacingBetweenLines() { After = "0", Line = "240", LineRule = LineSpacingRuleValues.Auto };
            Justification justification10 = new Justification() { Val = JustificationValues.Center };

            ParagraphMarkRunProperties paragraphMarkRunProperties49 = new ParagraphMarkRunProperties();
            RunFonts runFonts91 = new RunFonts() { Ascii = "New Roman", HighAnsi = "New Roman", EastAsia = "New Roman", ComplexScript = "Times New Roman" };
            FontSize fontSize91 = new FontSize() { Val = "18" };
            FontSizeComplexScript fontSizeComplexScript91 = new FontSizeComplexScript() { Val = "18" };

            paragraphMarkRunProperties49.Append(runFonts91);
            paragraphMarkRunProperties49.Append(fontSize91);
            paragraphMarkRunProperties49.Append(fontSizeComplexScript91);

            paragraphProperties49.Append(widowControl49);
            paragraphProperties49.Append(paragraphBorders1);
            paragraphProperties49.Append(autoSpaceDE49);
            paragraphProperties49.Append(autoSpaceDN49);
            paragraphProperties49.Append(adjustRightIndent49);
            paragraphProperties49.Append(spacingBetweenLines35);
            paragraphProperties49.Append(justification10);
            paragraphProperties49.Append(paragraphMarkRunProperties49);

            Run run43 = new Run();

            RunProperties runProperties43 = new RunProperties();
            RunFonts runFonts92 = new RunFonts() { Ascii = "New Roman", HighAnsi = "New Roman", EastAsia = "New Roman", ComplexScript = "Times New Roman" };
            FontSize fontSize92 = new FontSize() { Val = "18" };
            FontSizeComplexScript fontSizeComplexScript92 = new FontSizeComplexScript() { Val = "18" };

            runProperties43.Append(runFonts92);
            runProperties43.Append(fontSize92);
            runProperties43.Append(fontSizeComplexScript92);
            Text text43 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text43.Text = "Страница ";

            run43.Append(runProperties43);
            run43.Append(text43);

            Run run44 = new Run();

            RunProperties runProperties44 = new RunProperties();
            RunFonts runFonts93 = new RunFonts() { Ascii = "New Roman", HighAnsi = "New Roman", EastAsia = "New Roman", ComplexScript = "Times New Roman" };
            FontSize fontSize93 = new FontSize() { Val = "18" };
            FontSizeComplexScript fontSizeComplexScript93 = new FontSizeComplexScript() { Val = "18" };

            runProperties44.Append(runFonts93);
            runProperties44.Append(fontSize93);
            runProperties44.Append(fontSizeComplexScript93);
            FieldChar fieldChar1 = new FieldChar() { FieldCharType = FieldCharValues.Begin };

            run44.Append(runProperties44);
            run44.Append(fieldChar1);

            Run run45 = new Run();

            RunProperties runProperties45 = new RunProperties();
            RunFonts runFonts94 = new RunFonts() { Ascii = "New Roman", HighAnsi = "New Roman", EastAsia = "New Roman", ComplexScript = "Times New Roman" };
            FontSize fontSize94 = new FontSize() { Val = "18" };
            FontSizeComplexScript fontSizeComplexScript94 = new FontSizeComplexScript() { Val = "18" };

            runProperties45.Append(runFonts94);
            runProperties45.Append(fontSize94);
            runProperties45.Append(fontSizeComplexScript94);
            FieldCode fieldCode1 = new FieldCode();
            fieldCode1.Text = "PAGE";

            run45.Append(runProperties45);
            run45.Append(fieldCode1);

            Run run46 = new Run();

            RunProperties runProperties46 = new RunProperties();
            RunFonts runFonts95 = new RunFonts() { Ascii = "New Roman", HighAnsi = "New Roman", EastAsia = "New Roman", ComplexScript = "Times New Roman" };
            FontSize fontSize95 = new FontSize() { Val = "18" };
            FontSizeComplexScript fontSizeComplexScript95 = new FontSizeComplexScript() { Val = "18" };

            runProperties46.Append(runFonts95);
            runProperties46.Append(fontSize95);
            runProperties46.Append(fontSizeComplexScript95);
            FieldChar fieldChar2 = new FieldChar() { FieldCharType = FieldCharValues.Separate };

            run46.Append(runProperties46);
            run46.Append(fieldChar2);

            Run run47 = new Run() { RsidRunAddition = "00D60978" };

            RunProperties runProperties47 = new RunProperties();
            RunFonts runFonts96 = new RunFonts() { Ascii = "New Roman", HighAnsi = "New Roman", EastAsia = "New Roman", ComplexScript = "Times New Roman" };
            NoProof noProof1 = new NoProof();
            FontSize fontSize96 = new FontSize() { Val = "18" };
            FontSizeComplexScript fontSizeComplexScript96 = new FontSizeComplexScript() { Val = "18" };

            runProperties47.Append(runFonts96);
            runProperties47.Append(noProof1);
            runProperties47.Append(fontSize96);
            runProperties47.Append(fontSizeComplexScript96);
            Text text44 = new Text();
            text44.Text = "1";

            run47.Append(runProperties47);
            run47.Append(text44);

            Run run48 = new Run();

            RunProperties runProperties48 = new RunProperties();
            RunFonts runFonts97 = new RunFonts() { Ascii = "New Roman", HighAnsi = "New Roman", EastAsia = "New Roman", ComplexScript = "Times New Roman" };
            FontSize fontSize97 = new FontSize() { Val = "18" };
            FontSizeComplexScript fontSizeComplexScript97 = new FontSizeComplexScript() { Val = "18" };

            runProperties48.Append(runFonts97);
            runProperties48.Append(fontSize97);
            runProperties48.Append(fontSizeComplexScript97);
            FieldChar fieldChar3 = new FieldChar() { FieldCharType = FieldCharValues.End };

            run48.Append(runProperties48);
            run48.Append(fieldChar3);

            Run run49 = new Run();

            RunProperties runProperties49 = new RunProperties();
            RunFonts runFonts98 = new RunFonts() { Ascii = "New Roman", HighAnsi = "New Roman", EastAsia = "New Roman", ComplexScript = "Times New Roman" };
            FontSize fontSize98 = new FontSize() { Val = "18" };
            FontSizeComplexScript fontSizeComplexScript98 = new FontSizeComplexScript() { Val = "18" };

            runProperties49.Append(runFonts98);
            runProperties49.Append(fontSize98);
            runProperties49.Append(fontSizeComplexScript98);
            Text text45 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text45.Text = " из ";

            run49.Append(runProperties49);
            run49.Append(text45);

            Run run50 = new Run();

            RunProperties runProperties50 = new RunProperties();
            RunFonts runFonts99 = new RunFonts() { Ascii = "New Roman", HighAnsi = "New Roman", EastAsia = "New Roman", ComplexScript = "Times New Roman" };
            FontSize fontSize99 = new FontSize() { Val = "18" };
            FontSizeComplexScript fontSizeComplexScript99 = new FontSizeComplexScript() { Val = "18" };

            runProperties50.Append(runFonts99);
            runProperties50.Append(fontSize99);
            runProperties50.Append(fontSizeComplexScript99);
            FieldChar fieldChar4 = new FieldChar() { FieldCharType = FieldCharValues.Begin };

            run50.Append(runProperties50);
            run50.Append(fieldChar4);

            Run run51 = new Run();

            RunProperties runProperties51 = new RunProperties();
            RunFonts runFonts100 = new RunFonts() { Ascii = "New Roman", HighAnsi = "New Roman", EastAsia = "New Roman", ComplexScript = "Times New Roman" };
            FontSize fontSize100 = new FontSize() { Val = "18" };
            FontSizeComplexScript fontSizeComplexScript100 = new FontSizeComplexScript() { Val = "18" };

            runProperties51.Append(runFonts100);
            runProperties51.Append(fontSize100);
            runProperties51.Append(fontSizeComplexScript100);
            FieldCode fieldCode2 = new FieldCode();
            fieldCode2.Text = "NUMPAGES";

            run51.Append(runProperties51);
            run51.Append(fieldCode2);

            Run run52 = new Run();

            RunProperties runProperties52 = new RunProperties();
            RunFonts runFonts101 = new RunFonts() { Ascii = "New Roman", HighAnsi = "New Roman", EastAsia = "New Roman", ComplexScript = "Times New Roman" };
            FontSize fontSize101 = new FontSize() { Val = "18" };
            FontSizeComplexScript fontSizeComplexScript101 = new FontSizeComplexScript() { Val = "18" };

            runProperties52.Append(runFonts101);
            runProperties52.Append(fontSize101);
            runProperties52.Append(fontSizeComplexScript101);
            FieldChar fieldChar5 = new FieldChar() { FieldCharType = FieldCharValues.Separate };

            run52.Append(runProperties52);
            run52.Append(fieldChar5);

            Run run53 = new Run() { RsidRunAddition = "00D60978" };

            RunProperties runProperties53 = new RunProperties();
            RunFonts runFonts102 = new RunFonts() { Ascii = "New Roman", HighAnsi = "New Roman", EastAsia = "New Roman", ComplexScript = "Times New Roman" };
            NoProof noProof2 = new NoProof();
            FontSize fontSize102 = new FontSize() { Val = "18" };
            FontSizeComplexScript fontSizeComplexScript102 = new FontSizeComplexScript() { Val = "18" };

            runProperties53.Append(runFonts102);
            runProperties53.Append(noProof2);
            runProperties53.Append(fontSize102);
            runProperties53.Append(fontSizeComplexScript102);
            Text text46 = new Text();
            text46.Text = "1";

            run53.Append(runProperties53);
            run53.Append(text46);

            Run run54 = new Run();

            RunProperties runProperties54 = new RunProperties();
            RunFonts runFonts103 = new RunFonts() { Ascii = "New Roman", HighAnsi = "New Roman", EastAsia = "New Roman", ComplexScript = "Times New Roman" };
            FontSize fontSize103 = new FontSize() { Val = "18" };
            FontSizeComplexScript fontSizeComplexScript103 = new FontSizeComplexScript() { Val = "18" };

            runProperties54.Append(runFonts103);
            runProperties54.Append(fontSize103);
            runProperties54.Append(fontSizeComplexScript103);
            FieldChar fieldChar6 = new FieldChar() { FieldCharType = FieldCharValues.End };

            run54.Append(runProperties54);
            run54.Append(fieldChar6);

            Run run55 = new Run();

            RunProperties runProperties55 = new RunProperties();
            RunFonts runFonts104 = new RunFonts() { Ascii = "New Roman", HighAnsi = "New Roman", EastAsia = "New Roman", ComplexScript = "Times New Roman" };
            FontSize fontSize104 = new FontSize() { Val = "18" };
            FontSizeComplexScript fontSizeComplexScript104 = new FontSizeComplexScript() { Val = "18" };

            runProperties55.Append(runFonts104);
            runProperties55.Append(fontSize104);
            runProperties55.Append(fontSizeComplexScript104);
            Text text47 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text47.Text = " ";

            run55.Append(runProperties55);
            run55.Append(text47);

            paragraph51.Append(paragraphProperties49);
            paragraph51.Append(run43);
            paragraph51.Append(run44);
            paragraph51.Append(run45);
            paragraph51.Append(run46);
            paragraph51.Append(run47);
            paragraph51.Append(run48);
            paragraph51.Append(run49);
            paragraph51.Append(run50);
            paragraph51.Append(run51);
            paragraph51.Append(run52);
            paragraph51.Append(run53);
            paragraph51.Append(run54);
            paragraph51.Append(run55);

            footer1.Append(paragraph51);

            footerPart1.Footer = footer1;
        }

        // Generates content of documentSettingsPart1.
        private void GenerateDocumentSettingsPart1Content(DocumentSettingsPart documentSettingsPart1)
        {
            Settings settings1 = new Settings() { MCAttributes = new MarkupCompatibilityAttributes() { Ignorable = "w14" } };
            settings1.AddNamespaceDeclaration("mc", "http://schemas.openxmlformats.org/markup-compatibility/2006");
            settings1.AddNamespaceDeclaration("o", "urn:schemas-microsoft-com:office:office");
            settings1.AddNamespaceDeclaration("r", "http://schemas.openxmlformats.org/officeDocument/2006/relationships");
            settings1.AddNamespaceDeclaration("m", "http://schemas.openxmlformats.org/officeDocument/2006/math");
            settings1.AddNamespaceDeclaration("v", "urn:schemas-microsoft-com:vml");
            settings1.AddNamespaceDeclaration("w10", "urn:schemas-microsoft-com:office:word");
            settings1.AddNamespaceDeclaration("w", "http://schemas.openxmlformats.org/wordprocessingml/2006/main");
            settings1.AddNamespaceDeclaration("w14", "http://schemas.microsoft.com/office/word/2010/wordml");
            settings1.AddNamespaceDeclaration("sl", "http://schemas.openxmlformats.org/schemaLibrary/2006/main");
            Zoom zoom1 = new Zoom() { Percent = "100" };
            ProofState proofState1 = new ProofState() { Spelling = ProofingStateValues.Clean, Grammar = ProofingStateValues.Clean };
            DefaultTabStop defaultTabStop1 = new DefaultTabStop() { Val = 708 };
            CharacterSpacingControl characterSpacingControl1 = new CharacterSpacingControl() { Val = CharacterSpacingValues.DoNotCompress };

            FootnoteDocumentWideProperties footnoteDocumentWideProperties1 = new FootnoteDocumentWideProperties();
            FootnoteSpecialReference footnoteSpecialReference1 = new FootnoteSpecialReference() { Id = -1 };
            FootnoteSpecialReference footnoteSpecialReference2 = new FootnoteSpecialReference() { Id = 0 };

            footnoteDocumentWideProperties1.Append(footnoteSpecialReference1);
            footnoteDocumentWideProperties1.Append(footnoteSpecialReference2);

            EndnoteDocumentWideProperties endnoteDocumentWideProperties1 = new EndnoteDocumentWideProperties();
            EndnoteSpecialReference endnoteSpecialReference1 = new EndnoteSpecialReference() { Id = -1 };
            EndnoteSpecialReference endnoteSpecialReference2 = new EndnoteSpecialReference() { Id = 0 };

            endnoteDocumentWideProperties1.Append(endnoteSpecialReference1);
            endnoteDocumentWideProperties1.Append(endnoteSpecialReference2);

            Compatibility compatibility1 = new Compatibility();
            CompatibilitySetting compatibilitySetting1 = new CompatibilitySetting() { Name = CompatSettingNameValues.CompatibilityMode, Uri = "http://schemas.microsoft.com/office/word", Val = "14" };
            CompatibilitySetting compatibilitySetting2 = new CompatibilitySetting() { Name = CompatSettingNameValues.OverrideTableStyleFontSizeAndJustification, Uri = "http://schemas.microsoft.com/office/word", Val = "1" };
            CompatibilitySetting compatibilitySetting3 = new CompatibilitySetting() { Name = CompatSettingNameValues.EnableOpenTypeFeatures, Uri = "http://schemas.microsoft.com/office/word", Val = "1" };
            CompatibilitySetting compatibilitySetting4 = new CompatibilitySetting() { Name = CompatSettingNameValues.DoNotFlipMirrorIndents, Uri = "http://schemas.microsoft.com/office/word", Val = "1" };

            compatibility1.Append(compatibilitySetting1);
            compatibility1.Append(compatibilitySetting2);
            compatibility1.Append(compatibilitySetting3);
            compatibility1.Append(compatibilitySetting4);

            Rsids rsids1 = new Rsids();
            RsidRoot rsidRoot1 = new RsidRoot() { Val = "00945FC6" };
            Rsid rsid1 = new Rsid() { Val = "00391036" };
            Rsid rsid2 = new Rsid() { Val = "00571FC0" };
            Rsid rsid3 = new Rsid() { Val = "00900A10" };
            Rsid rsid4 = new Rsid() { Val = "00945FC6" };
            Rsid rsid5 = new Rsid() { Val = "00D60978" };

            rsids1.Append(rsidRoot1);
            rsids1.Append(rsid1);
            rsids1.Append(rsid2);
            rsids1.Append(rsid3);
            rsids1.Append(rsid4);
            rsids1.Append(rsid5);

            M.MathProperties mathProperties1 = new M.MathProperties();
            M.MathFont mathFont1 = new M.MathFont() { Val = "Cambria Math" };
            M.BreakBinary breakBinary1 = new M.BreakBinary() { Val = M.BreakBinaryOperatorValues.Before };
            M.BreakBinarySubtraction breakBinarySubtraction1 = new M.BreakBinarySubtraction() { Val = M.BreakBinarySubtractionValues.MinusMinus };
            M.SmallFraction smallFraction1 = new M.SmallFraction() { Val = M.BooleanValues.Zero };
            M.DisplayDefaults displayDefaults1 = new M.DisplayDefaults();
            M.LeftMargin leftMargin1 = new M.LeftMargin() { Val = (UInt32Value)0U };
            M.RightMargin rightMargin1 = new M.RightMargin() { Val = (UInt32Value)0U };
            M.DefaultJustification defaultJustification1 = new M.DefaultJustification() { Val = M.JustificationValues.CenterGroup };
            M.WrapIndent wrapIndent1 = new M.WrapIndent() { Val = (UInt32Value)1440U };
            M.IntegralLimitLocation integralLimitLocation1 = new M.IntegralLimitLocation() { Val = M.LimitLocationValues.SubscriptSuperscript };
            M.NaryLimitLocation naryLimitLocation1 = new M.NaryLimitLocation() { Val = M.LimitLocationValues.UnderOver };

            mathProperties1.Append(mathFont1);
            mathProperties1.Append(breakBinary1);
            mathProperties1.Append(breakBinarySubtraction1);
            mathProperties1.Append(smallFraction1);
            mathProperties1.Append(displayDefaults1);
            mathProperties1.Append(leftMargin1);
            mathProperties1.Append(rightMargin1);
            mathProperties1.Append(defaultJustification1);
            mathProperties1.Append(wrapIndent1);
            mathProperties1.Append(integralLimitLocation1);
            mathProperties1.Append(naryLimitLocation1);
            ThemeFontLanguages themeFontLanguages1 = new ThemeFontLanguages() { Val = "ru-RU" };
            ColorSchemeMapping colorSchemeMapping1 = new ColorSchemeMapping() { Background1 = ColorSchemeIndexValues.Light1, Text1 = ColorSchemeIndexValues.Dark1, Background2 = ColorSchemeIndexValues.Light2, Text2 = ColorSchemeIndexValues.Dark2, Accent1 = ColorSchemeIndexValues.Accent1, Accent2 = ColorSchemeIndexValues.Accent2, Accent3 = ColorSchemeIndexValues.Accent3, Accent4 = ColorSchemeIndexValues.Accent4, Accent5 = ColorSchemeIndexValues.Accent5, Accent6 = ColorSchemeIndexValues.Accent6, Hyperlink = ColorSchemeIndexValues.Hyperlink, FollowedHyperlink = ColorSchemeIndexValues.FollowedHyperlink };

            ShapeDefaults shapeDefaults1 = new ShapeDefaults();
            Ovml.ShapeDefaults shapeDefaults2 = new Ovml.ShapeDefaults() { Extension = V.ExtensionHandlingBehaviorValues.Edit, MaxShapeId = 1026 };

            Ovml.ShapeLayout shapeLayout1 = new Ovml.ShapeLayout() { Extension = V.ExtensionHandlingBehaviorValues.Edit };
            Ovml.ShapeIdMap shapeIdMap1 = new Ovml.ShapeIdMap() { Extension = V.ExtensionHandlingBehaviorValues.Edit, Data = "1" };

            shapeLayout1.Append(shapeIdMap1);

            shapeDefaults1.Append(shapeDefaults2);
            shapeDefaults1.Append(shapeLayout1);
            DecimalSymbol decimalSymbol1 = new DecimalSymbol() { Val = "," };
            ListSeparator listSeparator1 = new ListSeparator() { Val = ";" };

            settings1.Append(zoom1);
            settings1.Append(proofState1);
            settings1.Append(defaultTabStop1);
            settings1.Append(characterSpacingControl1);
            settings1.Append(footnoteDocumentWideProperties1);
            settings1.Append(endnoteDocumentWideProperties1);
            settings1.Append(compatibility1);
            settings1.Append(rsids1);
            settings1.Append(mathProperties1);
            settings1.Append(themeFontLanguages1);
            settings1.Append(colorSchemeMapping1);
            settings1.Append(shapeDefaults1);
            settings1.Append(decimalSymbol1);
            settings1.Append(listSeparator1);

            documentSettingsPart1.Settings = settings1;
        }

        // Generates content of headerPart1.
        private void GenerateHeaderPart1Content(HeaderPart headerPart1)
        {
            Header header1 = new Header() { MCAttributes = new MarkupCompatibilityAttributes() { Ignorable = "w14 wp14" } };
            header1.AddNamespaceDeclaration("wpc", "http://schemas.microsoft.com/office/word/2010/wordprocessingCanvas");
            header1.AddNamespaceDeclaration("mc", "http://schemas.openxmlformats.org/markup-compatibility/2006");
            header1.AddNamespaceDeclaration("o", "urn:schemas-microsoft-com:office:office");
            header1.AddNamespaceDeclaration("r", "http://schemas.openxmlformats.org/officeDocument/2006/relationships");
            header1.AddNamespaceDeclaration("m", "http://schemas.openxmlformats.org/officeDocument/2006/math");
            header1.AddNamespaceDeclaration("v", "urn:schemas-microsoft-com:vml");
            header1.AddNamespaceDeclaration("wp14", "http://schemas.microsoft.com/office/word/2010/wordprocessingDrawing");
            header1.AddNamespaceDeclaration("wp", "http://schemas.openxmlformats.org/drawingml/2006/wordprocessingDrawing");
            header1.AddNamespaceDeclaration("w10", "urn:schemas-microsoft-com:office:word");
            header1.AddNamespaceDeclaration("w", "http://schemas.openxmlformats.org/wordprocessingml/2006/main");
            header1.AddNamespaceDeclaration("w14", "http://schemas.microsoft.com/office/word/2010/wordml");
            header1.AddNamespaceDeclaration("wpg", "http://schemas.microsoft.com/office/word/2010/wordprocessingGroup");
            header1.AddNamespaceDeclaration("wpi", "http://schemas.microsoft.com/office/word/2010/wordprocessingInk");
            header1.AddNamespaceDeclaration("wne", "http://schemas.microsoft.com/office/word/2006/wordml");
            header1.AddNamespaceDeclaration("wps", "http://schemas.microsoft.com/office/word/2010/wordprocessingShape");

            Paragraph paragraph52 = new Paragraph() { RsidParagraphAddition = "004F7F90", RsidRunAdditionDefault = "00900A10" };

            ParagraphProperties paragraphProperties50 = new ParagraphProperties();
            WidowControl widowControl50 = new WidowControl() { Val = false };
            AutoSpaceDE autoSpaceDE50 = new AutoSpaceDE() { Val = false };
            AutoSpaceDN autoSpaceDN50 = new AutoSpaceDN() { Val = false };
            AdjustRightIndent adjustRightIndent50 = new AdjustRightIndent() { Val = false };
            SpacingBetweenLines spacingBetweenLines36 = new SpacingBetweenLines() { After = "0", Line = "240", LineRule = LineSpacingRuleValues.Auto };
            Justification justification11 = new Justification() { Val = JustificationValues.Center };

            ParagraphMarkRunProperties paragraphMarkRunProperties50 = new ParagraphMarkRunProperties();
            RunFonts runFonts105 = new RunFonts() { Ascii = "Verdana", HighAnsi = "Verdana", EastAsia = "New Roman", ComplexScript = "Verdana" };
            FontSize fontSize105 = new FontSize() { Val = "16" };
            FontSizeComplexScript fontSizeComplexScript105 = new FontSizeComplexScript() { Val = "16" };

            paragraphMarkRunProperties50.Append(runFonts105);
            paragraphMarkRunProperties50.Append(fontSize105);
            paragraphMarkRunProperties50.Append(fontSizeComplexScript105);

            paragraphProperties50.Append(widowControl50);
            paragraphProperties50.Append(autoSpaceDE50);
            paragraphProperties50.Append(autoSpaceDN50);
            paragraphProperties50.Append(adjustRightIndent50);
            paragraphProperties50.Append(spacingBetweenLines36);
            paragraphProperties50.Append(justification11);
            paragraphProperties50.Append(paragraphMarkRunProperties50);

            Run run56 = new Run();

            RunProperties runProperties56 = new RunProperties();
            RunFonts runFonts106 = new RunFonts() { Ascii = "Verdana", HighAnsi = "Verdana", EastAsia = "New Roman", ComplexScript = "Verdana" };
            Bold bold19 = new Bold();
            BoldComplexScript boldComplexScript19 = new BoldComplexScript();
            FontSize fontSize106 = new FontSize() { Val = "16" };
            FontSizeComplexScript fontSizeComplexScript106 = new FontSizeComplexScript() { Val = "16" };

            runProperties56.Append(runFonts106);
            runProperties56.Append(bold19);
            runProperties56.Append(boldComplexScript19);
            runProperties56.Append(fontSize106);
            runProperties56.Append(fontSizeComplexScript106);
            Text text48 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text48.Text = "Смоленская государственная медицинская академия ";

            run56.Append(runProperties56);
            run56.Append(text48);

            paragraph52.Append(paragraphProperties50);
            paragraph52.Append(run56);

            Paragraph paragraph53 = new Paragraph() { RsidParagraphAddition = "004F7F90", RsidRunAdditionDefault = "00900A10" };

            ParagraphProperties paragraphProperties51 = new ParagraphProperties();
            WidowControl widowControl51 = new WidowControl() { Val = false };
            AutoSpaceDE autoSpaceDE51 = new AutoSpaceDE() { Val = false };
            AutoSpaceDN autoSpaceDN51 = new AutoSpaceDN() { Val = false };
            AdjustRightIndent adjustRightIndent51 = new AdjustRightIndent() { Val = false };
            SpacingBetweenLines spacingBetweenLines37 = new SpacingBetweenLines() { After = "0", Line = "240", LineRule = LineSpacingRuleValues.Auto };
            Justification justification12 = new Justification() { Val = JustificationValues.Center };

            ParagraphMarkRunProperties paragraphMarkRunProperties51 = new ParagraphMarkRunProperties();
            RunFonts runFonts107 = new RunFonts() { Ascii = "Verdana", HighAnsi = "Verdana", EastAsia = "New Roman", ComplexScript = "Verdana" };
            FontSize fontSize107 = new FontSize() { Val = "16" };
            FontSizeComplexScript fontSizeComplexScript107 = new FontSizeComplexScript() { Val = "16" };

            paragraphMarkRunProperties51.Append(runFonts107);
            paragraphMarkRunProperties51.Append(fontSize107);
            paragraphMarkRunProperties51.Append(fontSizeComplexScript107);

            paragraphProperties51.Append(widowControl51);
            paragraphProperties51.Append(autoSpaceDE51);
            paragraphProperties51.Append(autoSpaceDN51);
            paragraphProperties51.Append(adjustRightIndent51);
            paragraphProperties51.Append(spacingBetweenLines37);
            paragraphProperties51.Append(justification12);
            paragraphProperties51.Append(paragraphMarkRunProperties51);

            Run run57 = new Run();

            RunProperties runProperties57 = new RunProperties();
            RunFonts runFonts108 = new RunFonts() { Ascii = "Verdana", HighAnsi = "Verdana", EastAsia = "New Roman", ComplexScript = "Verdana" };
            Bold bold20 = new Bold();
            BoldComplexScript boldComplexScript20 = new BoldComplexScript();
            FontSize fontSize108 = new FontSize() { Val = "16" };
            FontSizeComplexScript fontSizeComplexScript108 = new FontSizeComplexScript() { Val = "16" };

            runProperties57.Append(runFonts108);
            runProperties57.Append(bold20);
            runProperties57.Append(boldComplexScript20);
            runProperties57.Append(fontSize108);
            runProperties57.Append(fontSizeComplexScript108);
            Text text49 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text49.Text = "Научно-исследовательский институт антимикробной химиотерапии ";

            run57.Append(runProperties57);
            run57.Append(text49);

            paragraph53.Append(paragraphProperties51);
            paragraph53.Append(run57);

            Paragraph paragraph54 = new Paragraph() { RsidParagraphAddition = "004F7F90", RsidRunAdditionDefault = "00900A10" };

            ParagraphProperties paragraphProperties52 = new ParagraphProperties();
            WidowControl widowControl52 = new WidowControl() { Val = false };
            AutoSpaceDE autoSpaceDE52 = new AutoSpaceDE() { Val = false };
            AutoSpaceDN autoSpaceDN52 = new AutoSpaceDN() { Val = false };
            AdjustRightIndent adjustRightIndent52 = new AdjustRightIndent() { Val = false };
            SpacingBetweenLines spacingBetweenLines38 = new SpacingBetweenLines() { After = "0", Line = "240", LineRule = LineSpacingRuleValues.Auto };
            Justification justification13 = new Justification() { Val = JustificationValues.Center };

            ParagraphMarkRunProperties paragraphMarkRunProperties52 = new ParagraphMarkRunProperties();
            RunFonts runFonts109 = new RunFonts() { Ascii = "Verdana", HighAnsi = "Verdana", EastAsia = "New Roman", ComplexScript = "Verdana" };
            FontSize fontSize109 = new FontSize() { Val = "16" };
            FontSizeComplexScript fontSizeComplexScript109 = new FontSizeComplexScript() { Val = "16" };

            paragraphMarkRunProperties52.Append(runFonts109);
            paragraphMarkRunProperties52.Append(fontSize109);
            paragraphMarkRunProperties52.Append(fontSizeComplexScript109);

            paragraphProperties52.Append(widowControl52);
            paragraphProperties52.Append(autoSpaceDE52);
            paragraphProperties52.Append(autoSpaceDN52);
            paragraphProperties52.Append(adjustRightIndent52);
            paragraphProperties52.Append(spacingBetweenLines38);
            paragraphProperties52.Append(justification13);
            paragraphProperties52.Append(paragraphMarkRunProperties52);

            Run run58 = new Run();

            RunProperties runProperties58 = new RunProperties();
            RunFonts runFonts110 = new RunFonts() { Ascii = "Verdana", HighAnsi = "Verdana", EastAsia = "New Roman", ComplexScript = "Verdana" };
            Bold bold21 = new Bold();
            BoldComplexScript boldComplexScript21 = new BoldComplexScript();
            FontSize fontSize110 = new FontSize() { Val = "16" };
            FontSizeComplexScript fontSizeComplexScript110 = new FontSizeComplexScript() { Val = "16" };

            runProperties58.Append(runFonts110);
            runProperties58.Append(bold21);
            runProperties58.Append(boldComplexScript21);
            runProperties58.Append(fontSize110);
            runProperties58.Append(fontSizeComplexScript110);
            Text text50 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text50.Text = "Клинико-диагностическая лаборатория, тел. 45-06-13 ";

            run58.Append(runProperties58);
            run58.Append(text50);

            paragraph54.Append(paragraphProperties52);
            paragraph54.Append(run58);

            header1.Append(paragraph52);
            header1.Append(paragraph53);
            header1.Append(paragraph54);

            headerPart1.Header = header1;
        }

        // Generates content of stylesWithEffectsPart1.
        private void GenerateStylesWithEffectsPart1Content(StylesWithEffectsPart stylesWithEffectsPart1)
        {
            Styles styles1 = new Styles() { MCAttributes = new MarkupCompatibilityAttributes() { Ignorable = "w14 wp14" } };
            styles1.AddNamespaceDeclaration("wpc", "http://schemas.microsoft.com/office/word/2010/wordprocessingCanvas");
            styles1.AddNamespaceDeclaration("mc", "http://schemas.openxmlformats.org/markup-compatibility/2006");
            styles1.AddNamespaceDeclaration("o", "urn:schemas-microsoft-com:office:office");
            styles1.AddNamespaceDeclaration("r", "http://schemas.openxmlformats.org/officeDocument/2006/relationships");
            styles1.AddNamespaceDeclaration("m", "http://schemas.openxmlformats.org/officeDocument/2006/math");
            styles1.AddNamespaceDeclaration("v", "urn:schemas-microsoft-com:vml");
            styles1.AddNamespaceDeclaration("wp14", "http://schemas.microsoft.com/office/word/2010/wordprocessingDrawing");
            styles1.AddNamespaceDeclaration("wp", "http://schemas.openxmlformats.org/drawingml/2006/wordprocessingDrawing");
            styles1.AddNamespaceDeclaration("w10", "urn:schemas-microsoft-com:office:word");
            styles1.AddNamespaceDeclaration("w", "http://schemas.openxmlformats.org/wordprocessingml/2006/main");
            styles1.AddNamespaceDeclaration("w14", "http://schemas.microsoft.com/office/word/2010/wordml");
            styles1.AddNamespaceDeclaration("wpg", "http://schemas.microsoft.com/office/word/2010/wordprocessingGroup");
            styles1.AddNamespaceDeclaration("wpi", "http://schemas.microsoft.com/office/word/2010/wordprocessingInk");
            styles1.AddNamespaceDeclaration("wne", "http://schemas.microsoft.com/office/word/2006/wordml");
            styles1.AddNamespaceDeclaration("wps", "http://schemas.microsoft.com/office/word/2010/wordprocessingShape");

            DocDefaults docDefaults1 = new DocDefaults();

            RunPropertiesDefault runPropertiesDefault1 = new RunPropertiesDefault();

            RunPropertiesBaseStyle runPropertiesBaseStyle1 = new RunPropertiesBaseStyle();
            RunFonts runFonts111 = new RunFonts() { AsciiTheme = ThemeFontValues.MinorHighAnsi, HighAnsiTheme = ThemeFontValues.MinorHighAnsi, EastAsiaTheme = ThemeFontValues.MinorHighAnsi, ComplexScriptTheme = ThemeFontValues.MinorBidi };
            FontSize fontSize111 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript111 = new FontSizeComplexScript() { Val = "22" };
            Languages languages1 = new Languages() { Val = "ru-RU", EastAsia = "en-US", Bidi = "ar-SA" };

            runPropertiesBaseStyle1.Append(runFonts111);
            runPropertiesBaseStyle1.Append(fontSize111);
            runPropertiesBaseStyle1.Append(fontSizeComplexScript111);
            runPropertiesBaseStyle1.Append(languages1);

            runPropertiesDefault1.Append(runPropertiesBaseStyle1);

            ParagraphPropertiesDefault paragraphPropertiesDefault1 = new ParagraphPropertiesDefault();

            ParagraphPropertiesBaseStyle paragraphPropertiesBaseStyle1 = new ParagraphPropertiesBaseStyle();
            SpacingBetweenLines spacingBetweenLines39 = new SpacingBetweenLines() { After = "200", Line = "276", LineRule = LineSpacingRuleValues.Auto };

            paragraphPropertiesBaseStyle1.Append(spacingBetweenLines39);

            paragraphPropertiesDefault1.Append(paragraphPropertiesBaseStyle1);

            docDefaults1.Append(runPropertiesDefault1);
            docDefaults1.Append(paragraphPropertiesDefault1);

            LatentStyles latentStyles1 = new LatentStyles() { DefaultLockedState = false, DefaultUiPriority = 99, DefaultSemiHidden = true, DefaultUnhideWhenUsed = true, DefaultPrimaryStyle = false, Count = 267 };
            LatentStyleExceptionInfo latentStyleExceptionInfo1 = new LatentStyleExceptionInfo() { Name = "Normal", UiPriority = 0, SemiHidden = false, UnhideWhenUsed = false, PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo2 = new LatentStyleExceptionInfo() { Name = "heading 1", UiPriority = 9, SemiHidden = false, UnhideWhenUsed = false, PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo3 = new LatentStyleExceptionInfo() { Name = "heading 2", UiPriority = 9, PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo4 = new LatentStyleExceptionInfo() { Name = "heading 3", UiPriority = 9, PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo5 = new LatentStyleExceptionInfo() { Name = "heading 4", UiPriority = 9, PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo6 = new LatentStyleExceptionInfo() { Name = "heading 5", UiPriority = 9, PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo7 = new LatentStyleExceptionInfo() { Name = "heading 6", UiPriority = 9, PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo8 = new LatentStyleExceptionInfo() { Name = "heading 7", UiPriority = 9, PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo9 = new LatentStyleExceptionInfo() { Name = "heading 8", UiPriority = 9, PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo10 = new LatentStyleExceptionInfo() { Name = "heading 9", UiPriority = 9, PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo11 = new LatentStyleExceptionInfo() { Name = "toc 1", UiPriority = 39 };
            LatentStyleExceptionInfo latentStyleExceptionInfo12 = new LatentStyleExceptionInfo() { Name = "toc 2", UiPriority = 39 };
            LatentStyleExceptionInfo latentStyleExceptionInfo13 = new LatentStyleExceptionInfo() { Name = "toc 3", UiPriority = 39 };
            LatentStyleExceptionInfo latentStyleExceptionInfo14 = new LatentStyleExceptionInfo() { Name = "toc 4", UiPriority = 39 };
            LatentStyleExceptionInfo latentStyleExceptionInfo15 = new LatentStyleExceptionInfo() { Name = "toc 5", UiPriority = 39 };
            LatentStyleExceptionInfo latentStyleExceptionInfo16 = new LatentStyleExceptionInfo() { Name = "toc 6", UiPriority = 39 };
            LatentStyleExceptionInfo latentStyleExceptionInfo17 = new LatentStyleExceptionInfo() { Name = "toc 7", UiPriority = 39 };
            LatentStyleExceptionInfo latentStyleExceptionInfo18 = new LatentStyleExceptionInfo() { Name = "toc 8", UiPriority = 39 };
            LatentStyleExceptionInfo latentStyleExceptionInfo19 = new LatentStyleExceptionInfo() { Name = "toc 9", UiPriority = 39 };
            LatentStyleExceptionInfo latentStyleExceptionInfo20 = new LatentStyleExceptionInfo() { Name = "caption", UiPriority = 35, PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo21 = new LatentStyleExceptionInfo() { Name = "Title", UiPriority = 10, SemiHidden = false, UnhideWhenUsed = false, PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo22 = new LatentStyleExceptionInfo() { Name = "Default Paragraph Font", UiPriority = 1 };
            LatentStyleExceptionInfo latentStyleExceptionInfo23 = new LatentStyleExceptionInfo() { Name = "Subtitle", UiPriority = 11, SemiHidden = false, UnhideWhenUsed = false, PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo24 = new LatentStyleExceptionInfo() { Name = "Strong", UiPriority = 22, SemiHidden = false, UnhideWhenUsed = false, PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo25 = new LatentStyleExceptionInfo() { Name = "Emphasis", UiPriority = 20, SemiHidden = false, UnhideWhenUsed = false, PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo26 = new LatentStyleExceptionInfo() { Name = "Table Grid", UiPriority = 59, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo27 = new LatentStyleExceptionInfo() { Name = "Placeholder Text", UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo28 = new LatentStyleExceptionInfo() { Name = "No Spacing", UiPriority = 1, SemiHidden = false, UnhideWhenUsed = false, PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo29 = new LatentStyleExceptionInfo() { Name = "Light Shading", UiPriority = 60, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo30 = new LatentStyleExceptionInfo() { Name = "Light List", UiPriority = 61, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo31 = new LatentStyleExceptionInfo() { Name = "Light Grid", UiPriority = 62, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo32 = new LatentStyleExceptionInfo() { Name = "Medium Shading 1", UiPriority = 63, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo33 = new LatentStyleExceptionInfo() { Name = "Medium Shading 2", UiPriority = 64, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo34 = new LatentStyleExceptionInfo() { Name = "Medium List 1", UiPriority = 65, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo35 = new LatentStyleExceptionInfo() { Name = "Medium List 2", UiPriority = 66, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo36 = new LatentStyleExceptionInfo() { Name = "Medium Grid 1", UiPriority = 67, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo37 = new LatentStyleExceptionInfo() { Name = "Medium Grid 2", UiPriority = 68, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo38 = new LatentStyleExceptionInfo() { Name = "Medium Grid 3", UiPriority = 69, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo39 = new LatentStyleExceptionInfo() { Name = "Dark List", UiPriority = 70, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo40 = new LatentStyleExceptionInfo() { Name = "Colorful Shading", UiPriority = 71, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo41 = new LatentStyleExceptionInfo() { Name = "Colorful List", UiPriority = 72, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo42 = new LatentStyleExceptionInfo() { Name = "Colorful Grid", UiPriority = 73, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo43 = new LatentStyleExceptionInfo() { Name = "Light Shading Accent 1", UiPriority = 60, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo44 = new LatentStyleExceptionInfo() { Name = "Light List Accent 1", UiPriority = 61, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo45 = new LatentStyleExceptionInfo() { Name = "Light Grid Accent 1", UiPriority = 62, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo46 = new LatentStyleExceptionInfo() { Name = "Medium Shading 1 Accent 1", UiPriority = 63, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo47 = new LatentStyleExceptionInfo() { Name = "Medium Shading 2 Accent 1", UiPriority = 64, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo48 = new LatentStyleExceptionInfo() { Name = "Medium List 1 Accent 1", UiPriority = 65, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo49 = new LatentStyleExceptionInfo() { Name = "Revision", UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo50 = new LatentStyleExceptionInfo() { Name = "List Paragraph", UiPriority = 34, SemiHidden = false, UnhideWhenUsed = false, PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo51 = new LatentStyleExceptionInfo() { Name = "Quote", UiPriority = 29, SemiHidden = false, UnhideWhenUsed = false, PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo52 = new LatentStyleExceptionInfo() { Name = "Intense Quote", UiPriority = 30, SemiHidden = false, UnhideWhenUsed = false, PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo53 = new LatentStyleExceptionInfo() { Name = "Medium List 2 Accent 1", UiPriority = 66, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo54 = new LatentStyleExceptionInfo() { Name = "Medium Grid 1 Accent 1", UiPriority = 67, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo55 = new LatentStyleExceptionInfo() { Name = "Medium Grid 2 Accent 1", UiPriority = 68, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo56 = new LatentStyleExceptionInfo() { Name = "Medium Grid 3 Accent 1", UiPriority = 69, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo57 = new LatentStyleExceptionInfo() { Name = "Dark List Accent 1", UiPriority = 70, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo58 = new LatentStyleExceptionInfo() { Name = "Colorful Shading Accent 1", UiPriority = 71, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo59 = new LatentStyleExceptionInfo() { Name = "Colorful List Accent 1", UiPriority = 72, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo60 = new LatentStyleExceptionInfo() { Name = "Colorful Grid Accent 1", UiPriority = 73, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo61 = new LatentStyleExceptionInfo() { Name = "Light Shading Accent 2", UiPriority = 60, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo62 = new LatentStyleExceptionInfo() { Name = "Light List Accent 2", UiPriority = 61, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo63 = new LatentStyleExceptionInfo() { Name = "Light Grid Accent 2", UiPriority = 62, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo64 = new LatentStyleExceptionInfo() { Name = "Medium Shading 1 Accent 2", UiPriority = 63, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo65 = new LatentStyleExceptionInfo() { Name = "Medium Shading 2 Accent 2", UiPriority = 64, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo66 = new LatentStyleExceptionInfo() { Name = "Medium List 1 Accent 2", UiPriority = 65, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo67 = new LatentStyleExceptionInfo() { Name = "Medium List 2 Accent 2", UiPriority = 66, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo68 = new LatentStyleExceptionInfo() { Name = "Medium Grid 1 Accent 2", UiPriority = 67, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo69 = new LatentStyleExceptionInfo() { Name = "Medium Grid 2 Accent 2", UiPriority = 68, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo70 = new LatentStyleExceptionInfo() { Name = "Medium Grid 3 Accent 2", UiPriority = 69, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo71 = new LatentStyleExceptionInfo() { Name = "Dark List Accent 2", UiPriority = 70, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo72 = new LatentStyleExceptionInfo() { Name = "Colorful Shading Accent 2", UiPriority = 71, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo73 = new LatentStyleExceptionInfo() { Name = "Colorful List Accent 2", UiPriority = 72, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo74 = new LatentStyleExceptionInfo() { Name = "Colorful Grid Accent 2", UiPriority = 73, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo75 = new LatentStyleExceptionInfo() { Name = "Light Shading Accent 3", UiPriority = 60, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo76 = new LatentStyleExceptionInfo() { Name = "Light List Accent 3", UiPriority = 61, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo77 = new LatentStyleExceptionInfo() { Name = "Light Grid Accent 3", UiPriority = 62, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo78 = new LatentStyleExceptionInfo() { Name = "Medium Shading 1 Accent 3", UiPriority = 63, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo79 = new LatentStyleExceptionInfo() { Name = "Medium Shading 2 Accent 3", UiPriority = 64, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo80 = new LatentStyleExceptionInfo() { Name = "Medium List 1 Accent 3", UiPriority = 65, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo81 = new LatentStyleExceptionInfo() { Name = "Medium List 2 Accent 3", UiPriority = 66, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo82 = new LatentStyleExceptionInfo() { Name = "Medium Grid 1 Accent 3", UiPriority = 67, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo83 = new LatentStyleExceptionInfo() { Name = "Medium Grid 2 Accent 3", UiPriority = 68, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo84 = new LatentStyleExceptionInfo() { Name = "Medium Grid 3 Accent 3", UiPriority = 69, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo85 = new LatentStyleExceptionInfo() { Name = "Dark List Accent 3", UiPriority = 70, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo86 = new LatentStyleExceptionInfo() { Name = "Colorful Shading Accent 3", UiPriority = 71, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo87 = new LatentStyleExceptionInfo() { Name = "Colorful List Accent 3", UiPriority = 72, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo88 = new LatentStyleExceptionInfo() { Name = "Colorful Grid Accent 3", UiPriority = 73, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo89 = new LatentStyleExceptionInfo() { Name = "Light Shading Accent 4", UiPriority = 60, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo90 = new LatentStyleExceptionInfo() { Name = "Light List Accent 4", UiPriority = 61, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo91 = new LatentStyleExceptionInfo() { Name = "Light Grid Accent 4", UiPriority = 62, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo92 = new LatentStyleExceptionInfo() { Name = "Medium Shading 1 Accent 4", UiPriority = 63, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo93 = new LatentStyleExceptionInfo() { Name = "Medium Shading 2 Accent 4", UiPriority = 64, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo94 = new LatentStyleExceptionInfo() { Name = "Medium List 1 Accent 4", UiPriority = 65, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo95 = new LatentStyleExceptionInfo() { Name = "Medium List 2 Accent 4", UiPriority = 66, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo96 = new LatentStyleExceptionInfo() { Name = "Medium Grid 1 Accent 4", UiPriority = 67, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo97 = new LatentStyleExceptionInfo() { Name = "Medium Grid 2 Accent 4", UiPriority = 68, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo98 = new LatentStyleExceptionInfo() { Name = "Medium Grid 3 Accent 4", UiPriority = 69, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo99 = new LatentStyleExceptionInfo() { Name = "Dark List Accent 4", UiPriority = 70, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo100 = new LatentStyleExceptionInfo() { Name = "Colorful Shading Accent 4", UiPriority = 71, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo101 = new LatentStyleExceptionInfo() { Name = "Colorful List Accent 4", UiPriority = 72, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo102 = new LatentStyleExceptionInfo() { Name = "Colorful Grid Accent 4", UiPriority = 73, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo103 = new LatentStyleExceptionInfo() { Name = "Light Shading Accent 5", UiPriority = 60, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo104 = new LatentStyleExceptionInfo() { Name = "Light List Accent 5", UiPriority = 61, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo105 = new LatentStyleExceptionInfo() { Name = "Light Grid Accent 5", UiPriority = 62, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo106 = new LatentStyleExceptionInfo() { Name = "Medium Shading 1 Accent 5", UiPriority = 63, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo107 = new LatentStyleExceptionInfo() { Name = "Medium Shading 2 Accent 5", UiPriority = 64, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo108 = new LatentStyleExceptionInfo() { Name = "Medium List 1 Accent 5", UiPriority = 65, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo109 = new LatentStyleExceptionInfo() { Name = "Medium List 2 Accent 5", UiPriority = 66, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo110 = new LatentStyleExceptionInfo() { Name = "Medium Grid 1 Accent 5", UiPriority = 67, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo111 = new LatentStyleExceptionInfo() { Name = "Medium Grid 2 Accent 5", UiPriority = 68, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo112 = new LatentStyleExceptionInfo() { Name = "Medium Grid 3 Accent 5", UiPriority = 69, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo113 = new LatentStyleExceptionInfo() { Name = "Dark List Accent 5", UiPriority = 70, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo114 = new LatentStyleExceptionInfo() { Name = "Colorful Shading Accent 5", UiPriority = 71, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo115 = new LatentStyleExceptionInfo() { Name = "Colorful List Accent 5", UiPriority = 72, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo116 = new LatentStyleExceptionInfo() { Name = "Colorful Grid Accent 5", UiPriority = 73, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo117 = new LatentStyleExceptionInfo() { Name = "Light Shading Accent 6", UiPriority = 60, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo118 = new LatentStyleExceptionInfo() { Name = "Light List Accent 6", UiPriority = 61, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo119 = new LatentStyleExceptionInfo() { Name = "Light Grid Accent 6", UiPriority = 62, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo120 = new LatentStyleExceptionInfo() { Name = "Medium Shading 1 Accent 6", UiPriority = 63, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo121 = new LatentStyleExceptionInfo() { Name = "Medium Shading 2 Accent 6", UiPriority = 64, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo122 = new LatentStyleExceptionInfo() { Name = "Medium List 1 Accent 6", UiPriority = 65, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo123 = new LatentStyleExceptionInfo() { Name = "Medium List 2 Accent 6", UiPriority = 66, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo124 = new LatentStyleExceptionInfo() { Name = "Medium Grid 1 Accent 6", UiPriority = 67, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo125 = new LatentStyleExceptionInfo() { Name = "Medium Grid 2 Accent 6", UiPriority = 68, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo126 = new LatentStyleExceptionInfo() { Name = "Medium Grid 3 Accent 6", UiPriority = 69, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo127 = new LatentStyleExceptionInfo() { Name = "Dark List Accent 6", UiPriority = 70, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo128 = new LatentStyleExceptionInfo() { Name = "Colorful Shading Accent 6", UiPriority = 71, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo129 = new LatentStyleExceptionInfo() { Name = "Colorful List Accent 6", UiPriority = 72, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo130 = new LatentStyleExceptionInfo() { Name = "Colorful Grid Accent 6", UiPriority = 73, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo131 = new LatentStyleExceptionInfo() { Name = "Subtle Emphasis", UiPriority = 19, SemiHidden = false, UnhideWhenUsed = false, PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo132 = new LatentStyleExceptionInfo() { Name = "Intense Emphasis", UiPriority = 21, SemiHidden = false, UnhideWhenUsed = false, PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo133 = new LatentStyleExceptionInfo() { Name = "Subtle Reference", UiPriority = 31, SemiHidden = false, UnhideWhenUsed = false, PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo134 = new LatentStyleExceptionInfo() { Name = "Intense Reference", UiPriority = 32, SemiHidden = false, UnhideWhenUsed = false, PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo135 = new LatentStyleExceptionInfo() { Name = "Book Title", UiPriority = 33, SemiHidden = false, UnhideWhenUsed = false, PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo136 = new LatentStyleExceptionInfo() { Name = "Bibliography", UiPriority = 37 };
            LatentStyleExceptionInfo latentStyleExceptionInfo137 = new LatentStyleExceptionInfo() { Name = "TOC Heading", UiPriority = 39, PrimaryStyle = true };

            latentStyles1.Append(latentStyleExceptionInfo1);
            latentStyles1.Append(latentStyleExceptionInfo2);
            latentStyles1.Append(latentStyleExceptionInfo3);
            latentStyles1.Append(latentStyleExceptionInfo4);
            latentStyles1.Append(latentStyleExceptionInfo5);
            latentStyles1.Append(latentStyleExceptionInfo6);
            latentStyles1.Append(latentStyleExceptionInfo7);
            latentStyles1.Append(latentStyleExceptionInfo8);
            latentStyles1.Append(latentStyleExceptionInfo9);
            latentStyles1.Append(latentStyleExceptionInfo10);
            latentStyles1.Append(latentStyleExceptionInfo11);
            latentStyles1.Append(latentStyleExceptionInfo12);
            latentStyles1.Append(latentStyleExceptionInfo13);
            latentStyles1.Append(latentStyleExceptionInfo14);
            latentStyles1.Append(latentStyleExceptionInfo15);
            latentStyles1.Append(latentStyleExceptionInfo16);
            latentStyles1.Append(latentStyleExceptionInfo17);
            latentStyles1.Append(latentStyleExceptionInfo18);
            latentStyles1.Append(latentStyleExceptionInfo19);
            latentStyles1.Append(latentStyleExceptionInfo20);
            latentStyles1.Append(latentStyleExceptionInfo21);
            latentStyles1.Append(latentStyleExceptionInfo22);
            latentStyles1.Append(latentStyleExceptionInfo23);
            latentStyles1.Append(latentStyleExceptionInfo24);
            latentStyles1.Append(latentStyleExceptionInfo25);
            latentStyles1.Append(latentStyleExceptionInfo26);
            latentStyles1.Append(latentStyleExceptionInfo27);
            latentStyles1.Append(latentStyleExceptionInfo28);
            latentStyles1.Append(latentStyleExceptionInfo29);
            latentStyles1.Append(latentStyleExceptionInfo30);
            latentStyles1.Append(latentStyleExceptionInfo31);
            latentStyles1.Append(latentStyleExceptionInfo32);
            latentStyles1.Append(latentStyleExceptionInfo33);
            latentStyles1.Append(latentStyleExceptionInfo34);
            latentStyles1.Append(latentStyleExceptionInfo35);
            latentStyles1.Append(latentStyleExceptionInfo36);
            latentStyles1.Append(latentStyleExceptionInfo37);
            latentStyles1.Append(latentStyleExceptionInfo38);
            latentStyles1.Append(latentStyleExceptionInfo39);
            latentStyles1.Append(latentStyleExceptionInfo40);
            latentStyles1.Append(latentStyleExceptionInfo41);
            latentStyles1.Append(latentStyleExceptionInfo42);
            latentStyles1.Append(latentStyleExceptionInfo43);
            latentStyles1.Append(latentStyleExceptionInfo44);
            latentStyles1.Append(latentStyleExceptionInfo45);
            latentStyles1.Append(latentStyleExceptionInfo46);
            latentStyles1.Append(latentStyleExceptionInfo47);
            latentStyles1.Append(latentStyleExceptionInfo48);
            latentStyles1.Append(latentStyleExceptionInfo49);
            latentStyles1.Append(latentStyleExceptionInfo50);
            latentStyles1.Append(latentStyleExceptionInfo51);
            latentStyles1.Append(latentStyleExceptionInfo52);
            latentStyles1.Append(latentStyleExceptionInfo53);
            latentStyles1.Append(latentStyleExceptionInfo54);
            latentStyles1.Append(latentStyleExceptionInfo55);
            latentStyles1.Append(latentStyleExceptionInfo56);
            latentStyles1.Append(latentStyleExceptionInfo57);
            latentStyles1.Append(latentStyleExceptionInfo58);
            latentStyles1.Append(latentStyleExceptionInfo59);
            latentStyles1.Append(latentStyleExceptionInfo60);
            latentStyles1.Append(latentStyleExceptionInfo61);
            latentStyles1.Append(latentStyleExceptionInfo62);
            latentStyles1.Append(latentStyleExceptionInfo63);
            latentStyles1.Append(latentStyleExceptionInfo64);
            latentStyles1.Append(latentStyleExceptionInfo65);
            latentStyles1.Append(latentStyleExceptionInfo66);
            latentStyles1.Append(latentStyleExceptionInfo67);
            latentStyles1.Append(latentStyleExceptionInfo68);
            latentStyles1.Append(latentStyleExceptionInfo69);
            latentStyles1.Append(latentStyleExceptionInfo70);
            latentStyles1.Append(latentStyleExceptionInfo71);
            latentStyles1.Append(latentStyleExceptionInfo72);
            latentStyles1.Append(latentStyleExceptionInfo73);
            latentStyles1.Append(latentStyleExceptionInfo74);
            latentStyles1.Append(latentStyleExceptionInfo75);
            latentStyles1.Append(latentStyleExceptionInfo76);
            latentStyles1.Append(latentStyleExceptionInfo77);
            latentStyles1.Append(latentStyleExceptionInfo78);
            latentStyles1.Append(latentStyleExceptionInfo79);
            latentStyles1.Append(latentStyleExceptionInfo80);
            latentStyles1.Append(latentStyleExceptionInfo81);
            latentStyles1.Append(latentStyleExceptionInfo82);
            latentStyles1.Append(latentStyleExceptionInfo83);
            latentStyles1.Append(latentStyleExceptionInfo84);
            latentStyles1.Append(latentStyleExceptionInfo85);
            latentStyles1.Append(latentStyleExceptionInfo86);
            latentStyles1.Append(latentStyleExceptionInfo87);
            latentStyles1.Append(latentStyleExceptionInfo88);
            latentStyles1.Append(latentStyleExceptionInfo89);
            latentStyles1.Append(latentStyleExceptionInfo90);
            latentStyles1.Append(latentStyleExceptionInfo91);
            latentStyles1.Append(latentStyleExceptionInfo92);
            latentStyles1.Append(latentStyleExceptionInfo93);
            latentStyles1.Append(latentStyleExceptionInfo94);
            latentStyles1.Append(latentStyleExceptionInfo95);
            latentStyles1.Append(latentStyleExceptionInfo96);
            latentStyles1.Append(latentStyleExceptionInfo97);
            latentStyles1.Append(latentStyleExceptionInfo98);
            latentStyles1.Append(latentStyleExceptionInfo99);
            latentStyles1.Append(latentStyleExceptionInfo100);
            latentStyles1.Append(latentStyleExceptionInfo101);
            latentStyles1.Append(latentStyleExceptionInfo102);
            latentStyles1.Append(latentStyleExceptionInfo103);
            latentStyles1.Append(latentStyleExceptionInfo104);
            latentStyles1.Append(latentStyleExceptionInfo105);
            latentStyles1.Append(latentStyleExceptionInfo106);
            latentStyles1.Append(latentStyleExceptionInfo107);
            latentStyles1.Append(latentStyleExceptionInfo108);
            latentStyles1.Append(latentStyleExceptionInfo109);
            latentStyles1.Append(latentStyleExceptionInfo110);
            latentStyles1.Append(latentStyleExceptionInfo111);
            latentStyles1.Append(latentStyleExceptionInfo112);
            latentStyles1.Append(latentStyleExceptionInfo113);
            latentStyles1.Append(latentStyleExceptionInfo114);
            latentStyles1.Append(latentStyleExceptionInfo115);
            latentStyles1.Append(latentStyleExceptionInfo116);
            latentStyles1.Append(latentStyleExceptionInfo117);
            latentStyles1.Append(latentStyleExceptionInfo118);
            latentStyles1.Append(latentStyleExceptionInfo119);
            latentStyles1.Append(latentStyleExceptionInfo120);
            latentStyles1.Append(latentStyleExceptionInfo121);
            latentStyles1.Append(latentStyleExceptionInfo122);
            latentStyles1.Append(latentStyleExceptionInfo123);
            latentStyles1.Append(latentStyleExceptionInfo124);
            latentStyles1.Append(latentStyleExceptionInfo125);
            latentStyles1.Append(latentStyleExceptionInfo126);
            latentStyles1.Append(latentStyleExceptionInfo127);
            latentStyles1.Append(latentStyleExceptionInfo128);
            latentStyles1.Append(latentStyleExceptionInfo129);
            latentStyles1.Append(latentStyleExceptionInfo130);
            latentStyles1.Append(latentStyleExceptionInfo131);
            latentStyles1.Append(latentStyleExceptionInfo132);
            latentStyles1.Append(latentStyleExceptionInfo133);
            latentStyles1.Append(latentStyleExceptionInfo134);
            latentStyles1.Append(latentStyleExceptionInfo135);
            latentStyles1.Append(latentStyleExceptionInfo136);
            latentStyles1.Append(latentStyleExceptionInfo137);

            Style style1 = new Style() { Type = StyleValues.Paragraph, StyleId = "a", Default = true };
            StyleName styleName1 = new StyleName() { Val = "Normal" };
            PrimaryStyle primaryStyle1 = new PrimaryStyle();
            Rsid rsid6 = new Rsid() { Val = "00900A10" };

            StyleRunProperties styleRunProperties1 = new StyleRunProperties();
            RunFonts runFonts112 = new RunFonts() { EastAsiaTheme = ThemeFontValues.MinorEastAsia };
            Languages languages2 = new Languages() { EastAsia = "ru-RU" };

            styleRunProperties1.Append(runFonts112);
            styleRunProperties1.Append(languages2);

            style1.Append(styleName1);
            style1.Append(primaryStyle1);
            style1.Append(rsid6);
            style1.Append(styleRunProperties1);

            Style style2 = new Style() { Type = StyleValues.Character, StyleId = "a0", Default = true };
            StyleName styleName2 = new StyleName() { Val = "Default Paragraph Font" };
            UIPriority uIPriority1 = new UIPriority() { Val = 1 };
            SemiHidden semiHidden1 = new SemiHidden();
            UnhideWhenUsed unhideWhenUsed1 = new UnhideWhenUsed();

            style2.Append(styleName2);
            style2.Append(uIPriority1);
            style2.Append(semiHidden1);
            style2.Append(unhideWhenUsed1);

            Style style3 = new Style() { Type = StyleValues.Table, StyleId = "a1", Default = true };
            StyleName styleName3 = new StyleName() { Val = "Normal Table" };
            UIPriority uIPriority2 = new UIPriority() { Val = 99 };
            SemiHidden semiHidden2 = new SemiHidden();
            UnhideWhenUsed unhideWhenUsed2 = new UnhideWhenUsed();

            StyleTableProperties styleTableProperties1 = new StyleTableProperties();
            TableIndentation tableIndentation4 = new TableIndentation() { Width = 0, Type = TableWidthUnitValues.Dxa };

            TableCellMarginDefault tableCellMarginDefault4 = new TableCellMarginDefault();
            TopMargin topMargin1 = new TopMargin() { Width = "0", Type = TableWidthUnitValues.Dxa };
            TableCellLeftMargin tableCellLeftMargin4 = new TableCellLeftMargin() { Width = 108, Type = TableWidthValues.Dxa };
            BottomMargin bottomMargin1 = new BottomMargin() { Width = "0", Type = TableWidthUnitValues.Dxa };
            TableCellRightMargin tableCellRightMargin4 = new TableCellRightMargin() { Width = 108, Type = TableWidthValues.Dxa };

            tableCellMarginDefault4.Append(topMargin1);
            tableCellMarginDefault4.Append(tableCellLeftMargin4);
            tableCellMarginDefault4.Append(bottomMargin1);
            tableCellMarginDefault4.Append(tableCellRightMargin4);

            styleTableProperties1.Append(tableIndentation4);
            styleTableProperties1.Append(tableCellMarginDefault4);

            style3.Append(styleName3);
            style3.Append(uIPriority2);
            style3.Append(semiHidden2);
            style3.Append(unhideWhenUsed2);
            style3.Append(styleTableProperties1);

            Style style4 = new Style() { Type = StyleValues.Numbering, StyleId = "a2", Default = true };
            StyleName styleName4 = new StyleName() { Val = "No List" };
            UIPriority uIPriority3 = new UIPriority() { Val = 99 };
            SemiHidden semiHidden3 = new SemiHidden();
            UnhideWhenUsed unhideWhenUsed3 = new UnhideWhenUsed();

            style4.Append(styleName4);
            style4.Append(uIPriority3);
            style4.Append(semiHidden3);
            style4.Append(unhideWhenUsed3);

            Style style5 = new Style() { Type = StyleValues.Table, StyleId = "a3" };
            StyleName styleName5 = new StyleName() { Val = "Table Grid" };
            BasedOn basedOn1 = new BasedOn() { Val = "a1" };
            UIPriority uIPriority4 = new UIPriority() { Val = 59 };
            Rsid rsid7 = new Rsid() { Val = "00D60978" };

            StyleParagraphProperties styleParagraphProperties1 = new StyleParagraphProperties();
            SpacingBetweenLines spacingBetweenLines40 = new SpacingBetweenLines() { After = "0", Line = "240", LineRule = LineSpacingRuleValues.Auto };

            styleParagraphProperties1.Append(spacingBetweenLines40);

            StyleTableProperties styleTableProperties2 = new StyleTableProperties();
            TableIndentation tableIndentation5 = new TableIndentation() { Width = 0, Type = TableWidthUnitValues.Dxa };

            TableBorders tableBorders2 = new TableBorders();
            TopBorder topBorder19 = new TopBorder() { Val = BorderValues.Single, Color = "auto", Size = (UInt32Value)4U, Space = (UInt32Value)0U };
            LeftBorder leftBorder18 = new LeftBorder() { Val = BorderValues.Single, Color = "auto", Size = (UInt32Value)4U, Space = (UInt32Value)0U };
            BottomBorder bottomBorder18 = new BottomBorder() { Val = BorderValues.Single, Color = "auto", Size = (UInt32Value)4U, Space = (UInt32Value)0U };
            RightBorder rightBorder18 = new RightBorder() { Val = BorderValues.Single, Color = "auto", Size = (UInt32Value)4U, Space = (UInt32Value)0U };
            InsideHorizontalBorder insideHorizontalBorder2 = new InsideHorizontalBorder() { Val = BorderValues.Single, Color = "auto", Size = (UInt32Value)4U, Space = (UInt32Value)0U };
            InsideVerticalBorder insideVerticalBorder2 = new InsideVerticalBorder() { Val = BorderValues.Single, Color = "auto", Size = (UInt32Value)4U, Space = (UInt32Value)0U };

            tableBorders2.Append(topBorder19);
            tableBorders2.Append(leftBorder18);
            tableBorders2.Append(bottomBorder18);
            tableBorders2.Append(rightBorder18);
            tableBorders2.Append(insideHorizontalBorder2);
            tableBorders2.Append(insideVerticalBorder2);

            TableCellMarginDefault tableCellMarginDefault5 = new TableCellMarginDefault();
            TopMargin topMargin2 = new TopMargin() { Width = "0", Type = TableWidthUnitValues.Dxa };
            TableCellLeftMargin tableCellLeftMargin5 = new TableCellLeftMargin() { Width = 108, Type = TableWidthValues.Dxa };
            BottomMargin bottomMargin2 = new BottomMargin() { Width = "0", Type = TableWidthUnitValues.Dxa };
            TableCellRightMargin tableCellRightMargin5 = new TableCellRightMargin() { Width = 108, Type = TableWidthValues.Dxa };

            tableCellMarginDefault5.Append(topMargin2);
            tableCellMarginDefault5.Append(tableCellLeftMargin5);
            tableCellMarginDefault5.Append(bottomMargin2);
            tableCellMarginDefault5.Append(tableCellRightMargin5);

            styleTableProperties2.Append(tableIndentation5);
            styleTableProperties2.Append(tableBorders2);
            styleTableProperties2.Append(tableCellMarginDefault5);

            style5.Append(styleName5);
            style5.Append(basedOn1);
            style5.Append(uIPriority4);
            style5.Append(rsid7);
            style5.Append(styleParagraphProperties1);
            style5.Append(styleTableProperties2);

            styles1.Append(docDefaults1);
            styles1.Append(latentStyles1);
            styles1.Append(style1);
            styles1.Append(style2);
            styles1.Append(style3);
            styles1.Append(style4);
            styles1.Append(style5);

            stylesWithEffectsPart1.Styles = styles1;
        }

        // Generates content of styleDefinitionsPart1.
        private void GenerateStyleDefinitionsPart1Content(StyleDefinitionsPart styleDefinitionsPart1)
        {
            Styles styles2 = new Styles() { MCAttributes = new MarkupCompatibilityAttributes() { Ignorable = "w14" } };
            styles2.AddNamespaceDeclaration("mc", "http://schemas.openxmlformats.org/markup-compatibility/2006");
            styles2.AddNamespaceDeclaration("r", "http://schemas.openxmlformats.org/officeDocument/2006/relationships");
            styles2.AddNamespaceDeclaration("w", "http://schemas.openxmlformats.org/wordprocessingml/2006/main");
            styles2.AddNamespaceDeclaration("w14", "http://schemas.microsoft.com/office/word/2010/wordml");

            DocDefaults docDefaults2 = new DocDefaults();

            RunPropertiesDefault runPropertiesDefault2 = new RunPropertiesDefault();

            RunPropertiesBaseStyle runPropertiesBaseStyle2 = new RunPropertiesBaseStyle();
            RunFonts runFonts113 = new RunFonts() { AsciiTheme = ThemeFontValues.MinorHighAnsi, HighAnsiTheme = ThemeFontValues.MinorHighAnsi, EastAsiaTheme = ThemeFontValues.MinorHighAnsi, ComplexScriptTheme = ThemeFontValues.MinorBidi };
            FontSize fontSize112 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript112 = new FontSizeComplexScript() { Val = "22" };
            Languages languages3 = new Languages() { Val = "ru-RU", EastAsia = "en-US", Bidi = "ar-SA" };

            runPropertiesBaseStyle2.Append(runFonts113);
            runPropertiesBaseStyle2.Append(fontSize112);
            runPropertiesBaseStyle2.Append(fontSizeComplexScript112);
            runPropertiesBaseStyle2.Append(languages3);

            runPropertiesDefault2.Append(runPropertiesBaseStyle2);

            ParagraphPropertiesDefault paragraphPropertiesDefault2 = new ParagraphPropertiesDefault();

            ParagraphPropertiesBaseStyle paragraphPropertiesBaseStyle2 = new ParagraphPropertiesBaseStyle();
            SpacingBetweenLines spacingBetweenLines41 = new SpacingBetweenLines() { After = "200", Line = "276", LineRule = LineSpacingRuleValues.Auto };

            paragraphPropertiesBaseStyle2.Append(spacingBetweenLines41);

            paragraphPropertiesDefault2.Append(paragraphPropertiesBaseStyle2);

            docDefaults2.Append(runPropertiesDefault2);
            docDefaults2.Append(paragraphPropertiesDefault2);

            LatentStyles latentStyles2 = new LatentStyles() { DefaultLockedState = false, DefaultUiPriority = 99, DefaultSemiHidden = true, DefaultUnhideWhenUsed = true, DefaultPrimaryStyle = false, Count = 267 };
            LatentStyleExceptionInfo latentStyleExceptionInfo138 = new LatentStyleExceptionInfo() { Name = "Normal", UiPriority = 0, SemiHidden = false, UnhideWhenUsed = false, PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo139 = new LatentStyleExceptionInfo() { Name = "heading 1", UiPriority = 9, SemiHidden = false, UnhideWhenUsed = false, PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo140 = new LatentStyleExceptionInfo() { Name = "heading 2", UiPriority = 9, PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo141 = new LatentStyleExceptionInfo() { Name = "heading 3", UiPriority = 9, PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo142 = new LatentStyleExceptionInfo() { Name = "heading 4", UiPriority = 9, PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo143 = new LatentStyleExceptionInfo() { Name = "heading 5", UiPriority = 9, PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo144 = new LatentStyleExceptionInfo() { Name = "heading 6", UiPriority = 9, PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo145 = new LatentStyleExceptionInfo() { Name = "heading 7", UiPriority = 9, PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo146 = new LatentStyleExceptionInfo() { Name = "heading 8", UiPriority = 9, PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo147 = new LatentStyleExceptionInfo() { Name = "heading 9", UiPriority = 9, PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo148 = new LatentStyleExceptionInfo() { Name = "toc 1", UiPriority = 39 };
            LatentStyleExceptionInfo latentStyleExceptionInfo149 = new LatentStyleExceptionInfo() { Name = "toc 2", UiPriority = 39 };
            LatentStyleExceptionInfo latentStyleExceptionInfo150 = new LatentStyleExceptionInfo() { Name = "toc 3", UiPriority = 39 };
            LatentStyleExceptionInfo latentStyleExceptionInfo151 = new LatentStyleExceptionInfo() { Name = "toc 4", UiPriority = 39 };
            LatentStyleExceptionInfo latentStyleExceptionInfo152 = new LatentStyleExceptionInfo() { Name = "toc 5", UiPriority = 39 };
            LatentStyleExceptionInfo latentStyleExceptionInfo153 = new LatentStyleExceptionInfo() { Name = "toc 6", UiPriority = 39 };
            LatentStyleExceptionInfo latentStyleExceptionInfo154 = new LatentStyleExceptionInfo() { Name = "toc 7", UiPriority = 39 };
            LatentStyleExceptionInfo latentStyleExceptionInfo155 = new LatentStyleExceptionInfo() { Name = "toc 8", UiPriority = 39 };
            LatentStyleExceptionInfo latentStyleExceptionInfo156 = new LatentStyleExceptionInfo() { Name = "toc 9", UiPriority = 39 };
            LatentStyleExceptionInfo latentStyleExceptionInfo157 = new LatentStyleExceptionInfo() { Name = "caption", UiPriority = 35, PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo158 = new LatentStyleExceptionInfo() { Name = "Title", UiPriority = 10, SemiHidden = false, UnhideWhenUsed = false, PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo159 = new LatentStyleExceptionInfo() { Name = "Default Paragraph Font", UiPriority = 1 };
            LatentStyleExceptionInfo latentStyleExceptionInfo160 = new LatentStyleExceptionInfo() { Name = "Subtitle", UiPriority = 11, SemiHidden = false, UnhideWhenUsed = false, PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo161 = new LatentStyleExceptionInfo() { Name = "Strong", UiPriority = 22, SemiHidden = false, UnhideWhenUsed = false, PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo162 = new LatentStyleExceptionInfo() { Name = "Emphasis", UiPriority = 20, SemiHidden = false, UnhideWhenUsed = false, PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo163 = new LatentStyleExceptionInfo() { Name = "Table Grid", UiPriority = 59, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo164 = new LatentStyleExceptionInfo() { Name = "Placeholder Text", UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo165 = new LatentStyleExceptionInfo() { Name = "No Spacing", UiPriority = 1, SemiHidden = false, UnhideWhenUsed = false, PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo166 = new LatentStyleExceptionInfo() { Name = "Light Shading", UiPriority = 60, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo167 = new LatentStyleExceptionInfo() { Name = "Light List", UiPriority = 61, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo168 = new LatentStyleExceptionInfo() { Name = "Light Grid", UiPriority = 62, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo169 = new LatentStyleExceptionInfo() { Name = "Medium Shading 1", UiPriority = 63, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo170 = new LatentStyleExceptionInfo() { Name = "Medium Shading 2", UiPriority = 64, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo171 = new LatentStyleExceptionInfo() { Name = "Medium List 1", UiPriority = 65, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo172 = new LatentStyleExceptionInfo() { Name = "Medium List 2", UiPriority = 66, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo173 = new LatentStyleExceptionInfo() { Name = "Medium Grid 1", UiPriority = 67, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo174 = new LatentStyleExceptionInfo() { Name = "Medium Grid 2", UiPriority = 68, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo175 = new LatentStyleExceptionInfo() { Name = "Medium Grid 3", UiPriority = 69, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo176 = new LatentStyleExceptionInfo() { Name = "Dark List", UiPriority = 70, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo177 = new LatentStyleExceptionInfo() { Name = "Colorful Shading", UiPriority = 71, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo178 = new LatentStyleExceptionInfo() { Name = "Colorful List", UiPriority = 72, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo179 = new LatentStyleExceptionInfo() { Name = "Colorful Grid", UiPriority = 73, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo180 = new LatentStyleExceptionInfo() { Name = "Light Shading Accent 1", UiPriority = 60, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo181 = new LatentStyleExceptionInfo() { Name = "Light List Accent 1", UiPriority = 61, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo182 = new LatentStyleExceptionInfo() { Name = "Light Grid Accent 1", UiPriority = 62, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo183 = new LatentStyleExceptionInfo() { Name = "Medium Shading 1 Accent 1", UiPriority = 63, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo184 = new LatentStyleExceptionInfo() { Name = "Medium Shading 2 Accent 1", UiPriority = 64, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo185 = new LatentStyleExceptionInfo() { Name = "Medium List 1 Accent 1", UiPriority = 65, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo186 = new LatentStyleExceptionInfo() { Name = "Revision", UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo187 = new LatentStyleExceptionInfo() { Name = "List Paragraph", UiPriority = 34, SemiHidden = false, UnhideWhenUsed = false, PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo188 = new LatentStyleExceptionInfo() { Name = "Quote", UiPriority = 29, SemiHidden = false, UnhideWhenUsed = false, PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo189 = new LatentStyleExceptionInfo() { Name = "Intense Quote", UiPriority = 30, SemiHidden = false, UnhideWhenUsed = false, PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo190 = new LatentStyleExceptionInfo() { Name = "Medium List 2 Accent 1", UiPriority = 66, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo191 = new LatentStyleExceptionInfo() { Name = "Medium Grid 1 Accent 1", UiPriority = 67, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo192 = new LatentStyleExceptionInfo() { Name = "Medium Grid 2 Accent 1", UiPriority = 68, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo193 = new LatentStyleExceptionInfo() { Name = "Medium Grid 3 Accent 1", UiPriority = 69, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo194 = new LatentStyleExceptionInfo() { Name = "Dark List Accent 1", UiPriority = 70, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo195 = new LatentStyleExceptionInfo() { Name = "Colorful Shading Accent 1", UiPriority = 71, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo196 = new LatentStyleExceptionInfo() { Name = "Colorful List Accent 1", UiPriority = 72, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo197 = new LatentStyleExceptionInfo() { Name = "Colorful Grid Accent 1", UiPriority = 73, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo198 = new LatentStyleExceptionInfo() { Name = "Light Shading Accent 2", UiPriority = 60, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo199 = new LatentStyleExceptionInfo() { Name = "Light List Accent 2", UiPriority = 61, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo200 = new LatentStyleExceptionInfo() { Name = "Light Grid Accent 2", UiPriority = 62, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo201 = new LatentStyleExceptionInfo() { Name = "Medium Shading 1 Accent 2", UiPriority = 63, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo202 = new LatentStyleExceptionInfo() { Name = "Medium Shading 2 Accent 2", UiPriority = 64, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo203 = new LatentStyleExceptionInfo() { Name = "Medium List 1 Accent 2", UiPriority = 65, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo204 = new LatentStyleExceptionInfo() { Name = "Medium List 2 Accent 2", UiPriority = 66, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo205 = new LatentStyleExceptionInfo() { Name = "Medium Grid 1 Accent 2", UiPriority = 67, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo206 = new LatentStyleExceptionInfo() { Name = "Medium Grid 2 Accent 2", UiPriority = 68, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo207 = new LatentStyleExceptionInfo() { Name = "Medium Grid 3 Accent 2", UiPriority = 69, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo208 = new LatentStyleExceptionInfo() { Name = "Dark List Accent 2", UiPriority = 70, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo209 = new LatentStyleExceptionInfo() { Name = "Colorful Shading Accent 2", UiPriority = 71, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo210 = new LatentStyleExceptionInfo() { Name = "Colorful List Accent 2", UiPriority = 72, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo211 = new LatentStyleExceptionInfo() { Name = "Colorful Grid Accent 2", UiPriority = 73, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo212 = new LatentStyleExceptionInfo() { Name = "Light Shading Accent 3", UiPriority = 60, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo213 = new LatentStyleExceptionInfo() { Name = "Light List Accent 3", UiPriority = 61, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo214 = new LatentStyleExceptionInfo() { Name = "Light Grid Accent 3", UiPriority = 62, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo215 = new LatentStyleExceptionInfo() { Name = "Medium Shading 1 Accent 3", UiPriority = 63, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo216 = new LatentStyleExceptionInfo() { Name = "Medium Shading 2 Accent 3", UiPriority = 64, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo217 = new LatentStyleExceptionInfo() { Name = "Medium List 1 Accent 3", UiPriority = 65, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo218 = new LatentStyleExceptionInfo() { Name = "Medium List 2 Accent 3", UiPriority = 66, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo219 = new LatentStyleExceptionInfo() { Name = "Medium Grid 1 Accent 3", UiPriority = 67, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo220 = new LatentStyleExceptionInfo() { Name = "Medium Grid 2 Accent 3", UiPriority = 68, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo221 = new LatentStyleExceptionInfo() { Name = "Medium Grid 3 Accent 3", UiPriority = 69, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo222 = new LatentStyleExceptionInfo() { Name = "Dark List Accent 3", UiPriority = 70, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo223 = new LatentStyleExceptionInfo() { Name = "Colorful Shading Accent 3", UiPriority = 71, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo224 = new LatentStyleExceptionInfo() { Name = "Colorful List Accent 3", UiPriority = 72, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo225 = new LatentStyleExceptionInfo() { Name = "Colorful Grid Accent 3", UiPriority = 73, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo226 = new LatentStyleExceptionInfo() { Name = "Light Shading Accent 4", UiPriority = 60, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo227 = new LatentStyleExceptionInfo() { Name = "Light List Accent 4", UiPriority = 61, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo228 = new LatentStyleExceptionInfo() { Name = "Light Grid Accent 4", UiPriority = 62, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo229 = new LatentStyleExceptionInfo() { Name = "Medium Shading 1 Accent 4", UiPriority = 63, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo230 = new LatentStyleExceptionInfo() { Name = "Medium Shading 2 Accent 4", UiPriority = 64, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo231 = new LatentStyleExceptionInfo() { Name = "Medium List 1 Accent 4", UiPriority = 65, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo232 = new LatentStyleExceptionInfo() { Name = "Medium List 2 Accent 4", UiPriority = 66, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo233 = new LatentStyleExceptionInfo() { Name = "Medium Grid 1 Accent 4", UiPriority = 67, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo234 = new LatentStyleExceptionInfo() { Name = "Medium Grid 2 Accent 4", UiPriority = 68, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo235 = new LatentStyleExceptionInfo() { Name = "Medium Grid 3 Accent 4", UiPriority = 69, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo236 = new LatentStyleExceptionInfo() { Name = "Dark List Accent 4", UiPriority = 70, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo237 = new LatentStyleExceptionInfo() { Name = "Colorful Shading Accent 4", UiPriority = 71, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo238 = new LatentStyleExceptionInfo() { Name = "Colorful List Accent 4", UiPriority = 72, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo239 = new LatentStyleExceptionInfo() { Name = "Colorful Grid Accent 4", UiPriority = 73, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo240 = new LatentStyleExceptionInfo() { Name = "Light Shading Accent 5", UiPriority = 60, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo241 = new LatentStyleExceptionInfo() { Name = "Light List Accent 5", UiPriority = 61, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo242 = new LatentStyleExceptionInfo() { Name = "Light Grid Accent 5", UiPriority = 62, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo243 = new LatentStyleExceptionInfo() { Name = "Medium Shading 1 Accent 5", UiPriority = 63, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo244 = new LatentStyleExceptionInfo() { Name = "Medium Shading 2 Accent 5", UiPriority = 64, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo245 = new LatentStyleExceptionInfo() { Name = "Medium List 1 Accent 5", UiPriority = 65, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo246 = new LatentStyleExceptionInfo() { Name = "Medium List 2 Accent 5", UiPriority = 66, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo247 = new LatentStyleExceptionInfo() { Name = "Medium Grid 1 Accent 5", UiPriority = 67, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo248 = new LatentStyleExceptionInfo() { Name = "Medium Grid 2 Accent 5", UiPriority = 68, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo249 = new LatentStyleExceptionInfo() { Name = "Medium Grid 3 Accent 5", UiPriority = 69, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo250 = new LatentStyleExceptionInfo() { Name = "Dark List Accent 5", UiPriority = 70, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo251 = new LatentStyleExceptionInfo() { Name = "Colorful Shading Accent 5", UiPriority = 71, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo252 = new LatentStyleExceptionInfo() { Name = "Colorful List Accent 5", UiPriority = 72, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo253 = new LatentStyleExceptionInfo() { Name = "Colorful Grid Accent 5", UiPriority = 73, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo254 = new LatentStyleExceptionInfo() { Name = "Light Shading Accent 6", UiPriority = 60, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo255 = new LatentStyleExceptionInfo() { Name = "Light List Accent 6", UiPriority = 61, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo256 = new LatentStyleExceptionInfo() { Name = "Light Grid Accent 6", UiPriority = 62, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo257 = new LatentStyleExceptionInfo() { Name = "Medium Shading 1 Accent 6", UiPriority = 63, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo258 = new LatentStyleExceptionInfo() { Name = "Medium Shading 2 Accent 6", UiPriority = 64, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo259 = new LatentStyleExceptionInfo() { Name = "Medium List 1 Accent 6", UiPriority = 65, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo260 = new LatentStyleExceptionInfo() { Name = "Medium List 2 Accent 6", UiPriority = 66, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo261 = new LatentStyleExceptionInfo() { Name = "Medium Grid 1 Accent 6", UiPriority = 67, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo262 = new LatentStyleExceptionInfo() { Name = "Medium Grid 2 Accent 6", UiPriority = 68, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo263 = new LatentStyleExceptionInfo() { Name = "Medium Grid 3 Accent 6", UiPriority = 69, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo264 = new LatentStyleExceptionInfo() { Name = "Dark List Accent 6", UiPriority = 70, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo265 = new LatentStyleExceptionInfo() { Name = "Colorful Shading Accent 6", UiPriority = 71, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo266 = new LatentStyleExceptionInfo() { Name = "Colorful List Accent 6", UiPriority = 72, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo267 = new LatentStyleExceptionInfo() { Name = "Colorful Grid Accent 6", UiPriority = 73, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo268 = new LatentStyleExceptionInfo() { Name = "Subtle Emphasis", UiPriority = 19, SemiHidden = false, UnhideWhenUsed = false, PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo269 = new LatentStyleExceptionInfo() { Name = "Intense Emphasis", UiPriority = 21, SemiHidden = false, UnhideWhenUsed = false, PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo270 = new LatentStyleExceptionInfo() { Name = "Subtle Reference", UiPriority = 31, SemiHidden = false, UnhideWhenUsed = false, PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo271 = new LatentStyleExceptionInfo() { Name = "Intense Reference", UiPriority = 32, SemiHidden = false, UnhideWhenUsed = false, PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo272 = new LatentStyleExceptionInfo() { Name = "Book Title", UiPriority = 33, SemiHidden = false, UnhideWhenUsed = false, PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo273 = new LatentStyleExceptionInfo() { Name = "Bibliography", UiPriority = 37 };
            LatentStyleExceptionInfo latentStyleExceptionInfo274 = new LatentStyleExceptionInfo() { Name = "TOC Heading", UiPriority = 39, PrimaryStyle = true };

            latentStyles2.Append(latentStyleExceptionInfo138);
            latentStyles2.Append(latentStyleExceptionInfo139);
            latentStyles2.Append(latentStyleExceptionInfo140);
            latentStyles2.Append(latentStyleExceptionInfo141);
            latentStyles2.Append(latentStyleExceptionInfo142);
            latentStyles2.Append(latentStyleExceptionInfo143);
            latentStyles2.Append(latentStyleExceptionInfo144);
            latentStyles2.Append(latentStyleExceptionInfo145);
            latentStyles2.Append(latentStyleExceptionInfo146);
            latentStyles2.Append(latentStyleExceptionInfo147);
            latentStyles2.Append(latentStyleExceptionInfo148);
            latentStyles2.Append(latentStyleExceptionInfo149);
            latentStyles2.Append(latentStyleExceptionInfo150);
            latentStyles2.Append(latentStyleExceptionInfo151);
            latentStyles2.Append(latentStyleExceptionInfo152);
            latentStyles2.Append(latentStyleExceptionInfo153);
            latentStyles2.Append(latentStyleExceptionInfo154);
            latentStyles2.Append(latentStyleExceptionInfo155);
            latentStyles2.Append(latentStyleExceptionInfo156);
            latentStyles2.Append(latentStyleExceptionInfo157);
            latentStyles2.Append(latentStyleExceptionInfo158);
            latentStyles2.Append(latentStyleExceptionInfo159);
            latentStyles2.Append(latentStyleExceptionInfo160);
            latentStyles2.Append(latentStyleExceptionInfo161);
            latentStyles2.Append(latentStyleExceptionInfo162);
            latentStyles2.Append(latentStyleExceptionInfo163);
            latentStyles2.Append(latentStyleExceptionInfo164);
            latentStyles2.Append(latentStyleExceptionInfo165);
            latentStyles2.Append(latentStyleExceptionInfo166);
            latentStyles2.Append(latentStyleExceptionInfo167);
            latentStyles2.Append(latentStyleExceptionInfo168);
            latentStyles2.Append(latentStyleExceptionInfo169);
            latentStyles2.Append(latentStyleExceptionInfo170);
            latentStyles2.Append(latentStyleExceptionInfo171);
            latentStyles2.Append(latentStyleExceptionInfo172);
            latentStyles2.Append(latentStyleExceptionInfo173);
            latentStyles2.Append(latentStyleExceptionInfo174);
            latentStyles2.Append(latentStyleExceptionInfo175);
            latentStyles2.Append(latentStyleExceptionInfo176);
            latentStyles2.Append(latentStyleExceptionInfo177);
            latentStyles2.Append(latentStyleExceptionInfo178);
            latentStyles2.Append(latentStyleExceptionInfo179);
            latentStyles2.Append(latentStyleExceptionInfo180);
            latentStyles2.Append(latentStyleExceptionInfo181);
            latentStyles2.Append(latentStyleExceptionInfo182);
            latentStyles2.Append(latentStyleExceptionInfo183);
            latentStyles2.Append(latentStyleExceptionInfo184);
            latentStyles2.Append(latentStyleExceptionInfo185);
            latentStyles2.Append(latentStyleExceptionInfo186);
            latentStyles2.Append(latentStyleExceptionInfo187);
            latentStyles2.Append(latentStyleExceptionInfo188);
            latentStyles2.Append(latentStyleExceptionInfo189);
            latentStyles2.Append(latentStyleExceptionInfo190);
            latentStyles2.Append(latentStyleExceptionInfo191);
            latentStyles2.Append(latentStyleExceptionInfo192);
            latentStyles2.Append(latentStyleExceptionInfo193);
            latentStyles2.Append(latentStyleExceptionInfo194);
            latentStyles2.Append(latentStyleExceptionInfo195);
            latentStyles2.Append(latentStyleExceptionInfo196);
            latentStyles2.Append(latentStyleExceptionInfo197);
            latentStyles2.Append(latentStyleExceptionInfo198);
            latentStyles2.Append(latentStyleExceptionInfo199);
            latentStyles2.Append(latentStyleExceptionInfo200);
            latentStyles2.Append(latentStyleExceptionInfo201);
            latentStyles2.Append(latentStyleExceptionInfo202);
            latentStyles2.Append(latentStyleExceptionInfo203);
            latentStyles2.Append(latentStyleExceptionInfo204);
            latentStyles2.Append(latentStyleExceptionInfo205);
            latentStyles2.Append(latentStyleExceptionInfo206);
            latentStyles2.Append(latentStyleExceptionInfo207);
            latentStyles2.Append(latentStyleExceptionInfo208);
            latentStyles2.Append(latentStyleExceptionInfo209);
            latentStyles2.Append(latentStyleExceptionInfo210);
            latentStyles2.Append(latentStyleExceptionInfo211);
            latentStyles2.Append(latentStyleExceptionInfo212);
            latentStyles2.Append(latentStyleExceptionInfo213);
            latentStyles2.Append(latentStyleExceptionInfo214);
            latentStyles2.Append(latentStyleExceptionInfo215);
            latentStyles2.Append(latentStyleExceptionInfo216);
            latentStyles2.Append(latentStyleExceptionInfo217);
            latentStyles2.Append(latentStyleExceptionInfo218);
            latentStyles2.Append(latentStyleExceptionInfo219);
            latentStyles2.Append(latentStyleExceptionInfo220);
            latentStyles2.Append(latentStyleExceptionInfo221);
            latentStyles2.Append(latentStyleExceptionInfo222);
            latentStyles2.Append(latentStyleExceptionInfo223);
            latentStyles2.Append(latentStyleExceptionInfo224);
            latentStyles2.Append(latentStyleExceptionInfo225);
            latentStyles2.Append(latentStyleExceptionInfo226);
            latentStyles2.Append(latentStyleExceptionInfo227);
            latentStyles2.Append(latentStyleExceptionInfo228);
            latentStyles2.Append(latentStyleExceptionInfo229);
            latentStyles2.Append(latentStyleExceptionInfo230);
            latentStyles2.Append(latentStyleExceptionInfo231);
            latentStyles2.Append(latentStyleExceptionInfo232);
            latentStyles2.Append(latentStyleExceptionInfo233);
            latentStyles2.Append(latentStyleExceptionInfo234);
            latentStyles2.Append(latentStyleExceptionInfo235);
            latentStyles2.Append(latentStyleExceptionInfo236);
            latentStyles2.Append(latentStyleExceptionInfo237);
            latentStyles2.Append(latentStyleExceptionInfo238);
            latentStyles2.Append(latentStyleExceptionInfo239);
            latentStyles2.Append(latentStyleExceptionInfo240);
            latentStyles2.Append(latentStyleExceptionInfo241);
            latentStyles2.Append(latentStyleExceptionInfo242);
            latentStyles2.Append(latentStyleExceptionInfo243);
            latentStyles2.Append(latentStyleExceptionInfo244);
            latentStyles2.Append(latentStyleExceptionInfo245);
            latentStyles2.Append(latentStyleExceptionInfo246);
            latentStyles2.Append(latentStyleExceptionInfo247);
            latentStyles2.Append(latentStyleExceptionInfo248);
            latentStyles2.Append(latentStyleExceptionInfo249);
            latentStyles2.Append(latentStyleExceptionInfo250);
            latentStyles2.Append(latentStyleExceptionInfo251);
            latentStyles2.Append(latentStyleExceptionInfo252);
            latentStyles2.Append(latentStyleExceptionInfo253);
            latentStyles2.Append(latentStyleExceptionInfo254);
            latentStyles2.Append(latentStyleExceptionInfo255);
            latentStyles2.Append(latentStyleExceptionInfo256);
            latentStyles2.Append(latentStyleExceptionInfo257);
            latentStyles2.Append(latentStyleExceptionInfo258);
            latentStyles2.Append(latentStyleExceptionInfo259);
            latentStyles2.Append(latentStyleExceptionInfo260);
            latentStyles2.Append(latentStyleExceptionInfo261);
            latentStyles2.Append(latentStyleExceptionInfo262);
            latentStyles2.Append(latentStyleExceptionInfo263);
            latentStyles2.Append(latentStyleExceptionInfo264);
            latentStyles2.Append(latentStyleExceptionInfo265);
            latentStyles2.Append(latentStyleExceptionInfo266);
            latentStyles2.Append(latentStyleExceptionInfo267);
            latentStyles2.Append(latentStyleExceptionInfo268);
            latentStyles2.Append(latentStyleExceptionInfo269);
            latentStyles2.Append(latentStyleExceptionInfo270);
            latentStyles2.Append(latentStyleExceptionInfo271);
            latentStyles2.Append(latentStyleExceptionInfo272);
            latentStyles2.Append(latentStyleExceptionInfo273);
            latentStyles2.Append(latentStyleExceptionInfo274);

            Style style6 = new Style() { Type = StyleValues.Paragraph, StyleId = "a", Default = true };
            StyleName styleName6 = new StyleName() { Val = "Normal" };
            PrimaryStyle primaryStyle2 = new PrimaryStyle();
            Rsid rsid8 = new Rsid() { Val = "00900A10" };

            StyleRunProperties styleRunProperties2 = new StyleRunProperties();
            RunFonts runFonts114 = new RunFonts() { EastAsiaTheme = ThemeFontValues.MinorEastAsia };
            Languages languages4 = new Languages() { EastAsia = "ru-RU" };

            styleRunProperties2.Append(runFonts114);
            styleRunProperties2.Append(languages4);

            style6.Append(styleName6);
            style6.Append(primaryStyle2);
            style6.Append(rsid8);
            style6.Append(styleRunProperties2);

            Style style7 = new Style() { Type = StyleValues.Character, StyleId = "a0", Default = true };
            StyleName styleName7 = new StyleName() { Val = "Default Paragraph Font" };
            UIPriority uIPriority5 = new UIPriority() { Val = 1 };
            SemiHidden semiHidden4 = new SemiHidden();
            UnhideWhenUsed unhideWhenUsed4 = new UnhideWhenUsed();

            style7.Append(styleName7);
            style7.Append(uIPriority5);
            style7.Append(semiHidden4);
            style7.Append(unhideWhenUsed4);

            Style style8 = new Style() { Type = StyleValues.Table, StyleId = "a1", Default = true };
            StyleName styleName8 = new StyleName() { Val = "Normal Table" };
            UIPriority uIPriority6 = new UIPriority() { Val = 99 };
            SemiHidden semiHidden5 = new SemiHidden();
            UnhideWhenUsed unhideWhenUsed5 = new UnhideWhenUsed();

            StyleTableProperties styleTableProperties3 = new StyleTableProperties();
            TableIndentation tableIndentation6 = new TableIndentation() { Width = 0, Type = TableWidthUnitValues.Dxa };

            TableCellMarginDefault tableCellMarginDefault6 = new TableCellMarginDefault();
            TopMargin topMargin3 = new TopMargin() { Width = "0", Type = TableWidthUnitValues.Dxa };
            TableCellLeftMargin tableCellLeftMargin6 = new TableCellLeftMargin() { Width = 108, Type = TableWidthValues.Dxa };
            BottomMargin bottomMargin3 = new BottomMargin() { Width = "0", Type = TableWidthUnitValues.Dxa };
            TableCellRightMargin tableCellRightMargin6 = new TableCellRightMargin() { Width = 108, Type = TableWidthValues.Dxa };

            tableCellMarginDefault6.Append(topMargin3);
            tableCellMarginDefault6.Append(tableCellLeftMargin6);
            tableCellMarginDefault6.Append(bottomMargin3);
            tableCellMarginDefault6.Append(tableCellRightMargin6);

            styleTableProperties3.Append(tableIndentation6);
            styleTableProperties3.Append(tableCellMarginDefault6);

            style8.Append(styleName8);
            style8.Append(uIPriority6);
            style8.Append(semiHidden5);
            style8.Append(unhideWhenUsed5);
            style8.Append(styleTableProperties3);

            Style style9 = new Style() { Type = StyleValues.Numbering, StyleId = "a2", Default = true };
            StyleName styleName9 = new StyleName() { Val = "No List" };
            UIPriority uIPriority7 = new UIPriority() { Val = 99 };
            SemiHidden semiHidden6 = new SemiHidden();
            UnhideWhenUsed unhideWhenUsed6 = new UnhideWhenUsed();

            style9.Append(styleName9);
            style9.Append(uIPriority7);
            style9.Append(semiHidden6);
            style9.Append(unhideWhenUsed6);

            Style style10 = new Style() { Type = StyleValues.Table, StyleId = "a3" };
            StyleName styleName10 = new StyleName() { Val = "Table Grid" };
            BasedOn basedOn2 = new BasedOn() { Val = "a1" };
            UIPriority uIPriority8 = new UIPriority() { Val = 59 };
            Rsid rsid9 = new Rsid() { Val = "00D60978" };

            StyleParagraphProperties styleParagraphProperties2 = new StyleParagraphProperties();
            SpacingBetweenLines spacingBetweenLines42 = new SpacingBetweenLines() { After = "0", Line = "240", LineRule = LineSpacingRuleValues.Auto };

            styleParagraphProperties2.Append(spacingBetweenLines42);

            StyleTableProperties styleTableProperties4 = new StyleTableProperties();
            TableIndentation tableIndentation7 = new TableIndentation() { Width = 0, Type = TableWidthUnitValues.Dxa };

            TableBorders tableBorders3 = new TableBorders();
            TopBorder topBorder20 = new TopBorder() { Val = BorderValues.Single, Color = "auto", Size = (UInt32Value)4U, Space = (UInt32Value)0U };
            LeftBorder leftBorder19 = new LeftBorder() { Val = BorderValues.Single, Color = "auto", Size = (UInt32Value)4U, Space = (UInt32Value)0U };
            BottomBorder bottomBorder19 = new BottomBorder() { Val = BorderValues.Single, Color = "auto", Size = (UInt32Value)4U, Space = (UInt32Value)0U };
            RightBorder rightBorder19 = new RightBorder() { Val = BorderValues.Single, Color = "auto", Size = (UInt32Value)4U, Space = (UInt32Value)0U };
            InsideHorizontalBorder insideHorizontalBorder3 = new InsideHorizontalBorder() { Val = BorderValues.Single, Color = "auto", Size = (UInt32Value)4U, Space = (UInt32Value)0U };
            InsideVerticalBorder insideVerticalBorder3 = new InsideVerticalBorder() { Val = BorderValues.Single, Color = "auto", Size = (UInt32Value)4U, Space = (UInt32Value)0U };

            tableBorders3.Append(topBorder20);
            tableBorders3.Append(leftBorder19);
            tableBorders3.Append(bottomBorder19);
            tableBorders3.Append(rightBorder19);
            tableBorders3.Append(insideHorizontalBorder3);
            tableBorders3.Append(insideVerticalBorder3);

            TableCellMarginDefault tableCellMarginDefault7 = new TableCellMarginDefault();
            TopMargin topMargin4 = new TopMargin() { Width = "0", Type = TableWidthUnitValues.Dxa };
            TableCellLeftMargin tableCellLeftMargin7 = new TableCellLeftMargin() { Width = 108, Type = TableWidthValues.Dxa };
            BottomMargin bottomMargin4 = new BottomMargin() { Width = "0", Type = TableWidthUnitValues.Dxa };
            TableCellRightMargin tableCellRightMargin7 = new TableCellRightMargin() { Width = 108, Type = TableWidthValues.Dxa };

            tableCellMarginDefault7.Append(topMargin4);
            tableCellMarginDefault7.Append(tableCellLeftMargin7);
            tableCellMarginDefault7.Append(bottomMargin4);
            tableCellMarginDefault7.Append(tableCellRightMargin7);

            styleTableProperties4.Append(tableIndentation7);
            styleTableProperties4.Append(tableBorders3);
            styleTableProperties4.Append(tableCellMarginDefault7);

            style10.Append(styleName10);
            style10.Append(basedOn2);
            style10.Append(uIPriority8);
            style10.Append(rsid9);
            style10.Append(styleParagraphProperties2);
            style10.Append(styleTableProperties4);

            styles2.Append(docDefaults2);
            styles2.Append(latentStyles2);
            styles2.Append(style6);
            styles2.Append(style7);
            styles2.Append(style8);
            styles2.Append(style9);
            styles2.Append(style10);

            styleDefinitionsPart1.Styles = styles2;
        }

        // Generates content of endnotesPart1.
        private void GenerateEndnotesPart1Content(EndnotesPart endnotesPart1)
        {
            Endnotes endnotes1 = new Endnotes() { MCAttributes = new MarkupCompatibilityAttributes() { Ignorable = "w14 wp14" } };
            endnotes1.AddNamespaceDeclaration("wpc", "http://schemas.microsoft.com/office/word/2010/wordprocessingCanvas");
            endnotes1.AddNamespaceDeclaration("mc", "http://schemas.openxmlformats.org/markup-compatibility/2006");
            endnotes1.AddNamespaceDeclaration("o", "urn:schemas-microsoft-com:office:office");
            endnotes1.AddNamespaceDeclaration("r", "http://schemas.openxmlformats.org/officeDocument/2006/relationships");
            endnotes1.AddNamespaceDeclaration("m", "http://schemas.openxmlformats.org/officeDocument/2006/math");
            endnotes1.AddNamespaceDeclaration("v", "urn:schemas-microsoft-com:vml");
            endnotes1.AddNamespaceDeclaration("wp14", "http://schemas.microsoft.com/office/word/2010/wordprocessingDrawing");
            endnotes1.AddNamespaceDeclaration("wp", "http://schemas.openxmlformats.org/drawingml/2006/wordprocessingDrawing");
            endnotes1.AddNamespaceDeclaration("w10", "urn:schemas-microsoft-com:office:word");
            endnotes1.AddNamespaceDeclaration("w", "http://schemas.openxmlformats.org/wordprocessingml/2006/main");
            endnotes1.AddNamespaceDeclaration("w14", "http://schemas.microsoft.com/office/word/2010/wordml");
            endnotes1.AddNamespaceDeclaration("wpg", "http://schemas.microsoft.com/office/word/2010/wordprocessingGroup");
            endnotes1.AddNamespaceDeclaration("wpi", "http://schemas.microsoft.com/office/word/2010/wordprocessingInk");
            endnotes1.AddNamespaceDeclaration("wne", "http://schemas.microsoft.com/office/word/2006/wordml");
            endnotes1.AddNamespaceDeclaration("wps", "http://schemas.microsoft.com/office/word/2010/wordprocessingShape");

            Endnote endnote1 = new Endnote() { Type = FootnoteEndnoteValues.Separator, Id = -1 };

            Paragraph paragraph55 = new Paragraph() { RsidParagraphAddition = "00571FC0", RsidRunAdditionDefault = "00571FC0" };

            ParagraphProperties paragraphProperties53 = new ParagraphProperties();
            SpacingBetweenLines spacingBetweenLines43 = new SpacingBetweenLines() { After = "0", Line = "240", LineRule = LineSpacingRuleValues.Auto };

            paragraphProperties53.Append(spacingBetweenLines43);

            Run run59 = new Run();
            SeparatorMark separatorMark1 = new SeparatorMark();

            run59.Append(separatorMark1);

            paragraph55.Append(paragraphProperties53);
            paragraph55.Append(run59);

            endnote1.Append(paragraph55);

            Endnote endnote2 = new Endnote() { Type = FootnoteEndnoteValues.ContinuationSeparator, Id = 0 };

            Paragraph paragraph56 = new Paragraph() { RsidParagraphAddition = "00571FC0", RsidRunAdditionDefault = "00571FC0" };

            ParagraphProperties paragraphProperties54 = new ParagraphProperties();
            SpacingBetweenLines spacingBetweenLines44 = new SpacingBetweenLines() { After = "0", Line = "240", LineRule = LineSpacingRuleValues.Auto };

            paragraphProperties54.Append(spacingBetweenLines44);

            Run run60 = new Run();
            ContinuationSeparatorMark continuationSeparatorMark1 = new ContinuationSeparatorMark();

            run60.Append(continuationSeparatorMark1);

            paragraph56.Append(paragraphProperties54);
            paragraph56.Append(run60);

            endnote2.Append(paragraph56);

            endnotes1.Append(endnote1);
            endnotes1.Append(endnote2);

            endnotesPart1.Endnotes = endnotes1;
        }

        // Generates content of footnotesPart1.
        private void GenerateFootnotesPart1Content(FootnotesPart footnotesPart1)
        {
            Footnotes footnotes1 = new Footnotes() { MCAttributes = new MarkupCompatibilityAttributes() { Ignorable = "w14 wp14" } };
            footnotes1.AddNamespaceDeclaration("wpc", "http://schemas.microsoft.com/office/word/2010/wordprocessingCanvas");
            footnotes1.AddNamespaceDeclaration("mc", "http://schemas.openxmlformats.org/markup-compatibility/2006");
            footnotes1.AddNamespaceDeclaration("o", "urn:schemas-microsoft-com:office:office");
            footnotes1.AddNamespaceDeclaration("r", "http://schemas.openxmlformats.org/officeDocument/2006/relationships");
            footnotes1.AddNamespaceDeclaration("m", "http://schemas.openxmlformats.org/officeDocument/2006/math");
            footnotes1.AddNamespaceDeclaration("v", "urn:schemas-microsoft-com:vml");
            footnotes1.AddNamespaceDeclaration("wp14", "http://schemas.microsoft.com/office/word/2010/wordprocessingDrawing");
            footnotes1.AddNamespaceDeclaration("wp", "http://schemas.openxmlformats.org/drawingml/2006/wordprocessingDrawing");
            footnotes1.AddNamespaceDeclaration("w10", "urn:schemas-microsoft-com:office:word");
            footnotes1.AddNamespaceDeclaration("w", "http://schemas.openxmlformats.org/wordprocessingml/2006/main");
            footnotes1.AddNamespaceDeclaration("w14", "http://schemas.microsoft.com/office/word/2010/wordml");
            footnotes1.AddNamespaceDeclaration("wpg", "http://schemas.microsoft.com/office/word/2010/wordprocessingGroup");
            footnotes1.AddNamespaceDeclaration("wpi", "http://schemas.microsoft.com/office/word/2010/wordprocessingInk");
            footnotes1.AddNamespaceDeclaration("wne", "http://schemas.microsoft.com/office/word/2006/wordml");
            footnotes1.AddNamespaceDeclaration("wps", "http://schemas.microsoft.com/office/word/2010/wordprocessingShape");

            Footnote footnote1 = new Footnote() { Type = FootnoteEndnoteValues.Separator, Id = -1 };

            Paragraph paragraph57 = new Paragraph() { RsidParagraphAddition = "00571FC0", RsidRunAdditionDefault = "00571FC0" };

            ParagraphProperties paragraphProperties55 = new ParagraphProperties();
            SpacingBetweenLines spacingBetweenLines45 = new SpacingBetweenLines() { After = "0", Line = "240", LineRule = LineSpacingRuleValues.Auto };

            paragraphProperties55.Append(spacingBetweenLines45);

            Run run61 = new Run();
            SeparatorMark separatorMark2 = new SeparatorMark();

            run61.Append(separatorMark2);

            paragraph57.Append(paragraphProperties55);
            paragraph57.Append(run61);

            footnote1.Append(paragraph57);

            Footnote footnote2 = new Footnote() { Type = FootnoteEndnoteValues.ContinuationSeparator, Id = 0 };

            Paragraph paragraph58 = new Paragraph() { RsidParagraphAddition = "00571FC0", RsidRunAdditionDefault = "00571FC0" };

            ParagraphProperties paragraphProperties56 = new ParagraphProperties();
            SpacingBetweenLines spacingBetweenLines46 = new SpacingBetweenLines() { After = "0", Line = "240", LineRule = LineSpacingRuleValues.Auto };

            paragraphProperties56.Append(spacingBetweenLines46);

            Run run62 = new Run();
            ContinuationSeparatorMark continuationSeparatorMark2 = new ContinuationSeparatorMark();

            run62.Append(continuationSeparatorMark2);

            paragraph58.Append(paragraphProperties56);
            paragraph58.Append(run62);

            footnote2.Append(paragraph58);

            footnotes1.Append(footnote1);
            footnotes1.Append(footnote2);

            footnotesPart1.Footnotes = footnotes1;
        }

        // Generates content of themePart1.
        private void GenerateThemePart1Content(ThemePart themePart1)
        {
            A.Theme theme1 = new A.Theme() { Name = "Тема Office" };
            theme1.AddNamespaceDeclaration("a", "http://schemas.openxmlformats.org/drawingml/2006/main");

            A.ThemeElements themeElements1 = new A.ThemeElements();

            A.ColorScheme colorScheme1 = new A.ColorScheme() { Name = "Стандартная" };

            A.Dark1Color dark1Color1 = new A.Dark1Color();
            A.SystemColor systemColor1 = new A.SystemColor() { Val = A.SystemColorValues.WindowText, LastColor = "000000" };

            dark1Color1.Append(systemColor1);

            A.Light1Color light1Color1 = new A.Light1Color();
            A.SystemColor systemColor2 = new A.SystemColor() { Val = A.SystemColorValues.Window, LastColor = "FFFFFF" };

            light1Color1.Append(systemColor2);

            A.Dark2Color dark2Color1 = new A.Dark2Color();
            A.RgbColorModelHex rgbColorModelHex1 = new A.RgbColorModelHex() { Val = "1F497D" };

            dark2Color1.Append(rgbColorModelHex1);

            A.Light2Color light2Color1 = new A.Light2Color();
            A.RgbColorModelHex rgbColorModelHex2 = new A.RgbColorModelHex() { Val = "EEECE1" };

            light2Color1.Append(rgbColorModelHex2);

            A.Accent1Color accent1Color1 = new A.Accent1Color();
            A.RgbColorModelHex rgbColorModelHex3 = new A.RgbColorModelHex() { Val = "4F81BD" };

            accent1Color1.Append(rgbColorModelHex3);

            A.Accent2Color accent2Color1 = new A.Accent2Color();
            A.RgbColorModelHex rgbColorModelHex4 = new A.RgbColorModelHex() { Val = "C0504D" };

            accent2Color1.Append(rgbColorModelHex4);

            A.Accent3Color accent3Color1 = new A.Accent3Color();
            A.RgbColorModelHex rgbColorModelHex5 = new A.RgbColorModelHex() { Val = "9BBB59" };

            accent3Color1.Append(rgbColorModelHex5);

            A.Accent4Color accent4Color1 = new A.Accent4Color();
            A.RgbColorModelHex rgbColorModelHex6 = new A.RgbColorModelHex() { Val = "8064A2" };

            accent4Color1.Append(rgbColorModelHex6);

            A.Accent5Color accent5Color1 = new A.Accent5Color();
            A.RgbColorModelHex rgbColorModelHex7 = new A.RgbColorModelHex() { Val = "4BACC6" };

            accent5Color1.Append(rgbColorModelHex7);

            A.Accent6Color accent6Color1 = new A.Accent6Color();
            A.RgbColorModelHex rgbColorModelHex8 = new A.RgbColorModelHex() { Val = "F79646" };

            accent6Color1.Append(rgbColorModelHex8);

            A.Hyperlink hyperlink1 = new A.Hyperlink();
            A.RgbColorModelHex rgbColorModelHex9 = new A.RgbColorModelHex() { Val = "0000FF" };

            hyperlink1.Append(rgbColorModelHex9);

            A.FollowedHyperlinkColor followedHyperlinkColor1 = new A.FollowedHyperlinkColor();
            A.RgbColorModelHex rgbColorModelHex10 = new A.RgbColorModelHex() { Val = "800080" };

            followedHyperlinkColor1.Append(rgbColorModelHex10);

            colorScheme1.Append(dark1Color1);
            colorScheme1.Append(light1Color1);
            colorScheme1.Append(dark2Color1);
            colorScheme1.Append(light2Color1);
            colorScheme1.Append(accent1Color1);
            colorScheme1.Append(accent2Color1);
            colorScheme1.Append(accent3Color1);
            colorScheme1.Append(accent4Color1);
            colorScheme1.Append(accent5Color1);
            colorScheme1.Append(accent6Color1);
            colorScheme1.Append(hyperlink1);
            colorScheme1.Append(followedHyperlinkColor1);

            A.FontScheme fontScheme1 = new A.FontScheme() { Name = "Стандартная" };

            A.MajorFont majorFont1 = new A.MajorFont();
            A.LatinFont latinFont1 = new A.LatinFont() { Typeface = "Cambria" };
            A.EastAsianFont eastAsianFont1 = new A.EastAsianFont() { Typeface = "" };
            A.ComplexScriptFont complexScriptFont1 = new A.ComplexScriptFont() { Typeface = "" };
            A.SupplementalFont supplementalFont1 = new A.SupplementalFont() { Script = "Jpan", Typeface = "ＭＳ ゴシック" };
            A.SupplementalFont supplementalFont2 = new A.SupplementalFont() { Script = "Hang", Typeface = "맑은 고딕" };
            A.SupplementalFont supplementalFont3 = new A.SupplementalFont() { Script = "Hans", Typeface = "宋体" };
            A.SupplementalFont supplementalFont4 = new A.SupplementalFont() { Script = "Hant", Typeface = "新細明體" };
            A.SupplementalFont supplementalFont5 = new A.SupplementalFont() { Script = "Arab", Typeface = "Times New Roman" };
            A.SupplementalFont supplementalFont6 = new A.SupplementalFont() { Script = "Hebr", Typeface = "Times New Roman" };
            A.SupplementalFont supplementalFont7 = new A.SupplementalFont() { Script = "Thai", Typeface = "Angsana New" };
            A.SupplementalFont supplementalFont8 = new A.SupplementalFont() { Script = "Ethi", Typeface = "Nyala" };
            A.SupplementalFont supplementalFont9 = new A.SupplementalFont() { Script = "Beng", Typeface = "Vrinda" };
            A.SupplementalFont supplementalFont10 = new A.SupplementalFont() { Script = "Gujr", Typeface = "Shruti" };
            A.SupplementalFont supplementalFont11 = new A.SupplementalFont() { Script = "Khmr", Typeface = "MoolBoran" };
            A.SupplementalFont supplementalFont12 = new A.SupplementalFont() { Script = "Knda", Typeface = "Tunga" };
            A.SupplementalFont supplementalFont13 = new A.SupplementalFont() { Script = "Guru", Typeface = "Raavi" };
            A.SupplementalFont supplementalFont14 = new A.SupplementalFont() { Script = "Cans", Typeface = "Euphemia" };
            A.SupplementalFont supplementalFont15 = new A.SupplementalFont() { Script = "Cher", Typeface = "Plantagenet Cherokee" };
            A.SupplementalFont supplementalFont16 = new A.SupplementalFont() { Script = "Yiii", Typeface = "Microsoft Yi Baiti" };
            A.SupplementalFont supplementalFont17 = new A.SupplementalFont() { Script = "Tibt", Typeface = "Microsoft Himalaya" };
            A.SupplementalFont supplementalFont18 = new A.SupplementalFont() { Script = "Thaa", Typeface = "MV Boli" };
            A.SupplementalFont supplementalFont19 = new A.SupplementalFont() { Script = "Deva", Typeface = "Mangal" };
            A.SupplementalFont supplementalFont20 = new A.SupplementalFont() { Script = "Telu", Typeface = "Gautami" };
            A.SupplementalFont supplementalFont21 = new A.SupplementalFont() { Script = "Taml", Typeface = "Latha" };
            A.SupplementalFont supplementalFont22 = new A.SupplementalFont() { Script = "Syrc", Typeface = "Estrangelo Edessa" };
            A.SupplementalFont supplementalFont23 = new A.SupplementalFont() { Script = "Orya", Typeface = "Kalinga" };
            A.SupplementalFont supplementalFont24 = new A.SupplementalFont() { Script = "Mlym", Typeface = "Kartika" };
            A.SupplementalFont supplementalFont25 = new A.SupplementalFont() { Script = "Laoo", Typeface = "DokChampa" };
            A.SupplementalFont supplementalFont26 = new A.SupplementalFont() { Script = "Sinh", Typeface = "Iskoola Pota" };
            A.SupplementalFont supplementalFont27 = new A.SupplementalFont() { Script = "Mong", Typeface = "Mongolian Baiti" };
            A.SupplementalFont supplementalFont28 = new A.SupplementalFont() { Script = "Viet", Typeface = "Times New Roman" };
            A.SupplementalFont supplementalFont29 = new A.SupplementalFont() { Script = "Uigh", Typeface = "Microsoft Uighur" };
            A.SupplementalFont supplementalFont30 = new A.SupplementalFont() { Script = "Geor", Typeface = "Sylfaen" };

            majorFont1.Append(latinFont1);
            majorFont1.Append(eastAsianFont1);
            majorFont1.Append(complexScriptFont1);
            majorFont1.Append(supplementalFont1);
            majorFont1.Append(supplementalFont2);
            majorFont1.Append(supplementalFont3);
            majorFont1.Append(supplementalFont4);
            majorFont1.Append(supplementalFont5);
            majorFont1.Append(supplementalFont6);
            majorFont1.Append(supplementalFont7);
            majorFont1.Append(supplementalFont8);
            majorFont1.Append(supplementalFont9);
            majorFont1.Append(supplementalFont10);
            majorFont1.Append(supplementalFont11);
            majorFont1.Append(supplementalFont12);
            majorFont1.Append(supplementalFont13);
            majorFont1.Append(supplementalFont14);
            majorFont1.Append(supplementalFont15);
            majorFont1.Append(supplementalFont16);
            majorFont1.Append(supplementalFont17);
            majorFont1.Append(supplementalFont18);
            majorFont1.Append(supplementalFont19);
            majorFont1.Append(supplementalFont20);
            majorFont1.Append(supplementalFont21);
            majorFont1.Append(supplementalFont22);
            majorFont1.Append(supplementalFont23);
            majorFont1.Append(supplementalFont24);
            majorFont1.Append(supplementalFont25);
            majorFont1.Append(supplementalFont26);
            majorFont1.Append(supplementalFont27);
            majorFont1.Append(supplementalFont28);
            majorFont1.Append(supplementalFont29);
            majorFont1.Append(supplementalFont30);

            A.MinorFont minorFont1 = new A.MinorFont();
            A.LatinFont latinFont2 = new A.LatinFont() { Typeface = "Calibri" };
            A.EastAsianFont eastAsianFont2 = new A.EastAsianFont() { Typeface = "" };
            A.ComplexScriptFont complexScriptFont2 = new A.ComplexScriptFont() { Typeface = "" };
            A.SupplementalFont supplementalFont31 = new A.SupplementalFont() { Script = "Jpan", Typeface = "ＭＳ 明朝" };
            A.SupplementalFont supplementalFont32 = new A.SupplementalFont() { Script = "Hang", Typeface = "맑은 고딕" };
            A.SupplementalFont supplementalFont33 = new A.SupplementalFont() { Script = "Hans", Typeface = "宋体" };
            A.SupplementalFont supplementalFont34 = new A.SupplementalFont() { Script = "Hant", Typeface = "新細明體" };
            A.SupplementalFont supplementalFont35 = new A.SupplementalFont() { Script = "Arab", Typeface = "Arial" };
            A.SupplementalFont supplementalFont36 = new A.SupplementalFont() { Script = "Hebr", Typeface = "Arial" };
            A.SupplementalFont supplementalFont37 = new A.SupplementalFont() { Script = "Thai", Typeface = "Cordia New" };
            A.SupplementalFont supplementalFont38 = new A.SupplementalFont() { Script = "Ethi", Typeface = "Nyala" };
            A.SupplementalFont supplementalFont39 = new A.SupplementalFont() { Script = "Beng", Typeface = "Vrinda" };
            A.SupplementalFont supplementalFont40 = new A.SupplementalFont() { Script = "Gujr", Typeface = "Shruti" };
            A.SupplementalFont supplementalFont41 = new A.SupplementalFont() { Script = "Khmr", Typeface = "DaunPenh" };
            A.SupplementalFont supplementalFont42 = new A.SupplementalFont() { Script = "Knda", Typeface = "Tunga" };
            A.SupplementalFont supplementalFont43 = new A.SupplementalFont() { Script = "Guru", Typeface = "Raavi" };
            A.SupplementalFont supplementalFont44 = new A.SupplementalFont() { Script = "Cans", Typeface = "Euphemia" };
            A.SupplementalFont supplementalFont45 = new A.SupplementalFont() { Script = "Cher", Typeface = "Plantagenet Cherokee" };
            A.SupplementalFont supplementalFont46 = new A.SupplementalFont() { Script = "Yiii", Typeface = "Microsoft Yi Baiti" };
            A.SupplementalFont supplementalFont47 = new A.SupplementalFont() { Script = "Tibt", Typeface = "Microsoft Himalaya" };
            A.SupplementalFont supplementalFont48 = new A.SupplementalFont() { Script = "Thaa", Typeface = "MV Boli" };
            A.SupplementalFont supplementalFont49 = new A.SupplementalFont() { Script = "Deva", Typeface = "Mangal" };
            A.SupplementalFont supplementalFont50 = new A.SupplementalFont() { Script = "Telu", Typeface = "Gautami" };
            A.SupplementalFont supplementalFont51 = new A.SupplementalFont() { Script = "Taml", Typeface = "Latha" };
            A.SupplementalFont supplementalFont52 = new A.SupplementalFont() { Script = "Syrc", Typeface = "Estrangelo Edessa" };
            A.SupplementalFont supplementalFont53 = new A.SupplementalFont() { Script = "Orya", Typeface = "Kalinga" };
            A.SupplementalFont supplementalFont54 = new A.SupplementalFont() { Script = "Mlym", Typeface = "Kartika" };
            A.SupplementalFont supplementalFont55 = new A.SupplementalFont() { Script = "Laoo", Typeface = "DokChampa" };
            A.SupplementalFont supplementalFont56 = new A.SupplementalFont() { Script = "Sinh", Typeface = "Iskoola Pota" };
            A.SupplementalFont supplementalFont57 = new A.SupplementalFont() { Script = "Mong", Typeface = "Mongolian Baiti" };
            A.SupplementalFont supplementalFont58 = new A.SupplementalFont() { Script = "Viet", Typeface = "Arial" };
            A.SupplementalFont supplementalFont59 = new A.SupplementalFont() { Script = "Uigh", Typeface = "Microsoft Uighur" };
            A.SupplementalFont supplementalFont60 = new A.SupplementalFont() { Script = "Geor", Typeface = "Sylfaen" };

            minorFont1.Append(latinFont2);
            minorFont1.Append(eastAsianFont2);
            minorFont1.Append(complexScriptFont2);
            minorFont1.Append(supplementalFont31);
            minorFont1.Append(supplementalFont32);
            minorFont1.Append(supplementalFont33);
            minorFont1.Append(supplementalFont34);
            minorFont1.Append(supplementalFont35);
            minorFont1.Append(supplementalFont36);
            minorFont1.Append(supplementalFont37);
            minorFont1.Append(supplementalFont38);
            minorFont1.Append(supplementalFont39);
            minorFont1.Append(supplementalFont40);
            minorFont1.Append(supplementalFont41);
            minorFont1.Append(supplementalFont42);
            minorFont1.Append(supplementalFont43);
            minorFont1.Append(supplementalFont44);
            minorFont1.Append(supplementalFont45);
            minorFont1.Append(supplementalFont46);
            minorFont1.Append(supplementalFont47);
            minorFont1.Append(supplementalFont48);
            minorFont1.Append(supplementalFont49);
            minorFont1.Append(supplementalFont50);
            minorFont1.Append(supplementalFont51);
            minorFont1.Append(supplementalFont52);
            minorFont1.Append(supplementalFont53);
            minorFont1.Append(supplementalFont54);
            minorFont1.Append(supplementalFont55);
            minorFont1.Append(supplementalFont56);
            minorFont1.Append(supplementalFont57);
            minorFont1.Append(supplementalFont58);
            minorFont1.Append(supplementalFont59);
            minorFont1.Append(supplementalFont60);

            fontScheme1.Append(majorFont1);
            fontScheme1.Append(minorFont1);

            A.FormatScheme formatScheme1 = new A.FormatScheme() { Name = "Стандартная" };

            A.FillStyleList fillStyleList1 = new A.FillStyleList();

            A.SolidFill solidFill1 = new A.SolidFill();
            A.SchemeColor schemeColor1 = new A.SchemeColor() { Val = A.SchemeColorValues.PhColor };

            solidFill1.Append(schemeColor1);

            A.GradientFill gradientFill1 = new A.GradientFill() { RotateWithShape = true };

            A.GradientStopList gradientStopList1 = new A.GradientStopList();

            A.GradientStop gradientStop1 = new A.GradientStop() { Position = 0 };

            A.SchemeColor schemeColor2 = new A.SchemeColor() { Val = A.SchemeColorValues.PhColor };
            A.Tint tint1 = new A.Tint() { Val = 50000 };
            A.SaturationModulation saturationModulation1 = new A.SaturationModulation() { Val = 300000 };

            schemeColor2.Append(tint1);
            schemeColor2.Append(saturationModulation1);

            gradientStop1.Append(schemeColor2);

            A.GradientStop gradientStop2 = new A.GradientStop() { Position = 35000 };

            A.SchemeColor schemeColor3 = new A.SchemeColor() { Val = A.SchemeColorValues.PhColor };
            A.Tint tint2 = new A.Tint() { Val = 37000 };
            A.SaturationModulation saturationModulation2 = new A.SaturationModulation() { Val = 300000 };

            schemeColor3.Append(tint2);
            schemeColor3.Append(saturationModulation2);

            gradientStop2.Append(schemeColor3);

            A.GradientStop gradientStop3 = new A.GradientStop() { Position = 100000 };

            A.SchemeColor schemeColor4 = new A.SchemeColor() { Val = A.SchemeColorValues.PhColor };
            A.Tint tint3 = new A.Tint() { Val = 15000 };
            A.SaturationModulation saturationModulation3 = new A.SaturationModulation() { Val = 350000 };

            schemeColor4.Append(tint3);
            schemeColor4.Append(saturationModulation3);

            gradientStop3.Append(schemeColor4);

            gradientStopList1.Append(gradientStop1);
            gradientStopList1.Append(gradientStop2);
            gradientStopList1.Append(gradientStop3);
            A.LinearGradientFill linearGradientFill1 = new A.LinearGradientFill() { Angle = 16200000, Scaled = true };

            gradientFill1.Append(gradientStopList1);
            gradientFill1.Append(linearGradientFill1);

            A.GradientFill gradientFill2 = new A.GradientFill() { RotateWithShape = true };

            A.GradientStopList gradientStopList2 = new A.GradientStopList();

            A.GradientStop gradientStop4 = new A.GradientStop() { Position = 0 };

            A.SchemeColor schemeColor5 = new A.SchemeColor() { Val = A.SchemeColorValues.PhColor };
            A.Shade shade1 = new A.Shade() { Val = 51000 };
            A.SaturationModulation saturationModulation4 = new A.SaturationModulation() { Val = 130000 };

            schemeColor5.Append(shade1);
            schemeColor5.Append(saturationModulation4);

            gradientStop4.Append(schemeColor5);

            A.GradientStop gradientStop5 = new A.GradientStop() { Position = 80000 };

            A.SchemeColor schemeColor6 = new A.SchemeColor() { Val = A.SchemeColorValues.PhColor };
            A.Shade shade2 = new A.Shade() { Val = 93000 };
            A.SaturationModulation saturationModulation5 = new A.SaturationModulation() { Val = 130000 };

            schemeColor6.Append(shade2);
            schemeColor6.Append(saturationModulation5);

            gradientStop5.Append(schemeColor6);

            A.GradientStop gradientStop6 = new A.GradientStop() { Position = 100000 };

            A.SchemeColor schemeColor7 = new A.SchemeColor() { Val = A.SchemeColorValues.PhColor };
            A.Shade shade3 = new A.Shade() { Val = 94000 };
            A.SaturationModulation saturationModulation6 = new A.SaturationModulation() { Val = 135000 };

            schemeColor7.Append(shade3);
            schemeColor7.Append(saturationModulation6);

            gradientStop6.Append(schemeColor7);

            gradientStopList2.Append(gradientStop4);
            gradientStopList2.Append(gradientStop5);
            gradientStopList2.Append(gradientStop6);
            A.LinearGradientFill linearGradientFill2 = new A.LinearGradientFill() { Angle = 16200000, Scaled = false };

            gradientFill2.Append(gradientStopList2);
            gradientFill2.Append(linearGradientFill2);

            fillStyleList1.Append(solidFill1);
            fillStyleList1.Append(gradientFill1);
            fillStyleList1.Append(gradientFill2);

            A.LineStyleList lineStyleList1 = new A.LineStyleList();

            A.Outline outline1 = new A.Outline() { Width = 9525, CapType = A.LineCapValues.Flat, CompoundLineType = A.CompoundLineValues.Single, Alignment = A.PenAlignmentValues.Center };

            A.SolidFill solidFill2 = new A.SolidFill();

            A.SchemeColor schemeColor8 = new A.SchemeColor() { Val = A.SchemeColorValues.PhColor };
            A.Shade shade4 = new A.Shade() { Val = 95000 };
            A.SaturationModulation saturationModulation7 = new A.SaturationModulation() { Val = 105000 };

            schemeColor8.Append(shade4);
            schemeColor8.Append(saturationModulation7);

            solidFill2.Append(schemeColor8);
            A.PresetDash presetDash1 = new A.PresetDash() { Val = A.PresetLineDashValues.Solid };

            outline1.Append(solidFill2);
            outline1.Append(presetDash1);

            A.Outline outline2 = new A.Outline() { Width = 25400, CapType = A.LineCapValues.Flat, CompoundLineType = A.CompoundLineValues.Single, Alignment = A.PenAlignmentValues.Center };

            A.SolidFill solidFill3 = new A.SolidFill();
            A.SchemeColor schemeColor9 = new A.SchemeColor() { Val = A.SchemeColorValues.PhColor };

            solidFill3.Append(schemeColor9);
            A.PresetDash presetDash2 = new A.PresetDash() { Val = A.PresetLineDashValues.Solid };

            outline2.Append(solidFill3);
            outline2.Append(presetDash2);

            A.Outline outline3 = new A.Outline() { Width = 38100, CapType = A.LineCapValues.Flat, CompoundLineType = A.CompoundLineValues.Single, Alignment = A.PenAlignmentValues.Center };

            A.SolidFill solidFill4 = new A.SolidFill();
            A.SchemeColor schemeColor10 = new A.SchemeColor() { Val = A.SchemeColorValues.PhColor };

            solidFill4.Append(schemeColor10);
            A.PresetDash presetDash3 = new A.PresetDash() { Val = A.PresetLineDashValues.Solid };

            outline3.Append(solidFill4);
            outline3.Append(presetDash3);

            lineStyleList1.Append(outline1);
            lineStyleList1.Append(outline2);
            lineStyleList1.Append(outline3);

            A.EffectStyleList effectStyleList1 = new A.EffectStyleList();

            A.EffectStyle effectStyle1 = new A.EffectStyle();

            A.EffectList effectList1 = new A.EffectList();

            A.OuterShadow outerShadow1 = new A.OuterShadow() { BlurRadius = 40000L, Distance = 20000L, Direction = 5400000, RotateWithShape = false };

            A.RgbColorModelHex rgbColorModelHex11 = new A.RgbColorModelHex() { Val = "000000" };
            A.Alpha alpha1 = new A.Alpha() { Val = 38000 };

            rgbColorModelHex11.Append(alpha1);

            outerShadow1.Append(rgbColorModelHex11);

            effectList1.Append(outerShadow1);

            effectStyle1.Append(effectList1);

            A.EffectStyle effectStyle2 = new A.EffectStyle();

            A.EffectList effectList2 = new A.EffectList();

            A.OuterShadow outerShadow2 = new A.OuterShadow() { BlurRadius = 40000L, Distance = 23000L, Direction = 5400000, RotateWithShape = false };

            A.RgbColorModelHex rgbColorModelHex12 = new A.RgbColorModelHex() { Val = "000000" };
            A.Alpha alpha2 = new A.Alpha() { Val = 35000 };

            rgbColorModelHex12.Append(alpha2);

            outerShadow2.Append(rgbColorModelHex12);

            effectList2.Append(outerShadow2);

            effectStyle2.Append(effectList2);

            A.EffectStyle effectStyle3 = new A.EffectStyle();

            A.EffectList effectList3 = new A.EffectList();

            A.OuterShadow outerShadow3 = new A.OuterShadow() { BlurRadius = 40000L, Distance = 23000L, Direction = 5400000, RotateWithShape = false };

            A.RgbColorModelHex rgbColorModelHex13 = new A.RgbColorModelHex() { Val = "000000" };
            A.Alpha alpha3 = new A.Alpha() { Val = 35000 };

            rgbColorModelHex13.Append(alpha3);

            outerShadow3.Append(rgbColorModelHex13);

            effectList3.Append(outerShadow3);

            A.Scene3DType scene3DType1 = new A.Scene3DType();

            A.Camera camera1 = new A.Camera() { Preset = A.PresetCameraValues.OrthographicFront };
            A.Rotation rotation1 = new A.Rotation() { Latitude = 0, Longitude = 0, Revolution = 0 };

            camera1.Append(rotation1);

            A.LightRig lightRig1 = new A.LightRig() { Rig = A.LightRigValues.ThreePoints, Direction = A.LightRigDirectionValues.Top };
            A.Rotation rotation2 = new A.Rotation() { Latitude = 0, Longitude = 0, Revolution = 1200000 };

            lightRig1.Append(rotation2);

            scene3DType1.Append(camera1);
            scene3DType1.Append(lightRig1);

            A.Shape3DType shape3DType1 = new A.Shape3DType();
            A.BevelTop bevelTop1 = new A.BevelTop() { Width = 63500L, Height = 25400L };

            shape3DType1.Append(bevelTop1);

            effectStyle3.Append(effectList3);
            effectStyle3.Append(scene3DType1);
            effectStyle3.Append(shape3DType1);

            effectStyleList1.Append(effectStyle1);
            effectStyleList1.Append(effectStyle2);
            effectStyleList1.Append(effectStyle3);

            A.BackgroundFillStyleList backgroundFillStyleList1 = new A.BackgroundFillStyleList();

            A.SolidFill solidFill5 = new A.SolidFill();
            A.SchemeColor schemeColor11 = new A.SchemeColor() { Val = A.SchemeColorValues.PhColor };

            solidFill5.Append(schemeColor11);

            A.GradientFill gradientFill3 = new A.GradientFill() { RotateWithShape = true };

            A.GradientStopList gradientStopList3 = new A.GradientStopList();

            A.GradientStop gradientStop7 = new A.GradientStop() { Position = 0 };

            A.SchemeColor schemeColor12 = new A.SchemeColor() { Val = A.SchemeColorValues.PhColor };
            A.Tint tint4 = new A.Tint() { Val = 40000 };
            A.SaturationModulation saturationModulation8 = new A.SaturationModulation() { Val = 350000 };

            schemeColor12.Append(tint4);
            schemeColor12.Append(saturationModulation8);

            gradientStop7.Append(schemeColor12);

            A.GradientStop gradientStop8 = new A.GradientStop() { Position = 40000 };

            A.SchemeColor schemeColor13 = new A.SchemeColor() { Val = A.SchemeColorValues.PhColor };
            A.Tint tint5 = new A.Tint() { Val = 45000 };
            A.Shade shade5 = new A.Shade() { Val = 99000 };
            A.SaturationModulation saturationModulation9 = new A.SaturationModulation() { Val = 350000 };

            schemeColor13.Append(tint5);
            schemeColor13.Append(shade5);
            schemeColor13.Append(saturationModulation9);

            gradientStop8.Append(schemeColor13);

            A.GradientStop gradientStop9 = new A.GradientStop() { Position = 100000 };

            A.SchemeColor schemeColor14 = new A.SchemeColor() { Val = A.SchemeColorValues.PhColor };
            A.Shade shade6 = new A.Shade() { Val = 20000 };
            A.SaturationModulation saturationModulation10 = new A.SaturationModulation() { Val = 255000 };

            schemeColor14.Append(shade6);
            schemeColor14.Append(saturationModulation10);

            gradientStop9.Append(schemeColor14);

            gradientStopList3.Append(gradientStop7);
            gradientStopList3.Append(gradientStop8);
            gradientStopList3.Append(gradientStop9);

            A.PathGradientFill pathGradientFill1 = new A.PathGradientFill() { Path = A.PathShadeValues.Circle };
            A.FillToRectangle fillToRectangle1 = new A.FillToRectangle() { Left = 50000, Top = -80000, Right = 50000, Bottom = 180000 };

            pathGradientFill1.Append(fillToRectangle1);

            gradientFill3.Append(gradientStopList3);
            gradientFill3.Append(pathGradientFill1);

            A.GradientFill gradientFill4 = new A.GradientFill() { RotateWithShape = true };

            A.GradientStopList gradientStopList4 = new A.GradientStopList();

            A.GradientStop gradientStop10 = new A.GradientStop() { Position = 0 };

            A.SchemeColor schemeColor15 = new A.SchemeColor() { Val = A.SchemeColorValues.PhColor };
            A.Tint tint6 = new A.Tint() { Val = 80000 };
            A.SaturationModulation saturationModulation11 = new A.SaturationModulation() { Val = 300000 };

            schemeColor15.Append(tint6);
            schemeColor15.Append(saturationModulation11);

            gradientStop10.Append(schemeColor15);

            A.GradientStop gradientStop11 = new A.GradientStop() { Position = 100000 };

            A.SchemeColor schemeColor16 = new A.SchemeColor() { Val = A.SchemeColorValues.PhColor };
            A.Shade shade7 = new A.Shade() { Val = 30000 };
            A.SaturationModulation saturationModulation12 = new A.SaturationModulation() { Val = 200000 };

            schemeColor16.Append(shade7);
            schemeColor16.Append(saturationModulation12);

            gradientStop11.Append(schemeColor16);

            gradientStopList4.Append(gradientStop10);
            gradientStopList4.Append(gradientStop11);

            A.PathGradientFill pathGradientFill2 = new A.PathGradientFill() { Path = A.PathShadeValues.Circle };
            A.FillToRectangle fillToRectangle2 = new A.FillToRectangle() { Left = 50000, Top = 50000, Right = 50000, Bottom = 50000 };

            pathGradientFill2.Append(fillToRectangle2);

            gradientFill4.Append(gradientStopList4);
            gradientFill4.Append(pathGradientFill2);

            backgroundFillStyleList1.Append(solidFill5);
            backgroundFillStyleList1.Append(gradientFill3);
            backgroundFillStyleList1.Append(gradientFill4);

            formatScheme1.Append(fillStyleList1);
            formatScheme1.Append(lineStyleList1);
            formatScheme1.Append(effectStyleList1);
            formatScheme1.Append(backgroundFillStyleList1);

            themeElements1.Append(colorScheme1);
            themeElements1.Append(fontScheme1);
            themeElements1.Append(formatScheme1);
            A.ObjectDefaults objectDefaults1 = new A.ObjectDefaults();
            A.ExtraColorSchemeList extraColorSchemeList1 = new A.ExtraColorSchemeList();

            theme1.Append(themeElements1);
            theme1.Append(objectDefaults1);
            theme1.Append(extraColorSchemeList1);

            themePart1.Theme = theme1;
        }

        // Generates content of webSettingsPart1.
        private void GenerateWebSettingsPart1Content(WebSettingsPart webSettingsPart1)
        {
            WebSettings webSettings1 = new WebSettings() { MCAttributes = new MarkupCompatibilityAttributes() { Ignorable = "w14" } };
            webSettings1.AddNamespaceDeclaration("mc", "http://schemas.openxmlformats.org/markup-compatibility/2006");
            webSettings1.AddNamespaceDeclaration("r", "http://schemas.openxmlformats.org/officeDocument/2006/relationships");
            webSettings1.AddNamespaceDeclaration("w", "http://schemas.openxmlformats.org/wordprocessingml/2006/main");
            webSettings1.AddNamespaceDeclaration("w14", "http://schemas.microsoft.com/office/word/2010/wordml");
            OptimizeForBrowser optimizeForBrowser1 = new OptimizeForBrowser();
            AllowPNG allowPNG1 = new AllowPNG();

            webSettings1.Append(optimizeForBrowser1);
            webSettings1.Append(allowPNG1);

            webSettingsPart1.WebSettings = webSettings1;
        }

        // Generates content of fontTablePart1.
        private void GenerateFontTablePart1Content(FontTablePart fontTablePart1)
        {
            Fonts fonts1 = new Fonts() { MCAttributes = new MarkupCompatibilityAttributes() { Ignorable = "w14" } };
            fonts1.AddNamespaceDeclaration("mc", "http://schemas.openxmlformats.org/markup-compatibility/2006");
            fonts1.AddNamespaceDeclaration("r", "http://schemas.openxmlformats.org/officeDocument/2006/relationships");
            fonts1.AddNamespaceDeclaration("w", "http://schemas.openxmlformats.org/wordprocessingml/2006/main");
            fonts1.AddNamespaceDeclaration("w14", "http://schemas.microsoft.com/office/word/2010/wordml");

            Font font1 = new Font() { Name = "Calibri" };
            Panose1Number panose1Number1 = new Panose1Number() { Val = "020F0502020204030204" };
            FontCharSet fontCharSet1 = new FontCharSet() { Val = "CC" };
            FontFamily fontFamily1 = new FontFamily() { Val = FontFamilyValues.Swiss };
            Pitch pitch1 = new Pitch() { Val = FontPitchValues.Variable };
            FontSignature fontSignature1 = new FontSignature() { UnicodeSignature0 = "E10002FF", UnicodeSignature1 = "4000ACFF", UnicodeSignature2 = "00000009", UnicodeSignature3 = "00000000", CodePageSignature0 = "0000019F", CodePageSignature1 = "00000000" };

            font1.Append(panose1Number1);
            font1.Append(fontCharSet1);
            font1.Append(fontFamily1);
            font1.Append(pitch1);
            font1.Append(fontSignature1);

            Font font2 = new Font() { Name = "Times New Roman" };
            Panose1Number panose1Number2 = new Panose1Number() { Val = "02020603050405020304" };
            FontCharSet fontCharSet2 = new FontCharSet() { Val = "CC" };
            FontFamily fontFamily2 = new FontFamily() { Val = FontFamilyValues.Roman };
            Pitch pitch2 = new Pitch() { Val = FontPitchValues.Variable };
            FontSignature fontSignature2 = new FontSignature() { UnicodeSignature0 = "E0002AFF", UnicodeSignature1 = "C0007841", UnicodeSignature2 = "00000009", UnicodeSignature3 = "00000000", CodePageSignature0 = "000001FF", CodePageSignature1 = "00000000" };

            font2.Append(panose1Number2);
            font2.Append(fontCharSet2);
            font2.Append(fontFamily2);
            font2.Append(pitch2);
            font2.Append(fontSignature2);

            Font font3 = new Font() { Name = "New Roman" };
            Panose1Number panose1Number3 = new Panose1Number() { Val = "00000000000000000000" };
            FontCharSet fontCharSet3 = new FontCharSet() { Val = "CC" };
            FontFamily fontFamily3 = new FontFamily() { Val = FontFamilyValues.Auto };
            NotTrueType notTrueType1 = new NotTrueType();
            Pitch pitch3 = new Pitch() { Val = FontPitchValues.Default };
            FontSignature fontSignature3 = new FontSignature() { UnicodeSignature0 = "00000201", UnicodeSignature1 = "00000000", UnicodeSignature2 = "00000000", UnicodeSignature3 = "00000000", CodePageSignature0 = "00000004", CodePageSignature1 = "00000000" };

            font3.Append(panose1Number3);
            font3.Append(fontCharSet3);
            font3.Append(fontFamily3);
            font3.Append(notTrueType1);
            font3.Append(pitch3);
            font3.Append(fontSignature3);

            Font font4 = new Font() { Name = "Verdana" };
            Panose1Number panose1Number4 = new Panose1Number() { Val = "020B0604030504040204" };
            FontCharSet fontCharSet4 = new FontCharSet() { Val = "CC" };
            FontFamily fontFamily4 = new FontFamily() { Val = FontFamilyValues.Swiss };
            Pitch pitch4 = new Pitch() { Val = FontPitchValues.Variable };
            FontSignature fontSignature4 = new FontSignature() { UnicodeSignature0 = "A10006FF", UnicodeSignature1 = "4000205B", UnicodeSignature2 = "00000010", UnicodeSignature3 = "00000000", CodePageSignature0 = "0000019F", CodePageSignature1 = "00000000" };

            font4.Append(panose1Number4);
            font4.Append(fontCharSet4);
            font4.Append(fontFamily4);
            font4.Append(pitch4);
            font4.Append(fontSignature4);

            Font font5 = new Font() { Name = "Cambria" };
            Panose1Number panose1Number5 = new Panose1Number() { Val = "02040503050406030204" };
            FontCharSet fontCharSet5 = new FontCharSet() { Val = "CC" };
            FontFamily fontFamily5 = new FontFamily() { Val = FontFamilyValues.Roman };
            Pitch pitch5 = new Pitch() { Val = FontPitchValues.Variable };
            FontSignature fontSignature5 = new FontSignature() { UnicodeSignature0 = "E00002FF", UnicodeSignature1 = "400004FF", UnicodeSignature2 = "00000000", UnicodeSignature3 = "00000000", CodePageSignature0 = "0000019F", CodePageSignature1 = "00000000" };

            font5.Append(panose1Number5);
            font5.Append(fontCharSet5);
            font5.Append(fontFamily5);
            font5.Append(pitch5);
            font5.Append(fontSignature5);

            fonts1.Append(font1);
            fonts1.Append(font2);
            fonts1.Append(font3);
            fonts1.Append(font4);
            fonts1.Append(font5);

            fontTablePart1.Fonts = fonts1;
        }

        private void SetPackageProperties(OpenXmlPackage document)
        {
            document.PackageProperties.Creator = "asus1215";
            document.PackageProperties.Revision = "2";
            document.PackageProperties.Created = System.Xml.XmlConvert.ToDateTime("2013-01-14T19:41:00Z", System.Xml.XmlDateTimeSerializationMode.RoundtripKind);
            document.PackageProperties.Modified = System.Xml.XmlConvert.ToDateTime("2013-01-14T19:41:00Z", System.Xml.XmlDateTimeSerializationMode.RoundtripKind);
            document.PackageProperties.LastModifiedBy = "asus1215";
        }


    }
}
