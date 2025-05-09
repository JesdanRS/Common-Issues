---
category: "UPD"
cvss: "N/A"
generation:
  getIssueContext: |
    return [
      ...new Set(
        window.issueGeneration.trivy.context.filter(
          (x) =>
            x.ArtifactType === "container_image" &&
            x.Metadata &&
            x.Metadata.OS &&
            x.Metadata.OS.EOSL &&
            x.Metadata.OS.EOSL === true
        )
      ),
    ].sort((a, b) => a.ArtifactName.localeCompare(b.ArtifactName));
  getAffectedSystems: |
    return issueContext.map((x) => x.ArtifactName);
  getPlaceholderContent: |
    return [
      "|Image|Operating System|Version|",
      "|--|--|--|",
      ...issueContext.map(
        (x) => `|${x.ArtifactName}|${x.Metadata.OS.Family}|${x.Metadata.OS.Name}`
      ),
    ].join("\n");
---
### Container Images Based on Unsupported Operating Systems
Review of the above container images indicates that they are based on unsupported operating systems, as detailed below:

{==PLACEHOLDER==}
#### Impact: High
No further updates for {==this/these==} operating system{==s==} will be provided, and the software will become increasingly vulnerable to attack as time progresses. {==There are a number of remotely exploitable vulnerabilities in the above operating system versions for which exploit code is publicly available.==}
#### Likelihood: Low
Whilst {==this/these==} operating system{==s==} {==is/are==} likely to be increasingly actively targeted as time progresses, vulnerable components or configurations would need to be in use, and exposed by container functionality, for this issue to be exploitable.
#### Recommendation
Ensure that base container images are regularly updated. Consider the use of container vulnerability scanning to identify outdated and vulnerable components throughout the container lifecycle. Further information regarding container vulnerability scanning is also available at the following URL{==s==}:

[https://owasp.org/www-project-devsecops-guideline/latest/02f-Container-Vulnerability-Scanning]()
{==AWS==} [https://docs.aws.amazon.com/AmazonECR/latest/userguide/image-scanning.html]()
{==Azure==} [https://learn.microsoft.com/en-us/azure/container-registry/scan-images-defender]()
{==Docker Hub==} [https://docs.docker.com/docker-hub/repos/manage/vulnerability-scanning]()