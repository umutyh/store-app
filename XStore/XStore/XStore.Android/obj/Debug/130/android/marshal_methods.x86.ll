; ModuleID = 'obj\Debug\130\android\marshal_methods.x86.ll'
source_filename = "obj\Debug\130\android\marshal_methods.x86.ll"
target datalayout = "e-m:e-p:32:32-p270:32:32-p271:32:32-p272:64:64-f64:32:64-f80:32-n8:16:32-S128"
target triple = "i686-unknown-linux-android"


%struct.MonoImage = type opaque

%struct.MonoClass = type opaque

%struct.MarshalMethodsManagedClass = type {
	i32,; uint32_t token
	%struct.MonoClass*; MonoClass* klass
}

%struct.MarshalMethodName = type {
	i64,; uint64_t id
	i8*; char* name
}

%class._JNIEnv = type opaque

%class._jobject = type {
	i8; uint8_t b
}

%class._jclass = type {
	i8; uint8_t b
}

%class._jstring = type {
	i8; uint8_t b
}

%class._jthrowable = type {
	i8; uint8_t b
}

%class._jarray = type {
	i8; uint8_t b
}

%class._jobjectArray = type {
	i8; uint8_t b
}

%class._jbooleanArray = type {
	i8; uint8_t b
}

%class._jbyteArray = type {
	i8; uint8_t b
}

%class._jcharArray = type {
	i8; uint8_t b
}

%class._jshortArray = type {
	i8; uint8_t b
}

%class._jintArray = type {
	i8; uint8_t b
}

%class._jlongArray = type {
	i8; uint8_t b
}

%class._jfloatArray = type {
	i8; uint8_t b
}

%class._jdoubleArray = type {
	i8; uint8_t b
}

