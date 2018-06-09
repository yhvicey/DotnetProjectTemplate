# .NET Core project template

This is a project template for personal projects.

## Folder structure

```text
.
|-- Directory.Build.props           // Common build properties. Customize build properties here.
|-- Directory.Build.targets         // Common build targets. Customize build target here.
|-- README.MD                       // Repo description.
|-- build                           // Build result folder.
|   |-- Template.ClassLibrary       // Project Template.ClassLibrary's build result.
|   `-- Template.ClassLibrary.Test  // Project Template.ClassLibrary.Test's build result.
|-- build.proj                      // Build entry project.
|-- publish                         // Publish result folder. Test projects will not be published.
|   `-- Template.ClassLibrary       // Project Template.ClassLibrary's publish result.
`-- src                             // Projects source folder.
    |-- Template.ClassLibrary       // Project Template.ClassLibrary's source folder.
    |-- Template.ClassLibrary.Test  // Project Template.ClassLibrary.Test's source folder.
    `-- Template.sln                // Projects' Visual Studio solution file.
```

## Common commands

Restore:

```shell
dotnet restore
```

Build:

```shell
dotnet build
```

Test:

```shell
dotnet test
```

Publish:

```shell
dotnet publish
```