using System;
using System.Collections.Generic;
using System.Text;
using Innis.Model;

namespace Innis.CommonIssue.ArtifactBuilder
{
    public class CommonIssue
    {
        #region Public Properties

        public string Category { get; internal set; }
        public string Description { get; internal set; }
        public string Impact { get; internal set; }
        public PenetrationTestRisk ImpactRisk { get; internal set; }
        public string Likelihood { get; internal set; }
        public PenetrationTestRisk LikelihoodRisk { get; internal set; }
        public string Recommendation { get; internal set; }
        public PenetrationTestRisk Risk => (PenetrationTestRisk)(((int)ImpactRisk + (int)LikelihoodRisk) - 3);
        public string Title { get; internal set; }
        public string FlatOpcPlural { get; internal set; }
        public string FlatOpcSingular { get; internal set; }

        #endregion Public Properties

        #region Public Methods

        public string ToReportMdString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"### {Title.Trim('\r', '\n')}\tRisk: {Risk}");
            sb.AppendLine(Description.Trim('\r', '\n'));
            sb.AppendLine($"#### Impact: {ImpactRisk}");
            sb.AppendLine(Impact.Trim('\r', '\n'));
            sb.AppendLine($"#### Likelihood: {LikelihoodRisk}");
            sb.AppendLine(Likelihood.Trim('\r', '\n'));
            sb.AppendLine("#### Recommendation");
            sb.AppendLine(Recommendation.Trim('\r', '\n'));

            var reportMd = sb.ToString().Trim('\r', '\n');

            return reportMd;
        }

        #endregion Public Methods
    }
}
