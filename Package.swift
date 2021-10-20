// swift-tools-version:5.5

import PackageDescription

let package = Package(
    name: "consoleApp",
    products: [
        .library(
            name: "consoleApp",
            type: .dynamic,
            targets: ["app"]),
    ],
    dependencies: [
        .package(name: "sourcegear-bridge-dotnet", url: "https://github.com/sourcegear/sourcegear-bridge-dotnet", .exact("0.2.0")),
    ],
    targets: [
        .target(
            name: "app",
            dependencies: [
                .product(name: "dotnet", package: "sourcegear-bridge-dotnet")
            ]
            ),
    ]
)