; assembly_image_cache
@assembly_image_cache = local_unnamed_addr global [0 x %struct.MonoImage*] zeroinitializer, align 4
; Each entry maps hash of an assembly name to an index into the `assembly_image_cache` array
@assembly_image_cache_hashes = local_unnamed_addr constant [258 x i32] [
	i32 32687329, ; 0: Xamarin.AndroidX.Lifecycle.Runtime => 0x1f2c4e1 => 83
	i32 34715100, ; 1: Xamarin.Google.Guava.ListenableFuture.dll => 0x211b5dc => 112
	i32 39109920, ; 2: Newtonsoft.Json.dll => 0x254c520 => 27
	i32 57263871, ; 3: Xamarin.Forms.Core.dll => 0x369c6ff => 107
	i32 66706743, ; 4: Syncfusion.SfMaskedEdit.XForms.Android.dll => 0x3f9dd37 => 36
	i32 99762151, ; 5: Syncfusion.Buttons.XForms.dll => 0x5f23fe7 => 29
	i32 101534019, ; 6: Xamarin.AndroidX.SlidingPaneLayout => 0x60d4943 => 97
	i32 117431740, ; 7: System.Runtime.InteropServices => 0x6ffddbc => 125
	i32 120558881, ; 8: Xamarin.AndroidX.SlidingPaneLayout.dll => 0x72f9521 => 97
	i32 165246403, ; 9: Xamarin.AndroidX.Collection.dll => 0x9d975c3 => 64
	i32 182336117, ; 10: Xamarin.AndroidX.SwipeRefreshLayout.dll => 0xade3a75 => 98
	i32 209399409, ; 11: Xamarin.AndroidX.Browser.dll => 0xc7b2e71 => 62
	i32 220171995, ; 12: System.Diagnostics.Debug => 0xd1f8edb => 14
	i32 230216969, ; 13: Xamarin.AndroidX.Legacy.Support.Core.Utils.dll => 0xdb8d509 => 78
	i32 230752869, ; 14: Microsoft.CSharp.dll => 0xdc10265 => 22
	i32 232815796, ; 15: System.Web.Services => 0xde07cb4 => 119
	i32 261689757, ; 16: Xamarin.AndroidX.ConstraintLayout.dll => 0xf99119d => 67
	i32 278686392, ; 17: Xamarin.AndroidX.Lifecycle.LiveData.dll => 0x109c6ab8 => 82
	i32 280482487, ; 18: Xamarin.AndroidX.Interpolator => 0x10b7d2b7 => 76
	i32 318968648, ; 19: Xamarin.AndroidX.Activity.dll => 0x13031348 => 54
	i32 321597661, ; 20: System.Numerics => 0x132b30dd => 49
	i32 332531999, ; 21: Syncfusion.SfBusyIndicator.XForms.Android => 0x13d2091f => 34
	i32 342366114, ; 22: Xamarin.AndroidX.Lifecycle.Common => 0x146817a2 => 80
	i32 346219089, ; 23: Autofac => 0x14a2e251 => 17
	i32 349849074, ; 24: Syncfusion.SfNavigationDrawer.XForms.Android.dll => 0x14da45f2 => 39
	i32 385762202, ; 25: System.Memory.dll => 0x16fe439a => 127
	i32 441335492, ; 26: Xamarin.AndroidX.ConstraintLayout.Core => 0x1a4e3ec4 => 66
	i32 442521989, ; 27: Xamarin.Essentials => 0x1a605985 => 106
	i32 442565967, ; 28: System.Collections => 0x1a61054f => 6
	i32 450948140, ; 29: Xamarin.AndroidX.Fragment.dll => 0x1ae0ec2c => 75
	i32 465846621, ; 30: mscorlib => 0x1bc4415d => 26
	i32 469710990, ; 31: System.dll => 0x1bff388e => 48
	i32 476646585, ; 32: Xamarin.AndroidX.Interpolator.dll => 0x1c690cb9 => 76
	i32 486930444, ; 33: Xamarin.AndroidX.LocalBroadcastManager.dll => 0x1d05f80c => 87
	i32 526420162, ; 34: System.Transactions.dll => 0x1f6088c2 => 118
	i32 535134469, ; 35: Syncfusion.SfBusyIndicator.Android => 0x1fe58105 => 33
	i32 545304856, ; 36: System.Runtime.Extensions => 0x2080b118 => 7
	i32 555173402, ; 37: Syncfusion.SfPicker.XForms.Android => 0x2117461a => 42
	i32 563512029, ; 38: Syncfusion.SfNavigationDrawer.Android => 0x219682dd => 38
	i32 605376203, ; 39: System.IO.Compression.FileSystem => 0x24154ecb => 116
	i32 627609679, ; 40: Xamarin.AndroidX.CustomView => 0x2568904f => 71
	i32 663517072, ; 41: Xamarin.AndroidX.VersionedParcelable => 0x278c7790 => 103
	i32 666292255, ; 42: Xamarin.AndroidX.Arch.Core.Common.dll => 0x27b6d01f => 59
	i32 672442732, ; 43: System.Collections.Concurrent => 0x2814a96c => 12
	i32 690569205, ; 44: System.Xml.Linq.dll => 0x29293ff5 => 53
	i32 699345723, ; 45: System.Reflection.Emit => 0x29af2b3b => 121
	i32 715243097, ; 46: Syncfusion.SfTabView.XForms.Android.dll => 0x2aa1be59 => 44
	i32 717426419, ; 47: Syncfusion.SfNavigationDrawer.XForms.Android => 0x2ac30ef3 => 39
	i32 719061231, ; 48: Syncfusion.Core.XForms.dll => 0x2adc00ef => 31
	i32 775507847, ; 49: System.IO.Compression => 0x2e394f87 => 115
	i32 809851609, ; 50: System.Drawing.Common.dll => 0x30455ad9 => 10
	i32 843511501, ; 51: Xamarin.AndroidX.Print => 0x3246f6cd => 94
	i32 864956750, ; 52: Syncfusion.SfMaskedEdit.XForms => 0x338e314e => 37
	i32 928116545, ; 53: Xamarin.Google.Guava.ListenableFuture => 0x3751ef41 => 112
	i32 946305544, ; 54: Syncfusion.SfTabView.XForms.Android => 0x38677a08 => 44
	i32 955402788, ; 55: Newtonsoft.Json => 0x38f24a24 => 27
	i32 967690846, ; 56: Xamarin.AndroidX.Lifecycle.Common.dll => 0x39adca5e => 80
	i32 974778368, ; 57: FormsViewGroup.dll => 0x3a19f000 => 20
	i32 975236339, ; 58: System.Diagnostics.Tracing => 0x3a20ecf3 => 126
	i32 992768348, ; 59: System.Collections.dll => 0x3b2c715c => 6
	i32 1012816738, ; 60: Xamarin.AndroidX.SavedState.dll => 0x3c5e5b62 => 96
	i32 1028951442, ; 61: Microsoft.Extensions.DependencyInjection.Abstractions => 0x3d548d92 => 23
	i32 1035644815, ; 62: Xamarin.AndroidX.AppCompat => 0x3dbaaf8f => 58
	i32 1042160112, ; 63: Xamarin.Forms.Platform.dll => 0x3e1e19f0 => 109
	i32 1052210849, ; 64: Xamarin.AndroidX.Lifecycle.ViewModel.dll => 0x3eb776a1 => 84
	i32 1098259244, ; 65: System => 0x41761b2c => 48
	i32 1175144683, ; 66: Xamarin.AndroidX.VectorDrawable.Animated => 0x460b48eb => 101
	i32 1178241025, ; 67: Xamarin.AndroidX.Navigation.Runtime.dll => 0x463a8801 => 91
	i32 1204270330, ; 68: Xamarin.AndroidX.Arch.Core.Common => 0x47c7b4fa => 59
	i32 1267360935, ; 69: Xamarin.AndroidX.VectorDrawable => 0x4b8a64a7 => 102
	i32 1293217323, ; 70: Xamarin.AndroidX.DrawerLayout.dll => 0x4d14ee2b => 73
	i32 1324164729, ; 71: System.Linq => 0x4eed2679 => 124
	i32 1365406463, ; 72: System.ServiceModel.Internals.dll => 0x516272ff => 120
	i32 1376866003, ; 73: Xamarin.AndroidX.SavedState => 0x52114ed3 => 96
	i32 1379779777, ; 74: System.Resources.ResourceManager => 0x523dc4c1 => 4
	i32 1395857551, ; 75: Xamarin.AndroidX.Media.dll => 0x5333188f => 88
	i32 1406073936, ; 76: Xamarin.AndroidX.CoordinatorLayout => 0x53cefc50 => 68
	i32 1452416952, ; 77: AutoMapper => 0x56921fb8 => 19
	i32 1457743152, ; 78: System.Runtime.Extensions.dll => 0x56e36530 => 7
	i32 1460219004, ; 79: Xamarin.Forms.Xaml => 0x57092c7c => 110
	i32 1462112819, ; 80: System.IO.Compression.dll => 0x57261233 => 115
	i32 1469204771, ; 81: Xamarin.AndroidX.AppCompat.AppCompatResources => 0x57924923 => 57
	i32 1516315406, ; 82: Syncfusion.Core.XForms.Android.dll => 0x5a61230e => 30
	i32 1533253840, ; 83: Syncfusion.SfBusyIndicator.Android.dll => 0x5b6398d0 => 33
	i32 1543031311, ; 84: System.Text.RegularExpressions.dll => 0x5bf8ca0f => 123
	i32 1543355203, ; 85: System.Reflection.Emit.dll => 0x5bfdbb43 => 121
	i32 1550322496, ; 86: System.Reflection.Extensions.dll => 0x5c680b40 => 8
	i32 1566488712, ; 87: Syncfusion.SfBusyIndicator.XForms.dll => 0x5d5eb888 => 35
	i32 1582372066, ; 88: Xamarin.AndroidX.DocumentFile.dll => 0x5e5114e2 => 72
	i32 1592978981, ; 89: System.Runtime.Serialization.dll => 0x5ef2ee25 => 16
	i32 1622152042, ; 90: Xamarin.AndroidX.Loader.dll => 0x60b0136a => 86
	i32 1624863272, ; 91: Xamarin.AndroidX.ViewPager2 => 0x60d97228 => 105
	i32 1636350590, ; 92: Xamarin.AndroidX.CursorAdapter => 0x6188ba7e => 70
	i32 1639515021, ; 93: System.Net.Http.dll => 0x61b9038d => 15
	i32 1639986890, ; 94: System.Text.RegularExpressions => 0x61c036ca => 123
	i32 1657153582, ; 95: System.Runtime => 0x62c6282e => 51
	i32 1658241508, ; 96: Xamarin.AndroidX.Tracing.Tracing.dll => 0x62d6c1e4 => 99
	i32 1658251792, ; 97: Xamarin.Google.Android.Material.dll => 0x62d6ea10 => 111
	i32 1670060433, ; 98: Xamarin.AndroidX.ConstraintLayout => 0x638b1991 => 67
	i32 1701541528, ; 99: System.Diagnostics.Debug.dll => 0x656b7698 => 14
	i32 1726116996, ; 100: System.Reflection.dll => 0x66e27484 => 5
	i32 1729485958, ; 101: Xamarin.AndroidX.CardView.dll => 0x6715dc86 => 63
	i32 1765942094, ; 102: System.Reflection.Extensions => 0x6942234e => 8
	i32 1766324549, ; 103: Xamarin.AndroidX.SwipeRefreshLayout => 0x6947f945 => 98
	i32 1776026572, ; 104: System.Core.dll => 0x69dc03cc => 46
	i32 1788241197, ; 105: Xamarin.AndroidX.Fragment => 0x6a96652d => 75
	i32 1796983048, ; 106: Syncfusion.SfTabView.XForms.dll => 0x6b1bc908 => 45
	i32 1808609942, ; 107: Xamarin.AndroidX.Loader => 0x6bcd3296 => 86
	i32 1813201214, ; 108: Xamarin.Google.Android.Material => 0x6c13413e => 111
	i32 1818569960, ; 109: Xamarin.AndroidX.Navigation.UI.dll => 0x6c652ce8 => 92
	i32 1867746548, ; 110: Xamarin.Essentials.dll => 0x6f538cf4 => 106
	i32 1878053835, ; 111: Xamarin.Forms.Xaml.dll => 0x6ff0d3cb => 110
	i32 1885316902, ; 112: Xamarin.AndroidX.Arch.Core.Runtime.dll => 0x705fa726 => 60
	i32 1900610850, ; 113: System.Resources.ResourceManager.dll => 0x71490522 => 4
	i32 1919157823, ; 114: Xamarin.AndroidX.MultiDex.dll => 0x7264063f => 89
	i32 1936121326, ; 115: Syncfusion.SfPicker.XForms.dll => 0x7366ddee => 43
	i32 2019465201, ; 116: Xamarin.AndroidX.Lifecycle.ViewModel => 0x785e97f1 => 84
	i32 2031445118, ; 117: AutoMapper.dll => 0x7915647e => 19
	i32 2055257422, ; 118: Xamarin.AndroidX.Lifecycle.LiveData.Core.dll => 0x7a80bd4e => 81
	i32 2071563619, ; 119: Syncfusion.Buttons.XForms.Android => 0x7b798d63 => 28
	i32 2079903147, ; 120: System.Runtime.dll => 0x7bf8cdab => 51
	i32 2090596640, ; 121: System.Numerics.Vectors => 0x7c9bf920 => 50
	i32 2097448633, ; 122: Xamarin.AndroidX.Legacy.Support.Core.UI => 0x7d0486b9 => 77
	i32 2126786730, ; 123: Xamarin.Forms.Platform.Android => 0x7ec430aa => 108
	i32 2136653343, ; 124: XStore.Service => 0x7f5abe1f => 2
	i32 2192674484, ; 125: Syncfusion.SfMaskedEdit.XForms.dll => 0x82b18eb4 => 37
	i32 2201231467, ; 126: System.Net.Http => 0x8334206b => 15
	i32 2217644978, ; 127: Xamarin.AndroidX.VectorDrawable.Animated.dll => 0x842e93b2 => 101
	i32 2244775296, ; 128: Xamarin.AndroidX.LocalBroadcastManager => 0x85cc8d80 => 87
	i32 2256548716, ; 129: Xamarin.AndroidX.MultiDex => 0x8680336c => 89
	i32 2261435625, ; 130: Xamarin.AndroidX.Legacy.Support.V4.dll => 0x86cac4e9 => 79
	i32 2272153315, ; 131: Syncfusion.SfPicker.Android.dll => 0x876e4ee3 => 41
	i32 2279755925, ; 132: Xamarin.AndroidX.RecyclerView.dll => 0x87e25095 => 95
	i32 2315684594, ; 133: Xamarin.AndroidX.Annotation.dll => 0x8a068af2 => 55
	i32 2343171156, ; 134: Syncfusion.Core.XForms => 0x8ba9f454 => 31
	i32 2350129686, ; 135: Microsoft.Rest.ClientRuntime.dll => 0x8c142216 => 24
	i32 2354730003, ; 136: Syncfusion.Licensing => 0x8c5a5413 => 32
	i32 2386006044, ; 137: XStore.Android => 0x8e37901c => 0
	i32 2409053734, ; 138: Xamarin.AndroidX.Preference.dll => 0x8f973e26 => 93
	i32 2454642406, ; 139: System.Text.Encoding.dll => 0x924edee6 => 9
	i32 2465532216, ; 140: Xamarin.AndroidX.ConstraintLayout.Core.dll => 0x92f50938 => 66
	i32 2471841756, ; 141: netstandard.dll => 0x93554fdc => 1
	i32 2475788418, ; 142: Java.Interop.dll => 0x93918882 => 21
	i32 2501346920, ; 143: System.Data.DataSetExtensions => 0x95178668 => 114
	i32 2505896520, ; 144: Xamarin.AndroidX.Lifecycle.Runtime.dll => 0x955cf248 => 83
	i32 2521435481, ; 145: XStore.ServiceClient.dll => 0x964a0d59 => 3
	i32 2545245673, ; 146: XStore.ServiceClient => 0x97b55de9 => 3
	i32 2562349572, ; 147: Microsoft.CSharp => 0x98ba5a04 => 22
	i32 2581819634, ; 148: Xamarin.AndroidX.VectorDrawable.dll => 0x99e370f2 => 102
	i32 2620871830, ; 149: Xamarin.AndroidX.CursorAdapter.dll => 0x9c375496 => 70
	i32 2624644809, ; 150: Xamarin.AndroidX.DynamicAnimation => 0x9c70e6c9 => 74
	i32 2633051222, ; 151: Xamarin.AndroidX.Lifecycle.LiveData => 0x9cf12c56 => 82
	i32 2635300604, ; 152: Syncfusion.Buttons.XForms => 0x9d137efc => 29
	i32 2652177085, ; 153: Autofac.Extensions.DependencyInjection => 0x9e1502bd => 18
	i32 2684716871, ; 154: Syncfusion.SfNavigationDrawer.Android.dll => 0xa0058747 => 38
	i32 2701096212, ; 155: Xamarin.AndroidX.Tracing.Tracing => 0xa0ff7514 => 99
	i32 2732626843, ; 156: Xamarin.AndroidX.Activity => 0xa2e0939b => 54
	i32 2737747696, ; 157: Xamarin.AndroidX.AppCompat.AppCompatResources.dll => 0xa32eb6f0 => 57
	i32 2766581644, ; 158: Xamarin.Forms.Core => 0xa4e6af8c => 107
	i32 2778768386, ; 159: Xamarin.AndroidX.ViewPager.dll => 0xa5a0a402 => 104
	i32 2784016111, ; 160: Syncfusion.SfPicker.XForms => 0xa5f0b6ef => 43
	i32 2810250172, ; 161: Xamarin.AndroidX.CoordinatorLayout.dll => 0xa78103bc => 68
	i32 2819470561, ; 162: System.Xml.dll => 0xa80db4e1 => 52
	i32 2853208004, ; 163: Xamarin.AndroidX.ViewPager => 0xaa107fc4 => 104
	i32 2855708567, ; 164: Xamarin.AndroidX.Transition => 0xaa36a797 => 100
	i32 2868557005, ; 165: Syncfusion.Licensing.dll => 0xaafab4cd => 32
	i32 2874148507, ; 166: Syncfusion.Core.XForms.Android => 0xab50069b => 30
	i32 2885205685, ; 167: Syncfusion.SfTabView.XForms => 0xabf8beb5 => 45
	i32 2886109683, ; 168: Syncfusion.SfBusyIndicator.XForms.Android.dll => 0xac0689f3 => 34
	i32 2901442782, ; 169: System.Reflection => 0xacf080de => 5
	i32 2903344695, ; 170: System.ComponentModel.Composition => 0xad0d8637 => 117
	i32 2905242038, ; 171: mscorlib.dll => 0xad2a79b6 => 26
	i32 2916838712, ; 172: Xamarin.AndroidX.ViewPager2.dll => 0xaddb6d38 => 105
	i32 2919462931, ; 173: System.Numerics.Vectors.dll => 0xae037813 => 50
	i32 2921128767, ; 174: Xamarin.AndroidX.Annotation.Experimental.dll => 0xae1ce33f => 56
	i32 2961259629, ; 175: Microsoft.Rest.ClientRuntime => 0xb0813c6d => 24
	i32 2978675010, ; 176: Xamarin.AndroidX.DrawerLayout => 0xb18af942 => 73
	i32 3009111917, ; 177: XStore.Android.dll => 0xb35b676d => 0
	i32 3017678341, ; 178: Syncfusion.SfMaskedEdit.XForms.Android => 0xb3de1e05 => 36
	i32 3024354802, ; 179: Xamarin.AndroidX.Legacy.Support.Core.Utils => 0xb443fdf2 => 78
	i32 3044182254, ; 180: FormsViewGroup => 0xb57288ee => 20
	i32 3057625584, ; 181: Xamarin.AndroidX.Navigation.Common => 0xb63fa9f0 => 90
	i32 3111772706, ; 182: System.Runtime.Serialization => 0xb979e222 => 16
	i32 3144447155, ; 183: Autofac.dll => 0xbb6c74b3 => 17
	i32 3147165239, ; 184: System.Diagnostics.Tracing.dll => 0xbb95ee37 => 126
	i32 3204380047, ; 185: System.Data.dll => 0xbefef58f => 11
	i32 3211777861, ; 186: Xamarin.AndroidX.DocumentFile => 0xbf6fd745 => 72
	i32 3220365878, ; 187: System.Threading => 0xbff2e236 => 13
	i32 3223135248, ; 188: XStoreApp => 0xc01d2410 => 113
	i32 3247949154, ; 189: Mono.Security => 0xc197c562 => 128
	i32 3258312781, ; 190: Xamarin.AndroidX.CardView => 0xc235e84d => 63
	i32 3267021929, ; 191: Xamarin.AndroidX.AsyncLayoutInflater => 0xc2bacc69 => 61
	i32 3270722617, ; 192: Syncfusion.SfPicker.Android => 0xc2f34439 => 41
	i32 3299363146, ; 193: System.Text.Encoding => 0xc4a8494a => 9
	i32 3317135071, ; 194: Xamarin.AndroidX.CustomView.dll => 0xc5b776df => 71
	i32 3317144872, ; 195: System.Data => 0xc5b79d28 => 11
	i32 3340431453, ; 196: Xamarin.AndroidX.Arch.Core.Runtime => 0xc71af05d => 60
	i32 3346324047, ; 197: Xamarin.AndroidX.Navigation.Runtime => 0xc774da4f => 91
	i32 3353484488, ; 198: Xamarin.AndroidX.Legacy.Support.Core.UI.dll => 0xc7e21cc8 => 77
	i32 3362522851, ; 199: Xamarin.AndroidX.Core => 0xc86c06e3 => 69
	i32 3366347497, ; 200: Java.Interop => 0xc8a662e9 => 21
	i32 3374999561, ; 201: Xamarin.AndroidX.RecyclerView => 0xc92a6809 => 95
	i32 3404865022, ; 202: System.ServiceModel.Internals => 0xcaf21dfe => 120
	i32 3429136800, ; 203: System.Xml => 0xcc6479a0 => 52
	i32 3430777524, ; 204: netstandard => 0xcc7d82b4 => 1
	i32 3434749838, ; 205: Syncfusion.Buttons.XForms.Android.dll => 0xccba1f8e => 28
	i32 3441283291, ; 206: Xamarin.AndroidX.DynamicAnimation.dll => 0xcd1dd0db => 74
	i32 3460255358, ; 207: Syncfusion.SfBusyIndicator.XForms => 0xce3f4e7e => 35
	i32 3476120550, ; 208: Mono.Android => 0xcf3163e6 => 25
	i32 3486566296, ; 209: System.Transactions => 0xcfd0c798 => 118
	i32 3493954962, ; 210: Xamarin.AndroidX.Concurrent.Futures.dll => 0xd0418592 => 65
	i32 3501239056, ; 211: Xamarin.AndroidX.AsyncLayoutInflater.dll => 0xd0b0ab10 => 61
	i32 3509114376, ; 212: System.Xml.Linq => 0xd128d608 => 53
	i32 3536029504, ; 213: Xamarin.Forms.Platform.Android.dll => 0xd2c38740 => 108
	i32 3567349600, ; 214: System.ComponentModel.Composition.dll => 0xd4a16f60 => 117
	i32 3580502273, ; 215: XStore.Service.dll => 0xd56a2101 => 2
	i32 3608519521, ; 216: System.Linq.dll => 0xd715a361 => 124
	i32 3618140916, ; 217: Xamarin.AndroidX.Preference => 0xd7a872f4 => 93
	i32 3627220390, ; 218: Xamarin.AndroidX.Print.dll => 0xd832fda6 => 94
	i32 3632359727, ; 219: Xamarin.Forms.Platform => 0xd881692f => 109
	i32 3633644679, ; 220: Xamarin.AndroidX.Annotation.Experimental => 0xd8950487 => 56
	i32 3641597786, ; 221: Xamarin.AndroidX.Lifecycle.LiveData.Core => 0xd90e5f5a => 81
	i32 3672681054, ; 222: Mono.Android.dll => 0xdae8aa5e => 25
	i32 3676310014, ; 223: System.Web.Services.dll => 0xdb2009fe => 119
	i32 3676915022, ; 224: XStoreApp.dll => 0xdb29454e => 113
	i32 3682565725, ; 225: Xamarin.AndroidX.Browser => 0xdb7f7e5d => 62
	i32 3684561358, ; 226: Xamarin.AndroidX.Concurrent.Futures => 0xdb9df1ce => 65
	i32 3689375977, ; 227: System.Drawing.Common => 0xdbe768e9 => 10
	i32 3718780102, ; 228: Xamarin.AndroidX.Annotation => 0xdda814c6 => 55
	i32 3724971120, ; 229: Xamarin.AndroidX.Navigation.Common.dll => 0xde068c70 => 90
	i32 3748608112, ; 230: System.Diagnostics.DiagnosticSource => 0xdf6f3870 => 47
	i32 3758932259, ; 231: Xamarin.AndroidX.Legacy.Support.V4 => 0xe00cc123 => 79
	i32 3786282454, ; 232: Xamarin.AndroidX.Collection => 0xe1ae15d6 => 64
	i32 3803290561, ; 233: Syncfusion.SfNavigationDrawer.XForms.dll => 0xe2b19bc1 => 40
	i32 3822602673, ; 234: Xamarin.AndroidX.Media => 0xe3d849b1 => 88
	i32 3829621856, ; 235: System.Numerics.dll => 0xe4436460 => 49
	i32 3841636137, ; 236: Microsoft.Extensions.DependencyInjection.Abstractions.dll => 0xe4fab729 => 23
	i32 3849253459, ; 237: System.Runtime.InteropServices.dll => 0xe56ef253 => 125
	i32 3885922214, ; 238: Xamarin.AndroidX.Transition.dll => 0xe79e77a6 => 100
	i32 3896106733, ; 239: System.Collections.Concurrent.dll => 0xe839deed => 12
	i32 3896760992, ; 240: Xamarin.AndroidX.Core.dll => 0xe843daa0 => 69
	i32 3920810846, ; 241: System.IO.Compression.FileSystem.dll => 0xe9b2d35e => 116
	i32 3921031405, ; 242: Xamarin.AndroidX.VersionedParcelable.dll => 0xe9b630ed => 103
	i32 3931092270, ; 243: Xamarin.AndroidX.Navigation.UI => 0xea4fb52e => 92
	i32 3945713374, ; 244: System.Data.DataSetExtensions.dll => 0xeb2ecede => 114
	i32 3949143839, ; 245: Syncfusion.SfPicker.XForms.Android.dll => 0xeb63271f => 42
	i32 3955647286, ; 246: Xamarin.AndroidX.AppCompat.dll => 0xebc66336 => 58
	i32 3969889706, ; 247: Autofac.Extensions.DependencyInjection.dll => 0xec9fb5aa => 18
	i32 4025784931, ; 248: System.Memory => 0xeff49a63 => 127
	i32 4054681211, ; 249: System.Reflection.Emit.ILGeneration => 0xf1ad867b => 122
	i32 4073602200, ; 250: System.Threading.dll => 0xf2ce3c98 => 13
	i32 4105002889, ; 251: Mono.Security.dll => 0xf4ad5f89 => 128
	i32 4147896353, ; 252: System.Reflection.Emit.ILGeneration.dll => 0xf73be021 => 122
	i32 4151237749, ; 253: System.Core => 0xf76edc75 => 46
	i32 4176864949, ; 254: Syncfusion.SfNavigationDrawer.XForms => 0xf8f5e6b5 => 40
	i32 4182413190, ; 255: Xamarin.AndroidX.Lifecycle.ViewModelSavedState.dll => 0xf94a8f86 => 85
	i32 4213026141, ; 256: System.Diagnostics.DiagnosticSource.dll => 0xfb1dad5d => 47
	i32 4292120959 ; 257: Xamarin.AndroidX.Lifecycle.ViewModelSavedState => 0xffd4917f => 85
], align 4
@assembly_image_cache_indices = local_unnamed_addr constant [258 x i32] [
	i32 83, i32 112, i32 27, i32 107, i32 36, i32 29, i32 97, i32 125, ; 0..7
	i32 97, i32 64, i32 98, i32 62, i32 14, i32 78, i32 22, i32 119, ; 8..15
	i32 67, i32 82, i32 76, i32 54, i32 49, i32 34, i32 80, i32 17, ; 16..23
	i32 39, i32 127, i32 66, i32 106, i32 6, i32 75, i32 26, i32 48, ; 24..31
	i32 76, i32 87, i32 118, i32 33, i32 7, i32 42, i32 38, i32 116, ; 32..39
	i32 71, i32 103, i32 59, i32 12, i32 53, i32 121, i32 44, i32 39, ; 40..47
	i32 31, i32 115, i32 10, i32 94, i32 37, i32 112, i32 44, i32 27, ; 48..55
	i32 80, i32 20, i32 126, i32 6, i32 96, i32 23, i32 58, i32 109, ; 56..63
	i32 84, i32 48, i32 101, i32 91, i32 59, i32 102, i32 73, i32 124, ; 64..71
	i32 120, i32 96, i32 4, i32 88, i32 68, i32 19, i32 7, i32 110, ; 72..79
	i32 115, i32 57, i32 30, i32 33, i32 123, i32 121, i32 8, i32 35, ; 80..87
	i32 72, i32 16, i32 86, i32 105, i32 70, i32 15, i32 123, i32 51, ; 88..95
	i32 99, i32 111, i32 67, i32 14, i32 5, i32 63, i32 8, i32 98, ; 96..103
	i32 46, i32 75, i32 45, i32 86, i32 111, i32 92, i32 106, i32 110, ; 104..111
	i32 60, i32 4, i32 89, i32 43, i32 84, i32 19, i32 81, i32 28, ; 112..119
	i32 51, i32 50, i32 77, i32 108, i32 2, i32 37, i32 15, i32 101, ; 120..127
	i32 87, i32 89, i32 79, i32 41, i32 95, i32 55, i32 31, i32 24, ; 128..135
	i32 32, i32 0, i32 93, i32 9, i32 66, i32 1, i32 21, i32 114, ; 136..143
	i32 83, i32 3, i32 3, i32 22, i32 102, i32 70, i32 74, i32 82, ; 144..151
	i32 29, i32 18, i32 38, i32 99, i32 54, i32 57, i32 107, i32 104, ; 152..159
	i32 43, i32 68, i32 52, i32 104, i32 100, i32 32, i32 30, i32 45, ; 160..167
	i32 34, i32 5, i32 117, i32 26, i32 105, i32 50, i32 56, i32 24, ; 168..175
	i32 73, i32 0, i32 36, i32 78, i32 20, i32 90, i32 16, i32 17, ; 176..183
	i32 126, i32 11, i32 72, i32 13, i32 113, i32 128, i32 63, i32 61, ; 184..191
	i32 41, i32 9, i32 71, i32 11, i32 60, i32 91, i32 77, i32 69, ; 192..199
	i32 21, i32 95, i32 120, i32 52, i32 1, i32 28, i32 74, i32 35, ; 200..207
	i32 25, i32 118, i32 65, i32 61, i32 53, i32 108, i32 117, i32 2, ; 208..215
	i32 124, i32 93, i32 94, i32 109, i32 56, i32 81, i32 25, i32 119, ; 216..223
	i32 113, i32 62, i32 65, i32 10, i32 55, i32 90, i32 47, i32 79, ; 224..231
	i32 64, i32 40, i32 88, i32 49, i32 23, i32 125, i32 100, i32 12, ; 232..239
	i32 69, i32 116, i32 103, i32 92, i32 114, i32 42, i32 58, i32 18, ; 240..247
	i32 127, i32 122, i32 13, i32 128, i32 122, i32 46, i32 40, i32 85, ; 248..255
	i32 47, i32 85 ; 256..257
], align 4

