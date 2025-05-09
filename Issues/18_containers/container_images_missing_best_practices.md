---
category: "N/A"
cvss: "N/A"
generation:
  getIssueContext: |
    return [
      ...new Set(
        issueGeneration.trivy.context.filter(
          (x) =>
            x.ArtifactType === "container_image" &&
            x.Results &&
            x.Results.filter(
              (y) => y.Misconfigurations && y.Misconfigurations.length > 0
            ).length > 0
        )
      ),
    ].sort((a, b) => a.ArtifactName.localeCompare(b.ArtifactName));
  getAffectedSystems: |
    return issueContext.map((x) => x.ArtifactName);
  getPlaceholderContent: |
    let misconfigurations = {};

    for (var i = 0; i < issueContext.length; i++) {
      const artifact = issueContext[i];

      if (artifact.Results) {
        for (var j = 0; j < artifact.Results.length; j++) {
          const result = artifact.Results[j];

          if (result.Misconfigurations) {
            for (var k = 0; k < result.Misconfigurations.length; k++) {
              const misconfiguration = result.Misconfigurations[k];

              if (
                misconfigurations[`${misconfiguration.Title}`] === undefined
              ) {
                misconfigurations[`${misconfiguration.Title}`] = [];
              }

              misconfigurations[misconfiguration.Title].push(
                artifact.ArtifactName
              );
            }
          }
        }
      }
    }

    let placeHolder = [];

    for (var i = 0; i < Object.keys(misconfigurations).length; i++) {
      placeHolder.push(
        `**${Object.keys(misconfigurations)[i]}**`
      );

      for (
        var j = 0;
        j < misconfigurations[Object.keys(misconfigurations)[i]].length;
        j++
      ) {
        placeHolder.push(
          `- ${misconfigurations[Object.keys(misconfigurations)[i]][j]}`
        );
      }

      placeHolder.push("");
    }

    return placeHolder.join("\n");
---
### Container Images Missing Best Practices
This is a generated helper issue which attempts to pull missing container image best practices from Trivy JSON.

{==PLACEHOLDER==}
#### Impact: Low
N/A
#### Likelihood: Low
N/A
#### Recommendation
N/A