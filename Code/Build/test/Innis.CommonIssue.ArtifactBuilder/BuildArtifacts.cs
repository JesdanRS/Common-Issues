using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using Innis.CommonIssues.Test;
using Innis.Model;
using Innis.ReportMd.Word;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Xunit;
using Xunit.Abstractions;
using System.Text.RegularExpressions;
using Newtonsoft.Json.Linq;
using System.Threading.Tasks;

namespace Innis.CommonIssue.ArtifactBuilder
{
    public class BuildArtifacts
    {
        #region Private Fields

        private static List<CommonIssue> _commonIssues;
        private readonly ITestOutputHelper output;

        #endregion Private Fields

        #region Public Constructors

        public BuildArtifacts(ITestOutputHelper output)
        {
            this.output = output;
        }

        #endregion Public Constructors

        #region Private Properties

        private static List<CommonIssue> CommonIssues
        {
            get
            {
                if (_commonIssues == null)
                {
                    _commonIssues = new List<CommonIssue>();

                    Parallel.ForEach(CommonIssuesParseTest.Data_IssueFiles().Select(x => (x[0] as FileInfo)).OrderBy(x => x.FullName), (fileInfo) =>
                    {
                        var issue = new CommonIssue
                        {
                            Category = fileInfo.Directory.Name
                        };

                        var lines = File.ReadAllLines(fileInfo.FullName).ToList();
                        int i = 0;
                        if (lines[i].StartsWith("---"))
                        {
                            i++;
                            StringBuilder frontmatterSb = new StringBuilder();
                            while (i < lines.Count)
                            {
                                if (lines[i].StartsWith("---"))
                                {
                                    i++;
                                    break;
                                }
                                frontmatterSb.AppendLine(lines[i]);
                                i++;
                            }
                        }
                        if (lines[i].StartsWith("### "))
                        {
                            issue.Title = lines[i].Replace("### ", "");
                            i++;

                            StringBuilder descriptionSb = new StringBuilder();
                            while (i < lines.Count)
                            {
                                if (lines[i].StartsWith("#### "))
                                {
                                    break;
                                }
                                descriptionSb.AppendLine(lines[i]);
                                i++;
                            }

                            issue.Description = descriptionSb.ToString();
                            issue.ImpactRisk = (PenetrationTestRisk)Enum.Parse(typeof(PenetrationTestRisk), lines[i].Replace("#### Impact: ", ""));
                            i++;
                            StringBuilder impactSb = new StringBuilder();
                            while (i < lines.Count)
                            {
                                if (lines[i].StartsWith("#### "))
                                {
                                    break;
                                }
                                impactSb.AppendLine(lines[i]);
                                i++;
                            }
                            issue.Impact = impactSb.ToString();

                            issue.LikelihoodRisk = (PenetrationTestRisk)Enum.Parse(typeof(PenetrationTestRisk), lines[i].Replace("#### Likelihood: ", ""));
                            i++;
                            StringBuilder likelihoodSb = new StringBuilder();
                            while (i < lines.Count)
                            {
                                if (lines[i].StartsWith("#### "))
                                {
                                    break;
                                }
                                likelihoodSb.AppendLine(lines[i]);
                                i++;
                            }
                            issue.Likelihood = likelihoodSb.ToString();
                            i++;

                            StringBuilder recommendationSb = new StringBuilder();
                            while (i < lines.Count)
                            {
                                if (lines[i].Trim() == "***")
                                {
                                    break;
                                }
                                recommendationSb.AppendLine(lines[i]);
                                i++;
                            }
                            issue.Recommendation = recommendationSb.ToString();
                        }

                        var flatOpc = ReportMdToFlatOpc(issue.ToReportMdString());
                        issue.FlatOpcPlural = Regex.Replace(flatOpc, @"\{([^{}|]*?)\|\|([^{}|]*?)\}", true ? "$1" : "$2");
                        issue.FlatOpcSingular = Regex.Replace(flatOpc, @"\{([^{}|]*?)\|\|([^{}|]*?)\}", false ? "$1" : "$2");

                        _commonIssues.Add(issue);
                    });
                }

                return _commonIssues;
            }
        }

        private string OutputDir { get; }

        #endregion Private Properties

        #region Public Methods

        public static Style GenerateIssueSubHeadingCharStyle()
        {
            Style style1 = new Style() { Type = StyleValues.Character, StyleId = "IssueSubHeadingChar", CustomStyle = true };
            StyleName styleName1 = new StyleName() { Val = "Issue SubHeading Char" };
            BasedOn basedOn1 = new BasedOn() { Val = "DefaultParagraphFont" };
            LinkedStyle linkedStyle1 = new LinkedStyle() { Val = "IssueSubHeading" };
            Rsid rsid1 = new Rsid() { Val = "004B7A86" };

            StyleRunProperties styleRunProperties1 = new StyleRunProperties();
            RunFonts runFonts1 = new RunFonts() { Ascii = "Calibri", HighAnsi = "Calibri" };
            Bold bold1 = new Bold();
            BoldComplexScript boldComplexScript1 = new BoldComplexScript();
            FontSize fontSize1 = new FontSize() { Val = "21" };
            FontSizeComplexScript fontSizeComplexScript1 = new FontSizeComplexScript() { Val = "24" };
            Languages languages1 = new Languages() { EastAsia = "en-US" };

            styleRunProperties1.Append(runFonts1);
            styleRunProperties1.Append(bold1);
            styleRunProperties1.Append(boldComplexScript1);
            styleRunProperties1.Append(fontSize1);
            styleRunProperties1.Append(fontSizeComplexScript1);
            styleRunProperties1.Append(languages1);

            style1.Append(styleName1);
            style1.Append(basedOn1);
            style1.Append(linkedStyle1);
            style1.Append(rsid1);
            style1.Append(styleRunProperties1);
            return style1;
        }

