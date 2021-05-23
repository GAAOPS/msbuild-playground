# Basics of MsBuild Projects
MsBuild Projects are consists of:
- Properties: Simple Variables
- Items: Objects List (Have a Key *Identity* plus *Metadata*)
- Targets: Main Logic, composed of tasks

https://docs.microsoft.com/en-us/visualstudio/msbuild/msbuild-reserved-and-well-known-properties?view=vs-2019

https://docs.microsoft.com/en-us/visualstudio/msbuild/msbuild-well-known-item-metadata?view=vs-2019

https://docs.microsoft.com/en-us/visualstudio/msbuild/msbuild-properties?view=vs-2019

https://docs.microsoft.com/en-us/visualstudio/msbuild/incremental-builds?view=vs-2019

## Evaluation Order:
1. Environment Variables
2. Imports & Properties
3. Item Definitions
4. Items
5. UsingTask
6. Targets