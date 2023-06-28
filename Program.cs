System.Console.WriteLine(System.Text.Json.JsonSerializer.Serialize(CpuFeaturesDotNet.X86.X86Info.GetX86Info(), new System.Text.Json.JsonSerializerOptions { IncludeFields = true, WriteIndented = true }));
void print(bool expr, [System.Runtime.CompilerServices.CallerArgumentExpression(nameof(expr))] string str = "<>") => System.Console.WriteLine($"{str}: {expr}");
print(System.Runtime.Intrinsics.X86.Avx.IsSupported);
print(System.Runtime.Intrinsics.X86.Avx2.IsSupported);
#pragma warning disable CA2252 // This API requires opting into preview features
print(System.Runtime.Intrinsics.X86.AvxVnni.IsSupported);
#pragma warning restore CA2252 // This API requires opting into preview features
print(System.Runtime.Intrinsics.X86.Fma.IsSupported);
print(System.Runtime.Intrinsics.X86.Avx512F.IsSupported);
print(System.Runtime.Intrinsics.X86.Avx512BW.IsSupported);
print(System.Runtime.Intrinsics.X86.Avx512DQ.IsSupported);
print(System.Runtime.Intrinsics.X86.Avx512CD.IsSupported);
print(System.Runtime.Intrinsics.X86.Avx512Vbmi.IsSupported);
print(System.Runtime.Intrinsics.X86.Avx512F.VL.IsSupported);
print(System.Runtime.Intrinsics.X86.Avx512BW.VL.IsSupported);
print(System.Runtime.Intrinsics.X86.Avx512DQ.VL.IsSupported);
print(System.Runtime.Intrinsics.X86.Avx512CD.VL.IsSupported);
print(System.Runtime.Intrinsics.X86.Avx512Vbmi.VL.IsSupported);