        public static Style GenerateIssueSubHeadingStyle()
        {
            Style style1 = new Style() { Type = StyleValues.Paragraph, StyleId = "IssueSubHeading", CustomStyle = true };
            StyleName styleName1 = new StyleName() { Val = "Issue SubHeading" };
            BasedOn basedOn1 = new BasedOn() { Val = "Normal" };
            LinkedStyle linkedStyle1 = new LinkedStyle() { Val = "IssueSubHeadingChar" };
            PrimaryStyle primaryStyle1 = new PrimaryStyle();
            Rsid rsid1 = new Rsid() { Val = "004B7A86" };

            StyleParagraphProperties styleParagraphProperties1 = new StyleParagraphProperties();
            KeepNext keepNext1 = new KeepNext();
            SpacingBetweenLines spacingBetweenLines1 = new SpacingBetweenLines() { Before = "220" };

            styleParagraphProperties1.Append(keepNext1);
            styleParagraphProperties1.Append(spacingBetweenLines1);

            StyleRunProperties styleRunProperties1 = new StyleRunProperties();
            Bold bold1 = new Bold();
            BoldComplexScript boldComplexScript1 = new BoldComplexScript();
            FontSize fontSize1 = new FontSize() { Val = "21" };

            styleRunProperties1.Append(bold1);
            styleRunProperties1.Append(boldComplexScript1);
            styleRunProperties1.Append(fontSize1);

            style1.Append(styleName1);
            style1.Append(basedOn1);
            style1.Append(linkedStyle1);
            style1.Append(primaryStyle1);
            style1.Append(rsid1);
            style1.Append(styleParagraphProperties1);
            style1.Append(styleRunProperties1);
            return style1;
        }

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void BuildCommonIssueDocument(bool plural)
        {
            var result = WordCompiler.GenerateWordDocument(string.Empty);
            using (var ms = new MemoryStream())
            {
                ms.Write(result.Output, 0, result.Output.Length);
                using (var document = WordprocessingDocument.Open(ms, true))
                {
                    document.MainDocumentPart.StyleDefinitionsPart.Styles.Append(GenerateIssueSubHeadingCharStyle());
                    document.MainDocumentPart.StyleDefinitionsPart.Styles.Append(GenerateIssueSubHeadingStyle());

                    foreach (var group in CommonIssues.GroupBy(x => x.Category))
                    {
                        var categoryHeadingParagraph = new Paragraph { ParagraphProperties = new ParagraphProperties { ParagraphStyleId = new ParagraphStyleId { Val = "Heading 2" } } };
                        var categoryHeadingRun = categoryHeadingParagraph.AppendChild(new Run());
                        categoryHeadingRun.AppendChild(new Text(group.Key));
                        document.MainDocumentPart.Document.Body.InsertBefore(categoryHeadingParagraph, document.MainDocumentPart.Document.Body.Elements<SectionProperties>().Last());

                        foreach (var issue in group)
                        {
                            var altPart = document.MainDocumentPart.AddAlternativeFormatImportPart(AlternativeFormatImportPartType.WordprocessingML);
                            var altPartId = document.MainDocumentPart.GetIdOfPart(altPart);
                            using (var issueMs = new MemoryStream())
                            using (var issueDocument = WordprocessingDocument.FromFlatOpcString(plural ? issue.FlatOpcPlural : issue.FlatOpcSingular))
                            {
                                issueDocument.Clone(issueMs);
                                using (var issueMs2 = new MemoryStream(issueMs.ToArray()))
                                {
                                    altPart.FeedData(issueMs2);
                                }
                            }
                            var altChunk = new AltChunk { Id = altPartId };
                            document.MainDocumentPart.Document.Body.InsertBefore(altChunk, document.MainDocumentPart.Document.Body.Elements<SectionProperties>().Last());
                        }
                    }

                    var fileNamePostfix = plural ? "_Plural" : "_Singular";
                    var fileName = $"./CommonIssues{fileNamePostfix}.docx";
                    document.SaveAs(fileName);
                }
            }
        }

        [Fact]
        public void BuildCommonIssueJson()
        {
            var jsonIssues = new JArray();
            foreach (var group in CommonIssues.GroupBy(x => x.Category))
            {
                foreach (var issue in group)
                {
                    var jsonIssue = JObject.FromObject(issue);
                    jsonIssues.Add(jsonIssue);
                }
            }
            var fileName = "./CommonIssues.json";
            File.WriteAllText(fileName, jsonIssues.ToString());
        }

        #endregion Public Methods

        #region Private Methods

        private static string ReportMdToFlatOpc(string reportMd)
        {
            var result = WordCompiler.GenerateWordDocument(reportMd + "\r\n\r\n\r\n");
            using (var ms = new MemoryStream())
            {
                ms.Write(result.Output, 0, result.Output.Length);
                using (var document = WordprocessingDocument.Open(ms, true))
                {
                    document.MainDocumentPart.StyleDefinitionsPart.Styles.Append(GenerateIssueSubHeadingCharStyle());
                    document.MainDocumentPart.StyleDefinitionsPart.Styles.Append(GenerateIssueSubHeadingStyle());

                    foreach (var paragraph in document.MainDocumentPart.RootElement.Descendants<Paragraph>())
                    {
                        if (paragraph.ParagraphProperties?.ParagraphStyleId?.Val == "Heading 4")
                        {
                            paragraph.ParagraphProperties.ParagraphStyleId.Val = "IssueSubHeading";
                        }
                    }

                    document.Save();
                    return document.ToFlatOpcString();
                }
            }
        }

        #endregion Private Methods
    }
}
