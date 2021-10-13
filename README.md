# Custom dotnet Item Templates
This repo contains [custom templates for use with 'dotnet new'](https://docs.microsoft.com/en-us/dotnet/core/tools/custom-templates#create-a-project-using-a-custom-template). These templates are intended to help kickstart .NET Core development: they contain customizations I frequently apply when starting a new project.

# Getting Started
To install & apply a template,<br>
```
dotnet new --install <TEMPLATE_DIRECTORY>
dotnet new <TEMPLATE_NAME> <TEMPLATE_PARAMETERS>
```

For example:<br>
```
dotnet new --install "C:\Projects\ItemTemplates\HexagonalApi\.template.config"
dotnet new hexapi --featureName MyApi
```