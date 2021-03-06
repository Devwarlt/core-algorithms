# PSTk - `PServer Toolkit` [![license-badge]][license] [![version-badge]][latest] [![size-badge]][latest] [![visitors-badge]][latest]

**PServer Toolkit**, also known with acronym **PSTk** and former name **Core Algorithms**, is a collection of features available in .NET framework that enhances game server performance using .NET native implementations. Can be ported to any other .NET environment with properly adjusts and implementation. However, target is for any game server structure.

## Documentation
For more details, consider to check our [**API documentation**][api-docs].

## Language & Framework
![language-badge] ![net-core-framework-badge] ![net-framework-badge] ![net-five-framework-badge]

## Build status
| Branch                      | .NET CI Status                       | GitHub Pages CI Status                         |
| ----------------------------| ------------------------------------ | ---------------------------------------------- |
| :wrench: [`dev`][dev-ref]   | [![dotnet-ci-dev-badge]][dotnet-ci]  | [![github-page-ci-dev-badge]][github-page-ci]  |
| :rocket: [`prod`][prod-ref] | [![dotnet-ci-prod-badge]][dotnet-ci] | [![github-page-ci-prod-badge]][github-page-ci] |

## Distributions
| Distribution           | NuGet                                               | Download                                                      |
| ---------------------- | --------------------------------------------------- | ------------------------------------------------------------- |
| **`PSTk.Core`**        | [![pstk-core-badge]][pstk-core-nuget]               | [![pstk-core-downloads-badge]][pstk-core-nuget]               |
| **`PSTk.Diagnostics`** | [![pstk-diagnostics-badge]][pstk-diagnostics-nuget] | [![pstk-diagnostics-downloads-badge]][pstk-diagnostics-nuget] |
| **`PSTk.Extensions`**  | [![pstk-extensions-badge]][pstk-extensions-nuget]   | [![pstk-extensions-downloads-badge]][pstk-extensions-nuget]   |
| **`PSTk.Networking`**  | [![pstk-networking-badge]][pstk-networking-nuget]   | [![pstk-networking-downloads-badge]][pstk-networking-nuget]   |
| **`PSTk.Threading`**   | [![pstk-threading-badge]][pstk-threading-nuget]     | [![pstk-threading-downloads-badge]][pstk-threading-nuget]     |
| **`PSTk.Redis`**       | [![pstk-redis-badge]][pstk-redis-nuget]             | [![pstk-redis-downloads-badge]][pstk-redis-nuget]             |

### Contributors
- [@Devwarlt][devwarlt-ref]
- [@Slendergo][slendergo-ref]

[dev-ref]: https://github.com/Devwarlt/pstk-core/tree/dev
[prod-ref]: https://github.com/Devwarlt/pstk-core

[devwarlt-ref]: https://github.com/Devwarlt
[slendergo-ref]: https://github.com/Slendergo

[license]: /LICENSE
[latest]: https://github.com/Devwarlt/pstk/releases/latest

[api-docs]: https://devwarlt.github.io/pstk-core/api/

[license-badge]: https://img.shields.io/badge/MIT-gray?style=plastic
[language-badge]: https://img.shields.io/github/languages/top/Devwarlt/pstk-core?style=plastic&color=purple
[net-framework-badge]: https://img.shields.io/badge/Framework-4.7.2%2B-purple?logo=.net&style=plastic
[net-core-framework-badge]: https://img.shields.io/badge/Core-3.1%2B-purple?logo=.net&style=plastic
[net-five-framework-badge]: https://img.shields.io/badge/%20-5.0%2B-purple?logo=.net&style=plastic
[version-badge]: https://img.shields.io/github/release/Devwarlt/pstk-core?color=success&logo=github&style=plastic
[size-badge]: https://img.shields.io/github/repo-size/Devwarlt/pstk-core?style=plastic
[visitors-badge]: https://visitor-badge.glitch.me/badge?page_id=Devwarlt.pstk-core

[github-page-ci]: https://github.com/Devwarlt/pstk-core/actions?query=workflow%3A"GitHub+Pages+CI"
[github-page-ci-dev-badge]: https://github.com/Devwarlt/pstk-core/workflows/GitHub%20Pages%20CI/badge.svg?branch=dev
[github-page-ci-prod-badge]: https://github.com/Devwarlt/pstk-core/workflows/GitHub%20Pages%20CI/badge.svg

[dotnet-ci]: https://github.com/Devwarlt/pstk-core/actions?query=workflow%3A".NET+CI"
[dotnet-ci-dev-badge]: https://github.com/Devwarlt/pstk-core/workflows/.NET%20CI/badge.svg?branch=dev
[dotnet-ci-prod-badge]: https://github.com/Devwarlt/pstk-core/workflows/.NET%20CI/badge.svg

[pstk-core-badge]: https://img.shields.io/nuget/v/PSTk.Core.svg?logo=nuget&style=plastic
[pstk-core-downloads-badge]: https://img.shields.io/nuget/dt/PSTk.Core.svg?logo=nuget&style=plastic
[pstk-core-nuget]: https://www.nuget.org/packages/PSTk.Core/

[pstk-diagnostics-badge]: https://img.shields.io/nuget/v/PSTk.Diagnostics.svg?logo=nuget&style=plastic
[pstk-diagnostics-downloads-badge]: https://img.shields.io/nuget/dt/PSTk.Diagnostics.svg?logo=nuget&style=plastic
[pstk-diagnostics-nuget]: https://www.nuget.org/packages/PSTk.Diagnostics/

[pstk-extensions-badge]: https://img.shields.io/nuget/v/PSTk.Extensions.svg?logo=nuget&style=plastic
[pstk-extensions-downloads-badge]: https://img.shields.io/nuget/dt/PSTk.Extensions.svg?logo=nuget&style=plastic
[pstk-extensions-nuget]: https://www.nuget.org/packages/PSTk.Extensions/

[pstk-networking-badge]: https://img.shields.io/nuget/v/PSTk.Networking.svg?logo=nuget&style=plastic
[pstk-networking-downloads-badge]: https://img.shields.io/nuget/dt/PSTk.Networking.svg?logo=nuget&style=plastic
[pstk-networking-nuget]: https://www.nuget.org/packages/PSTk.Networking/

[pstk-threading-badge]: https://img.shields.io/nuget/v/PSTk.Threading.svg?logo=nuget&style=plastic
[pstk-threading-downloads-badge]: https://img.shields.io/nuget/dt/PSTk.Threading.svg?logo=nuget&style=plastic
[pstk-threading-nuget]: https://www.nuget.org/packages/PSTk.Threading/

[pstk-redis-badge]: https://img.shields.io/nuget/v/PSTk.Redis.svg?logo=nuget&style=plastic
[pstk-redis-downloads-badge]: https://img.shields.io/nuget/dt/PSTk.Redis.svg?logo=nuget&style=plastic
[pstk-redis-nuget]: https://www.nuget.org/packages/PSTk.Redis/