@marshal_methods_number_of_classes = local_unnamed_addr constant i32 0, align 4

; marshal_methods_class_cache
@marshal_methods_class_cache = global [0 x %struct.MarshalMethodsManagedClass] [
], align 4; end of 'marshal_methods_class_cache' array


@get_function_pointer = internal unnamed_addr global void (i32, i32, i32, i8**)* null, align 4

; Function attributes: "frame-pointer"="none" "min-legal-vector-width"="0" mustprogress nofree norecurse nosync "no-trapping-math"="true" nounwind sspstrong "stack-protector-buffer-size"="8" "stackrealign" "target-cpu"="i686" "target-features"="+cx8,+mmx,+sse,+sse2,+sse3,+ssse3,+x87" "tune-cpu"="generic" uwtable willreturn writeonly
define void @xamarin_app_init (void (i32, i32, i32, i8**)* %fn) local_unnamed_addr #0
{
	store void (i32, i32, i32, i8**)* %fn, void (i32, i32, i32, i8**)** @get_function_pointer, align 4
	ret void
}

; Names of classes in which marshal methods reside
@mm_class_names = local_unnamed_addr constant [0 x i8*] zeroinitializer, align 4
@__MarshalMethodName_name.0 = internal constant [1 x i8] c"\00", align 1

