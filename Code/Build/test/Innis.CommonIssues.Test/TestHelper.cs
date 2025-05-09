using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Validation;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using Xunit.Abstractions;

namespace Innis.CommonIssues.Test
{
    public static class TestHelper
    {
        #region Private Fields

        private const string COMMON_ISSUE_DIR_NAME = "Issues";
        private static IReadOnlyCollection<FileInfo> _issueFiles;

        #endregion Private Fields

        #region Public Properties

        public static IReadOnlyCollection<FileInfo> IssueFiles
        {
            get
            {
                if (_issueFiles == null)
                {
                    _issueFiles = GetIssueFiles();
                }
                return _issueFiles;
            }
        }

        #endregion Public Properties

        #region Public Methods

        public static IEnumerable<ValidationErrorInfo> AddValidationErrors(this ITestOutputHelper output, OpenXmlPackage package, FileFormatVersions version)
        {
            var validator = new OpenXmlValidator(version);
            var errors = validator.Validate(package);
            foreach (var error in errors)
            {
                output.WriteLine($"Part: {error.Part} Node: {error.Node}, Description: {error.Description}");
            }
            return errors;
        }

        public static string GetMemberName([CallerMemberName]string name = "")
        {
            return name;
        }

        #endregion Public Methods

        #region Private Methods

        private static IReadOnlyCollection<FileInfo> GetIssueFiles()
        {
            var baseDir = new DirectoryInfo(Directory.GetCurrentDirectory());
            while (baseDir.EnumerateDirectories(COMMON_ISSUE_DIR_NAME).Count() == 0)
            {
                baseDir = baseDir.Parent;
            }
            baseDir = new DirectoryInfo(Path.Combine(baseDir.FullName, COMMON_ISSUE_DIR_NAME));
            return baseDir.GetFiles("*.*", SearchOption.AllDirectories);
        }

        #endregion Private Methods
    }
}
