# R5T.L0071
Strictly-framework library (netstandard2.1) for Rivet-specific, but general, functionality.

Rivet-specific functionality are opinionated things like:

* Copyright text: $"Copyright {Instances.Strings.Copyright} {copyrightHolder} {copyrightYear}"
* Creaete backup file using the "- BAK" file name stem suffix.
* {Executable Directory}/Files/{Project Name}/{File Name} file path pattern for copied-to-output resource files.


## Allowed Dependencies

* R5T.L0066 - The strictly-framework library for netstandard2.1.
* netstandard2.1