; mm_method_names
@mm_method_names = local_unnamed_addr constant [1 x %struct.MarshalMethodName] [
	; 0
	%struct.MarshalMethodName {
		i64 0, ; id 0x0; name: 
		i8* getelementptr inbounds ([1 x i8], [1 x i8]* @__MarshalMethodName_name.0, i32 0, i32 0); name
	}
], align 8; end of 'mm_method_names' array


attributes #0 = { "min-legal-vector-width"="0" mustprogress nofree norecurse nosync "no-trapping-math"="true" nounwind sspstrong "stack-protector-buffer-size"="8" uwtable willreturn writeonly "frame-pointer"="none" "target-cpu"="i686" "target-features"="+cx8,+mmx,+sse,+sse2,+sse3,+ssse3,+x87" "tune-cpu"="generic" "stackrealign" }
attributes #1 = { "min-legal-vector-width"="0" mustprogress "no-trapping-math"="true" nounwind sspstrong "stack-protector-buffer-size"="8" uwtable "frame-pointer"="none" "target-cpu"="i686" "target-features"="+cx8,+mmx,+sse,+sse2,+sse3,+ssse3,+x87" "tune-cpu"="generic" "stackrealign" }
attributes #2 = { nounwind }

!llvm.module.flags = !{!0, !1, !2}
!llvm.ident = !{!3}
!0 = !{i32 1, !"wchar_size", i32 4}
!1 = !{i32 7, !"PIC Level", i32 2}
!2 = !{i32 1, !"NumRegisterParameters", i32 0}
!3 = !{!"Xamarin.Android remotes/origin/d17-5 @ a200af12c1e846626b8caebd926ac14c185f71ec"}
!llvm.linker.options = !{}
