# ResponseSimulator

[![.NET](https://github.com/elmo128/responseSimulator/actions/workflows/dotnet.yml/badge.svg)](https://github.com/elmo128/responseSimulator/actions/workflows/dotnet.yml)
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)

This tool will be recognized by Windows Task Manager and the WinAPI function "IsHungAppWindow(HWND)" as "not responding", for a preset timeout duration.

Please note, that Windows is using a 5 sec. timeout to detect unresponsive apps. Thus the timeout preset of this app must be set appropriately.
