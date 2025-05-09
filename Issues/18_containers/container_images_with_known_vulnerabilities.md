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
              (y) => y.Vulnerabilities && y.Vulnerabilities.length > 0
            ).length > 0
        )
      ),
    ].sort((a, b) => a.ArtifactName.localeCompare(b.ArtifactName));
  getAffectedSystems: |
    return issueContext.map((x) => x.ArtifactName);
  getPlaceholderContent: |
    let rows = [];

    for (var i = 0; i < issueContext.length; i++) {
      const artifact = issueContext[i];

      if (artifact.Results) {
        for (var j = 0; j < artifact.Results.length; j++) {
          const result = artifact.Results[j];

          if (result.Vulnerabilities) {
            for (var k = 0; k < result.Vulnerabilities.length; k++) {
              const vulnerability = result.Vulnerabilities[k];

              const row = {
                ArtifactName: artifact.ArtifactName,
                Type: result.Type,
                PkgName: vulnerability.PkgName,
                InstalledVersion: vulnerability.InstalledVersion,
                Vulnerabilities: vulnerability.VulnerabilityID,
              };

              const existingRowIndex = rows.findIndex(
                (x) =>
                  x.ArtifactName === row.ArtifactName &&
                  x.Type === row.Type &&
                  x.PkgName === row.PkgName &&
                  x.InstalledVersion === row.InstalledVersion
              );

              if (existingRowIndex !== -1) {
                rows[
                  existingRowIndex
                ].Vulnerabilities = `${rows[existingRowIndex].Vulnerabilities}, ${row.Vulnerabilities}`;
              } else {
                rows.push(row);
              }
            }
          }
        }
      }
    }

    let placeHolder = [];
    placeHolder.push(
      "|Artifact|Type|Package|Installed Version|Vulnerabilities|"
    );
    placeHolder.push("|--|--|--|--|--|");
    rows.forEach((row) => {
      placeHolder.push(
        `|${row.ArtifactName}|${row.Type}|${row.PkgName}|${row.InstalledVersion}|${row.Vulnerabilities}|`
      );
    });

    return placeHolder.join("\n");
---
### Container Images with Known Vulnerabilities
This is a generated helper issue which attempts to pull container image with known vulnerabilities from Trivy JSON.

{==PLACEHOLDER==}
#### Impact: Low
N/A
#### Likelihood: Low
N/A
#### Recommendation
N/A