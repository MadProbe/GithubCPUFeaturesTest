﻿System.Console.WriteLine(System.Text.Json.JsonSerializer.Serialize(CpuFeaturesDotNet.X86.X86Info.GetX86Info(), new System.Text.Json.JsonSerializerOptions { IncludeFields = true, WriteIndented = true }));