@echo off

set PATH=%PATH%;C:\Windows\Microsoft.NET\Framework\v4.0.30319

msbuild Api.Benchmark.proj /target:Build /verbosity:Normal

pause