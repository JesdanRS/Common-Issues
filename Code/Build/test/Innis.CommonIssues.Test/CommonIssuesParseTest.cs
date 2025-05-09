using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using Innis.ReportMd.Grammar;
using Innis.ReportMd.Word;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using Xunit;
using Xunit.Abstractions;

namespace Innis.CommonIssues.Test
{
    public class CommonIssuesParseTest
    {
        #region Private Fields

        private readonly ITestOutputHelper output;

        #endregion Private Fields

        #region Public Constructors

        public CommonIssuesParseTest(ITestOutputHelper output)
        {
            this.output = output;
        }

        #endregion Public Constructors

        #region Public Methods

        public static IEnumerable<object[]> Data_IssueFiles()
        {
            foreach (var fileInfo in TestHelper.IssueFiles)
            {
                yield return new object[] { fileInfo };
            }
        }

        [Fact]
        public void FixtureDiscoversMdFiles()
        {
            Assert.NotEmpty(TestHelper.IssueFiles);
        }

        [Theory]
        [MemberData(nameof(Data_IssueFiles))]
        public void HasFilenameMatchingTitleHeading(FileInfo mdFile)
        {
            var lines = File.ReadAllLines(mdFile.FullName).ToList();
            int i = 0;
            if (lines[i].StartsWith("---"))
            {
                i++;
                while (i < lines.Count)
                {
                    if (lines[i].StartsWith("---"))
                    {
                        i++;
                        break;
                    }
                    i++;
                }
            }
            var title = lines[i].TrimStart('#').Trim();
            Assert.Equal($"{title.ToLower().Replace(" ", "_").Replace("/", "_")}.md", mdFile.Name);
        }

        [Theory]
        [MemberData(nameof(Data_IssueFiles))]
        public void HasMatchingCodifyBlocks(FileInfo mdFile)
        {
            var count = 0;
            foreach (var line in File.ReadLines(mdFile.FullName))
            {
                if (Regex.IsMatch(line, "^```$"))
                {
                    count++;
                }
            }
            Assert.True(count % 2 == 0);
        }

        [Theory]
        [MemberData(nameof(Data_IssueFiles))]
        public void HasMdExtension(FileInfo mdFile)
        {
            Assert.Equal(".md", mdFile.Extension);
        }

        [Theory]
        [MemberData(nameof(Data_IssueFiles))]
        public void HasNoHeadingWhitespace(FileInfo mdFile)
        {
            var lines = File.ReadLines(mdFile.FullName).ToArray();
            var headingLineIndexes = new List<int>();
            for (var i = 0; i < lines.Length; i++)
            {
                if (lines[i].StartsWith("###"))
                {
                    headingLineIndexes.Add(i);
                }
            }

            foreach (var index in headingLineIndexes)
            {
                Assert.False(string.IsNullOrWhiteSpace(lines[Math.Max(index - 1, 0)]), "Make sure no empty lines above or below of any headings.");
                Assert.False(string.IsNullOrWhiteSpace(lines[Math.Min(index + 1, lines.Length)]), "Make sure no empty lines above or below of any headings.");
            }
        }

        [Theory]
        [MemberData(nameof(Data_IssueFiles))]
        public void HasNoNewLineAtEof(FileInfo mdFile)
        {
            Assert.False(string.IsNullOrWhiteSpace(File.ReadLines(mdFile.FullName).Last()));
        }

        [Theory]
        [MemberData(nameof(Data_IssueFiles))]
        public void HasNoNonAsciiChars(FileInfo mdFile)
        {
            var nonAsciiChars = false;
            foreach (var line in File.ReadLines(mdFile.FullName))
            {
                if (System.Text.Encoding.UTF8.GetByteCount(line) != System.Text.Encoding.ASCII.GetByteCount(line))
                {
                    nonAsciiChars = true;
                    break;
                }
            }
            Assert.False(nonAsciiChars);
        }

        [Theory]
        [MemberData(nameof(Data_IssueFiles))]
        public void HasNoTrailingWhitespace(FileInfo mdFile)
        {
            var trailingWhitespace = false;
            var inFrontmatter = true;
            foreach (var line in File.ReadLines(mdFile.FullName))
            {
                if (inFrontmatter && !line.StartsWith("###"))
                {
                    continue;
                } 
                else 
                {
                    inFrontmatter = false;
                }

                if (Regex.IsMatch(line, "\\s$"))
                {
                    trailingWhitespace = true;
                    break;
                }
            }
            Assert.False(trailingWhitespace, "Make sure there is no stray WHITESPACE characters at the end of any common issue line.");
        }

        [Theory]
        [MemberData(nameof(Data_IssueFiles))]
        public void HasValidImpactHeading(FileInfo mdFile)
        {
            var found = false;
            foreach (var line in File.ReadLines(mdFile.FullName))
            {
                if (Regex.IsMatch(line, "^#### Impact: (Low|Medium|High)$"))
                {
                    if (found)
                    {
                        throw new Exception($"Error: Only one impact heading is allowed");
                    }
                    found = true;
                }
            }
            Assert.True(found);
        }

        [Theory]
        [MemberData(nameof(Data_IssueFiles))]
        public void HasValidLikelihoodHeading(FileInfo mdFile)
        {
            var found = false;
            foreach (var line in File.ReadLines(mdFile.FullName))
            {
                if (Regex.IsMatch(line, "^#### Likelihood: (Low|Medium|High)$"))
                {
                    if (found)
                    {
                        throw new Exception($"Error: Only one likelihood heading is allowed");
                    }
                    found = true;
                }
            }
            Assert.True(found);
        }

        [Theory]
        [MemberData(nameof(Data_IssueFiles))]
        public void HasValidRecommendationHeading(FileInfo mdFile)
        {
            var found = false;
            foreach (var line in File.ReadLines(mdFile.FullName))
            {
                if (line.Equals("#### Recommendation"))
                {
                    if (found)
                    {
                        throw new Exception($"Error: Only one recommendation heading is allowed");
                    }
                    found = true;
                }
            }
            Assert.True(found);
        }

        [Theory]
        [MemberData(nameof(Data_IssueFiles))]
        public void HasValidTitleHeading(FileInfo mdFile)
        {
            var found = false;
            foreach (var line in File.ReadLines(mdFile.FullName))
            {
                if (Regex.IsMatch(line, "^### .+$"))
                {
                    if (found)
                    {
                        throw new Exception($"Error: Only one title heading is allowed");
                    }
                    found = true;
                }
            }
            Assert.True(found);
        }

        [Theory]
        [MemberData(nameof(Data_IssueFiles))]
        public void ValidateReportMdSyntaxAndWordGeneration(FileInfo mdFile)
        {
            var reportMdString = File.ReadAllText(mdFile.FullName);
            var result = WordCompiler.GenerateWordDocument(reportMdString);
            foreach (var error in result.LexerErrors.Concat(result.ParserErrors))
            {
                output.WriteLine($"({error.Line},{error.CharPositionInLine}):\t{error.Message}");
            }
            Assert.Empty(result.LexerErrors);
            Assert.Empty(result.ParserErrors);

            using (var ms = new MemoryStream())
            {
                ms.Write(result.Output, 0, result.Output.Length);
                using (var package = WordprocessingDocument.Open(ms, false))
                {
                    Assert.Empty(output.AddValidationErrors(package, FileFormatVersions.Office2013));
                }
            }
        }

        #endregion Public Methods
    }
}
